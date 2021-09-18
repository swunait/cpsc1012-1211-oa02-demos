/*  Purpose:    Computes the future value of an intestment
 * 
 *  Inputs:     investment amount in dollars
 *              annual interest rate as percentage of 100
 *              years to invest
 * 
 *  Outputs:    future investment value
 *  
 *  Algorithm:  1) Display a welcome message
 *              2) Prompt and read in the 
 *                  investment amount, 
 *                  annual interest rate,
 *                  years
 *              3) Compute the monthly interest rate using the formula:
 *                      monthlyInterestRate = annualInterestRate / 12 / 100
 *              
 *                 Compute the future value using the formula:
 *                      futureValue = amount * (1 + monthlyInterestRate) ^ (years * 12)
 *              4) Display the future value
 * 
 * Test Plan:   Test Case       Test Data                   Expected Results
 *              ----------      -----------------------     ------------------
 *              short term      amount = 5000               futureValue = 5032.60
 *                              interestRate = 0.65%
 *                              years = 1
 *              average term    amount = 5000               futureValue = 5389.17
 *                              interestRate = 1.50%
 *                              years = 5
 *              long term       amount = 5000               futureValue = 6418.46
 *                              interestRate = 2.50%
 *                              years = 10
 * 
 * */
using System;

namespace SSPE_Question05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("This program computes the future value of an investment");
            // Declare variables for inputs (amount,annualInterestRate,years) and outputs (mpr, futureValue)
            double amount;                  // Invesment amount
            double annualInterestRate;      // Annual interest rate as percentage of 100
            int years;                      // Yeards for investment
            double monthlyInterestRate;
            double futureValue;             // Future value of investment with interest earned

            // Prompt for the amount
            Console.Write("Enter the investment amount: ");
            // Read in the amount
            amount = double.Parse(Console.ReadLine());
            // Prompt for the annual interest rate
            Console.Write("Enter the annual interest rate as a percentage of 100: ");
            // Read in the annual interest rate
            annualInterestRate = double.Parse(Console.ReadLine());
            // Prompt for the years
            Console.Write("Enter the number of years for investment: ");
            // Read in the years
            years = int.Parse(Console.ReadLine());

            // Compute the monthly interest rate
            monthlyInterestRate = annualInterestRate / 12 / 100;
            // Compute the future value
            futureValue = amount * Math.Pow(1 + monthlyInterestRate, years * 12);
            // Round future value to 2 decimal places
            futureValue = Math.Round(futureValue, 2);

            // Display the future value
            Console.WriteLine($"Future value is {futureValue:C}");

        }
    }
}
