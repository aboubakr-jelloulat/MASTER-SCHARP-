using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance._04_NestedClass
{
    public class Outher
    {
        private string IDCIN;

        public Outher(string CIN)
        {
            this.IDCIN = CIN;
        }
        
        public void OutherMethod()
        {
            Console.WriteLine("Outher Method Called");
        }

        public class Inner
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public void hej() { Console.WriteLine("Hej! im Inner Class"); }

            public  void AccesCIN(Outher other)
            {
                Console.WriteLine("CIN is : {0}", other.IDCIN);
            }
                

        }

    }
}
