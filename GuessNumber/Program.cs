using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101);

            Console.WriteLine($"This is a random number {randomNumber} guessing game.");
            // Prompt and read in the guess number
            Console.Write("Enter your guess (1-100): ");
            int guessNumber = int.Parse(Console.ReadLine());

            while (guessNumber != randomNumber)
            {
                if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Your guess number is too high.");
                }
                else 
                {
                    Console.WriteLine("Your guess number is too low.");
                } 
                // Prompt for another answer
                Console.Write("Enter your guess (1-100): ");
                guessNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Congratulations, you guessed the correct number");
        }
    }
}
