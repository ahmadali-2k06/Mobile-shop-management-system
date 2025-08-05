using System;
using System.Linq;
using System.Windows.Forms;
using TestingConsole2;

namespace ProjectUI2
{
    public partial class OrderForm : Form
    {
        private OrderManager orderManager;
        private ProductManager productManager;
        private StockManager stockManager;

        public OrderForm(ProductManager productMgr, StockManager stockMgr, OrderManager orderMgr)
        {
            InitializeComponent();

            productManager = productMgr;
            stockManager = stockMgr;
            orderManager = orderMgr;

            LoadOrders();
        }

        private string GenerateOrderId()
        {
            return "ORD-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
        }

        public void LoadOrders()
        {
            dgvOrders.Rows.Clear();

            var allOrders = orderManager.GetAllOrders();

            foreach (var order in allOrders)
            {
                dgvOrders.Rows.Add(
                    order.OrderID,          
                    order.OrderDate,
                    order.CustomerName,
                    order.TotalAmount,
                    order.OrderState,
                    order.DiscountPercent
                );
            }
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            var addOrderForm = new AddOrderForm(productManager, stockManager, orderManager, this);
            addOrderForm.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            DeleteSelectedOrder();
        }
        private void DeleteSelectedOrder()
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                string orderId = dgvOrders.SelectedRows[0].Cells["OrderID"].Value?.ToString();


                if (!string.IsNullOrWhiteSpace(orderId))
                {
                    bool success = orderManager.DeleteOrder(orderId);
                    if (success)
                    {
                        MessageBox.Show("Order deleted successfully.");
                        LoadOrders(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Order not found.");
                    }
                }
                else
                {
                    MessageBox.Show("Order ID is missing.");
                }
            }
            else
            {
                MessageBox.Show("Please select an order to delete.");
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                string selectedOrderId = dgvOrders.SelectedRows[0].Cells["OrderID"].Value?.ToString();

                if (string.IsNullOrEmpty(selectedOrderId))
                {
                    MessageBox.Show("Selected order has no valid OrderID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var order = orderManager.GetOrderById(selectedOrderId);

                if (order == null)
                {
                    MessageBox.Show("Order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var orderDetailsForm = new OrderDetails(order);
                orderDetailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an order first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchId = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchId))
            {
                MessageBox.Show("Please enter an Order ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var allOrders = orderManager.GetAllOrders();
            var matchingOrder = allOrders.FirstOrDefault(o => o.OrderID.Equals(searchId, StringComparison.OrdinalIgnoreCase));

            dgvOrders.Rows.Clear();

            if (matchingOrder != null)
            {
                dgvOrders.Rows.Add(
                    matchingOrder.OrderID,
                    matchingOrder.OrderDate.ToString("dd MMM yyyy"),
                    matchingOrder.CustomerName,
                    "Rs. " + matchingOrder.TotalAmount.ToString("N2"),
                    matchingOrder.OrderState,
                    matchingOrder.DiscountPercent
                );
            }
            else
            {
                MessageBox.Show("No order found with the given Order ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();  // Clear the search input
            LoadOrders();    // Reload all orders into the DataGridView
        }
    }
}
