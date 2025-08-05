using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TestingConsole2;

namespace ProjectUI2
{
    public partial class ProductDetails : Form
    {
        // Win32 API for dragging the borderless form
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private Timer fadeInTimer;

        public ProductDetails(Product product, Stock stock)
        {
            InitializeComponent();

            this.Opacity = 0; // Start invisible

            // Fade-in timer setup (faster)
            fadeInTimer = new Timer();
            fadeInTimer.Interval = 10; // faster timer interval
            fadeInTimer.Tick += FadeInTimer_Tick;
            fadeInTimer.Start();

            // Center form manually relative to owner
            this.StartPosition = FormStartPosition.Manual;
            if (this.Owner != null)
            {
                this.Location = new Point(
                    this.Owner.Location.X + (this.Owner.Width - this.Width) / 2,
                    this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2
                );
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }

            // Assign label values
            lblComapny.Text = product.Company;
            lblMobileName.Text = product.ModelName;
            lblRam.Text = product.Ram;
            lblStorage.Text = product.Storage;
            lblBattery.Text = product.Battery;
            lblPrice.Text = "Rs. " + product.CalculatePrice().ToString("N2");
            lblQuantity.Text = stock != null ? stock.Quantity.ToString() : "N/A";

            // Add drag functionality to panelTop
            panelTop.MouseDown += Paneltop_MouseDown;
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += 0.1; // bigger steps for faster fade-in
            }
            else
            {
                fadeInTimer.Stop();
            }
        }

        private void Paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
