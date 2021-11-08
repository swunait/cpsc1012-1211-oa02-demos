/* Purpose:     Compute the weekly gross pay for an employee
 * 
 * Inputs:      hours
 *              hourly pay rate
 * 
 * Outputs:     gross pay
 * 
 * Algorithm:   1) Prompt for hours and hourly pay rate
 *              2) Call CalculatePay method and display the gross pay returned
 * 
 * Test Plan:   Test Case               Test Data           Expected Results
 *              ------------------      ---------           -----------------
 *              less than 40 hours      hours: 30           grossPay = 30 * 20 = 600
 *                                      hourlyRate: 20      
 *              between 40 to 50        hours: 45           grossPay = 40 * 20 + (45-40) * 20 * 1.5 
 *                                      hourlyRate: 20              = 800 + 150
 *                                                                  = 950
 *              over 50 hours           hours: 60           grossPay = 40 * 20 + 10 * 20 * 1.5 + (60-50) * 20 * 2  
 *                                      hourlyRate: 20          = 800 + 300 + 400
 *                                                              = 1500
 * 
 * */
using System;

namespace MP3_Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Delcare variables for inputs and outputs
            int hours,
                    hourlyRate;

            double grossPay;

            // Display welcome message
            Console.WriteLine("This program computes the weekly wage for an empoyee.");

            // Prompt and read in hours and hourlyRate
            hours = PromptForIntegerPositiveOrZero("Enter hours worked: ");
            hourlyRate = PromptForIntegerPositiveOrZero("Enter hourly rate: ");

            // Call CalculatePay and display the pay returned
            grossPay = CalculatePay(hours, hourlyRate);

            // Display the gross pay
            Console.WriteLine($"Gross pay: {grossPay:C}");
        }

        static double CalculatePay(double hours, double hourlyRate)
        {
            double grossPay = 0;

            if (hours <= 40)
            {
                grossPay = hours * hourlyRate;
            }
            else if (hours <= 50)
            {
                grossPay = (40 * hourlyRate) + (hours - 40) * hourlyRate * 1.5;
            }
            else
            {
                grossPay = (40 * hourlyRate) + (10 * hourlyRate * 1.5) + (hours - 50) * hourlyRate * 2;
            }

            return grossPay;
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