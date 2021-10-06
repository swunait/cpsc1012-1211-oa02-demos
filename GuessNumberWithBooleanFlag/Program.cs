using System;

namespace GuessNumberWithBooleanFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;

            // Generate a random number between 1 and 100
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);

            Console.WriteLine($"This is a random number {randomNumber} guessing game.");

            while (!gameOver)   // while (gameOver != true)
            {
                // Prompt and read in the guess number
                Console.Write("Enter your guess (1-100): ");
                int guessNumber = int.Parse(Console.ReadLine());

                // Determine if the guessNumbers is correct, too high, or too low
                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("Congratulations, you guessed the correct number");
                    gameOver = true;
                }
                else if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Your guess number is too high.");
                }
                else
                {
                    Console.WriteLine("Your guess number is too low.");
                }

            }
            
        }
    }
}
