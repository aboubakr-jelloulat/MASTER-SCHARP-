using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Advanced_Csharp._01__Extension_Methods
{

    static class clsNumbersUtils
    {
        public static bool IsBetween(this int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        public static string RemoveWhiteSpace(this string value)
        {
            return value.Replace(" ", "");
            
        }

        public static string ReverseString(this string value)
        {
            return new string(value.Reverse().ToArray());
        }

    }

    internal class Extension_Methods
    {
        public void PersentageIsBetween()
        {
            int persnt = -10;

            if (persnt.IsBetween(0, 100))
                Console.WriteLine("Percentage Is Valid");
            else
                Console.WriteLine("Invalid Percentage");

        }


        public void RemoveWhiteSpaceAndReverse()
        {
            Console.Write("Enter a string :   ");
            var input = Console.ReadLine();

            Console.WriteLine("\n" + input.RemoveWhiteSpace().ReverseString());
        }

    }
}
