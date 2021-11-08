/* Purpose:     Compute and display the surface area and volume of a rectangle.
 * 
 * Inputs:      length of rectangle
 *              width of rectangle
 *              height of rectangle
 * 
 * Outputs:     surface area of rectangle
 *              volume of rectangle
 *              
 * Algorithm:   1) Prompt and read in the length and width
 *              2) Call CalculateArea() and display the area returned
 *              3) Call CalculateVolume() and display the volume returned
 * 
 * */
using System;

namespace MP3_Question04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delcare variables for inputs and outputs
            int length,
                width,
                height;

            double area,
                    volume;

            // Display welcome message
            Console.WriteLine("This program computes the surface area and volume of a rectangle.");

            // Prompt and read in the length, width, and height
            length = PromptForIntegerPositiveOrZero("Enter length of rectangle: ");
            width = PromptForIntegerPositiveOrZero("Enter width of rectangle: ");
            height = PromptForIntegerPositiveOrZero("Enter height of rectangle: ");

            // Calculate area and volume of rectangle
            area = CalculateArea(length, width, height);
            volume = CalculateVolume(length, width, height);

            // Display the area of volume
            Console.WriteLine($"The surface area of the rectangle is {area:F1}");
            Console.WriteLine($"The volume the rectangle is {volume:F1}");

        }

        static double CalculateArea(int length, int width, double height)
        {
            double area;

            area = 2 * (length * width + width * height + length * height);

            return area;
        }

        static double CalculateVolume(int length, int width, int height)
        {
            double volume;

            volume = length * height * width;

            return volume;
        }

        static int PromptForIntegerPositiveOrZero(string prompt)
        {
            int intValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(prompt);
                try
                {
                    intValue = int.Parse(Console.ReadLine());
                    if (intValue >= 0)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input. You must enter a positive or zero number.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return intValue;
        }
    }
}
