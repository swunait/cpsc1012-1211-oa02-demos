/*  Purpose:    Computes the area and volume of a cylinder.
 *  
 *  Inputs:     radius of the cylinder
 *              length of the cylinder
 * 
 *  Outputs:    Computed area and volume of the cylinder
 *  
 *  Algorithm:  1) Display a welcome message
 *              2) Prompt and read in the radius and length
 *              3) Compute the area and volume of the cylinder using the formula
 *                  area = radius * radius * pi
 *                  volume = area * length
 *              4) Display the area and volume
 *              
 * Test Plan:
 *      Test Case               Test Data       Expected Results        Passed
 *      small size              radius=5.5      area = 94.985
 *                              length=12       volume = 1139.82
 *      medium size             radius=250      area = 196,250
 *                              length=500      volume = 98,125,000
 *      large size              radius=1500     area = 7,065,000
 *                              length=3000     volume = 21,195,000,000
 *                              
 * */
using System;

namespace SSPE_Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("This program computes the area and volume of cylinder.");
            // Prompt and read in the radius and length
            double radius;
            double length;
            //double  radius,
            //        length;
            Console.Write("Enter the radius of the cylinder: ");
            radius = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of the cyliner: ");
            length = double.Parse(Console.ReadLine());

            // Compute the area and volume 
            double area;
            double volume;
            const double PI = 3.14;
            //area = radius * radius * 3.14;
            area = radius * radius * PI;
            volume = area * length;

            // Display the area and volume
            Console.WriteLine($"The area is {area:F3}");
            Console.WriteLine($"The volume is {volume:F0}");
        }
    }
}
