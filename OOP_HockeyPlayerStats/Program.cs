using System;

namespace OOP_HockeyPlayerStats
{
    // Define a new class named HockeyPlayer
    class HockeyPlayer
    {
        // Define data field to store data
        private string _name;
        //private int _number;
        //private int _gamesPlayed;
        //private int _assists;

        // Define properties to encapulate access to the data fields
        public string Name
        {
            get // Accessor
            {
                return _name;
            }
            set // Mutator
            {
                _name = value;
            }
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
