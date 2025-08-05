using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TestingConsole2
{
    public class StockManager
    {
        private List<Stock> stockList;

        public StockManager()
        {
            stockList = new List<Stock>();
        }

        /// <summary>
        /// Adds a new stock item to the list.
        /// If stock with same model + RAM + Storage exists, increases quantity.
        /// </summary>
        public void AddStock(Stock stock)
        {
            var existing = GetStockByModel(stock.Product.ModelName, stock.Product.Ram, stock.Product.Storage);

            if (existing != null)
            {
                existing.Quantity += stock.Quantity;
            }
            else
            {
                stockList.Add(stock);
            }
        }

        /// <summary>
        /// Gets all stock items.
        /// </summary>
        public List<Stock> GetAllStocks()
        {
            return stockList;
        }

        /// <summary>
        /// Finds stock by product model name, RAM, and storage (case-insensitive).
        /// </summary>
        public Stock GetStockByModel(string modelName, string ram, string storage)
        {
            if (string.IsNullOrWhiteSpace(modelName) || string.IsNullOrWhiteSpace(ram) || string.IsNullOrWhiteSpace(storage))
                return null;

            return stockList.FirstOrDefault(s =>
                s.Product.ModelName.Equals(modelName, StringComparison.OrdinalIgnoreCase) &&
                s.Product.Ram.Equals(ram, StringComparison.OrdinalIgnoreCase) &&
                s.Product.Storage.Equals(storage, StringComparison.OrdinalIgnoreCase)
            );
        }


        /// <summary>
        /// Finds stock by stock ID (case-insensitive).
        /// </summary>
        public Stock GetStockById(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return null;
            return stockList.FirstOrDefault(s => s.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Updates the quantity of stock for the given model + specs.
        /// Quantity must be zero or positive.
        /// </summary>
        public bool UpdateQuantity(string modelName, string ram, string storage, int newQuantity)
        {
            if (newQuantity < 0) return false;
            var stock = GetStockByModel(modelName, ram, storage);
            if (stock != null)
            {
                stock.Quantity = newQuantity;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Increases quantity of stock for the given model + specs by amount.
        /// Amount must be positive.
        /// </summary>
        public bool IncreaseQuantity(string modelName, string ram, string storage, int amount)
        {
            if (amount <= 0) return false;
            var stock = GetStockByModel(modelName, ram, storage);
            if (stock != null)
            {
                stock.Quantity += amount;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Decreases quantity of stock for the given model + specs by amount.
        /// Does not allow quantity to go below zero.
        /// </summary>
        public bool DecreaseQuantity(string modelName, string ram, string storage, int amount)
        {
            if (amount <= 0) return false;
            var stock = GetStockByModel(modelName, ram, storage);
            if (stock != null && stock.Quantity >= amount)
            {
                stock.Quantity -= amount;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes the stock item for the given model + specs.
        /// </summary>
        public bool RemoveStock(string modelName, string ram, string storage)
        {
            var stock = GetStockByModel(modelName, ram, storage);
            if (stock != null)
            {
                stockList.Remove(stock);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if stock exists for the given product (model + specs).
        /// </summary>
        public bool StockExists(Product product)
        {
            if (product == null) return false;

            return stockList.Any(s =>
                s.Product.ModelName.Equals(product.ModelName, StringComparison.OrdinalIgnoreCase) &&
                s.Product.Ram.Equals(product.Ram, StringComparison.OrdinalIgnoreCase) &&
                s.Product.Storage.Equals(product.Storage, StringComparison.OrdinalIgnoreCase)
            );
        }

        /// <summary>
        /// Adds a new stock or updates existing stock quantity and product.
        /// </summary>
        public void AddOrUpdateStock(Stock stock)
        {
            if (stock == null) throw new ArgumentNullException(nameof(stock));

            var existingStock = GetStockByModel(stock.Product.ModelName, stock.Product.Ram, stock.Product.Storage);
            if (existingStock != null)
            {
                existingStock.Quantity += stock.Quantity;
                existingStock.Product = stock.Product; // update product info if needed
            }
            else
            {
                stockList.Add(stock);
            }
        }
        public Stock GetStockByName(string modelName)
        {
            if (string.IsNullOrWhiteSpace(modelName)) return null;

            return stockList.FirstOrDefault(s =>
                s.Product.ModelName.Equals(modelName, StringComparison.OrdinalIgnoreCase)
            );
        }
    }
}
