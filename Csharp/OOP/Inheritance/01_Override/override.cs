using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance._01_Override
{
    public class clsA
    {
        public virtual void Display()
        {
            Console.WriteLine("Hej, jag är klass A");
        }

    }

    public class clsB : clsA
    {
        public override void Display()
        {
            Console.WriteLine("Hey , Im class B");

            base.Display();
        }

    }

}
