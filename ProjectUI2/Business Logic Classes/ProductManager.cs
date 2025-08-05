using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestingConsole2
{
    public class ProductManager
    {
        private List<Product> products;

        public ProductManager()
        {
            products = new List<Product>();
        }

        // Add a product to the list
        public void AddProduct(Product product)
        {
            if (!ProductExists(product))
                products.Add(product);
        }

        // Get all products
        public List<Product> GetAllProducts()
        {
            return products;
        }

        // Find a product by model name only
        public Product FindByModelName(string modelName)
        {
            return products.FirstOrDefault(p => p.ModelName.Equals(modelName, StringComparison.OrdinalIgnoreCase));
        }

        // Remove product by full match on model name, RAM, and storage
        public bool RemoveProduct(string modelName, string ram, string storage)
        {
            var product = products.FirstOrDefault(p =>
                p.ModelName.Equals(modelName, StringComparison.OrdinalIgnoreCase) &&
                p.Ram.Equals(ram, StringComparison.OrdinalIgnoreCase) &&
                p.Storage.Equals(storage, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                products.Remove(product);
                return true;
            }

            return false;
        }

        // Remove product by model name only (if unique)
        // Use cautiously, prefer the above overload for full match
        public bool RemoveProductByModelName(string modelName)
        {
            var product = FindByModelName(modelName);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }

        // Check if an identical product already exists
        public bool ProductExists(Product newProduct)
        {
            if (newProduct == null)
                return false;

            if (products == null || products.Count == 0)
                return false;

            return products.Any(p =>
                p != null &&
                !string.IsNullOrEmpty(p.Company) && !string.IsNullOrEmpty(newProduct.Company) &&
                p.Company.Equals(newProduct.Company, StringComparison.OrdinalIgnoreCase) &&

                !string.IsNullOrEmpty(p.ModelName) && !string.IsNullOrEmpty(newProduct.ModelName) &&
                p.ModelName.Equals(newProduct.ModelName, StringComparison.OrdinalIgnoreCase) &&

                !string.IsNullOrEmpty(p.Ram) && !string.IsNullOrEmpty(newProduct.Ram) &&
                p.Ram.Equals(newProduct.Ram, StringComparison.OrdinalIgnoreCase) &&

                !string.IsNullOrEmpty(p.Storage) && !string.IsNullOrEmpty(newProduct.Storage) &&
                p.Storage.Equals(newProduct.Storage, StringComparison.OrdinalIgnoreCase) &&

                !string.IsNullOrEmpty(p.Battery) && !string.IsNullOrEmpty(newProduct.Battery) &&
                p.Battery.Equals(newProduct.Battery, StringComparison.OrdinalIgnoreCase)
            );
        }


        // Find exact match with all specs
        public Product FindExactProduct(string company, string modelName, string ram, string storage, string battery)
        {
            return products.FirstOrDefault(p =>
                p.Company.Equals(company, StringComparison.OrdinalIgnoreCase) &&
                p.ModelName.Equals(modelName, StringComparison.OrdinalIgnoreCase) &&
                p.Ram.Equals(ram, StringComparison.OrdinalIgnoreCase) &&
                p.Storage.Equals(storage, StringComparison.OrdinalIgnoreCase) &&
                p.Battery.Equals(battery, StringComparison.OrdinalIgnoreCase)
            );
        }

        // Save products to JSON file using Newtonsoft.Json
        public void SaveProductsToJson(string filePath)
        {
            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        // Load products from JSON file using Newtonsoft.Json
        public void LoadProductsFromJson(string filePath)
        {
            if (!File.Exists(filePath))
            {
                products = new List<Product>();
                return;
            }

            string json = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
        }
    }
}
