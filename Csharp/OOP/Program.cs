using   OOP.Static_Members;
using   OOP.Variable_Scopes;
using   OOP.PrivateConstractor_StaticClass;
using   OOP.Inheritance._00_Declaration;
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

            /* 


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




             */


            /* ***** [  Private Constractor vs Static Class ] **********   */




            //StaticClass.foo();
            //Console.WriteLine(PrivateConstractor.Day);


            // ***** We cann't create objects of the class in other class if we have a  1)- private constractor   or  2)-  static class


            //StaticClass cls = new();

            //PrivateConstractor prv = new();







            /* ***** [ Inheritance  ] **********   */


            Student st = new Student(10, "Aboubakr", 1000, 20, "IT");

            st.DisplayInfo();

            st.ShowStudentInfo();








        }
    }

        
}
