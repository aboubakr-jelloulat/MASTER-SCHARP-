using System;


namespace Csharp
{
    public class Bsics
    {
        static void Main()
        {
            /* *********   Parse  ********* */


            /*

            Console.WriteLine("Enter your birth year : ");

            string year = Console.ReadLine();

            int str_to_int = int.Parse(year);

            Console.Write($"Your age is : {2025 - str_to_int}");



            */



            /*  ***********  Arrays    ****************  */


            /*

            int[] Schools = {13, 37, 42, 19};

            Array.Sort(Schools);   // - sort

            int[] copy_array = new int[4];  // - copy

            Array.Copy(Schools, copy_array, Schools.Length);

            Console.WriteLine(copy_array[1]);


            for (int i = 0; i < Schools.Length; i++)
                Console.WriteLine($" index {i}  : value : {Schools[i]}");



            */




            /*  ***********    foreach    **************   */




            /*

            char[] numbers = { '0', '1', '2', '3' };

            foreach (char digit in numbers)
            {
                Console.WriteLine(digit);
            }


            */




            /*   *************       switch case    *************  */



            /*
      
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1 - Say Hello");
            Console.WriteLine("2 - Show Date");
            Console.WriteLine("3 - Exit");

            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            int parse = int.Parse(input);

            switch (parse)
            {

                case 1:
                    Console.WriteLine("\nHello, Aboubaker! 👋");
                    break;

                case 2:
                    Console.WriteLine("\nToday's date is: " + DateTime.Now.ToShortDateString());
                    break;

                case 3:
                    Console.WriteLine("\nExiting... Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    break;
             
            }

            */




            Console.ReadKey();

        }
    }
}

