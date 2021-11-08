/*  Purpose:    Compute the total change for a set of pennies, nickels, dimes, quarters, loonies, and twonies.
 *  
 *  Input:      Twonies
 *              Loonies
 *              Quarter
 *              Dimes
 *              Nickels
 *              Pennies
 * 
 *  Output:     Total change in dollars and cents
 *  
 *  Algorithm:  1) Prompt and read in values for twonies, loonies, quarters, dimes, nickels, pennies
 *              2) Call the GetTotal() and display the total returned
 * 
 * */
using System;

namespace MP3_Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs and outputs
            int twonies,
                loonies,
                quarters,
                dimes,
                nickels,
                pennies;
            double totalChange = 0;

            Console.WriteLine("This program computes the total amount of coins.");
            // Prompt and read in values for twonies, loonies, quarters, dimes, nickels, pennnies
            twonies = PromptForIntegerPositiveOrZero("Enter the number of twonies: ");
            loonies = PromptForIntegerPositiveOrZero("Enter the number of loonies: ");
            quarters = PromptForIntegerPositiveOrZero("Enter the number of quarters: ");
            dimes = PromptForIntegerPositiveOrZero("Enter the number of dimes: ");
            nickels = PromptForIntegerPositiveOrZero("Enter the number of nickels: ");
            pennies = PromptForIntegerPositiveOrZero("Enter the number of pennies: ");

            // Get the total amount of change 
            totalChange = GetTotal(twonies, loonies, quarters, dimes, nickels, pennies);

            // Displal the total amount of change
            Console.WriteLine($"The total amount of change is: {totalChange:C}");
        }

        static double GetTotal(int twoonies, int loonies, int quarters, int dimes, int nickels, int pennies)
        {
            double total;
            total = twoonies * 2 + loonies * 1 + quarters * 0.25 + dimes * 0.10 + nickels * 0.05 + pennies * 0.01;
            return total;
        }

        static int PromptForIntegerPositiveOrZero(string prompt)
        {
            int intValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(prompt);
                try
                {
                    intValue = int.Parse(Console.ReadLine());
                    if (intValue >= 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input. You must enter a positive or zero number.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return intValue;
        }
    }
}