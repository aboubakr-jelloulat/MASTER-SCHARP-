using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Variable_Scopes
{
    public class VariableScopes
    {

        // ***** [ Variables Scopes ]

        private string _name = "Hej ";

        public static void VariablesScopes()
        {
            //Console.WriteLine(_name); // you can't acces it non-static 

            var MyScope = new VariableScopes();

            Console.WriteLine(MyScope._name);

        }

        public static void BlockScope()
        {
            int x = 1337;

            while (true)
            {
                int y = 42;

                Console.WriteLine($"im y visible here : {y}");

                break;
            }

            //Console.WriteLine($"im y not visible here : {y}");

        }

       
        
    }
}
