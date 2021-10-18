using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012
{
    public class CPSC1012Helper
    {
        public static double PromptForDouble(string prompt)
        {
            double doubleValue = 0;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out doubleValue))
            {
                Console.WriteLine("Invalid input value. Try again.");
                Console.Write(prompt);
            }
            return doubleValue;
        }

    }
}
