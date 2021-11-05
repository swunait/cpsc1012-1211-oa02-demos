using System;

using System.IO;    // for StreamReader class

namespace ArrayDemo02
{
    // This program reads a list of prices from a text file then it determines
    // the total of all prices, the average price, the lowest price, and the highest price.
    // Sort the array of prices from smallest to largest.
    class Program
    {
        static void Main(string[] args)
        {
            // Read from a text file a list of prices where each price is on a new line
            // Store the prices from the file in a double array of size 100
            const int MaxPriceCount = 100;  // Maximum number of prices
            int priceCount = 0;             // Number of current prices (logical array size)
            double[] priceArray = new double[MaxPriceCount];
            string userInput;
            string dataImportFilePath;

            // Prompt and read in the data import file path
            Console.Write("Enter the data file path: ");
            userInput = Console.ReadLine();
            dataImportFilePath = userInput;
            if (File.Exists(dataImportFilePath))
            {
                // Create a StreamReader object that can used for reading from a file
                StreamReader reader = new StreamReader(dataImportFilePath);
                // Read one line at a time from file and store each line as an double in pricesArray
                // 99.99
                // 88.88
                // 6.89
                string lineText;
                while ( (lineText = reader.ReadLine()) != null)
                {
                    double currentPrice = double.Parse(lineText);
                    priceArray[priceCount] = currentPrice;
                    priceCount++;
                }
                reader.Close();
            }
            

            // Display all the prices in the pricesArray

            // Calculate and display the sum of all prices

            // Calcualte and display the average price of all prices

            // Determine and display the highest price

            // Determine and display the lowest price

        }
    }
}
