/*  Purpose:    A program that generate a random math addition question for the the user to answer
 *  
 *  Input:      User answer to the addition question
 *  
 *  Output:     Message indicating if answer is correct or incorrect
 * 
 *  Algorithm:  1) Display a welcome message
 *              2) Generate two random numbers (num1, num2) between 1 and 99
 *              3) Compute 
 *                  correctAnswer = num1 + num2
 *              4)  Prompt and read the user answer to the addition question
 *                  While input value is not valid do the following:
 *                      a. Display an error message 
 *                      b. Prompt and read the user answer to the addition question
 *                  End While
 *              5) If userAnswer = correctAnswer do the following:
 *                      a. Display message that the answer is correct
 *                 Else
 *                      a. Display messate that the answer is incorrect.
 *                 End If
 * 
 * */
using System;

namespace MathTutor01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("This is a math addition quiz program.");
            // Generate two random numbers (num1, num2) between 1 and 99
            const int MinNumber = 1;
            const int MaxNumber = 99;
            // Create an object that can generate random numbers
            Random rand = new Random();
            int num1 = rand.Next(MinNumber, MaxNumber + 1);
            int num2 = rand.Next(MinNumber, MaxNumber + 1);
            // Compute correctAnswer = num1 + num2
            int correctAnswer = num1 + num2;
            // Prompt and read the user answer to the addition question
            int userAnswer;
            Console.Write($"What is {num1} + {num2} = ? ");
            bool validInput = false;
            validInput = int.TryParse(Console.ReadLine(), out userAnswer);
            /*
             * While input value is not valid do the following:
 *                      a. Display an error message 
 *                      b. Prompt and read the user answer to the addition question
 *                  End While
             * */
            while (!validInput)
            {
                Console.WriteLine($"Invalid input. You must enter an integer value.");
                Console.Write($"What is {num1} + {num2} = ? ");
                validInput = int.TryParse(Console.ReadLine(), out userAnswer);
            }

            /*If userAnswer = correctAnswer do the following:
 *                      a. Display message that the answer is correct
 *                 Else
 *                      a. Display messate that the answer is incorrect.
 *                 End If
             * 
             * */
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("Your answer is correct.");
            }
            else
            {
                Console.WriteLine($"Your answer is incorrect. The correct answer is {correctAnswer}.");
            }

        }
    }
}
