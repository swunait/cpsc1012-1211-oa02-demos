using System;

namespace SwitchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs
            //const char ExitProgramChoice = 'x';
            //char menuChoice;
            const int ExitProgramChoice = 0;
            int menuChoice;

            do
            {
                // Display a menu of options for the user to choose from
                Console.WriteLine("Please enter: ");
                //Console.WriteLine("a - Print Multiplication Table, or");
                //Console.WriteLine("b - Play Dice Game, or ");
                //Console.WriteLine("c - Play Rock-Paper-Scissor Game, or");
                //Console.WriteLine("x - Exit program.");
                Console.WriteLine("1 - Print Multiplication Table, or");
                Console.WriteLine("2 - Play Dice Game, or ");
                Console.WriteLine("3 - Play Rock-Paper-Scissor Game, or");
                Console.WriteLine("0 - Exit program.");
                // Read the menu choice input
                //menuChoice = char.Parse(Console.ReadLine());
                //menuChoice = Console.ReadKey().KeyChar;
                //Console.WriteLine();
                menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    //case 'a':
                    case 1:
                        {
                            // Multiplication Table 
                            Console.WriteLine("Multiplication Table");
                        }
                        break;
                    //case 'b':
                    case 2:
                        {
                            // Dice Game
                            Console.WriteLine("Dice Game");
                        }
                        break;
                    //case 'c':
                    case 3:
                        {
                            // Rock-Paper-Scissor Game
                            Console.WriteLine("Rock-Paper-Scissor Game");
                        }
                        break;
                    //case 'x':
                    case 0:
                        break;
                    default:
                        Console.WriteLine($"Invalid menu choice {menuChoice}");
                        break;
                }
            } while (menuChoice != ExitProgramChoice);
            Console.WriteLine("Good-bye");
            


        }
    }
}
