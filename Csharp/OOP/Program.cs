using   OOP.Static_Members;
using   OOP.Variable_Scopes;
using   OOP.PrivateConstractor_StaticClass;
using   OOP.Inheritance._00_Declaration;
using   OOP.Inheritance._01_Override;
using   OOP.Inheritance.Method_Hiding___Shodowing;
using   OOP.Inheritance._02_AbstractClass;
using   OOP.Inheritance._03_Interface;
using System;
using OOP.Inheritance._04_NestedClass;

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





            /*
             
            Student st = new Student(10, "Aboubakr", 1000, 20, "IT");

            st.DisplayInfo();

            st.ShowStudentInfo();

            */








            /* ***** [ Overriding in c# + Base Keyword  ] **********   */



            /*

            clsB B = new clsB();

            B.Display();


            */





            /* ***** [Method Hidding  / Shodowing  ] **********   */


            /* 

            MyBaseClass myBaseObj = new MyBaseClass();
            Console.WriteLine("\nBase Object:\n");
            myBaseObj.MyMethod(); // Output: "Base class implementation"
            myBaseObj.MyOtherMethod(); // Output: "Base class implementation of MyOtherMethod"


            MyDerivedClass myDerivedObj = new MyDerivedClass();
            Console.WriteLine("\nDerived Object:\n");
            myDerivedObj.MyMethod(); // Output: "Derived class implementation using override"
            myDerivedObj.MyOtherMethod(); // Output: "Derived class implementation of MyOtherMethod using new"


            MyBaseClass myDerivedObjAsBase = myDerivedObj;
            Console.WriteLine("\nAfter Casting:\n");
            myDerivedObjAsBase.MyMethod(); // Output: "Derived class implementation using override"
            myDerivedObjAsBase.MyOtherMethod(); // Output: "Base class implementation of MyOtherMethod"


            */









            /* ***** [Method Hidding  / Shodowing  ] **********   */





            /* 


            AbsStudent S1 = new AbsStudent("Aboubakr", "Jelloulat", "IT");

            S1.WhoAmi();



            */





            /* ***** [ Interface ] **********   */


            //Movie movie = new Movie("Inception");
            //movie.Play();
            //movie.Stop();

            //Music music = new Music("Shape of You");
            //music.Play();
            //music.Pause();

            // ------  Multiple Interfaces -----


            //EBook book = new EBook("Clean Code");

            //book.Read();
            //book.Read();
            //book.Download();






            /* ***** [ Nested Class ] **********   */


            Outher.Inner inner = new Outher.Inner();

            inner.hej();

            Outher outher = new Outher("CN61606");

            inner.AccesCIN(outher);



        }
    }

        
}
