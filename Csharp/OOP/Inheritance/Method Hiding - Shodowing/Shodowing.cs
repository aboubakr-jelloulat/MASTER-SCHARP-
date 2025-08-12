using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance.Method_Hiding___Shodowing
{

    /*
      
        As we already know about polymorphism and method overriding in C#. C# also provides a concept to hide the methods of the base class from derived class, this concept is known as Method Hiding. It is also known as Method Shadowing. In method hiding, you can hide the implementation of the methods of a base class from the derived class using the new keyword. Or in other words, in method hiding, you can redefine the method of the base class in the derived class by using the new keyword.


     */

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
