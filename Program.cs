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

            Console.WriteLine(stocks["GM"]);
            Console.WriteLine(stocks["CAT"]);
            Console.WriteLine(stocks["LIL"]);
            Console.WriteLine(stocks["ME"]);

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));

            purchases.Add((ticker: "CAT", shares: 20, price: 22.05));
            purchases.Add((ticker: "CAT", shares: 40, price: 18.00));
            purchases.Add((ticker: "CAT", shares: 60, price: 16.00));

            purchases.Add((ticker: "LIL", shares: 10, price: 15.50));
            purchases.Add((ticker: "LIL", shares: 20, price: 16.00));

            purchases.Add((ticker: "ME", shares: 25, price: 17.05));
            purchases.Add((ticker: "ME", shares: 30, price: 18.05));

            Dictionary<string, int>allStocks = new Dictionary<string, int>();

            foreach ((string ticker, int shares, double price) purchase in purchases)
            {

            if (stocks.ContainsKey (purchase.ticker)){

                if (allStocks.ContainsKey (stocks[purchase.ticker])){
                    allStocks[stocks[purchase.ticker]] += (int) purchase.price * (int)purchase.shares;

                } else {
                    

                        allStocks.Add(stocks[purchase.ticker], (int) purchase.price * (int) purchase.shares);
                    
                    }
            }
            }

            foreach (KeyValuePair<string, int> purchase in allStocks)
            {
        
            
                Console.WriteLine ($"{purchase.Key} sold {purchase.Value}");

            }
        }
    }
}

            
            
        
