using System;

namespace OOPDemo01
{
    // Define a new custom class named Circle
    class Circle    
    {
        // Define a auto-implemented property for the Radius of the circle
        public double Radius { get; set; }

        // Define a no-argument constructor for creating a circle with a radius of 1
        public Circle()
        {
            Radius = 1;
        }
        // Define a parameterized contructor for creating a circle with a specific radius
        public Circle(double newRadius)
        {
            Radius = newRadius;
        }

        // Define an instance-level method to calculate and return the Area of this circle
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        // Define an instance-level method to calculate and return the Cirumference of this circle
        public double Circumference()
        {
            return 2 * Math.PI * Radius;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Construct a new Circle with a radius of 1
            Circle circle1 = new Circle();
            Console.WriteLine($"The area of this circle of radius {circle1.Radius} is {circle1.Area()}");
            // Change the radius of circle1 to 5
            circle1.Radius = 5;
            // Display the new radius and area of circle1
            Console.WriteLine($"The area of this circle of radius {circle1.Radius} is {circle1.Area()}");

            // Construct a new Circle with a radius of 25
            Circle circle2 = new Circle(25);
            // Display the new radius and area of circle2
            Console.WriteLine($"The area of this circle of radius {circle2.Radius} is {circle2.Area()}");

            // C# specific technique for creating objects and initalizing properties of the object 
            // with a single statement.
            // Construct a new Circle object using the default no-argument constructor
            // then set the Radius to 50 using Object Initializer syntax
            Circle circle3 = new Circle() { Radius = 50 };


            // Display the new radius and area of circle2
            Console.WriteLine($"The area of this circle of radius {circle3.Radius} is {circle3.Area()}");

        }
    }
}
