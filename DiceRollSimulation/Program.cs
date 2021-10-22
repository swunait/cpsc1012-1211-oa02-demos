/*  Purpose:    A menu-driven program that allows the user to simulate rolling a Die a number of times.
 *  
 *  Inputs:     menu choice (1 - enter Die sides and number of rolls,
 *                          2 - roll the die )
 *                          0 - exit the program
 *              Die sides
 *              Number of Die rolls
 *  
 *  Output:     A table of each Die roll and its face value
 * 
 *  Algorithm:  1) Display a welcome message
 *              2) Do the following:
 *                  a. Prompt and read in the menu choice
 *                  b.  If menu choice is 1 Then
 *                          a. Prompt and read Die sides and number of rolls     
 *                      Else if menu choice is 2 Then
 *                          a. For rollCount ranging from 1 through numberOfRolls do the following:
 *                                  a. Simulate rolling a dice by generating a random between 1 
 *                                      and diceSides
 *                                  b. Display rollCount and face value of Dice roll
 *                             End For
 *                      Else if menu choice is 0 Then
 *                          a. Do nothing
 *                      Else
 *                          a. Print invalid menu choice message
 *                      End If
 *                  While menuChoice is not 0      
 * 
 * */
using System;

namespace DiceRollSimulation
{
    class Program
    {
        static int PromptForIntegerValue(string prompt)
        {
            int integerValue = 0;

            Console.Write(prompt);
            while ( !int.TryParse(Console.ReadLine(), out integerValue))
            {
                Console.WriteLine("Invalid input. Please enter an integer number.");
                Console.Write(prompt);
            }

            return integerValue;
        }

        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("This program simulates the rolling a Die n number of times.");
            // Declare variables for input (menuChoice, dieSides, dieRollTotal)
            const int ExitProgramChoice = 0;
            int menuChoice,
                dieSides = 6,
                dieRollTotal = 5;
            // Delcare a object for generating random numbers
            Random rand = new Random();

            // Display and process menu choices
            do
            {
                // Display menu of choices
                //Console.WriteLine("1. Enter die sides and number of rolls");
                //Console.WriteLine("2. Simulate Die roll");
                //Console.WriteLine("0. Exit program");
                //Console.Write("Your menu choice: ");
                //menuChoice = int.Parse(Console.ReadLine());
                menuChoice = PromptForIntegerValue(
                    "1. Enter die sides and number of rolls\n" +
                    "2. Simulate Die roll\n" +
                    "0. Exit program\n" +
                    "Your menu choice: ");

                // Process the menu choice
                switch (menuChoice)
                {
                    case 1: // enter die sides and number of rolls
                        {
                            //Console.Write("Enter the number of sides for the Die: ");
                            //dieSides = int.Parse(Console.ReadLine());
                            dieSides = PromptForIntegerValue("Enter the number of sides for the Die: ");

                            //Console.Write("Enter the number of rolls to simulate: ");
                            //dieRollTotal = int.Parse(Console.ReadLine());
                            dieRollTotal = PromptForIntegerValue("Enter the number of rolls to simulate: ");

                        }
                        break;
                    case 2: // simulate rollling the Die n number of times
                        {
                            // 12345 1234567890
                            // Roll# Face Value

                            Console.WriteLine($"{"Roll#",5} {"Face Value",10}");
                            for (int counter = 1; counter <= dieRollTotal; counter++)
                            {
                                // Roll the dice and store the face value
                                int dieFaceValue = rand.Next(1, dieSides + 1);
                                // Display the counter and dieFaceValue
                                Console.WriteLine($"{counter,5} {dieFaceValue,10}");
                            }
                        }
                        break;
                    case 0: // exit program option - do nothing
                        break;
                    default:    // print invalid menu choice
                        Console.WriteLine($"Invalid menu choice {menuChoice}.");
                        break;
                }

            } while (menuChoice != ExitProgramChoice);
            Console.WriteLine("Good-bye");
        }
    }
}
