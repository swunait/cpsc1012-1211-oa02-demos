using System;

using System.IO;    // for StreamWriter class

namespace ArrayDemo01
{
    class Program
    {
        // This program creates an string array to storing student names and then it writes
        // the contents of the array to a text file
        static void Main(string[] args)
        {
            // Define a constant for the maximum number of students in a class
            const int MaxStudents = 25; // Physical size of array
            // Declare and create a new string array of size MaxStudents
            string[] nameArray = new string[MaxStudents];
            // Declare a variable to track the number of students in the array (logical size of array)
            int studentCount = 0;

            // Repeatly prompt, and read in the student names and store in the array
            // until the input is the sentinel value of a empty string
            Console.WriteLine("Enter the student names (empty line to stop): ");
            bool endOfInput = false;
            string userInput;
            while( !endOfInput )
            {
                // Read user input
                userInput = Console.ReadLine();
                // Add input to nameArray if it is not empty
                if (userInput == "")
                {
                    endOfInput = true;                  
                }
                else
                {
                    // Add userInput value to the next empty slot in the array
                    nameArray[studentCount] = userInput;
                    // Increase the studentCount
                    studentCount++;
                }
            }

            // Print the name of each student in nameArray
            Console.WriteLine("The students in class today are: ");
            for (int index = 0; index < studentCount; index++)
            {
                Console.WriteLine(nameArray[index]);
            }

            // Sort the array ascendingly for the first studentCount elements
            Console.WriteLine("The students name in sorted order:");
            //Array.Sort(nameArray);  // sort all the elements in the array
            Array.Sort(nameArray, 0, studentCount); // sort only the first studentCount elements in the array
            for (int index = 0; index < studentCount; index++)
            {
                Console.WriteLine(nameArray[index]);
            }

            // Write the name of each student to a file
            Console.Write("Enter the file name to save to: ");
            userInput = Console.ReadLine();
            string exportDataFilePath = userInput;
            // Create a StreamWriter object for writing to a text file
            StreamWriter writer = new StreamWriter(exportDataFilePath);
            // Write each name in nameArray to the text file
            for (int index = 0; index < studentCount; index++)
            {
                // Write one name per line
                writer.WriteLine(nameArray[index]);
            }
            writer.Close();
            Console.WriteLine($"Write to file path {exportDataFilePath} was successful.");            

        }
    }
}
