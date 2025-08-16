using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSA._00_Intro;
using DSA._00_Intro.Generic_List___Dictionary;
using DSA._00_Intro.Stack_Queue;


namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ****** Array List & Boxing Unboxing ********


            //clsArrayList list = new clsArrayList();

            //list.ArrayListOperation();

            //list.BoxingUnboxing();




            // ******** Generic List & Dictionary  *********


            //clsGenericList Glist = new clsGenericList();

            //Glist.GenericListOperations();

            //Glist.DictionaryOperations();




            // ********    Stack     *********

            // clsStack stack = new clsStack();

            // stack.ImplementUndoRedo();


            // ********    Queue     *********

            clsQueue queue = new clsQueue();

            queue.ImplementPrinter();




            Console.ReadKey();
        }
    }
}
