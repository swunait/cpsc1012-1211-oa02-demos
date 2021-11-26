using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise01
{
    public class Die
    {
        // Define a read only property for the Sides
        public int Sides { get; }
        // Define a read only property for the Value but allow write for internal usage
        public int Value { get; private set; }
        
        // Define a constructor for creating a Die with a specific number of sides
        public Die(int numSides)
        {
            Sides = numSides;
            Roll();
        }

        // Define an instance-level method to Roll die
        public void Roll()
        {
            Random rand = new Random();
            Value = rand.Next(1, Sides + 1);
        }

    }
}
