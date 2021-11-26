using System;

namespace OOP_Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This simulates the rolling of a 6-sided die and a 12-sided die.");
            // Create a 6-sided Die and a 12-sided Die
            Die sixSidedDie = new Die(6);
            Die tweleveSideDie = new Die(12);

            // Print the Value of both Die
            Console.WriteLine("Rolling the dice 5 times.");
            Console.WriteLine($"{sixSidedDie.Value,10} {tweleveSideDie.Value, 10}");


            // Simulate rolling each die 5 times
            Console.WriteLine("Rolling the dice 5 times.");
            for (int counter = 1; counter <= 5; counter++)
            {
                sixSidedDie.Roll();
                tweleveSideDie.Roll();
                Console.WriteLine($"{sixSidedDie.Value,10} {tweleveSideDie.Value,10}");
            }
        }
    }
}
