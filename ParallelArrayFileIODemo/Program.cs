using System;

using System.IO;    // for StreamWriter and StreamReader classes

namespace ParallelArrayFileIODemo
{
    class Program
    {
        static void DisplayData(string[] nameArray, double[] markArray, int arraySize)
        {
            /*    21                      4
             *    123456789012345678901   1234 
             *    Student Name            Mark
             *    ---------------------   ----
             *    John Bob                  80
             *    Bob Smith                100
             * */
            Console.WriteLine($"{"Student Name",-21} {"Mark",4}");
            Console.WriteLine($"{"------------",-21} {"----",4}");
            for (int index = 0; index < arraySize; index++)
            {
                Console.WriteLine($"{nameArray[index],-21} {markArray[index],4}");
            }

        }
        /// <summary>
        /// Loads the two parallel arrays nameArray and markArray with data from a CSV file.
        /// </summary>
        /// <param name="nameArray">The array for student names</param>
        /// <param name="markArray">The array for student markss</param>
        /// <returns>the number of records read</returns>
        static int LoadData(string[] nameArray, double[] markArray)
        {
            int recordCount = 0;        // The number of records read the data import file
            string importDataFilePath;  // The file path for the data file
            // Prompt and read in the file path for the data file
            Console.Write("Enter the file path of the data import: ");
            importDataFilePath = Console.ReadLine();
            try
            {
                // Check if the file path exists
                if (File.Exists(importDataFilePath))
                {
                    StreamReader reader = new StreamReader(importDataFilePath);
                    string lineText;
                    const char delimiter = ',';
                    int index = 0;
                    // Read one line at a time
                    while (reader.EndOfStream == false && index < nameArray.Length)
                    {
                        // Read one line from the stream
                        lineText = reader.ReadLine();
                        // Split the line into array of values separated by a delimiter character
                        string[] valueArray = lineText.Split(delimiter);
                        // The student name is located in element 0 of the valueArray
                        nameArray[index] = valueArray[0];
                        // The student mark is located in element 1 of the valueArray
                        markArray[index] = double.Parse(valueArray[1]);
                        //markArray[index] = Convert.ToDouble(valueArray[1]);
                        // Increase the size of the array by one
                        index++;
                    }
                    reader.Close();
                    // Set the recordCount to the current index
                    recordCount = index;
                }
                else
                {
                    Console.WriteLine($"The {importDataFilePath} does not exist.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return recordCount;

        }
        static void Main(string[] args)
        {
            // Define a constant for the maximum number of students to track
            const int MaxStudents = 30;
            // Declare and create a new array of string for student names
            string[] studentNameArray = new string[MaxStudents];
            // Declare and create a new arry of double for student marks
            double[] studentMarkArray = new double[MaxStudents];
            // Declare a variable to track the number of active students
            int studentCount;

            // Call the LoadData method to load data into studentNameArray and studentMarkArray
            studentCount = LoadData(studentNameArray, studentMarkArray);
            // Call the DisplayData method display the contents of the two parallel arrays 
            DisplayData(studentNameArray, studentMarkArray, studentCount);

        }
    }
}
