using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingConsole2
{
    public class OrderManager
    {
        private List<Order> orders = new List<Order>();
        private StockManager stockManager;

        public OrderManager(StockManager stockMgr)
        {
            stockManager = stockMgr;
        }

        /// <summary>
        /// Adds a new order after checking stock availability based on model, RAM, and storage.
        /// </summary>
        public void AddOrder(Order order)
        {
            var product = order.Product;
            Stock stock = stockManager.GetStockByModel(product.ModelName, product.Ram, product.Storage);

            if (stock == null)
            {
                order.OrderState = "Rejected - Product Not Found";
            }
            else if (stock.Quantity >= order.OrderQuantity)
            {
                stock.Quantity -= order.OrderQuantity;
                order.TotalAmount = order.OrderQuantity * stock.Product.CalculatePrice();
                order.OrderState = "Processed";
            }
            else
            {
                order.OrderState = "Rejected - Insufficient Stock";
            }

            orders.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }

        public Order GetOrderById(string orderId)
        {
            if (string.IsNullOrWhiteSpace(orderId)) return null;

            return orders.FirstOrDefault(o => o != null && o.OrderID != null &&
                                              o.OrderID.Equals(orderId, StringComparison.OrdinalIgnoreCase));
        }
        public bool UpdateOrderState(string orderId, string newState)
        {
            var order = GetOrderById(orderId);
            if (order == null)
                return false;

            order.OrderState = newState;
            return true;
        }

        public List<Order> GetProcessedOrders()
        {
            return orders.Where(o => o.OrderState == "Processed" || o.OrderState == "Processed with Discount").ToList();
        }

        /// <summary>
        /// Deletes an order by ID. Restores stock if the order was processed.
        /// </summary>
        public bool DeleteOrder(string orderId)
        {
            if (string.IsNullOrWhiteSpace(orderId))
                return false;

            var order = GetOrderById(orderId);
            if (order == null)
                return false;

            // Restore stock if order was processed
            if (order.OrderState == "Processed" || order.OrderState == "Processed with Discount")
            {
                var stock = stockManager.GetStockByModel(order.Product.ModelName, order.Product.Ram, order.Product.Storage);
                if (stock != null)
                {
                    stock.Quantity += order.OrderQuantity;
                }
            }

            orders.Remove(order);
            return true;
        }
    }
}
