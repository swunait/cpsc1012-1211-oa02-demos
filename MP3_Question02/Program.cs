/* Purpose:     Convert time from hours, minutes, and seconds to total seconds
 * 
 * Inputs:      hours
 *              minutes
 *              seconds
 * 
 * Outputs:     total seconds
 * 
 * Algorithm:   1) Prompt for hourse, minutes, and seconds
 *              2) Call CalculateSeconds and display the total seconds returned
 * 
 * 
 * 
 * */
using System;

namespace MP3_Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs and outputs
            int hours,
                minutes,
                seconds;

            int totalSeconds;

            Console.WriteLine("This program converts time from hours, minutes, and seconds to total seconds.");
            // Prompt and read in the hours, minutes, and seconds
            hours = PromptForIntegerPositiveOrZero("Enter the hours to convert: ");
            minutes = PromptForIntegerPositiveOrZero("Enter the minutes to convert: ");
            seconds = PromptForIntegerPositiveOrZero("Enter the seconds to convert: ");

            // Call CalulateSeconds 
            totalSeconds = CalculatSeconds(hours, minutes, seconds);

            // Display the total seconds
            Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00} = {totalSeconds}");

        }

        static int CalculatSeconds(int hours, int minutes, int seconds)
        {
            return hours * 3600 + minutes * 60 + seconds;
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