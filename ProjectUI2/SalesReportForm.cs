using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TestingConsole2;


namespace ProjectUI2
{
    public partial class SaleReportForm : Form
    {
        private OrderManager orderManager;
        private SalesReportManager salesReportManager;

        public SaleReportForm(OrderManager orderManager)
        {
            InitializeComponent();

            this.orderManager = orderManager;

            // Use the orders list inside OrderManager to create SalesReportManager
            salesReportManager = new SalesReportManager(orderManager.GetAllOrders());

            LoadSalesChart();
            LoadSalesReport();
        }

        private void LoadSalesReport()
        {
            var allOrders = orderManager.GetAllOrders();

            // same code as before using allOrders and salesReportManager
            int totalSalesCount = allOrders.Count;
            decimal totalSalesAmount = allOrders.Sum(o => o.TotalAmount);

            DateTime today = DateTime.Today;
            var salesToday = allOrders.Where(o => o.OrderDate.Date == today).ToList();

            int totalSalesTodayCount = salesToday.Count;
            decimal totalSalesTodayAmount = salesToday.Sum(o => o.TotalAmount);

            int ordersInProcess = salesReportManager.GetPendingOrders().Count + salesReportManager.GetProcessedOrders().Count;

            lblTotalSales.Text = totalSalesCount.ToString();
            lblTotalSalesToday.Text = $"{totalSalesTodayCount} (Rs. {totalSalesTodayAmount:N2})";
            lblOrdersInProcess.Text = ordersInProcess.ToString();
            lblTotalAmount.Text = $"Rs. {totalSalesAmount:N2}";
        }
        private void LoadSalesChart()
        {
            chartSales.Series.Clear();
            chartSales.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            chartSales.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Sales",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String // We'll use string labels like "10:02"
            };

            chartSales.Series.Add(series);

            var allOrders = orderManager.GetAllOrders();

            DateTime startDate = DateTime.Today; // or set a range if you want

            // Filter orders for today (or any desired range)
            var ordersToday = allOrders.Where(o => o.OrderDate.Date == DateTime.Today).ToList();

            // Group orders by 2-minute intervals
            var groupedOrders = ordersToday
                .GroupBy(o => TruncateTo2Minute(o.OrderDate))
                .OrderBy(g => g.Key)
                .Select(g => new
                {
                    Interval = g.Key,
                    TotalSales = g.Sum(o => o.TotalAmount)
                })
                .ToList();

            // Fill series points
            foreach (var interval in groupedOrders)
            {
                string label = interval.Interval.ToString("HH:mm");
                series.Points.AddXY(label, interval.TotalSales);
            }

            chartSales.Invalidate();
        }
        private DateTime TruncateTo2Minute(DateTime dt)
        {
            int minutes = (dt.Minute / 2) * 2;
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, minutes, 0);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            // Ask user where to save the CSV file
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "SalesReport.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportSalesDataToCsv(sfd.FileName);
                        MessageBox.Show("Export successful!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExportSalesDataToCsv(string filePath)
        {
            var allOrders = orderManager.GetAllOrders();

            var csvLines = new List<string>();

            // Header row
            csvLines.Add("OrderID,OrderDate,Customer,TotalAmount,OrderState");

            foreach (var order in allOrders)
            {
                var line = $"{order.OrderID},{order.OrderDate:yyyy-MM-dd HH:mm},{order.CustomerName},{order.TotalAmount},{order.OrderState}";
                csvLines.Add(line);
            }

            System.IO.File.WriteAllLines(filePath, csvLines);
        }

        public void ExportSalesReportToPdf(string filePath, string imagePath, int totalSales, decimal totalAmount)
        {
            using (var writer = new PdfWriter(filePath))
            using (var pdf = new PdfDocument(writer))
            using (var document = new Document(pdf))
            {
                var font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                var title = new Paragraph("Sales Report")
                    .SetFont(font)
                    .SetFontSize(18)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                document.Add(title);

                // Add logo image if it exists
                if (File.Exists(imagePath))
                {
                    var img = new Image(ImageDataFactory.Create(imagePath));
                    img.ScaleToFit(150, 150);
                    img.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    document.Add(img);
                }

                var normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                document.Add(new Paragraph($"Total Sales: {totalSales}").SetFont(normalFont).SetFontSize(12));
                document.Add(new Paragraph($"Total Sales Amount: Rs. {totalAmount:N2}").SetFont(normalFont).SetFontSize(12));

                using (MemoryStream chartStream = new MemoryStream())
                {
                    chartSales.SaveImage(chartStream, ChartImageFormat.Png);
                    chartStream.Position = 0;

                    var chartImage = new Image(ImageDataFactory.Create(chartStream.ToArray()));
                    chartImage.ScaleToFit(500, 300);
                    chartImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                    document.Add(chartImage);
                }

                document.Close();
            }
        }
        

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Sales Report PDF";
                saveFileDialog.FileName = "SalesReport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Assume imagePath points to your logo/image
                    string imagePath = @"C:\path\to\your\image.png";

                    // Get your data from form or manager
                    int totalSales = int.Parse(lblTotalSales.Text);
                    decimal totalAmount = decimal.Parse(lblTotalAmount.Text.Replace("Rs. ", ""));

                    ExportSalesReportToPdf(filePath, imagePath, totalSales, totalAmount);

                    MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
    }

