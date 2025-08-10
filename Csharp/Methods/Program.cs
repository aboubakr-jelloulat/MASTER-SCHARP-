using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {


        /*  ************  Methods   **************  */


        // syntax of Method



        // AccessModifier   modifer   return type   MethodeName(parameter1,  parametere2) {}


        // AccessModifier :  public    private   protected    internal -> Accessible within the same project (assembly)  

        // modifier       :  static   virtual   abstract  new   partial 

        // return  type   :   int      string   ...



        public static int Multiply(int x, int y)
        {

            /*
                public → accessible from anywhere

                static → can be called without creating an object

                int → returns an integer

                Multiply → method name

                (int x, int y) → two input parameters

                return x * y; → result is returned





             */


            return x * y;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("the result of 5 x 5 = {0}", Multiply(5, 5));

        }
    }
}

