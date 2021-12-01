using System;

using System.Collections.Generic;   // for List<T>

namespace ObjectProblems2_Question1And2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and create a new list of Quiz objects
            List<Quiz> quizList = new List<Quiz>();
            // Declare a constant for the maximum number of quizzes to track
            const int MaxQuizCount = 25;
            // Call the EnterQuizMarks method
            EnterQuizMarks(quizList, MaxQuizCount);
            // Call the DisplayQuizMarks method
            DisplayQuizMarks(quizList);

        }

        /// <summary>
        /// This method allows the user to enter up to 25 quiz marks
        /// </summary>
        /// <param name="quizList">The list of quiz objects created</param>
        /// <param name="maxQuizCount">The maximum number of Quiz object allowed in the list</param>
        static void EnterQuizMarks(List<Quiz> quizList, int maxQuizCount)
        {
            char yesNoAnswer = 'y';
            int quizCount = 0;

            // Prompt and read in the quiz total and quiz weight
            int quizTotal;
            int quizWeight;
            Console.Write("Enter the quiz total: ");
            quizTotal = int.Parse(Console.ReadLine());
            Console.Write("Enter the quiz weight: ");
            quizWeight = int.Parse(Console.ReadLine());

            do
            {
                // Construct a new Quiz object
                Quiz currentQuiz = new Quiz(quizTotal, quizWeight);
                // Prompt and read the quiz Student Name, Mark
                bool validInput = false;

                while (!validInput)
                {
                    // Prompt for student name
                    Console.Write("Enter the student name: ");
                    try
                    {
                        currentQuiz.StudentName = Console.ReadLine();
                        validInput = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                validInput = false;
                while (!validInput)
                {
                    // Prompt for quiz mark
                    Console.Write("Enter the quiz mark: ");
                    try
                    {
                        currentQuiz.Mark = int.Parse(Console.ReadLine());
                        validInput = true;
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                // Add currentQuiz the quizList
                quizList.Add(currentQuiz);
                // Increment the quizCount
                quizCount++;

                // If the quizCount is less than maxQuizCount prompt the user if they want to enter another quiz
                if (quizCount < maxQuizCount)
                {
                    // Ask the user if they want to enter another mark
                    validInput = false;
                    while (!validInput)
                    {
                        Console.Write("Do you want to enter another quiz mark (y/n): ");
                        yesNoAnswer = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        yesNoAnswer = char.ToLower(yesNoAnswer);
                        if (yesNoAnswer == 'y' || yesNoAnswer == 'n')
                        {
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input value. Enter y or n only.");
                        }
                    }
                   
                }

            } while (yesNoAnswer == 'y' && quizCount < maxQuizCount);

        }

        static void DisplayQuizMarks(List<Quiz> quizList)
        {
            /*  Total: 25
             *  Weight: 10
             *  
             *      123456789012345678  1234567890      1234567890
             *      Student Name(18)    Mark/Total(10)  Grade(10)     
             *      ------------        ----------      ----------      
             *      Jeremy              19/25                   76        
             *      Shane               23/25                   92
             */
            // Check if the are any quiz in the list
            if (quizList.Count == 0)
            {
                Console.WriteLine("There are no quiz in the system.");
            }
            else
            {
                Console.WriteLine($"{"Student Name",-18} {"Mark/Total",10} {"Grade",10}");
                Console.WriteLine($"{"------------",-18} {"----------",10} {"-----",10}");
                foreach(Quiz currentQuiz in quizList)
                {
Console.WriteLine($"{currentQuiz.StudentName,-18} {currentQuiz.Mark + "/" + currentQuiz.Total,10} {currentQuiz.Percentage(),10}");
                }
            }
        }
    }
}
