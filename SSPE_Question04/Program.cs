/*  Purpose:    Sum all the digits of an integer value between 0 and 1000.
 * 
 *  Input:      a integer number between 0 and 1000
 *  
 *  Output:     Sum of the digits of the integer number
 *  
 *  Algorithm:  We can use the % (modulus) operator to extract a single digit
 *              We can use the / (divide) operator to remove the extracted digit
 *              
 *                                  Q               R
 *              932 / 10    =       93              2
 *              93 / 10     =       9               3
 *              9 / 10      =       0               9
 *                                              -------
 *                                              Sum = 2 + 3 + 9
 *  Test Plan:  Test Case               Test Data   Expected Results
 *              ---------------------   ---------   ----------------
 *              single digit number         8       Sum = 8
 *              two digit number           25       Sum = 7
 *              three digit number        678       Sum = 21
 *              1000                     1000       Sum = 1
 *              9753                     9753       Sum = 24                        
 * */
using System;

namespace SSPE_Question04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("This program sums the digits of a number beteen 0 and 1000.");
            // Declare variables for input (number) and output (sumOfDigits)
            int number;             // A number between 0 and 1000
            int sumOfDigits = 0;    // The sum of the digits in number
            int digit;              // The digit extracted from the number
            int tempNumber;         // A copy of the number

            // Prompt for the number
            Console.Write("Enter a number between 0 and 1000: ");
            // Read in the number
            number = int.Parse(Console.ReadLine());
            tempNumber = number;

            // Extract the first right most digit
            digit = tempNumber % 10;
            // Add the digit to the sum
            sumOfDigits += digit;
            // Remove the right most digit from the number
            tempNumber = tempNumber / 10;

            // Extract the next (2nd) digit from number
            digit = tempNumber % 10;
            // Add the digit to the sum
            sumOfDigits += digit;
            // Remove the right most digit from the number
            tempNumber = tempNumber / 10;

            // Extract the next (3rd) digit from number
            digit = tempNumber % 10;
            // Add the digit to the sum
            sumOfDigits += digit;

            // The last digit extracted by dividing by 10
            digit = tempNumber / 10;
            sumOfDigits += digit;

            // Display the sum 
            Console.WriteLine($"The sum of the digits is {sumOfDigits} for {number}");

        }
    }
}
