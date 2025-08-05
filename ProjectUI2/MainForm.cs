using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TestingConsole2;

namespace ProjectUI2
{
    public partial class MainForm : Form
    {
        private Timer dashboardTimer;

        private ProductManager sharedProductManager = new ProductManager();
        private StockManager sharedStockManager = new StockManager();
        private OrderManager sharedOrderManager;

        private AddProductsForm addProductsForm;
        private StockForm stockForm;

        private Form activeForm = null;
        private Timer fadeTimer;

        private Label[] activityLabels;
        public MainForm()
        {
            this.Opacity = 0;
            this.DoubleBuffered = true;
            InitializeComponent();

            activityLabels = new Label[]
            {
                lblActivity1,
                lblActivity2,
                lblActivity3,
                lblActivity4,
                lblActivity5,
                lblActivity6
            };

            this.Load += MainForm_Load;

            sharedOrderManager = new OrderManager(sharedStockManager);

            addProductsForm = new AddProductsForm(sharedProductManager, sharedStockManager);
            stockForm = new StockForm(sharedProductManager, sharedStockManager);

            dashboardTimer = new Timer();
            dashboardTimer.Interval = 5000; // 5 seconds
            dashboardTimer.Tick += DashboardTimer_Tick;
            dashboardTimer.Start();

            UpdateDashboardLabels();
        }

        private void DashboardTimer_Tick(object sender, EventArgs e)
        {
            UpdateDashboardLabels();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fadeTimer = new Timer();
            fadeTimer.Interval = 20;
            fadeTimer.Tick += FadeTimer_Tick;
            fadeTimer.Start();

            UpdateDashboardLabels();
        }

