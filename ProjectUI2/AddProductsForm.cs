using ProjectUI2.Utility_Helper_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestingConsole2;

namespace ProjectUI2
{
    public partial class AddProductsForm : Form
    {
        private ProductManager productManager;
        private StockManager stockManager;
        private StockForm stockForm;
        private bool isResetting = false;
        private static readonly Random random = new Random();
        Dictionary<string, List<string>> companyModels = new Dictionary<string, List<string>>()
        {
            { "Samsung", new List<string> { "Galaxy S21", "Galaxy A52", "Note 20", "Note 24 Ultra", "Note 25" } },
            { "Apple", new List<string> { "iPhone 13", "iPhone 14", "iPhone SE", "iPhone 15", "iPhone 16" } },
            { "Huawei", new List<string> { "P50", "Mate 40", "Nova 8", "P40 Pro", "Mate X2" } },
            { "Redmi", new List<string> { "Redmi Note 13 Pro+ 5G", "Redmi Note 13", "Redmi 13C", "Redmi Note 14 Pro", "Redmi 12" } },
            { "Infinix", new List<string> { "Infinix Zero 30 5G", "Infinix Note 40 Pro", "Infinix Smart 8 Plus", "Infinix Zero 40", "Infinix Smart 9" } }
        };

        public AddProductsForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;

            cmbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModel.SelectedIndex = -1;

            txtQuantity.TextChanged += TxtQuantity_TextChanged;
            cmbCompany.SelectedIndexChanged += cmbCompany_SelectedIndexChanged;
            cmbModel.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
            cmbRam.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
            cmbStorage.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
            cmbBattery.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
        }

        public AddProductsForm(ProductManager sharedProductManager, StockManager sharedStockManager)
            : this()
        {
            this.productManager = sharedProductManager;
            this.stockManager = sharedStockManager;
        }

        public AddProductsForm(ProductManager sharedProductManager, StockManager sharedStockManager, StockForm stockForm)
            : this(sharedProductManager, sharedStockManager)
        {
            this.stockForm = stockForm;
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isResetting) return;

            string selectedCompany = cmbCompany.SelectedItem?.ToString();
            cmbModel.Items.Clear();

            if (!string.IsNullOrEmpty(selectedCompany) && companyModels.ContainsKey(selectedCompany))
            {
                cmbModel.Items.AddRange(companyModels[selectedCompany].ToArray());
            }

            cmbModel.SelectedIndex = -1;
            UpdateTotalPrice();
        }

        private void ComboBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            if (cmbCompany.SelectedItem == null ||
                cmbModel.SelectedItem == null ||
                cmbRam.SelectedItem == null ||
                cmbStorage.SelectedItem == null ||
                cmbBattery.SelectedItem == null)
            {
                lblTotalPrice.Text = "Select all fields.";
                return;
            }

            if (int.TryParse(txtQuantity.Text.Trim(), out int quantity) && quantity > 0)
            {
                var product = new Product(
                    cmbCompany.SelectedItem.ToString(),
                    cmbModel.SelectedItem.ToString(),
                    cmbRam.SelectedItem.ToString(),
                    cmbStorage.SelectedItem.ToString(),
                    cmbBattery.SelectedItem.ToString()
                );

                decimal unitPrice = product.CalculatePrice();
                decimal totalPrice = unitPrice * quantity;

                lblTotalPrice.Text = $"Rs {totalPrice:N0}";
            }
            else
            {
                lblTotalPrice.Text = "Enter valid quantity.";
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (cmbCompany.SelectedItem == null ||
                cmbModel.SelectedItem == null ||
                cmbRam.SelectedItem == null ||
                cmbStorage.SelectedItem == null ||
                cmbBattery.SelectedItem == null)
            {
                var msg = new messageBox("Please select all product details.", "Warning", messageBox.MessageType.Warning);
                msg.ShowDialog();
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity <= 0)
            {
                var msg = new messageBox("Please enter a valid quantity.", "Warning", messageBox.MessageType.Warning);
                msg.ShowDialog();
                return;
            }

            var product = new Product(
                cmbCompany.SelectedItem.ToString(),
                cmbModel.SelectedItem.ToString(),
                cmbRam.SelectedItem.ToString(),
                cmbStorage.SelectedItem.ToString(),
                cmbBattery.SelectedItem.ToString()
            );

            if (!productManager.ProductExists(product))
            {
                productManager.AddProduct(product);
            }

            string stockId = GenerateStockId();
            var stock = new Stock(stockId, product, quantity);
            stockManager.AddOrUpdateStock(stock);

            decimal unitPrice = product.CalculatePrice();
            decimal totalPrice = unitPrice * quantity;
            lblTotalPrice.Text = $"Rs {totalPrice:N0}";

            System.Media.SystemSounds.Asterisk.Play();

            var successMsg = new messageBox("Product added successfully!", "Success", messageBox.MessageType.Success);
            successMsg.ShowDialog();

            ResetForm();
            UpdateStockForm(); // ✅ Call to refresh StockForm's grid
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            isResetting = true;

            cmbCompany.SelectedIndex = -1;
            cmbModel.Items.Clear();
            cmbModel.SelectedIndex = -1;

            cmbRam.SelectedIndex = -1;
            cmbStorage.SelectedIndex = -1;
            cmbBattery.SelectedIndex = -1;

            txtQuantity.Clear();
            lblTotalPrice.Text = "Rs.0";

            isResetting = false;
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


       

        private void UpdateStockForm()
        {
            if (stockForm != null)
            {
                stockForm.RefreshStockGrid(); // ✅ This is the correct call
            }
        }

        private void bunifuButton2_Click_2(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Select Product JSON File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;

                    // Load list of ProductWithQuantity objects, NOT just Product
                    List<ProductWithQuantity> loadedItems = JsonFileHelper.LoadFromFile<ProductWithQuantity>(selectedFile);

                    if (loadedItems == null || loadedItems.Count == 0)
                    {
                        MessageBox.Show("No products found in the selected file.", "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int addedCount = 0;
                    foreach (var item in loadedItems)
                    {
                        var product = item.Product;
                        int quantity = item.Quantity;

                        if (!productManager.ProductExists(product))
                        {
                            productManager.AddProduct(product);
                            addedCount++;
                        }

                        // Add or update stock with quantity
                        string stockId = GenerateStockId();
                        var stock = new Stock(stockId, product, quantity);
                        stockManager.AddOrUpdateStock(stock);
                    }

                    if (addedCount > 0)
                    {
                        string defaultFilePath = "products.json";
                        productManager.SaveProductsToJson(defaultFilePath);
                        MessageBox.Show($"{addedCount} products added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No new products were added. All products already exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    UpdateStockForm(); // refresh UI
                }
            }

        }




















    }
}
