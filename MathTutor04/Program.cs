/*  Purpose:    A menu-driven program that allows the user to select a type
 *              of math question to answer.
 *  
 *  Inputs:     menu choice
 *              answer to math question
 *              answer to play again
 *              
 *  Outputs:    Message indicating if user answer is correct or incorrect.            
 * 
 *  Algorithm:  1) Display a welcome message
 *              2) Do the following:
 *                     a. Display the Menu
 *                     b. Read the menu choice
 *                     c. Process the menu choice
 *                 While menuChoice != 'x'
 * 
 * */
using System;

namespace MathTutor04
{
    class Program
    {
        static void DisplayMenu()
        {
            Console.WriteLine("Enter one of the following options: ");
            Console.WriteLine("a - Addition Question");
            Console.WriteLine("s - Subtraction Question");
            Console.WriteLine("m - Multiplication Question");
            Console.WriteLine("d - Division Question");
            Console.WriteLine("x - Exit Program");
            Console.Write("Your choice: ");
        }

        static void AdditionQuestion()
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
                Console.Write($"What is {num1} + {num2} = ? ");
                validInput = int.TryParse(Console.ReadLine(), out userAnswer);
                // While not validInput do the following:
                while (!validInput)
                {
                    // Display an error message
                    Console.WriteLine($"Invalid input. You must enter an integer value.");
                    // Prompt and read in the userAnswer
                    Console.Write($"What is {num1} + {num2} = ? ");
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
        }

        static void MultiplicationQuestion()
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

        }

        static void SubtractionQuestion()
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
            // Compute correctAnswer = num1 - num2
            int correctAnswer = num1 - num2;

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
                Console.Write($"What is {num1} - {num2} = ? ");
                validInput = int.TryParse(Console.ReadLine(), out userAnswer);
                // While not validInput do the following:
                while (!validInput)
                {
                    // Display an error message
                    Console.WriteLine($"Invalid input. You must enter an integer value.");
                    // Prompt and read in the userAnswer
                    Console.Write($"What is {num1} - {num2} = ? ");
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
        }

        static void DivisionQuestion()
        {

        }


        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Math Tutor - Version 0.4");
            char menuChoice = 'x';
            // Do the following:
            do
            {
                // a. Display the Menu
                DisplayMenu();
                // b. Read the menu choice
                menuChoice = Console.ReadKey().KeyChar;
                menuChoice = char.ToLower(menuChoice);

                // c. Process the menu choice
                switch (menuChoice)
                {
                    case 'a':   // Addition
                        AdditionQuestion();
                        break;
                    case 's':   // Subtraction
                        SubtractionQuestion();
                        break;  
                    case 'm':   // Multiplication
                        MultiplicationQuestion();
                        break;
                    case 'd':   // Division

                        break;
                    case 'x':   // Exit program
                        break;
                    default:    // Invalid menu choice
                        Console.WriteLine($"Invalid menu choice {menuChoice}.");
                        break;
                }

                //While menuChoice != 'x'
            } while (menuChoice != 'x');

        }
    }
}
