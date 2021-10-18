/* Purpose:     Convert cups to fluid ounces
 * 
 * Inputs:      cups
 * 
 * Outputs:     fluid ounces
 * 
 * Algorithm:   1) Display a welcome message
 *              2) Get the number of cups from the user
 *              3) Convert the number of cups to fluid ounces
 *              4) Display the conversion result
 * 
 * 
 * */
using System;
using CPSC1012;

namespace CupConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the number of cups from the user
            double theCups = GetCups();
            // Convert the number of cups to fluid ounces
            double theOunces = CupsToOunces(theCups);
            // Display the conversion result
            DisplayResults(theCups, theOunces);
        }

        /// <summary>
        /// Prompt, read, and return the number of cups
        /// </summary>
        /// <returns>the number of cups entered by the user</returns>
        static double GetCups()
        {
            double numCups = 0;
            // Prompt and read in the numCups value
            //Console.WriteLine("This program converts measurements in cups to fluid ounces");
            //Console.Write("For your reference the formula is: ");
            //Console.WriteLine("1 cup = 8 fluid ounces.");
            //Console.Write("Enter the number of cups: ");
            //numCups = double.Parse(Console.ReadLine());
            const string prompt = "This program converts measurements in cups to fluid ounces\n"
                + "For your reference the formula is: "
                + "1 cup = 8 fluid ounces.\n"
                + "Enter the number of cups: ";
            numCups = CPSC1012Helper.PromptForDouble(prompt);
             

            //while (!double.TryParse(Console.ReadLine(), out numCups))
            //{
            //    Console.WriteLine("Invalid input. Try again.");
            //}

            //bool validInput = false;
            //while (!validInput)
            //{
            //    try
            //    {
            //        numCups = double.Parse(Console.ReadLine());
            //        validInput = true;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Invalid input. Try again.");
            //    }
            //}            

            return numCups;
        }

        /// <summary>
        /// Convert cups to fluid ounces
        /// </summary>
        /// <param name="cups">the cups value to convert</param>
        /// <returns>the converted ounces value for cups</returns>
        static double CupsToOunces(double cups)
        {
            double ounces = 0;
            ounces = cups * 8.0;
            return ounces;
        }

        /// <summary>
        /// Print the cups and ounces value
        /// </summary>
        /// <param name="cups">the number of cups to display</param>
        /// <param name="ounces">the number ounces to display</param>
        static void DisplayResults(double cups, double ounces)
        {
            Console.WriteLine($"{cups} cups equal to {ounces} fluid ounces.");
        }

    }
}
