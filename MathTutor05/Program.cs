using System;

namespace MathTutor05
{
    class Program
    {
        static void Main(string[] args)
        {
            char menuChoice;
            Random rand = new Random();
            int minValue = 1;
            int maxValue = 9;
            int correctCount = 0;
            //int incorrectCount = 0;
            int totalCount = 0;
            do
            {
                menuChoice = PromptForMenuChoice();
                menuChoice = char.ToLower(menuChoice);

                switch (menuChoice)
                {
                    case 'a':
                        if (AskAdditionQuestion(rand, minValue, maxValue))
                        {
                            correctCount++;
                        }
                        totalCount++;
                        break;
                    case 's':
                        if (AskSubtractionQuestion(rand, minValue, maxValue))
                        {
                            correctCount++;
                        }
                        totalCount++;
                        break;
                    case 'm':
                        if (AskMultiplicationQuestion(rand, minValue, maxValue))
                        {
                            correctCount++;
                        }
                        totalCount++;
                        break;
                    case 'd':
                        if (AskDivisionQuestion(rand, minValue, maxValue))
                        {
                            correctCount++;
                        }
                        totalCount++;
                        break;
                    case 'v':
                        {
                            if (totalCount == 0)
                            {
                                Console.WriteLine("You have not answered any questions yet");
                            }
                            else
                            {
                                double percentage = 100.0 * correctCount / totalCount;
                                percentage = Math.Round(percentage);
                                Console.WriteLine($"Your current mark is {percentage}% ({correctCount}/{totalCount})");
                            }

                        }
                        break;
                    case 'e':
                        Console.WriteLine("Goodbye and thanks for playing.");
                        break;
                    default:
                        Console.WriteLine("Logic error in code. Invalid menu choice passed in");
                        break;
                }

                //ProcessMenuChoice(menuChoice, rand, minValue, maxValue, ref correctCount, ref incorrectCount);

            } while (menuChoice != 'e');
        }

        /// <summary>
        /// Prompt and return a valid int value entered by the user.
        /// </summary>
        /// <param name="prompt">Message to write to the screen</param>
        /// <returns>int value entered by the user</returns>
        //static int PromptForIntegerValue(string prompt)
        //{
        //    int integerValue = 0;
        //    bool validInput = false;
        //    while (!validInput)
        //    {
        //        Console.WriteLine(prompt);
        //        validInput = int.TryParse(Console.ReadLine(), out integerValue);
        //        if (!validInput)
        //        {
        //            Console.WriteLine("Invalid input value. Try again.");
        //        }
        //    }
        //    return integerValue;
        //}

        static int PromptForIntegerValue(string prompt)
        {
            int integerValue = 0;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine(prompt);
                try
                {
                    integerValue = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input value. Try again.");
                }
            }
            return integerValue;
        }

