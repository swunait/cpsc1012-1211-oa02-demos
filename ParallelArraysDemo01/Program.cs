using System;

namespace ParallelArraysDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a constant for the size of the array 
            const int ArraySize = 30;
            // Declare and create a new array of string of size ArraySize for student names
            string[] studentNameArray = new string[ArraySize];
            // Declare and create a new array of double of size ArraySize for student marks
            double[] studentMarkArray = new double[ArraySize];
            // Declare a variable to count the number of students in the arrays
            int studentCount = 0;

            // Prompt and read in the number of student marks to enter
            Console.Write("Enter the number of names and marks to enter: ");
            studentCount = int.Parse(Console.ReadLine());

            // Repeatly prompt and read in the name and mark for each student
            for (int index = 0; index < studentCount; index++)
            {
                Console.Write($"Enter the name for student #{index + 1}: ");
                studentNameArray[index] = Console.ReadLine();
                Console.Write($"Enter the mark for the student #{index + 1}:");
                studentMarkArray[index] = double.Parse(Console.ReadLine());
            }

            //// Display the name and mark for each student in the parallel arrays studentNameArray and studentMarkArray
            //Console.WriteLine($"{"Name",-20} {"Mark",4}");
            //Console.WriteLine($"{"----",-20} {"----",4}");
            //for (int index = 0; index < studentCount; index++)
            //{
            //    Console.WriteLine($"{studentNameArray[index], -20} {studentMarkArray[index], 4}");
            //}

            // Call the SortByStudentName method
            SortByStudentMark(studentNameArray, studentMarkArray, studentCount);

            // Call the PrintStudentMarks method
            PrintStudentMarks(studentNameArray, studentMarkArray, studentCount);

        }

        static void PrintStudentMarks(string[] nameArray, double[] markArray, int arraySize)
        {
            // Display the name and mark for each student in the parallel arrays studentNameArray and studentMarkArray
            Console.WriteLine($"{"Name",-20} {"Mark",4}");
            Console.WriteLine($"{"----",-20} {"----",4}");
            for (int index = 0; index < arraySize; index++)
            {
                Console.WriteLine($"{nameArray[index],-20} {markArray[index],4}");
            }
        }

        static void SortByStudentMark(string[] nameArray, double[] markArray, int arraySize)
        {
            // Sort the array using selection sort algorithm
            /* Selection sort finds the smallest number in the list and swaps it with the first element. 
             * It then finds the smallest number remaining and swaps it with the second element, and so on, 
             * until only a single number remains.            
             * */
            double smallestValue = 0;
            int smallestIndex = 0;
            // Select the smallest element in the list[1..arraySize-1];
            for (int outerIndex = 0; outerIndex < arraySize - 1; outerIndex++)
            {
                smallestValue = markArray[outerIndex];
                smallestIndex = outerIndex;
                for (int innerIndex = outerIndex + 1; innerIndex < arraySize; innerIndex++)
                {
                    if (markArray[innerIndex] < smallestValue)
                    {
                        smallestValue = markArray[innerIndex];
                        smallestIndex = innerIndex;
                    }
                }
                // Swap the smallest with markArray[index], if necessary
                if (smallestIndex != outerIndex)
                {
                    double tempMark = markArray[smallestIndex];
                    markArray[smallestIndex] = markArray[outerIndex];
                    markArray[outerIndex] = tempMark;

                    string tempName = nameArray[smallestIndex];
                    nameArray[smallestIndex] = nameArray[outerIndex];
                    nameArray[outerIndex] = tempName;
                }
            }
        }
    }
}
