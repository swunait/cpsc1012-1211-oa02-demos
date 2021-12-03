using System;

using System.Collections.Generic;   // for List<T>

namespace ObjectProblem1_Question1_2
{
    public class Student
    {
        // Define auto-implemented properties for the FirstName, LastName, IdNumber of the student
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdNumber { get; set; }

        public Student()
        {
            FirstName = "Unknown FirstName";
            LastName = "Unknown LastName";
            IdNumber = 0;
        }
        public Student(string FirstName, string LastName, int IdNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IdNumber = IdNumber;
        }

        public string FullName()
        {
            return $"{LastName}, {FirstName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Declare and create a new List of Student
            List<Student> studentList = new List<Student>();
            // Declare a variable to track menu choice
            int menuChoice;
            const int ExitProgramChoice = 0;

            do
            {
                // Display a menu of options
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Students");
                Console.WriteLine("0. Exit Program");
                Console.Write("Enter your choice: ");
                menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1: // add student
                        {
                            AddStudent(studentList);
                        }
                        break;
                    case 2: // display students
                        {
                            DisplayStudents(studentList);
                        }
                        break;
                    case 0: // Exit program
                        {
                            Console.WriteLine("Good-bye");
                        }
                        break;
                    default: // Invalid menu choice
                        Console.WriteLine("Invalid menu choice. Try again");
                        break;
                }
            } while (menuChoice != ExitProgramChoice);

        }

        static void DisplayStudents(List<Student> studentList)
        {
            /*      12      123456789012345
             *      Id(2)   Last Name(15)   First Name(15)
             *      --      ---------       ----------
             *      1       Doe             John
             *      2       Smith           Bob
             */
            if (studentList.Count == 0)
            {
                Console.WriteLine("There are no students in the system.");
            }
            else
            {
                Console.WriteLine($"{"Id",2} {"Last Name",-15} {"First Name",-15}");
                Console.WriteLine($"{"--",2} {"---------",-15} {"----------",-15}");
                foreach (Student currentStudent in studentList)
                {
                    Console.WriteLine($"{currentStudent.IdNumber,2} {currentStudent.LastName,-15} {currentStudent.FirstName,-15}");
                }
            }
            

        }
        static void AddStudent(List<Student> studentList)
        {
            // Declare a variable for Yes or No answer
            char yesNoAnswer = 'n';

            do
            {
                // Declare and create a new Student object
                Student currentStudent = new Student();
                // Prompt for the FirstName, LastName, and IdNumber of the student
                Console.Write("Enter the student's first name: ");
                currentStudent.FirstName = Console.ReadLine();
                Console.Write("Enter the student's last name: ");
                currentStudent.LastName = Console.ReadLine();
                Console.Write("Enter the student's id number: ");
                currentStudent.IdNumber = int.Parse(Console.ReadLine());
                // Add currentStudent to studentList
                studentList.Add(currentStudent);
                // Prompt the user if they want to enter another student
                Console.Write("Do you want to enter another student? Enter y or n :");
                yesNoAnswer = Console.ReadKey().KeyChar;
                // Convert yesNoAnswer to lowercase
                yesNoAnswer = char.ToLower(yesNoAnswer);
                Console.WriteLine();

            } while (yesNoAnswer == 'y');
            
           
        }
    }
}
