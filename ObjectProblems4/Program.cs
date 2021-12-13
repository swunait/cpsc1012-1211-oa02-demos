using System;

using System.Collections.Generic;   // for List<T>

namespace ObjectProblems4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and create a new of list of Stock objects
            List<Stock> stockList = new List<Stock>();

            // Call a method to add Stock objects to the list
            PromptForStocks(stockList);

            // Call a method to display the properties of each object in the list
            DisplayStocks(stockList);

        }

        static void PromptForStocks(List<Stock> stockList)
        {
            char yesOrNoAnswer = 'y';
            do
            {
                // Prompt and read in the stock name and stock symbol
                string name,
                        symbol;
                Console.Write("Enter the stock name: ");
                name = Console.ReadLine();
                Console.Write("Enter the stock symbol: ");
                symbol = Console.ReadLine();

                // Create a new Stock object the stock name and stock symbol
                Stock currentStock = new Stock(name, symbol);

                // Prompt and set the PreviousClosingPrice and CurrentPrice of the current stock object
                Console.Write($"Enter the {currentStock.Name} ({currentStock.Symbol}) previous closing price: ");
                currentStock.PreviousClosingPrice = double.Parse(Console.ReadLine());
                Console.Write($"Enter the {currentStock.Name} ({currentStock.Symbol}) current stock price: ");
                currentStock.CurrentPrice = double.Parse(Console.ReadLine());

                // Add currentStock to the list of stock
                stockList.Add(currentStock);

                Console.Write("Do you want to enter another stock (y/n): ");
                yesOrNoAnswer = char.Parse(Console.ReadLine());
                yesOrNoAnswer = char.ToLower(yesOrNoAnswer);

            } while (yesOrNoAnswer == 'y');

        }

        static void DisplayStocks(List<Stock> stockList)
        {
            /*  123456789012345678901   123456  123456789012    123456789012    1234567890123   12345678901
             *  Stock Name(21)          Symbol  ClosingPrice    CurrentPRice    PercentChange   PriceChange
             *  ---------------------   ------  ------------    ------------    -------------   ------------
             *  Microsoft Corporation   MSFT    288.33          288.385         0.02            0.0055
             *  Oralce Corporation      ORCL    89.90           89.99           0.10            0.09
             * 
             * */
            Console.WriteLine($"{"Stock Name",-21} {"Symbol",-6} {"ClosingPrice",12} {"CurrentPrice",12} {"PercentChange",13} {"PriceChange",11}");
            Console.WriteLine($"{"----------",-21} {"------",-6} {"------------",12} {"------------",12} {"-------------",13} {"-----------",11}");
            foreach (Stock currentStock in stockList)
            {
                //Console.WriteLine(currentStock); // only works if you define a ToString() method in Stock class.
                Console.WriteLine($"{currentStock.Name,-21} {currentStock.Symbol,-6} {currentStock.PreviousClosingPrice,12:C} {currentStock.CurrentPrice,12:C} {currentStock.ChangePercent(),13:P} {currentStock.ChangePrice(),11:C}");
            }
        }
    }
}
