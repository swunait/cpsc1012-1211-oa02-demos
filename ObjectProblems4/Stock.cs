using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProblems4
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
}
