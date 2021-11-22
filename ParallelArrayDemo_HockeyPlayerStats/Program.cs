﻿using System;

using System.IO;    // for StreamWriter, StreamReader, and File

namespace ParallelArrayDemo_HockeyPlayerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the maximum number of hockey players to track
            const int MaxPlayers = 23;
            // Declare and create a new string array for hockey player names
            string[] hockeyPlayerNameArray = new string[MaxPlayers];
            // Declare and create a new int array for hockey player points
            int[] hockeyPlayerPointArray = new int[MaxPlayers];
            // Declare a variable to track the current number of players
            int playerCount = 0;
            // Define the menu choice to exit the program
            const int ExitProgramChoice = 99;
            // Declare a variable to track the menuChoice
            int menuChoice;

            // Do the following:
            do
            {
                // Display Menu
                //Console.WriteLine("Hockey Player Stats");
                //Console.WriteLine("-------------------");
                //Console.WriteLine(" 1. Add Player");
                //Console.WriteLine(" 2. List Players");
                //Console.WriteLine(" 4. Remove Player");
                //Console.WriteLine(" 5. Remove All");
                //Console.WriteLine("11. Save data to file");
                //Console.WriteLine("12. Load data from file");
                //Console.WriteLine("99. Exit Program");
                //Console.Write("Enter your menu choice: ");
                const string MenuPrompt = "Hockey Player Stats\n"
                    + "-------------------\n"
                    + " 1. Add Player\n"
                    + " 2. List Players\n"
                    + " 4. Remove Player\n"
                    + " 5. Remove All\n"
                    + "11. Save data to file\n"
                    + "12. Load data from file\n"
                    + "99. Exit Program\n"
                    + "Enter your menu choice: ";
                int[] AcceptedMenuChoices = { 1, 2, 4, 5, 11, 12, 99 };
                // Process menu choice
                //menuChoice = int.Parse(Console.ReadLine());
                menuChoice = PromptForInteger(MenuPrompt, AcceptedMenuChoices);

                switch (menuChoice)
                {
                    case 1: // Add Player
                        {
                            //Console.WriteLine("Add Player");
                            playerCount = AddPlayer(hockeyPlayerNameArray, hockeyPlayerPointArray, playerCount);
                        }
                        break;
                    case 2: // List Players
                        {
                            //Console.WriteLine("List Players");
                            ListPlayers(hockeyPlayerNameArray, hockeyPlayerPointArray, playerCount);
                        }
                        break;
                    case 4: // Remove player
                        {
                            playerCount = RemovePlayer(hockeyPlayerNameArray, hockeyPlayerPointArray, playerCount);
                        }
                        break;
                    case 5: // Remove All 
                        {
                            playerCount = RemoveAll(hockeyPlayerNameArray, hockeyPlayerPointArray);
                            // Display a feedback message that all players have been removed.
                            Console.WriteLine("Succesfully removed all players from the system.");
                        }
                        break;
                    case 11: // Save data
                        {
                            SaveData(hockeyPlayerNameArray, hockeyPlayerPointArray, playerCount);
                        }
                        break;
                    case 12: // Load data
                        {
                            playerCount = LoadData(hockeyPlayerNameArray, hockeyPlayerPointArray);
                        }
                        break;
                    case 99: // Exit Program
                        {
                            Console.WriteLine("Exit Program");
                        }
                        break;
                    default:    // Invalid Menu Choice
                        {
                            Console.WriteLine("Invalid menu choice");
                        }
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            } while (menuChoice != ExitProgramChoice);

        }

        static int RemoveAll(string[] nameArray, int[] pointArray)
        {
            for (int index = 0; index < nameArray.Length; index++)
            {
                // Assigned default values for each element
                nameArray[index] = null;
                pointArray[index] = 0;
            }
            return 0;
        }

        static int RemovePlayer(string[] nameArray, int[] pointArray, int arraySize)
        {
            int playerCount = 0;

            if (arraySize <= 0)
            {
                Console.WriteLine("There are players to remove.");
            }
            else
            {
                // Display a list of players to remove
                /*      12345678    123456789012345678901234567 123456
                 *      PlayerNo(8) Player Name (27)            Points (6)
                 *      --------    -----------                 ------
                 *             1    Ryan Nugent-Hopkins             18
                 *      
                 * */
                Console.WriteLine($"{"PlayerNo",8} {"Player Name",-27} {"Points",6}");
                Console.WriteLine($"{"--------",8} {"-----------",-27} {"------",6}");
                for (int index = 0; index < arraySize; index++)
                {
                    Console.WriteLine($"{index + 1,8} {nameArray[index],-27} {pointArray[index],6}");
                }
                // Prompt and read the playerNo to remove
                //Console.Write("Enter the player number to remove: ");
                //int playerNumber = int.Parse(Console.ReadLine());
                int playerNumber = PromptForIntegerRange("Enter the player number to remove: ", 1, arraySize + 1);
                int removeIndex = playerNumber - 1;
                // Shift all elements at removeIndex up by one
                for (int index = removeIndex; index < (arraySize - 1); index++)
                {
                    // Overwrite the current element with value from the next element
                    nameArray[index] = nameArray[index + 1];
                    pointArray[index] = pointArray[index + 1];
                }
                nameArray[arraySize] = null;
                pointArray[arraySize] = 0;
                arraySize--;
                Console.WriteLine($"Successfully removed player {playerNumber}");
            }
            playerCount = arraySize;

            return playerCount;
        }

        static int AddPlayer(string[] nameArray, int[] pointArray, int arraySize)
        {
            int playerCount = 0;

            // Prompt and read in the player name
            Console.Write("Enter hockey player name: ");
            nameArray[arraySize] = Console.ReadLine();
            // Prompt and read in the player points
            Console.Write("Enter hockey player points: ");
            pointArray[arraySize] = int.Parse(Console.ReadLine());
            // Increment arraySize
            arraySize++;
            // Set playerCount to arraySize
            playerCount = arraySize;

            return playerCount;
        }

        static void ListPlayers(string[] nameArray, int[] pointArray, int arraySize)
        {
            if (arraySize == 0)
            {
                Console.WriteLine("There are no hockey players in the system.");
            }
            else
            {
                /*      123456789012345678901234567 123456
                 *      Player Name (27)            Points (6)
                 *      -----------                 ------
                 *      Ryan Nugent-Hopkins             18
                 *      
                 * */
                Console.WriteLine($"{"Player Name",-27} {"Points",6}");
                Console.WriteLine($"{"-----------",-27} {"------",6}");
                for (int index = 0; index < arraySize; index++)
                {
                    Console.WriteLine($"{nameArray[index],-27} {pointArray[index],6}");
                }
            }
        }

        static int LoadData(string[] nameArray, int[] pointArray)
        {
            int recordsRead = 0;
            // Prompt and read in the file path to read data from
            Console.Write("Enter the relative or absolute path of the file to import: ");
            string dataImportFilePath = Console.ReadLine();
            try
            {
                StreamReader reader = new StreamReader(dataImportFilePath);
                const char Delimiter = ',';
                string line;
                int index = 0;
                while (reader.EndOfStream == false && index < nameArray.Length)
                {
                    line = reader.ReadLine();
                    string[] lineValuesArray = line.Split(Delimiter);
                    nameArray[index] = lineValuesArray[0];
                    pointArray[index] = int.Parse(lineValuesArray[1]);
                    index++;
                }
                reader.Close();
                recordsRead = index;
                Console.WriteLine($"Successfully read data from {dataImportFilePath} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return recordsRead;
        }
        static void SaveData(string[] nameArray, int[] pointArray, int arraySize)
        {
            if (arraySize == 0)
            {
                Console.WriteLine("There are no hockey players in the system.");
            }
            else
            {
                // Prompt and read in the file path to write data to
                Console.Write("Enter relative or absolute path of the file to export to: ");
                string dataExportFilePath = Console.ReadLine();
                try
                {
                    // Create a StreamWriter object for writing to a text file
                    StreamWriter writer = new StreamWriter(dataExportFilePath);
                    // Define the delimiter character used to separate values
                    const char Delimiter = ',';
                    // Write each element from our parallel arrays to a file
                    for (int index = 0; index < arraySize; index++)
                    {
                        writer.WriteLine($"{nameArray[index]}{Delimiter}{pointArray[index]}");
                    }
                    writer.Close();
                    Console.WriteLine($"Succesfully saved data to {dataExportFilePath}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        static int PromptForInteger(string prompt, int[] acceptedIntegerArray)
        {
            int integerValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(prompt);
                try
                {
                    integerValue = int.Parse(Console.ReadLine());
                    for (int index = 0; index < acceptedIntegerArray.Length; index++)
                    {
                        if (integerValue == acceptedIntegerArray[index])
                        {
                            validInput = true;
                            index = acceptedIntegerArray.Length;
                        }
                    }
                    if (!validInput)
                    {
                        Console.Write("Input value must be one of the following :");
                        foreach(int acceptedInteger in acceptedIntegerArray)
                        {
                            Console.Write($"{acceptedInteger}, ");
                        }
                        Console.WriteLine();
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return integerValue;
        }
        static int PromptForIntegerRange(string prompt, int minValue, int maxValue)
        {
            int integerValue = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write(prompt);
                try
                {
                    integerValue = int.Parse(Console.ReadLine());
                    if (integerValue >= minValue && integerValue <= maxValue)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Invalid grade entered {integerValue}, please enter a value between 1-100. ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            return integerValue;
        }
    }
}
