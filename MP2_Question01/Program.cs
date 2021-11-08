using System;

namespace MP2_Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs (menuChoice, age) and outputs ticketPrice
            int menuChoice;
            int age;
            double ticketPrice;
            const int ExitProgramChoice = 2;

            do
            {
                //DisplayMenu();
                //menuChoice = int.Parse(Console.ReadLine());
                string prompt = "Please enter one of the following options:\n"
                    + "1. Get ticket price\n"
                    + "2. Quit program\n"
                    + "Your choice >> ";
                menuChoice = PromptForIntegerValue(prompt);
                // Process the menuChoice
                switch (menuChoice)
                {
                    case 1:     // Get ticket price
                        age = PromptForIntegerValue("Enter the age of the customer:");
                        ticketPrice = GetTicketPrice(age);
                        Console.WriteLine($"The ticket price is {ticketPrice:C} for a {age} years old.");
                        break;
                    case 2:     // Exit program
                        break;
                    default:    // Invalid menu choice
                        Console.WriteLine($"Invalid menu choice {menuChoice}. Try again.");
                        break;
                }

            } while (menuChoice != ExitProgramChoice);

            Console.WriteLine("Good-bye");
        }

        static int PromptForIntegerValue(string prompt)
        {
            int integerValue = 0;
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write(prompt);
                    integerValue = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input value. You must enter a integer value.");
                }
            }
            return integerValue;
        }

        static double GetTicketPrice(int age)
        {
            double ticketPrice = 0;

            if (age <= 6)   // Children
            {
                ticketPrice = 0.00;
            }
            else if (age <= 17) // Students
            {
                ticketPrice = 9.80;
            }
            else if (age <= 54) // Adult
            {
                ticketPrice = 11.35;
            }
            else // Senior
            {
                ticketPrice = 10.00;
            }

            return ticketPrice;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Please enter one of the following options:");
            Console.WriteLine("1. Get ticket price");
            Console.WriteLine("2. Quit program");
            Console.Write("Your choice >> ");
        }

    }
}
