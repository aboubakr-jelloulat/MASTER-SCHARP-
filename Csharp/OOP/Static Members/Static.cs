using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Static_Members
{
    public  class Static
    {

        // Static variable initialization directly in the class in C#
        public static int x = 1337; // In C#, static variables can be initialized inside the class directly

        // Static counter variable
        public static int counter = 0;

        public static int Foo()
        {
            return x;  // Static methods can access static variables directly
        }


        public static int Increment()
        {
            return ++counter;  // Increment and return the static counter
        }

    }
}

