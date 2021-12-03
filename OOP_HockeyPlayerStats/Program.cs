using System;

using System.IO;                        // for StreamReader and StreamWriter
using System.Collections.Generic;       // for List<T>

namespace OOP_HockeyPlayerStats
{
    // Define a new class named HockeyPlayer
    class HockeyPlayer
    {
        // Define auto-implemented properties of the hockey player
        public string PlayerName { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }
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
            const string ImportDataFilePath = @"C:\temp\oilers_dec03.txt";
            // Call the LoadPlayerData method to load the playerList with data from 
            LoadPlayerData(playerList, ImportDataFilePath, Delimiter);
            // Call the DisplayPlayerStats method
            DisplayPlayerStats(playerList);
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

        static void DisplayPlayerStats(List<HockeyPlayer> playerList)
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
