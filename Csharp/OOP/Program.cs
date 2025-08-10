using OOP.Static_Members;
using  OOP.Variable_Scopes;
using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* ***** [ Variables Scopes ] **********   */

            //VariableScopes.VariablesScopes();

            //VariableScopes.BlockScope();




            /* ***** [ Variables Scopes ] **********   */

        
                //  **Accessing static variables** in C#

                // In C#, static members are accessed using the class name

                Console.WriteLine("Variable: " + Static.x); // Accessing static variable using class name
                Console.WriteLine("Foo function: " + Static.Foo()); // Accessing static method using class name


            //  **Modifying static variables**

            // Modifying static variables in C# is done via the class name

            Static.x = 42;  // In C#, modify static variable using class name
            Console.WriteLine("\n\nModified Variable: " + Static.x);
            Console.WriteLine("Foo function after modification: " + Static.Foo());

            // 📌 **Using static method to modify another static variable (counter)**

            // Static methods can also modify static variables

            Console.WriteLine("Counter: " + Static.Increment()); // Increment static counter
            Console.WriteLine("Counter: " + Static.Increment());
            Console.WriteLine("Counter: " + Static.Increment());

            // 📌 **Accessing static members via object**

            //Static dif = new Static();  // Create an object of StaticDifferences


            // 🚸 🚸🚸 cannot be accessed through object, only through the class itself

            //Console.WriteLine("Accessing static variable via object: " + dif.x);
            //Console.WriteLine("Accessing static method via object: " + dif.Foo());




        }
    }
}
