using System;
using System.Collections.Generic;
namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("LIL", "Lil Cakes");
            stocks.Add("ME", "My Entertainment");

            string GM = stocks["GM"];   <--- "General Motors"

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));
            purchases.Add((ticker: "LIL", shares: 10, price: 15.50));
            purchases.Add((ticker: "LIL", shares: 20, price: 16.00));
            purchases.Add((ticker: "ME", shares: 25, price: 17.05));
            purchases.Add((ticker: "ME", shares: 30, price: 18.05));

            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?

                // If it does, update the total valuation

                // If not, add the new key and set its value
            }

            Console.WriteLine("Hello World!");
        }
    }
}
