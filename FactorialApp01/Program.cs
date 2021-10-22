/*  Purpose:    This program computes the factorial of a integer number.
 *              The factorial of a positive integer n is the product of the integers from 1 to n. 
 *              You can express the factorial of a positive integer n---written as n!--- using the formula:
 *                  n! = 1 * 2 * ... * (n - 2) * (n - 1) * n
 *              For example, 4! = 1 * 2 * 3 * 4 = 24    
 * 
 *  Input:      A positive integer number
 * 
 *  Output:     The factorial of the positive integer number
 * 
 *  Algorithm:  1) Set factorial to 1.
 *              2) Prompt and read in the positive integer number (n)
 *              3)  For num ranging from 1 to n do the following:
 *                      factorial = factorial * num
 *                  End For
 *                  
 *                  n = 4
 *                  factorial = 1
 *                  num     factorial
 *                  ---     ---------
 *                  1       factorial = factorial * num = 1 * 1 = 1
 *                  2       factorial = factorial * num = 1 * 2 = 2
 *                  3       factorial = factorial * num = 2 * 3 = 6
 *                  4       factorial = factorial * num = 6 * 4 = 24
 *              4) Display the factorial value
 * */
using System;

namespace FactorialApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("This program computes the factorial of a positive number.");
            // Declare variables for inputs (n) and output (factorial)
            int n;
            long factorial = 1;
            // Prompt and read in the postive integer number
            Console.Write("Enter the number to compute factorial for: ");
            n = int.Parse(Console.ReadLine());

            // Compute the factorial
            for (int num = 1; num <= n; num++)
            {
                factorial = factorial * num;
            }
            // Display the factorial value
            Console.WriteLine($"The factorial of {n}! is {factorial}");

        }
    }
}
