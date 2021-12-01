using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProblems2_Question1And2
{
    public class Quiz
    {
        // Define private data fields for storing data
        private string _studentName = "Unknown Name";
        private int _total = 100;
        private int _mark = 0;
        private int _weight = 10;

        // Define properties to encapsulate access to the data fields
        public string StudentName
        {
            get => _studentName;

            set
            {
                // Throw an exception if the new value is an null or contains only whitespaces
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Student Name must contain at least one non-whitespace character.");
                }
                _studentName = value;
            }

        }

        public int Total
        {
            get => _total;
        }

        public int Mark
        {
            get => _mark;
            //get { return _mark; }

            set
            {
                // Throw a exception if the mark is not between 0 and Total (inclusive)
                if (value < 0 || value > Total)
                {
                    throw new Exception($"Mark must be between 0 and {Total}.");
                }
                _mark = value;
            }
        }

        public int Weight
        {
            get => _weight;
        }

        // Define constructors for creating objects of this class
        public Quiz(int total, int weight)
        {
            _total = total;
            _weight = weight;
        }

        // Define instance-level methods that perform operations using the properties/fields of the object
        public int Percentage()
        {
            return (int) Math.Round((double) Mark / Total * 100, 0);
        }
    }
}
