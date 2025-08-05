using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TestingConsole2;

public static class JsonFileHelper
{
    public static void SaveToFile<T>(List<T> data, string filePath)
    {
        string jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(filePath, jsonString);
    }

    public static List<T> LoadFromFile<T>(string filePath)
    {
        if (!File.Exists(filePath))
            return new List<T>();

        var json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<T>>(json);
    }

    // New method to load products and convert to stocks with IDs and quantity
    public static List<Stock> LoadStocksFromProductFile(string productFilePath, Func<string> generateStockIdFunc, int defaultQuantity = 10)
    {
        List<Product> products = LoadFromFile<Product>(productFilePath);

        List<Stock> stocks = new List<Stock>();

        foreach (var product in products)
        {
            string stockId = generateStockIdFunc();  
            Stock stockItem = new Stock(stockId, product, defaultQuantity);
            stocks.Add(stockItem);
        }

        return stocks;
    }

}
