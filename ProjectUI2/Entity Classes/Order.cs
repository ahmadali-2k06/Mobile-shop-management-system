using System;

namespace TestingConsole2
{
    public class Order
    {
        public string OrderID { get; set; }  // Keep property for backward compatibility
        public Product Product { get; set; }  // Reference to Product object
        public int OrderQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderState { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public decimal DiscountPercent { get; set; }

        // Existing constructors with orderId
        public Order(string orderId, Product product, int orderQuantity)
        {
            OrderID = orderId;
            Product = product;
            OrderQuantity = orderQuantity;
            OrderState = "Pending";
            OrderDate = DateTime.Now;
        }

        public Order(string orderId, Product product, int orderQuantity, string customerName, decimal discountPercent)
            : this(orderId, product, orderQuantity)
        {
            CustomerName = customerName;
            DiscountPercent = discountPercent;
        }

        // New overloaded constructors WITHOUT orderId
        public Order(Product product, int orderQuantity)
        {
            Product = product;
            OrderQuantity = orderQuantity;
            OrderState = "Pending";
            OrderDate = DateTime.Now;
            OrderID = null;  
        }

        public Order(Product product, int orderQuantity, string customerName, decimal discountPercent)
            : this(product, orderQuantity)
        {
            CustomerName = customerName;
            DiscountPercent = discountPercent;
        }

        public bool CanProcessOrder(Stock stock)
        {
            return OrderQuantity <= stock.Quantity;
        }

        public virtual bool ProcessOrder(Stock stock)
        {
            if (CanProcessOrder(stock))
            {
                stock.Quantity -= OrderQuantity;
                TotalAmount = OrderQuantity * Product.CalculatePrice();
                OrderState = "Processed";
                return true;
            }
            else
            {
                OrderState = "Rejected - Insufficient Stock";
                return false;
            }
        }
    }
}
