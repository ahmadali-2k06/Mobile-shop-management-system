using System;

namespace TestingConsole2
{
    public class Stock
    {
        public string Id { get; private set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }



        public Stock(string id,Product product, int quantity)
        {
            Id = id;
            Product = product ?? throw new ArgumentNullException(nameof(product));
            Quantity = quantity >= 0 ? quantity : throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity cannot be negative");
        }

        // Unit price of the product
        public decimal UnitPrice => Product.CalculatePrice();

        // Total price = unit price * quantity
        public decimal TotalPrice => UnitPrice * Quantity;

        // Convenience properties
        public string Name => Product.ModelName;
        public string Brand => Product.Company;

        public override string ToString()
        {
            return $"{Brand} {Name} - Qty: {Quantity}, Unit Price: {UnitPrice:C}, Total: {TotalPrice:C}";
        }
        public decimal GetPrice()
        {
            return Product.CalculatePrice();
        }
    }
}
