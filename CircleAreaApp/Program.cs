using System;

namespace CircleAreaApp
{
    // This program calculates the area of a circle for a given radius.
    class Program
    {
        static void Main(string[] args)
        {
            // Step 0: Display a welcome message
            Console.WriteLine("This program calculates the area of circle for a given radius.");

            // Step 1: Read in the radius of the circle
            // Declare a variable to store the radius of the circle
            double radius;
            // Assign a value of 20 to the radius
            radius = 20;

            // Step 2: Calculate the area of the circle using the formula:
            //          area = pi x radius x radius
            double area = 3.14 * radius * radius;
            //double area = 3.14 * Math.Pow(radius, 2);

            // Step 3: Display the area of the circle
            Console.WriteLine($"The area for the circle of radius {radius} is {area}");

        }
    }
}
