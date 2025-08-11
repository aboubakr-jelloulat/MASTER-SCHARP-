using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance.Method_Hiding___Shodowing
{
    public class MyBaseClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Base class implementation");
        }


        public virtual void MyOtherMethod()
        {
            Console.WriteLine("Base class implementation of MyOtherMethod");
        }
    }


    public class MyDerivedClass : MyBaseClass
    {
        public override void MyMethod()
        {
            Console.WriteLine("Derived class implementation using override");
        }


        public new void MyOtherMethod()
        {
            Console.WriteLine("Derived class implementation of MyOtherMethod using new");
        }
    }


   
}