        /// <summary>
        /// Prompt and return a valid double value entered by the user.
        /// </summary>
        /// <param name="prompt">Message to write to the screen</param>
        /// <returns>double value entered by the user</returns>
        static double PromptForDoubleValue(string prompt)
        {
            double doubleValue = 0;
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine(prompt);
                validInput = double.TryParse(Console.ReadLine(), out doubleValue);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input value. Try again.");
                }
            }
            return doubleValue;
        }

        /// <summary>
        /// Writes a message to the screen indicating if the user answer is correct or incorrect
        /// and return a boolean flag indicating if the user answer is correct.
        /// </summary>
        /// <param name="correctAnswer">The correct answer to the question</param>
        /// <param name="userAnswer">The user answer to the question</param>
        /// <returns>A boolean flag indicating if the user answer matches the correct answer</returns>
        static bool CheckAnswer(double correctAnswer, double userAnswer)
        {
            bool isCorrectAnswer = false;
            if (userAnswer == correctAnswer)
            {
                Console.WriteLine("Correct!.");
                isCorrectAnswer = true;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {correctAnswer}");
            }
            return isCorrectAnswer;
        }

        /// <summary>
        /// Generates two random random numbers between minValue and maxValue,
        /// calculate the correct answer to the addition question, 
        /// prompt the user for their answer to the addition question,
        /// then returns the results of calling the CheckAnswer method.
        /// </summary>
        /// <param name="rand">The object to use for generating random numbers</param>
        /// <param name="minValue">The minimum value for the generated number</param>
        /// <param name="maxValue">The maximum value for the generated number</param>
        /// <returns>The result of calling the CheckAnswer method</returns>
        static bool AskAdditionQuestion(Random rand, int minValue, int maxValue)
        {
            int num1 = rand.Next(minValue, maxValue + 1);
            int num2 = rand.Next(minValue, maxValue + 1);
            int correctAnswer = num1 + num2;
            int userAnswer = PromptForIntegerValue($"What is {num1} + {num2} = ?");
            return CheckAnswer(correctAnswer, userAnswer);
        }

        /// <summary>
        /// Generates two random numbers between minValue and maxValue,
        /// swap the two randomers if the first number is less than the second number,
        /// calculate the correct answer to the subtraction question, 
        /// prompt the user for their answer to the subtraction question,
        /// then returns the result of calling the CheckAnswer method.
        /// </summary>
        /// <param name="rand">The object to use for generating random numbers</param>
        /// <param name="minValue">The minimum value for the generated number</param>
        /// <param name="maxValue">The maximum value for the generated number</param>
        /// <returns>The result of calling the CheckAnswer method</returns>
        static bool AskSubtractionQuestion(Random rand, int minValue, int maxValue)
        {
            int num1 = rand.Next(minValue, maxValue + 1);
            int num2 = rand.Next(minValue, maxValue + 1);
            if (num1 < num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            int correctAnswer = num1 - num2;
            int userAnswer = PromptForIntegerValue($"What is {num1} - {num2} = ?");
            return CheckAnswer(correctAnswer, userAnswer);
        }

        /// <summary>
        /// Generates two random numbers between minValue and maxValue 
        /// calculate the correct answer to the multiplication question, 
        /// prompt the user for their answer to the multiplication question,
        /// then returns the result of calling the CheckAnswer method.
        /// </summary>
        /// <param name="rand">The object to use for generating random numbers</param>
        /// <param name="minValue">The minimum value for the generated number</param>
        /// <param name="maxValue">The maximum value for the generated number</param>
        /// <returns>The result of calling the CheckAnswer method</returns>
        static bool AskMultiplicationQuestion(Random rand, int minValue, int maxValue)
        {
            int num1 = rand.Next(minValue, maxValue + 1);
            int num2 = rand.Next(minValue, maxValue + 1);
            int correctAnswer = num1 * num2;
            int userAnswer = PromptForIntegerValue($"What is {num1} x {num2} = ?");
            return CheckAnswer(correctAnswer, userAnswer);
        }

        /// <summary>
        /// Generates two random numbers between minValue and maxValue 
        /// calculate the correct answer to the division question rounded to 1 decimal place, 
        /// prompt the user for their answer to the division question,
        /// then returns the result of calling the CheckAnswer method.
        /// </summary>
        /// <param name="rand">The object to use for generating random numbers</param>
        /// <param name="minValue">The minimum value for the generated number</param>
        /// <param name="maxValue">The maximum value for the generated number</param>
        /// <returns>The result of calling the CheckAnswer method</returns>
        static bool AskDivisionQuestion(Random rand, int minValue, int maxValue)
        {
            double num1 = rand.Next(minValue, maxValue + 1);
            double num2 = rand.Next(minValue, maxValue + 1);
            double correctAnswer = num1 / num2;
            correctAnswer = Math.Round(correctAnswer, 1, MidpointRounding.AwayFromZero);
            double userAnswer = PromptForDoubleValue($"What is {num1} / {num2} = ? (rounded to 1 decimal place)");
            userAnswer = Math.Round(userAnswer, 1, MidpointRounding.AwayFromZero);
            return CheckAnswer(correctAnswer, userAnswer);
        }

        /// <summary>
        /// Write the menu choices to the screen.
        /// </summary>
        static void DisplayMenuChoices()
        {
            Console.WriteLine("|-----------");
            Console.WriteLine("| Math Quiz ");
            Console.WriteLine("|-----------");
            Console.WriteLine("a) Addition Question");
            Console.WriteLine("s) Subtraction Question");
            Console.WriteLine("m) Multiplication Question");
            Console.WriteLine("d) Division Question");
            Console.WriteLine("v) View Quiz Results");
            Console.WriteLine("e) Exit Program");
            Console.Write("Enter your choice (a,s,m,d,v,e): ");
        }

        /// <summary>
        /// Prompt and return a valid menu choice.
        /// </summary>
        /// <returns>a valid menu choice (a,s,m,d,v,e)</returns>
        static char PromptForMenuChoice()
        {
            char menuChoice;
            bool validInput = false;
            do
            {
                DisplayMenuChoices();
                menuChoice = Console.ReadKey().KeyChar;
                menuChoice = char.ToLower(menuChoice);
                if (menuChoice == 'a' || menuChoice == 's' || menuChoice == 'm'
                    || menuChoice == 'd' || menuChoice == 'e' || menuChoice == 'v')
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input value. Try again.");
                }
                Console.WriteLine();
            } while (!validInput);

            return menuChoice;
        }

        /// <summary>
        /// Use the menuChoice value to determine which operation to perform.
        /// </summary>
        /// <param name="menuChoice">menu choice entered by the user</param>
        /// <param name="rand">object used to generate random numbers</param>
        /// <param name="minValue">generate a random with this minimum value</param>
        /// <param name="maxValue">generate a random with this maximim value</param>
        /// <param name="correctCount">the number of correct answers</param>
        /// <param name="incorrectCount">the number of incorrect answers</param>
        static void ProcessMenuChoice(char menuChoice, Random rand, int minValue, int maxValue, ref int correctCount, ref int incorrectCount)
        {
            bool isCorrectAnswer;
            switch (menuChoice)
            {
                case 'a':
                    isCorrectAnswer = AskAdditionQuestion(rand, minValue, maxValue);
                    if (isCorrectAnswer)
                    {
                        correctCount++;
                    }
                    else
                    {
                        incorrectCount++;
                    }

                    break;
                case 's':
                    isCorrectAnswer = AskSubtractionQuestion(rand, minValue, maxValue);
                    if (isCorrectAnswer)
                    {
                        correctCount++;
                    }
                    else
                    {
                        incorrectCount++;
                    }
                    break;
                case 'm':
                    isCorrectAnswer = AskMultiplicationQuestion(rand, minValue, maxValue);
                    if (isCorrectAnswer)
                    {
                        correctCount++;
                    }
                    else
                    {
                        incorrectCount++;
                    }
                    break;
                case 'd':
                    isCorrectAnswer = AskDivisionQuestion(rand, minValue, maxValue);
                    if (isCorrectAnswer)
                    {
                        correctCount++;
                    }
                    else
                    {
                        incorrectCount++;
                    }
                    break;
                case 'v':
                    Console.WriteLine($"Number of correct answers = {correctCount}");
                    Console.WriteLine($"Number of incorrect answers = {incorrectCount}");
                    break;
                case 'e':
                    Console.WriteLine("Goodbye and thanks for playing.");
                    break;
                default:
                    Console.WriteLine("Logic error in code. Invalid menu choice passed in");
                    break;
            }

        }
    }
}
