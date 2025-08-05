using System;
using System.Linq;
using System.Windows.Forms;
using TestingConsole2;

namespace ProjectUI2
{
    public partial class AddOrderForm : Form
    {
        private ProductManager productManager;
        private StockManager stockManager;
        private OrderManager orderManager;
        private OrderForm orderForm;

        public AddOrderForm(ProductManager productMgr, StockManager stockMgr, OrderManager orderMgr)
            : this(productMgr, stockMgr, orderMgr, null) { }

        public AddOrderForm(ProductManager productMgr, StockManager stockMgr, OrderManager orderMgr, OrderForm orderFrm)
        {
            InitializeComponent();

            productManager = productMgr;
            stockManager = stockMgr;
            orderManager = orderMgr;
            orderForm = orderFrm;

            this.Load += AddOrderForm_Load;
            btnPlaceOrder.Click += BtnPlaceOrder_Click;
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            PopulateProductGrid();
        }

        private void PopulateProductGrid()
        {
            var allProducts = productManager.GetAllProducts();

            dgvProducts.Rows.Clear();

            foreach (var product in allProducts)
            {
                var stock = stockManager.GetStockByModel(product.ModelName, product.Ram, product.Storage);
                int quantity = stock?.Quantity ?? 0;

                dgvProducts.Rows.Add(
                    product.ModelName,
                    product.Company,
                    quantity,
                    product.CalculatePrice(),
                    false, // Select
                    "",    // Order quantity
                    product.Ram,
                    product.Storage
                );
            }

            if (dgvProducts.Rows.Count == 0)
            {
                MessageBox.Show("No products found to display.");
            }
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter the Customer Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDiscountPercent.Text, out decimal discountPercent) || discountPercent < 0 || discountPercent > 100)
            {
                MessageBox.Show("Please enter a valid Discount Percent between 0 and 100.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool anyOrderPlaced = false;

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.IsNewRow) continue;

                bool isSelected = Convert.ToBoolean(row.Cells["Select"].Value);
                if (!isSelected)
                    continue;

                string orderQtyText = row.Cells["OrderQuantity"].Value?.ToString();
                if (!int.TryParse(orderQtyText, out int orderQty) || orderQty <= 0)
                {
                    MessageBox.Show("Please enter a valid order quantity for all selected products.",
                                    "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string name = row.Cells["Name"].Value.ToString();
                string company = row.Cells["Company"].Value.ToString();
                string ram = row.Cells["Ram"].Value?.ToString();
                string storage = row.Cells["Storage"].Value?.ToString();

                var product = productManager.GetAllProducts()
                    .FirstOrDefault(p => p.ModelName == name && p.Company == company && p.Ram == ram && p.Storage == storage);

                if (product == null)
                {
                    MessageBox.Show($"Product {name} with specified specs not found.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var stock = stockManager.GetStockByModel(product.ModelName, product.Ram, product.Storage);

                if (stock == null || stock.Quantity < orderQty)
                {
                    MessageBox.Show($"Not enough stock for {name} (RAM: {ram}, Storage: {storage}). Available: {(stock?.Quantity ?? 0)}",
                                    "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                string realOrderId = "ORD-" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();

                
                var order = new Order(realOrderId, product, orderQty, customerName, discountPercent);

                orderManager.AddOrder(order);

                anyOrderPlaced = true;
            }

            if (anyOrderPlaced)
            {
                MessageBox.Show("Order(s) placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateProductGrid();
                orderForm?.LoadOrders();
            }
            else
            {
                MessageBox.Show("Please select at least one product to place an order.",
                                "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product row first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvProducts.SelectedRows[0];

            string name = selectedRow.Cells["Name"].Value?.ToString();
            string company = selectedRow.Cells["Company"].Value?.ToString();
            string ram = selectedRow.Cells["Ram"].Value?.ToString();
            string storage = selectedRow.Cells["Storage"].Value?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(company) || string.IsNullOrEmpty(ram) || string.IsNullOrEmpty(storage))
            {
                MessageBox.Show("Selected row does not have valid product data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = productManager.GetAllProducts()
                .FirstOrDefault(p => p.ModelName == name && p.Company == company && p.Ram == ram && p.Storage == storage);

            if (product == null)
            {
                MessageBox.Show("Product details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var stock = stockManager.GetStockByModel(product.ModelName, product.Ram, product.Storage);

            var detailsForm = new ProductDetails(product, stock);
            detailsForm.ShowDialog();
        }
    }
}
