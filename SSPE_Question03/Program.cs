/*
 * Purpose:     Computes the area of a hexagon
 * 
 * Inputs:      side of a hexagon
 * 
 * Algorithm:   1) Display a welcome message
 *              2) Prompt and read in the side of the hexagon
 *              3) Compute the area of the hexagon using the formula:
 *                      area = 3 * sqrt(3) * side * side / 2
 *              4) Display the area of the hexagon        
 * 
 * Output:      area of the hexagon
 * 
 * Test Plan:   Test Case           Test Data           Expected Results            Checked
 *              small side          side=5.5            area=78.5918
 *              medium side         side=25             area=1623.7976
 *              large side          side=150            area=58456.7148
 * 
 * */
using System;

namespace SSPE_Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message 
            Console.WriteLine("This program computes the area of hexagon.");

            // Declare variables for inputs (side) and outputs (area)
            double side;
            double area;

            // Prompt and read in the side of th hexagon
            Console.Write("Enter the side of the hexagon:");
            side = double.Parse(Console.ReadLine());

            // Compute the area of the hexagon using the formula:
            //  area = 3 * sqrt(3) * side * side / 2
            area = 3 * Math.Sqrt(3) * side * side / 2;

            // Display the area of the hexagon
            Console.WriteLine($"The area of the hexagon is {area:F4}");
        }
    }
}