        private void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                fadeTimer.Stop();
                fadeTimer.Dispose();
            }
        }

        // Win32 APIs for dragging borderless form
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            panelMain.Visible = true;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(addProductsForm);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            stockForm.LoadStockFromProducts();
            stockForm.PopulateStockGrid();
            OpenChildForm(stockForm);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var ordersForm = new OrderForm(sharedProductManager, sharedStockManager, sharedOrderManager);
            OpenChildForm(ordersForm);
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            var reportForm = new SaleReportForm(sharedOrderManager);
            OpenChildForm(reportForm);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            var addOrderForm = new AddOrderForm(sharedProductManager, sharedStockManager, sharedOrderManager);
            OpenChildForm(addOrderForm);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
                panelMain.Controls.Remove(activeForm);
            }

            activeForm = childForm;

            if (!panelMain.Controls.Contains(childForm))
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelMain.Controls.Add(childForm);
                panelMain.Tag = childForm;
            }

            childForm.BringToFront();
            childForm.Show();
        }

        private void CloseChildForm()
        {
            if (activeForm != null)
            {
                activeForm.Hide();
                panelMain.Controls.Remove(activeForm);
                activeForm = null;
            }
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblViewProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(addProductsForm);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            var reportForm = new SaleReportForm(sharedOrderManager);
            OpenChildForm(reportForm);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            var ordersForm = new OrderForm(sharedProductManager, sharedStockManager, sharedOrderManager);
            OpenChildForm(ordersForm);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            stockForm.LoadStockFromProducts();
            stockForm.PopulateStockGrid();
            OpenChildForm(stockForm);
        }

        public void UpdateDashboardLabels()
        {
            if (sharedProductManager == null || sharedStockManager == null || sharedOrderManager == null)
            {
                MessageBox.Show("Managers are not initialized.");
                return;
            }

            var allProducts = sharedProductManager.GetAllProducts() ?? new List<Product>();
            var allStocks = sharedStockManager.GetAllStocks() ?? new List<Stock>();
            var allOrders = sharedOrderManager.GetAllOrders() ?? new List<Order>();

            lblTotalProducts.Text = allProducts.Count.ToString();

            int lowStockCount = allStocks.Count(stock => stock.Quantity < 5);
            lblLowStockAlerts.Text = lowStockCount.ToString();

            DateTime today = DateTime.Today;
            decimal totalSalesToday = allOrders
                .Where(order => order.OrderDate != null && order.OrderDate.Date == today)
                .Sum(order => order.TotalAmount);
            lblTotalSalesToday.Text = "Rs. " + totalSalesToday.ToString("N2");

            lblOrdersProcessed.Text = allOrders.Count.ToString();

            var productActivities = allProducts
                .OrderByDescending(p => p.CreatedDate)
                .Take(2)
                .Select(p => (p.CreatedDate, $"New product added: {p.ModelName}"))
                .ToList();

            var orderActivities = allOrders
                .Where(o => o.OrderDate.Date == today)
                .OrderByDescending(o => o.OrderDate)
                .Take(2)
                .Select(o => (o.OrderDate, $"Sale made: Rs. {o.TotalAmount:N2} at {o.OrderDate:hh:mm tt}"))
                .ToList();

            var stockActivities = allStocks
                .Where(s => s.Quantity < 5)
                .OrderBy(s => s.Quantity)
                .Take(2)
                .Select(s => (DateTime.Now, $"Low stock: {s.Name}, {s.Quantity} left"))
                .ToList();

            
            var finalActivities = productActivities
                .Concat(orderActivities)
                .Concat(stockActivities)
                .ToList();

            
            for (int i = 0; i < activityLabels.Length; i++)
            {
                activityLabels[i].Text = i < finalActivities.Count ? "• " + finalActivities[i].Item2 : "";
            }
            UpdateSalesChart();          
            UpdateStockAnalysisChart();  
        }
        public void UpdateSalesChart()
        {
            var allOrders = sharedOrderManager?.GetAllOrders() ?? new List<Order>();

            var salesByDate = allOrders
                .Where(o => o.OrderDate != null)
                .GroupBy(o => o.OrderDate.Date)
                .OrderBy(g => g.Key)
                .Select(g => new
                {
                    Date = g.Key,
                    TotalSales = g.Sum(o => o.TotalAmount)
                })
                .ToList();

            chartSalesView.Series.Clear();
            chartSalesView.ChartAreas.Clear();

            chartSalesView.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("MainArea"));
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Daily Sales")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date
            };
            chartSalesView.Series.Add(series);

            foreach (var entry in salesByDate)
            {
                series.Points.AddXY(entry.Date.ToString("dd MMM"), entry.TotalSales);
            }

            series.Color = System.Drawing.Color.SeaGreen;
            series.IsValueShownAsLabel = true;

            var chartArea = chartSalesView.ChartAreas[0];
            chartArea.AxisX.Title = "Date";
            chartArea.AxisY.Title = "Total Sales (Rs.)";
            chartArea.AxisX.Interval = 1;

            chartSalesView.Invalidate();
        }
        public void UpdateStockAnalysisChart()
        {
            var allStocks = sharedStockManager?.GetAllStocks() ?? new List<Stock>();

            chartStockAnalysis.Series.Clear();
            chartStockAnalysis.ChartAreas.Clear();

            chartStockAnalysis.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("MainArea"));
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Stock Quantity")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column 
            };
            chartStockAnalysis.Series.Add(series);

          
            var stocksSorted = allStocks.OrderBy(s => s.Quantity).ToList();

            foreach (var stock in stocksSorted)
            {
                var truncatedName = stock.Name.Length > 12 ? stock.Name.Substring(0, 12) + "..." : stock.Name;
                var pointIndex = series.Points.AddXY(truncatedName, stock.Quantity);

                if (stock.Quantity < 5)
                    series.Points[pointIndex].Color = System.Drawing.Color.Red;
                else
                    series.Points[pointIndex].Color = System.Drawing.Color.CornflowerBlue;
            }

            var chartArea = chartStockAnalysis.ChartAreas[0];
            chartArea.AxisX.Title = "Product";
            chartArea.AxisY.Title = "Quantity";

            
            chartArea.AxisX.ScaleView.Zoomable = true;
            chartArea.AxisX.ScrollBar.Enabled = true;
            chartArea.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea.AxisX.ScrollBar.IsPositionedInside = true;

          
            int visibleProductsCount = 10;
            chartArea.AxisX.ScaleView.Size = visibleProductsCount;
            chartArea.AxisX.ScaleView.Position = 0;

           
            chartArea.CursorY.IsUserEnabled = true;
            chartArea.CursorY.IsUserSelectionEnabled = true;
            chartArea.AxisY.ScaleView.Zoomable = true;

            
            chartArea.AxisX.LabelStyle.Angle = 45;
            chartArea.AxisX.LabelStyle.IsEndLabelVisible = true;

            chartStockAnalysis.Invalidate();
        }








    }
}
