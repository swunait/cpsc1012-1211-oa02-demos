using System;

namespace GuessNumberWithDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);

            Console.WriteLine("This is a random number guessing game.");

            int guessNumber;
            do
            {
                // Prompt and read in the guess number
                Console.Write("Enter your guess (1-100): ");
                guessNumber = int.Parse(Console.ReadLine());

                // Determine if the guessNumbers is correct, too high, or too low
                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("Congratulations, you guessed the correct number");
                }
                else if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Your guess number is too high.");
                }
                else
                {
                    Console.WriteLine("Your guess number is too low.");
                }
                int gallons = (int) Math.Ceiling(1.91);
            } while (guessNumber != randomNumber);

        }
    }
}
