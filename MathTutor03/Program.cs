/*  Purpose:    A math multiplication question program with multiple attempts allowed.
 * 
 *  Inputs:     userAnswer (user answer to addition question)
 *              tryAgain   (user response to try again) 
 * 
 *  Outputs:    Message indicating if the user answer is correct or incorrect
 *              and display the number of attempts
 * 
 *  Algorithm:  1)  Display a welcome message
 *              2)  Generate two random numbers (num1,num2) between 1 and 9
 *              3)  Compute correctAnswer = num1 * num2
 *              4)  Set attempts = 0
 *              5)  Do the following:
 *                    a. Prompt and read in the userAnswer
 *                    b. While not validInput do the following:
 *                          a. Display an error message
 *                          b. Prompt and read in the userAnswer
 *                       End While
 *                    c. Increment attempts   
 *                    d. If userAnswer = correctAnswer do the following:
 *                          a. Display a message that answer is correct and number of attempts
 *                          b. Set tryAgain = n
 *                       Else
 *                          a. Display a message that answer is incorrect
 *                          b. Prompt and read to try again
 *                       End If
 *                  While user wants to try again      
 *              6) Good bye message             
 * 
 * */
using System;

namespace MathTutor03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("This is a math multiplication quiz program.");
            // Generate two random numbers (num1, num2) between 1 and 99
            const int MinNumber = 1;
            const int MaxNumber = 9;
            // Create an object that can generate random numbers
            Random rand = new Random();
            int num1 = rand.Next(MinNumber, MaxNumber + 1);
            int num2 = rand.Next(MinNumber, MaxNumber + 1);
            // Compute correctAnswer = num1 * num2
            int correctAnswer = num1 * num2;

            // Set attempts = 0
            int attempts = 0;
            char tryAgain;

            // Prompt and read the user answer to the addition question
            int userAnswer;
            bool validInput = false;

            // Do the following:
            do
            {
                // a. Prompt and read in the userAnswer
                Console.Write($"What is {num1} x {num2} = ? ");
                validInput = int.TryParse(Console.ReadLine(), out userAnswer);
                // While not validInput do the following:
                while (!validInput)
                {
                    // Display an error message
                    Console.WriteLine($"Invalid input. You must enter an integer value.");
                    // Prompt and read in the userAnswer
                    Console.Write($"What is {num1} x {num2} = ? ");
                    validInput = int.TryParse(Console.ReadLine(), out userAnswer);
                }
                // Increment attempts   
                attempts++;
                // If userAnswer = correctAnswer do the following:
                if (userAnswer == correctAnswer)
                {
                    // a. Display a message that answer is correct and number of attempts
                    Console.WriteLine($"Correct! You got the correct in {attempts} attempt.");
                    // b. Set tryAgain = n
                    tryAgain = 'n';
                }
                else
                {
                    // a. Display a message that answer is incorrect
                    Console.Write("Incorrect! Would you like to try again (y/n)? ");
                    // b. Prompt and read to try again
                    tryAgain = char.ToLower(Console.ReadKey().KeyChar);
                    Console.WriteLine();
                }
                //While user wants to try again
            } while (tryAgain == 'y');

            // Good bye message      
            Console.WriteLine("Good-bye and consider donating to my PayPal account if you like this program.");

        }
    }
}
