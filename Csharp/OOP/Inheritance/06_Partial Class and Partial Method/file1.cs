using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance._06_Partial_Class_and_Partial_Method
{

    /*
	There are many situations when you might need to split a class definition, such as when working on a large scale projects, multiple developers and programmers might need to work on the same class at the same time.
	In this case we can use a feature called Partial Class

    */



    /*
        A partial class allows you to split the definition of a class into multiple files.
        All parts are combined into a single class when the application is compiled.

    */




    /*

        A partial method lets you define a method in one part of a partial class, and optionally implement it in another part.

        🔸 If you don’t implement it, it gets removed at compile time — so no performance cost.


        Things to remember about Partial Method : 
            partial keyword.
            return type void.
            implicitly private.
            and cannot be virtual.


    */


    public partial class clsPartial
    {
        public decimal Age { get; set; }
        public void Method1()
        {
            System.Console.WriteLine("Hej ! I'm Method 1 file 1");
        }

        partial void PrintAge();

        public void PartialMethod1()
        {
            ++Age;

            PrintAge();
        }

    }
}
