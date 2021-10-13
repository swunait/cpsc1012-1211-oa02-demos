using System;

namespace RectangleBoxPattern
{
    class Program
    {
        /* This program prints a rectangle box on the screen with a user specified number
         * of rows and columns. For example with 6 rows and 8 columns and a $ symbol:
         *        1 2 3 4 5 6 7 8
         *      1 $ $ $ $ $ $ $ $
         *      2 $ _ _ _ _ _ _ $
         *      3 $ _ _ _ _ _ _ $
         *      4 $ _ _ _ _ _ _ $
         *      5 $ _ _ _ _ _ _ $
         *      6 $ $ $ $ $ $ $ $
         * 
         * 
         * */
        static void Main(string[] args)
        {
            int rows = 6;
            int columns = 8;
            char fillSymbol = '|';
            // Print one row at a time
            for (int currentRow = 1; currentRow <= rows; currentRow++)
            {
                // Print one column at a time for each row
                for (int currentColumn = 1; currentColumn <= columns; currentColumn++)
                {
                    // Print the fillSymbol for the first and last row and first and last column
                    // Otherwise print a single empty space
                    if (currentRow == 1 || currentRow == rows || currentColumn == 1 || currentColumn == columns)
                    {
                        Console.Write($"{fillSymbol}");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                // Print a new line for the next row
                Console.WriteLine();
            }
        }
    }
}
