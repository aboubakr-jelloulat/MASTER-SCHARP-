using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PrivateConstractor_StaticClass
{
    public static  class StaticClass
    {

        public static void foo()
        {
            Console.WriteLine("Im a static class");
        }

    }


    public  class PrivateConstractor
    {
        public static  int Day
        {
            get { return DateTime.Today.Day;  }
        }

        private PrivateConstractor()
        {
            Console.WriteLine("Im a privrate Constractor");
        }

    }


}
