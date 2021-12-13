using System;

namespace ObjectProblems3
{
    public class Stock
    {
        // Define properties for the Name, Symbol, PreviousClosingPrice, CurrentPrice
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double PreviousClosingPrice { get; set; }
        public double CurrentPrice { get; set; }

        // Define an constructor for creating a Stock object with a specified name and symbol
        public Stock(string name, string symbol)
        {
            // Assigned the Name and Symbol properties using the method parameters
           this.Name = name;
           this.Symbol = symbol;
        }

        // Define instance-level methods for the ChangePercent() and ChangePrice
        public double ChangePercent()
        {
            //return (CurrentPrice - PreviousClosingPrice) / PreviousClosingPrice;
            return (ChangePrice() / PreviousClosingPrice);
        }
        public double ChangePrice()
        {
            return CurrentPrice - PreviousClosingPrice;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{Name} ({Symbol}): {CurrentPrice:C}, {ChangePrice():F3}({ChangePercent():P})";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt and read in the stock name and stock symbol
            string  name,
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

            // Print the following information about the current stock object:
            //  Name (Symbol), CurrentStockPrice, ChangePrice(ChangePercent)
            Console.WriteLine($"{currentStock.Name} ({currentStock.Symbol}): {currentStock.CurrentPrice:C}, {currentStock.ChangePrice():F3}({currentStock.ChangePercent():P})");

            //Console.WriteLine(currentStock); // This will only work if you override the ToString() method of the Stock class
        
        }
    }
}
