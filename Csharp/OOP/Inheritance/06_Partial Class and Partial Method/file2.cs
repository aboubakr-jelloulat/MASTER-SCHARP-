using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance._06_Partial_Class_and_Partial_Method
{
    public partial class clsPartial
    {

        public void Method2()
        {
            System.Console.WriteLine("Hej ! I'm Method 2 file 2");
        }
        // ** In C#, partial methods cannot have access modifiers (like private, public, etc.).P
        partial void PrintAge()
        {
            System.Console.WriteLine($"Age : {Age}");
        }

    }
}
