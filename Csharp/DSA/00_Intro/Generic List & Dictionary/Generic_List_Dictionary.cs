using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA._00_Intro.Generic_List___Dictionary
{
    internal class clsGenericList
    {

        /* 
          * Why Use a Generic List Instead of an Array or ArrayList?
          * 
          * Type-safe → You specify the type once, so no casting or boxing/unboxing is needed.
          * 
          * Resizable → You can add/remove items dynamically without worrying about size.
         
         */
        public void GenericListOperations()
        {
            var list = new List<int>();

            list.Add(42);
            list.AddRange(new int[] { 13, 37, 19 });


            Console.WriteLine("Print the List Content : ");
            foreach(int item in list)
            {
                Console.WriteLine(item);
            }

            // operations : same operation of ArrayList

            if (list.Contains(42))
                Console.WriteLine("\nYes list is contain 42");
            else
                Console.WriteLine("\nNot list ism't contain 42");


        }


        public void DictionaryOperations()
        {
            Dictionary<string, string> Dict = new Dictionary<string, string>();

            Dict.Add("Intra", "abcd@1234");
            Dict.Add("Leetcode", "Leet@1337");
            Dict.Add("Gmail", "baker@1234");

            if (!Dict.ContainsKey("Linkedin"))
            {
                Dict.Add("Linkedin", "Aboubakr@1337");
            }

            Console.WriteLine("My Intra Password : {0}", Dict["Intra"]);

            if (Dict.TryGetValue("Linkedin", out string value))
            {
                Console.WriteLine($"\nMy Linkedin Password {value}");
            }

            Console.WriteLine("\nPrinting All Keys and Values : \n");

            foreach(var kvp in Dict)
            {
                Console.WriteLine($"\tKey : {kvp.Key}  \t=> Value : {kvp.Value}");

            }


        }
    }
}
