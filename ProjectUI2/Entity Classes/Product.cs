using System;
using System.Text;

namespace TestingConsole2
{
    public class Product
    {
        public string Company { get; set; }
        public string ModelName { get; set; }
        public string Ram { get; set; }
        public string Storage { get; set; }
        public string Battery { get; set; }

        /// <summary>
        /// Date and time when the product was created or added.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        // Parameterless constructor for JSON deserialization
        public Product()
        {
            // Optional: initialize CreatedDate to Now
            CreatedDate = DateTime.Now;
        }

        // Main constructor that sets everything, including CreatedDate
        public Product(string company, string modelName, string ram, string storage, string battery, DateTime createdDate)
        {
            Company = company;
            ModelName = modelName;
            Ram = ram;
            Storage = storage;
            Battery = battery;
            CreatedDate = createdDate;
        }

        // Overloaded constructor for existing use cases (auto-assigns CreatedDate)
        public Product(string company, string modelName, string ram, string storage, string battery)
            : this(company, modelName, ram, storage, battery, DateTime.Now) { }

        public decimal CalculatePrice()
        {
            decimal price = 0;

            if (!string.IsNullOrWhiteSpace(Company))
            {
                switch (Company.ToLowerInvariant())
                {
                    case "samsung": price += 20000; break;
                    case "apple": price += 70000; break;
                    case "xiaomi": price += 15000; break;
                    default: price += 10000; break;
                }
            }

            if (!string.IsNullOrWhiteSpace(Ram))
            {
                if (Ram.Contains("8")) price += 10000;
                else if (Ram.Contains("6")) price += 7000;
                else if (Ram.Contains("4")) price += 4000;
            }

            if (!string.IsNullOrWhiteSpace(Storage))
            {
                string storageLower = Storage.ToLowerInvariant();
                if (storageLower.Contains("ssd")) price += 3000;
                else if (storageLower.Contains("ufs")) price += 2000;
                else if (storageLower.Contains("emmc")) price += 1000;
            }

            if (!string.IsNullOrWhiteSpace(Battery))
            {
                int batteryMah = ExtractNumber(Battery);
                price += (batteryMah / 100) * 500;
            }

            decimal companyIncreasePercent = 0;
            switch (Company?.ToLowerInvariant())
            {
                case "samsung": companyIncreasePercent = 10; break;
                case "apple": companyIncreasePercent = 7; break;
                case "infinix": companyIncreasePercent = 5; break;
                case "redmi": companyIncreasePercent = 2; break;
                case "huawei": companyIncreasePercent = 8; break;
                default: companyIncreasePercent = 0; break;
            }

            price += price * (companyIncreasePercent / 100);
            return price;
        }

        private int ExtractNumber(string text)
        {
            if (string.IsNullOrEmpty(text)) return 0;

            var digits = new StringBuilder();
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    digits.Append(c);
                else if (digits.Length > 0)
                    break;
            }
            return int.TryParse(digits.ToString(), out int number) ? number : 0;
        }
    }
}
