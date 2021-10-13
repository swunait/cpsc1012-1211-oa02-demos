using System;

namespace RectanglePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program prints a rectangle pattern on the screen with a user specified
            // number of rows and columns. For example:
            //  rows = 6
            //  columns = 8
            //  symbol = '$'
            /*             1 2 3 4 5 6 7 8
             *          1  $ $ $ $ $ $ $ $
             *          2  $ $ $ $ $ $ $ $ 
             *          3  $ $ $ $ $ $ $ $
             *          4  $ $ $ $ $ $ $ $
             *          5  $ $ $ $ $ $ $ $
             *          6  $ $ $ $ $ $ $ $
             *          
             * 
             */
            int rows = 6;
            int columns = 8;
            char symbol = '$';
            // Print one row at a time
            for (int currentRow = 1; currentRow <= rows; currentRow++ )
            {
                // Print one column at a time for each row
                for (int currentColumn = 1; currentColumn <= columns; currentColumn++)
                {
                    Console.Write($"{symbol} ");
                }
                // Print a new line for the next row
                Console.WriteLine();
            }
        }
    }
}
