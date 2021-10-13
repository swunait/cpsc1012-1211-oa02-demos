using System;

namespace TriangleBoxPattern
{
    class Program
    {
        /* This program prints a right triangle pattern of a user specified base size to the screen.
         * For example base size of 8
         *    1 2 3 4 5 6 7 8
         *  1 $ 
         *  2 $ $
         *  3 $ $ $
         *  4 $ $ $ $
         *  5 $ $ $ $ $
         *  6 $ $ $ $ $ $
         *  7 $ $ $ $ $ $ $
         *  8 $ $ $ $ $ $ $ $
         * 
         * */
        static void Main(string[] args)
        {
            int baseSize = 8;
            char symbol = '$';
            // Print one row at a time
            for (int currentRow = 1; currentRow <= baseSize; currentRow++)
            {
                // Print one column at a time for each row
                for (int currentColumn = 1; currentColumn <= currentRow; currentColumn++)
                {
                    Console.Write($"{symbol} ");
                }
                // Print a new line for the next row
                Console.WriteLine();
            }
        }
    }
}
