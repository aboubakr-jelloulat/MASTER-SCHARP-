using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA._00_Intro
{
    internal class clsArrayList
    {
        public void ArrayListOperation()
        {
            ArrayList list = new ArrayList();


            list.Add(42);
            list.Add("42 The Network");
            list.Add(true);
            list.AddRange(new int[] {13, 37, 19});


            Console.WriteLine("Print Array List Items : \n");
            foreach(object item in list)
            {
                Console.WriteLine(item);
            }


            // operations 

            list.Remove(42);

            list.RemoveAt(0);

            Console.WriteLine("\nIndex of 19 is : " + list.IndexOf(19));

            Console.WriteLine("\nIndex of 42 is : " + list.IndexOf(42, 4));

            list.Insert(1, "1337 Coding School");


           
            Console.WriteLine("\n\nPrint Array List Items : \n");
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }


        }

        public void BoxingUnboxing()
        {
            /* 
                What is Boxing?

                    Boxing is the process of converting a value type (like int, bool, struct) into a reference type (specifically, an object or any interface type it implements)


                What is Unboxing ?

                    Unboxing is the reverse process — extracting the value type from the object back into a value type variable
             
             */


            int number = 42;        // Value type (stack)
            object obj = number;    // Boxing: num is copied into a new object on the heap

            Console.WriteLine("Boxing : " + obj);


            int nb = (int)obj + 10;  // Unboxing: extract int value from obj

            Console.WriteLine("\nUnboxing : " + nb);


        }


    }
}
