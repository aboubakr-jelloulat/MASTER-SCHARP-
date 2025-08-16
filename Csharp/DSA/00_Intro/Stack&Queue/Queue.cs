using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA._00_Intro.Stack_Queue
{


    internal class clsQueue
    {

        public void ImplementPrinter()
        {
            var MyQueue = new Queue<string>();
            string doc = "";

            while (true)
            {
                Console.Write("Please Select a Document to Print 'print'   :   ");
                doc = Console.ReadLine();

                if (doc.Equals("print", StringComparison.OrdinalIgnoreCase))
                {
                    while (MyQueue.Count > 0)
                        Console.WriteLine("Printing Document : " + MyQueue.Dequeue());

                }
                else if (doc.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                    MyQueue.Enqueue(doc);


            }



        }

    }
}
