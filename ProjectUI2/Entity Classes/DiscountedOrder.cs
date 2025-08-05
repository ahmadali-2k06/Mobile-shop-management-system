using System;

namespace TestingConsole2
{
    internal class DiscountedOrder : Order
    {
        public decimal DiscountRate { get; set; }

        public DiscountedOrder(string orderId, Product product, int orderQuantity, decimal discountRate)
            : base(orderId, product, orderQuantity)
        {
            if (discountRate < 0m || discountRate > 1m)
                throw new ArgumentOutOfRangeException(nameof(discountRate), "Discount rate must be between 0 and 1.");

            DiscountRate = discountRate;
        }

        public override bool ProcessOrder(Stock stock)
        {
            if (CanProcessOrder(stock))
            {
                stock.Quantity -= OrderQuantity;

                decimal originalPrice = OrderQuantity * Product.CalculatePrice();
                TotalAmount = originalPrice - (originalPrice * DiscountRate);

                OrderState = "Processed with Discount";
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
