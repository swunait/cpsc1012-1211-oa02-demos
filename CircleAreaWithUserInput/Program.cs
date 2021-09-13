using System;

namespace CircleAreaWithUserInput
{
    // This program calculates the area of a circle for a user input radius value.
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Display a welcome message
            Console.WriteLine("This program calculates the area of circle.");

            // Step 2: Prompt and read in the radius
            // Declare variables for user input and radius
            string userInput;
            double radius;
            // Prompt for the radius
            Console.Write("Enter the radius of the circle: ");
            // Read the input value
            userInput = Console.ReadLine();
            // Convert the input value to a double type
            radius = double.Parse(userInput);

            //radius = double.Parse(Console.ReadLine());


            // Step 3: Calculate the area of the circle using the formula:
            //          area = 3.14 x radius x radius
            const double pi = 3.14;
            double area = pi * radius * radius;

            // Step 4: Display the area of the circle
            Console.WriteLine($"The area is {area:F2} for a circle of radius {radius:F1}");

        }
    }
}
