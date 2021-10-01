/*  Purpose:    Determine if a number is positive or negative or zero
 * 
 *  Inputs:     number
 *  
 *  Output:     A message identifying if the number is positive, negative, or zero
 * 
 *  Algorithm:  1) Display a welcome message
 *              2) Prompt and read in a number
 *              3) Determine and output if the number is positive, negative, or zero
 *              
 *                  Test Condition          Action          
 *                  --------------          -----------
 *                  number > 0              Output positive
 *                  number < 0              Output negative
 *                  number == 0             Output zero
 * 
 * */
using System;

namespace DMP_Questoin01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("This program determines if a number is positive or negative or zero.");
            // Prompt and read in a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            // Determine and output if the number is positive, negative, or zero
            //if (number > 0)
            //{
            //    Console.WriteLine($"{number} is positive");
            //}
            //if (number < 0)
            //{
            //    Console.WriteLine($"{number} is negative");
            //}
            //if (number == 0)
            //{
            //    Console.WriteLine($"{number} is zero");
            //}

            if (number > 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is negative");
            }
            else //if (number == 0)
            {
                Console.WriteLine($"{number} is zero");
            }


        }
    }
}
