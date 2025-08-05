using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestingConsole2;

namespace ProjectUI2
{
    public partial class StockForm : Form
    {
        private ProductManager productManager;
        private StockManager stockManager;
        private ProductDetails currentProductDetailsForm;
        private static readonly Random random = new Random();

        public StockForm(ProductManager sharedProductManager, StockManager sharedStockManager)
        {
            InitializeComponent();
            this.productManager = sharedProductManager;
            this.stockManager = sharedStockManager;
            string productFilePath = @"products.json";
            this.Load += StockForm_Load;
        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            RefreshStock();
        }

        // Synchronizes stock entries with products
        public void LoadStockFromProducts()
        {
            foreach (var product in productManager.GetAllProducts())
            {
                if (!stockManager.StockExists(product))
                {
                    string stockId = GenerateStockId();
                    int defaultQuantity = 10; // or zero if you want
                    Stock newStock = new Stock(stockId, product, defaultQuantity);
                    stockManager.AddStock(newStock);
                }
            }
        }

        // Populate DataGridView rows based on current stock list
        public void PopulateStockGrid()
        {
            if (dgvStock.Columns.Count == 0)
            {
                dgvStock.Columns.Add("StockID", "Stock ID");
                dgvStock.Columns.Add("Name", "Product Name");
                dgvStock.Columns.Add("Brand", "Brand");
                dgvStock.Columns.Add("Quantity", "Quantity");
                dgvStock.Columns.Add("UnitPrice", "Unit Price");
                dgvStock.Columns.Add("TotalPrice", "Total Price");

                var ramColumn = new DataGridViewTextBoxColumn();
                ramColumn.Name = "Ram";
                ramColumn.HeaderText = "RAM";
                ramColumn.Visible = false;
                dgvStock.Columns.Add(ramColumn);

                var storageColumn = new DataGridViewTextBoxColumn();
                storageColumn.Name = "Storage";
                storageColumn.HeaderText = "Storage";
                storageColumn.Visible = false;
                dgvStock.Columns.Add(storageColumn);
            }

            dgvStock.Rows.Clear();

            foreach (var stock in stockManager.GetAllStocks())
            {
                decimal unitPrice = stock.GetPrice();
                decimal totalPrice = unitPrice * stock.Quantity;

                int rowIndex = dgvStock.Rows.Add(
                    stock.Id,
                    stock.Name,
                    stock.Brand,
                    stock.Quantity,
                    unitPrice,
                    totalPrice
                );

                dgvStock.Rows[rowIndex].Cells["Ram"].Value = stock.Product.Ram;
                dgvStock.Rows[rowIndex].Cells["Storage"].Value = stock.Product.Storage;
            }
        }

        public void RefreshStock()
        {
            LoadStockFromProducts();
            PopulateStockGrid();
        }

        private static string GenerateStockId()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var id = new char[4];
            for (int i = 0; i < id.Length; i++)
            {
                id[i] = chars[random.Next(chars.Length)];
            }
            return "STK-" + new string(id);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                var selectedRow = dgvStock.SelectedRows[0];

                string modelName = selectedRow.Cells["Name"].Value?.ToString();
                string ram = selectedRow.Cells["Ram"].Value?.ToString();
                string storage = selectedRow.Cells["Storage"].Value?.ToString();

                if (string.IsNullOrEmpty(modelName) || string.IsNullOrEmpty(ram) || string.IsNullOrEmpty(storage))
                {
                    MessageBox.Show("Selected row has missing product details.");
                    return;
                }

                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete the product '{modelName}' (RAM: {ram}, Storage: {storage}) from stock?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    bool removedFromStock = stockManager.RemoveStock(modelName, ram, storage);
                    bool removedFromProducts = productManager.RemoveProduct(modelName, ram, storage);

                    if (removedFromStock && removedFromProducts)
                    {
                        RefreshStock();
                        MessageBox.Show($"Product '{modelName}' deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete the product '{modelName}'. It may not exist.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product row to delete.");
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Please enter a mobile name to search.");
                return;
            }

            var searchedStock = stockManager.GetStockByName(searchName);

            if (searchedStock != null)
            {
                dgvStock.Rows.Clear();

                decimal unitPrice = searchedStock.GetPrice();
                decimal totalPrice = unitPrice * searchedStock.Quantity;

                int rowIndex = dgvStock.Rows.Add(
                    searchedStock.Id,
                    searchedStock.Name,
                    searchedStock.Brand,
                    searchedStock.Quantity,
                    unitPrice,
                    totalPrice
                );

                dgvStock.Rows[rowIndex].Cells["Ram"].Value = searchedStock.Product.Ram;
                dgvStock.Rows[rowIndex].Cells["Storage"].Value = searchedStock.Product.Storage;
            }
            else
            {
                MessageBox.Show($"Mobile '{searchName}' not found in stock.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            RefreshStock();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (currentProductDetailsForm != null && !currentProductDetailsForm.IsDisposed)
            {
                currentProductDetailsForm.BringToFront();
                currentProductDetailsForm.Focus();
                return;
            }

            if (dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a stock row first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvStock.SelectedRows[0];
            string modelName = selectedRow.Cells["Name"].Value?.ToString();
            string ram = selectedRow.Cells["Ram"].Value?.ToString();
            string storage = selectedRow.Cells["Storage"].Value?.ToString();

            if (string.IsNullOrEmpty(modelName) || string.IsNullOrEmpty(ram) || string.IsNullOrEmpty(storage))
            {
                MessageBox.Show("Selected row does not have valid product details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = productManager.GetAllProducts()
                            .FirstOrDefault(p => p.ModelName == modelName && p.Ram == ram && p.Storage == storage);

            if (product == null)
            {
                MessageBox.Show("Product details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var stock = stockManager.GetStockByModel(modelName, ram, storage);

            currentProductDetailsForm = new ProductDetails(product, stock);
            currentProductDetailsForm.FormClosed += (s, args) => currentProductDetailsForm = null;
            currentProductDetailsForm.Show();
        }

        public void RefreshStockGrid()
        {
            dgvStock.DataSource = null;
            dgvStock.DataSource = stockManager.GetAllStocks();
        }
        public void LoadStockFromProductFile(string productFilePath)
        {
            // Use the helper method and pass GenerateStockId delegate
            List<Stock> stocks = JsonFileHelper.LoadStocksFromProductFile(productFilePath, GenerateStockId, 10);

            foreach (var stock in stocks)
            {
                stockManager.AddStock(stock);
            }
        }







    }
}
