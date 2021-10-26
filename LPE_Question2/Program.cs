/* Purpose:     Display the average of a series of input numbers.
 * 
 * Inputs:      a series of integer values
 * 
 * Output:      The aveage of the input numbers
 * 
 * Algorithm:   0) Display a welcome message
 *              1) Declare variables to track the sum and count the number of valid integer values
 *              2) Prompt and read in a single number
 *              3) While number <> 0 do the following
 *                      a. Calculate 
 *                          sum = sum + number
 *                          count = count + 1
 *                      b. Prompt and read in another number
 *                 End While
 *              4) Calculate   
 *                  average = sum / count
 *              5) Print the average
 * */
using System;

namespace LPE_Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the average of a series of input numbers.");
            int sum = 0,
                count = 0,
                number;
            Console.Write("Enter a number (0 to quit): ");
            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                sum = sum + number;
                count++;
                Console.Write("Enter a number (0 to quit): ");
                number = int.Parse(Console.ReadLine());
            }

            //do
            //{
            //    Console.Write("Enter a number (0 to quit): ");
            //    number = int.Parse(Console.ReadLine());
            //    if (number != 0)
            //    {
            //        sum = sum + number;
            //        count++;
            //    }

            //} while (number != 0);


            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine($"The average of the input numbers is {average:F1}");
            }
            else
            {
                Console.WriteLine("There are no numbers to calculate averge with.");
            }
            
        }
    }
}
