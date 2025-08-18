using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Csharp._01__Extension_Methods;
using Advanced_Csharp._02_Recursion;
using Advanced_Csharp._03_Delegates;

namespace Advanced_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // *************** [ Extension Methods ] *********************




            //Extension_Methods methode = new Extension_Methods();

            //methode.PersentageIsBetween();

            //methode.RemoveWhiteSpaceAndReverse();




            // *************** [ Recursion ] *********************


            //Console.WriteLine(clsRecursion.CalculateFactorial(5));

            //clsRecursion.PrintDirectoryFileSystemEntries(@"C:\Users\HP\Desktop\42 cursus\Exam_Rank_04", 1);

            //Console.WriteLine("Size of this dir : {0}  KB", clsRecursion.ClaculateDirectorySize(@"C:\Users\HP\Desktop\42 cursus\Exam_Rank_04") / 1024);





            // *************** [ Delegates ] *********************


            Delegates delg = new Delegates();

            // delg.TestClaculate();

            //delg.MulticastingDelegate();

            Employee.AnyThings();




            Console.ReadKey();

        }
    }
}
