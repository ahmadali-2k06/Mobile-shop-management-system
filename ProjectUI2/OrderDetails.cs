using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingConsole2;

namespace ProjectUI2
{
    public partial class OrderDetails : Form
    {
        // DLL imports for dragging the form
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public OrderDetails(Order order)
        {
            InitializeComponent();

            // Set form opacity to 0 for fade-in effect
            this.Opacity = 0;
            this.Load += OrderDetails_Load;

            // Enable dragging on panelTop
            panelTop.MouseDown += PanelTop_MouseDown;

            if (order == null)
            {
                MessageBox.Show("Order data is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Product Details
            lblproductName.Text = order.Product.ModelName;
            lblComapny.Text = order.Product.Company;
            lblRam.Text = order.Product.Ram;
            lblStorage.Text = order.Product.Storage;
            lblBattery.Text = order.Product.Battery; // Assuming Battery is a property of Product
            lblPrice.Text = "Rs. " + order.Product.CalculatePrice().ToString("N2");

            // Order Details
            lblCustomerName.Text = order.CustomerName;
            lblOrderID.Text = order.OrderID;
            lblDate.Text = order.OrderDate.ToString("dd MMM yyyy");
            lblTotalAmount.Text = "Rs. " + order.TotalAmount.ToString("N2");
            lblOrderState.Text = order.OrderState;
            lblDiscountRate.Text = order.DiscountPercent + "%";
            lblQuantity.Text = order.OrderQuantity.ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private async void OrderDetails_Load(object sender, EventArgs e)
        {
            for (double opacity = 0.0; opacity <= 1.0; opacity += 0.05)
            {
                this.Opacity = opacity;
                await Task.Delay(15);
            }
        }
    }
}
