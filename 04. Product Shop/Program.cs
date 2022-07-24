using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string,Dictionary<string,double>>();
            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] cmd = input.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                    string shop= cmd[0];
                string product = cmd[1];
                double price = double.Parse(cmd[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);
            }
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
{
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
