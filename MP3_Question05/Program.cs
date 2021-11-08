/*  Purpose:    Compute the daily gross income for a one-person taxi company.
 *  
 *  Inputs:     menu choice (A, R, F, X)
 *              distance travel (km)
 *              time of trip (minutes)
 *              flat rate charge
 *              tip amount
 *              
 *  Outputs:    Total gross income
 * 
 *  Algorithm:  1. Do the following:
 *                  1. Prompt for menu choice
 *                  2. If menuChoice is A Then do the following
 *                          1. Call CalculateAirportAmount method and add return value to totalGrossIncome
 *                     Else if menuchoice is R then do the following
 *                          1. Call CalculateRegualrRateAmount method and add return value to totalGrossIncome
 *                     Else If menuChoice is F then do the following
 *                          1. Call CalculateFlatRateAmount method and add return value to totalGrossIncome
 *                     Else if menuChoice is X then do nothing
 *                     Else do the following
 *                          1. Display invalid menu choice error
 *                     End If
 *                  While menuChoice <> exit program    
 *              2. Print the TotalGrossIncome
 *              
 * 
 * */
using System;

namespace MP_Question05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs and outputs
            char menuChoice;
            double totalGrossIncome = 0;

            do
            {
                DisplayMenu();
                menuChoice = Console.ReadKey().KeyChar;
                menuChoice = char.ToUpper(menuChoice);
                Console.WriteLine();
                switch (menuChoice)
                {
                    case 'A':
                        totalGrossIncome += CalculateAirportAmount();
                        break;
                    case 'R':
                        totalGrossIncome += CalculateRegularFareAmount();
                        break;
                    case 'F':
                        totalGrossIncome += CalculateFlatRateAmount();
                        break;
                    case 'X':
                        // Do nothing
                        break;
                    default:
                        Console.WriteLine("Invalid menu choice. Try again.");
                        break;
                }
            } while (menuChoice != 'X');

            // Dispaly the total gross income
            Console.WriteLine($"The daily total gross income is: {totalGrossIncome:C}");
        }

        static double CalculateAirportAmount()
        {
            double amount;

            double tipAmount = PromptForDoublePositiveOrZero("Enter tip amount: ");
            amount = 25 + tipAmount;

            return amount;
        }

        static double CalculateRegularFareAmount()
        {
            double amount;

            double distance = PromptForDoublePositiveOrZero("Enter distance traveled in km: ");
            double time = PromptForDoublePositiveOrZero("Enter time traveled in minutes: ");
            double tipAmount = PromptForDoublePositiveOrZero("Enter tip amount: ");
            amount = distance * 1.10 + time * 0.20 + tipAmount;

            return amount;
        }

        static double CalculateFlatRateAmount()
        {
            double amount;

            double flatRate = PromptForDoublePositiveOrZero("Enter flat rate amount: ");
            double tipAmount = PromptForDoublePositiveOrZero("Enter tip amount: ");
            amount = flatRate + tipAmount;

            return amount; ;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Enter a letter for your choice");
            Console.WriteLine("A: Airport Trip");
            Console.WriteLine("R: Regular fare");
            Console.WriteLine("F: Flat rate");
            Console.WriteLine("X: Exit Program");
            Console.Write("Your choice: ");

        }

        static double PromptForDoublePositiveOrZero(string prompt)
        {
            double doubleValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(prompt);
                try
                {
                    doubleValue = double.Parse(Console.ReadLine());
                    if (doubleValue >= 0)
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

            return doubleValue;
        }
    }
}