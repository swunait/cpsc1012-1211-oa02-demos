using System;

namespace StringFormattingDemo
{
    class Program
    {
        // This program demonstrates how to format numbers as either a currency value 
        // or a fixed number of decimal places
        // and how to align output into columns
        static void Main(string[] args)
        {
            const double PI = 22.0 / 7;
            // Format the PI output value to 4 decimal places
            Console.WriteLine($"The value of PI is {PI:F4}");

            const double price1 = 123456.789;
            // Format the price1 value in currency format
            Console.WriteLine($"The value of price1 is {price1:C}");

            const string ColumnHeadingBeginningBalance = "Beginning Balance";
            const string ColumnHeadingEndingBalance = "Ending Balance";
            const double beginningBalance1 = 16305.32;
            const double endingBalance1 = 18794.16;
            const double beginningBalance2 = 18794.16;
            const double endingBalance2 = 17794.16;
            Console.WriteLine($"{ColumnHeadingBeginningBalance, -28} {ColumnHeadingEndingBalance, 14}");
            Console.WriteLine($"{beginningBalance1, -28:C} {endingBalance1, 14:C}");
            Console.WriteLine($"{beginningBalance2,-28:C} {endingBalance2, 14:C}");
        }
    }
}
