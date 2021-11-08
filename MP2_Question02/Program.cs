using System;

namespace MP2_Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program determines the grade of a student using their mark.");
            // Declare varaibles for inputs (name, mark) and outputs (grade)
            string name;
            int mark;
            char grade;
            // Prompt and read in the student name and mark
            //Console.Write("Enter the student name: ");
            //name = Console.ReadLine();
            name = PromptForStringValue("Enter the student name: ", 3);

            //Console.Write("Enter the student mark: ");
            //mark = int.Parse(Console.ReadLine());
            mark = PromptForIntegerValue("Enter the student mark: ");

            // Call the LetterGradeFromMark method to get the grade
            grade = LetterGradeFromMark(mark);

            // Print the student name and grade
            Console.WriteLine($"The grade for {name} is {grade}");
        }

        static char LetterGradeFromMark(int mark)
        {
            char letterGrade = 'A';

            if (mark >= 90 && mark <= 100)
            {
                letterGrade = 'A';
            }
            else if (mark >= 80 && mark <= 89)
            {
                letterGrade = 'B';
            }
            else if (mark >= 70 && mark <= 79)
            {
                letterGrade = 'C';
            }
            else if (mark >= 50 && mark <= 69)
            {
                letterGrade = 'D';
            }
            else
            {
                letterGrade = 'F';
            }

            return letterGrade;
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

        static string PromptForStringValue(string prompt, int minLength)
        {
            string stringValue = "";
            bool validInput = false;
            while (!validInput)
            {
                Console.Write(prompt);
                stringValue = Console.ReadLine();
                if (stringValue.Length >= minLength)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine($"Invalid input value. Minimum length must be at least {minLength}");
                }

            }
            return stringValue;
        }
    }
}
