using System;

using System.IO;                        // for StreamReader and StreamWriter
using System.Collections.Generic;       // for List<T>

namespace OOP_HockeyPlayerStats
{
    // Define a new class named HockeyPlayer
    //class HockeyPlayer
    //{
    //    // Define auto-implemented properties of the hockey player
    //    public string PlayerName { get; set; }
    //    public int Goals { get; set; }
    //    public int Assists { get; set; }
    //    // Define Points as a computed property (you could define it as method instead)
    //    public int Points
    //    {
    //        get
    //        {
    //            return Goals + Assists;
    //        }

    //        // Simplifed syntax using expression body modifier
    //        //get => Goals + Assists;

    //    }
    //}

    class HockeyPlayer
    {
        // Define private backing fields
        private string _playerName;
        private int _goals;
        private int _assists;

        // Define backing field properties
        public string PlayerName 
        {
            get => _playerName;
            set
            {
                if (string.IsNullOrEmpty(value)|| value.Length < 4)
                {
                    throw new Exception("A player name is required and must contain at least 4 characters.");
                }
                _playerName = value;
            }
        }

        public int Goals 
        {
            get => _goals;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Goals must be 0 or more.");
                }
                _goals = value;
            }
        }

        public int Assists 
        {
            get => _assists;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Assists must be 0 or more.");
                }
                _assists = value;
            }
        }
        // Define Points as a computed property (you could define it as method instead)
        public int Points
        {
            get
            {
                return Goals + Assists;
            }

            // Simplifed syntax using expression body modifier
            //get => Goals + Assists;
        }

        public HockeyPlayer()
        {
            PlayerName = "No Name";
            Goals = 0;
            Assists = 0;
        }

        public HockeyPlayer(string name, int goals, int assists)
        {
            this.PlayerName = name;
            this.Goals = goals;
            this.Assists = assists;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Define and create new list of HockeyPlayer
            List<HockeyPlayer> playerList = new List<HockeyPlayer>();
            // Define the delimiter character for the data file
            const char Delimiter = ',';
            // Define the location of the data file
            const string dataFilePath = @"C:\temp\oilers_dec03.txt";
            // Call the LoadPlayerData method to load the playerList with data from 
            LoadPlayerData(playerList, dataFilePath, Delimiter);

            string[] mainMenuChoiceArray = 
            {
                "--------------------",
                "| Main Menu        |",
                "--------------------",
                "| 1. Add Player    |",
                "| 2. List Players  |",
                "| 3. Find Player |",
                "| 4. Update Player |",
                "| 5. Delete Player |",
                "| 99. Exit program  |",
                "--------------------"
            };
            int[] validMainMenuChoiceArray = {1, 2, 3, 4, 5, 99};
            int mainMenuChoice = 99;
            const int ExitProgramChoice = 99;

            do
            {
                mainMenuChoice = PromptForMainMenuChoice(mainMenuChoiceArray, validMainMenuChoiceArray);
                switch (mainMenuChoice)
                {
                    case 1: // add player
                        {
                            Console.WriteLine("Add Player");
                            HockeyPlayer newHockeyPlayer = PromptForPlayerToAdd();
                            playerList.Add(newHockeyPlayer);
                        }
                        break;
                    case 2: // list players
                        {
                            // Call the ListPlayerStats method
                            ListPlayerStats(playerList);
                        }
                        break;
                    case 3: // find player
                        {
                            //Console.WriteLine("Find Player");
                            HockeyPlayer playerFound = FindPlayer(playerList);
                            if (playerFound != null)
                            {
                                Console.WriteLine("Found the following player: ");
                                Console.WriteLine($"Player Name: {playerFound.PlayerName}");
                                Console.WriteLine($"Player Goals: {playerFound.Goals}");
                                Console.WriteLine($"Player Assists: {playerFound.Assists}");
                                Console.WriteLine($"Player Points: {playerFound.Points}");
                            }
                            else
                            {
                                Console.WriteLine("No player found.");
                            }
                        }
                        break;
                    case 4: // update player
                        {
                            //Console.WriteLine("Update Player");
                            HockeyPlayer playerFound = FindPlayer(playerList);
                            if (playerFound != null)
                            {
                                Console.WriteLine("Found the following player: ");
                                Console.WriteLine($"Player Name: {playerFound.PlayerName}");
                                Console.WriteLine($"Player Goals: {playerFound.Goals}");
                                Console.WriteLine($"Player Assists: {playerFound.Assists}");
                                Console.WriteLine($"Player Points: {playerFound.Points}");

                                char yesOrNoAnswer;
                                do
                                {
                                    Console.Write("Do you want to change the player name? (y/n): ");
                                    yesOrNoAnswer = Console.ReadKey().KeyChar;
                                    Console.WriteLine();
                                    yesOrNoAnswer = char.ToLower(yesOrNoAnswer);
                                } while (yesOrNoAnswer != 'y' && yesOrNoAnswer != 'n');

                                if (yesOrNoAnswer == 'y')
                                {
                                    try
                                    {
                                        Console.Write("Enter the player name: ");
                                        playerFound.PlayerName = Console.ReadLine();
                                        Console.WriteLine($"Player name changed to {playerFound.PlayerName}");
                                    }
                                    catch(Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }

                                do
                                {
                                    Console.Write("Do you want to change the player goals? (y/n): ");
                                    yesOrNoAnswer = Console.ReadKey().KeyChar;
                                    Console.WriteLine();
                                    yesOrNoAnswer = char.ToLower(yesOrNoAnswer);
                                } while (yesOrNoAnswer != 'y' && yesOrNoAnswer != 'n');

                                if (yesOrNoAnswer == 'y')
                                {
                                    try
                                    {
                                        Console.Write($"Enter the number goals for {playerFound.PlayerName}: ");
                                        playerFound.Goals = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"Goals changed to {playerFound.Goals}");
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }

                                do
                                {
                                    Console.Write("Do you want to change the player assists? (y/n): ");
                                    yesOrNoAnswer = Console.ReadKey().KeyChar;
                                    Console.WriteLine();
                                    yesOrNoAnswer = char.ToLower(yesOrNoAnswer);
                                } while (yesOrNoAnswer != 'y' && yesOrNoAnswer != 'n');

                                if (yesOrNoAnswer == 'y')
                                {
                                    try
                                    {
                                        Console.Write($"Enter the number assists for {playerFound.PlayerName}: ");
                                        playerFound.Assists = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"Assists changed to {playerFound.Assists}");
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("No player found.");
                            }
                        }
                        break;
                    case 5: // delete player
                        {
                            //Console.WriteLine("Remove Player");
                            HockeyPlayer playerFound = FindPlayer(playerList);
                            if (playerFound != null)
                            {
                                Console.WriteLine("Found the following player: ");
                                Console.WriteLine($"Player Name: {playerFound.PlayerName}");
                                Console.WriteLine($"Player Goals: {playerFound.Goals}");
                                Console.WriteLine($"Player Assists: {playerFound.Assists}");
                                Console.WriteLine($"Player Points: {playerFound.Points}");
                                char yesOrNoAnswer;
                                do
                                {
                                    Console.Write("Do you want to delete this player (y/n)? ");
                                    yesOrNoAnswer = Console.ReadKey().KeyChar;
                                    Console.WriteLine();
                                    yesOrNoAnswer = char.ToLower(yesOrNoAnswer);
                                } while (yesOrNoAnswer != 'y' && yesOrNoAnswer != 'n');

                                if (yesOrNoAnswer == 'y')
                                {
                                    playerList.Remove(playerFound);
                                    Console.WriteLine("Successfully deleted player.");
                                }
                                else
                                {
                                    Console.WriteLine("Delete operation cancelled.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No player found.");
                            }
                        }
                        break;
                    case ExitProgramChoice:
                        {
                            Console.WriteLine("Good-bye and go oilers!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid menu choice.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();

            } while (mainMenuChoice != ExitProgramChoice);

            // Call the SavePlayerData method to save playerList to a text file
            SavePlayerData(playerList, dataFilePath, Delimiter);
        }

        static int PromptForMainMenuChoice(string[] menuOptionsArray, int [] validOptionArray)
        {
            int menuChoice = validOptionArray[0];
            bool validInput = false;

            while (!validInput)
            {
                foreach(string menuOption in menuOptionsArray)
                {
                    Console.WriteLine(menuOption);
                }
                Console.Write("Your choice > ");

                try
                {
                    menuChoice = int.Parse(Console.ReadLine());
                    for (int index = 0; index < validOptionArray.Length; index++)
                    {
                        if (menuChoice == validOptionArray[index])
                        {
                            validInput = true;
                            // Exit for loop by setting boolean expression for loop to false condition
                            index = validOptionArray.Length;
                        }
                    }                    
                }
                catch//(Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                }

                if (!validInput)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid menu choice.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            }

            return menuChoice;
        }

        static HockeyPlayer PromptForPlayerToAdd()
        {
            HockeyPlayer currentPlayer = new HockeyPlayer();
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    Console.Write("Enter the player name: ");
                    currentPlayer.PlayerName = Console.ReadLine();
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
                try
                {
                    Console.Write($"Enter the number of goals for {currentPlayer.PlayerName}: ");
                    currentPlayer.Goals = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write($"Enter the number of assists for {currentPlayer.PlayerName}: ");
                    currentPlayer.Assists = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return currentPlayer;
        }

        static HockeyPlayer FindPlayer(List<HockeyPlayer> playerList)
        {
            HockeyPlayer currentPlayer = null;
            
            // Prompt for the name of the player to search for
            Console.Write("Enter the name of the player: ");
            string playerName = Console.ReadLine();
            // Search for first matching player name
            for (int index = 0; index < playerList.Count; index++)
            {
                if (playerName == playerList[index].PlayerName)
                {
                    currentPlayer = playerList[index];
                    // Exit the for loop by setting its loop condition to false
                    index = playerList.Count;
                }
            }

            return currentPlayer;
        }

        static void SavePlayerData(List<HockeyPlayer> playerList, string exportDataFilePath, char delimiter)
        {
            if (playerList.Count > 0)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(exportDataFilePath);
                    foreach (HockeyPlayer currentPlayer in playerList)
                    {
                        writer.WriteLine($"{currentPlayer.PlayerName}{delimiter}{currentPlayer.Goals}{delimiter}{currentPlayer.Assists}");
                    }
                    writer.Close();
                } 
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                
            }
        }

        static void LoadPlayerData(List<HockeyPlayer> playerList, string importDataFilePath, char delimiter)
        {
            // Replace the existing playList data with new data from the file
            playerList.Clear();

            try
            {
                // Create a StreamReader object for reading the importDataFilePath
                StreamReader reader = new StreamReader(importDataFilePath);
                // Define a variable to store a single line of text read from the file
                string lineText;
                // Read one line at time from the file until we reached the EOF
                while( reader.EndOfStream == false)
                {
                    // Read the current line of text
                    lineText = reader.ReadLine();
                    // Convert the line of text to an array of values where each value is separated by a delimiter character
                    string[] lineValuesArray = lineText.Split(delimiter);
                    // The order of the values in the line are: PlayerName, Goals, Assists
                    // Create a new HockeyPlayer object for each line of text
                    HockeyPlayer currentPlayer = new HockeyPlayer();
                    // Set the properties of the currentPlayer using the lineValuesArray
                    currentPlayer.PlayerName = lineValuesArray[0];
                    currentPlayer.Goals = int.Parse(lineValuesArray[1]);
                    currentPlayer.Assists = int.Parse(lineValuesArray[2]);
                    // Add the currentPlayer object to playerList
                    playerList.Add(currentPlayer);
                }
                // Close the reader
                reader.Close();
            } 
            catch(Exception ex)
            {
                // print the exception message
                Console.WriteLine(ex.Message);
            }
        }

        static void ListPlayerStats(List<HockeyPlayer> playerList)
        {
            if (playerList.Count == 0)
            {
                Console.WriteLine("There are no hockey players in the system.");
            }
            else
            {
                /*      12345678901234567890    12  12  123
                 *      Player Name (20)        G   A   P
                 *      -----------             --  --  ---
                 *      Ryan Nugent-Hopkins      2  18   20
                 * 
                 */
                Console.WriteLine($"{"Player Name",-20} {"G",2} {"A",2} {"P",3}");
                Console.WriteLine($"{"-----------",-20} {"--",2} {"--",2} {"---",3}");
                foreach(HockeyPlayer currentPlayer in playerList)
                {
                    Console.WriteLine($"{currentPlayer.PlayerName,-20} {currentPlayer.Goals,2} {currentPlayer.Assists,2} {currentPlayer.Points,3}");
                }
            }
        }
        
    }
}
