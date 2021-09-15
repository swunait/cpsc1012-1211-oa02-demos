using System;

namespace SSPE_Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iteration 1
            // Display the name, age, and annual pay for the major Don Iveson
            //Console.WriteLine("My name is Don Iveson, my age is 45 and I hope to earn $204,747.00 per year");

            // Iteration 2
            // Declare variables for the name, age, and annualPay
            //string name = "Rachel Notley";
            //int age = 53;
            //double annualPay = 133404.00;
            // Display the name, age, and annual pay
            //Console.WriteLine($"My name is {name}, my age is {age}, and I hope to earn {annualPay:C}");

            // Iteration 3
            // Declare variables for the name, age, and annualPay
            string name;
            int age;
            double annualPay;

            // Prompt for the name
            Console.Write("Enter your name:");
            // Read in the name
            name = Console.ReadLine();

            // Prompt for the age
            Console.Write("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            // Prompt for the annualPay
            Console.Write("Enter your annual salary:");
            annualPay = double.Parse(Console.ReadLine());

            // Display the name, age, and annual pay
            Console.WriteLine($"My name is {name}, my age is {age}, and I hope to earn {annualPay:C}");

        }
    }
}
