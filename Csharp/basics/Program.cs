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

            




            /* ***********    fill array     ************  */


            /*
             

            Console.WriteLine("Enter the size of elements: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill the array: ");
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (a.Length != n)
            {
                Console.WriteLine($"Error: You entered {a.Length} elements, but expected {n}.");
                return;
            }

            Console.WriteLine("\nArray elements: ");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);


            */



            /* **************    Value Type  / Refrence Types */

            Console.WriteLine("\n *********  Numbers  *************\n\n");

            int num_1 = 42;
            int num_2 = num_1;
            num_1 = 1337;

            Console.WriteLine($"num 1 = {num_1}");
            Console.WriteLine($"num 2 = {num_2}\n");



            Console.WriteLine("\n *********  Arrays  *************\n\n");

            int[] numbers = { 1337, 2 };

            int[] numbers2 = numbers;

            Console.WriteLine($"numbers[0] = {numbers[0]}");
            Console.WriteLine($"numbers2[0] = {numbers2[0]}");



            Console.WriteLine("\n *********  With methodes  *************\n\n");


            int nb = 5;
            Duplicate_number(nb);
            Console.WriteLine($"nb =  {nb}\n");

            int[] arr = { 1, 2, 3, 4, 5 };
            DuplicateArraysValue(arr);

            Console.WriteLine($"arr[0] = {arr[0]}");
            Console.WriteLine($"arr[1] = {arr[1]}");
            Console.WriteLine($"arr[2] = {arr[2]}");
            Console.WriteLine($"arr[3] = {arr[3]}");



            Console.ReadKey();

        }

        static void Duplicate_number(int nb)
        {
            nb *= 2;
        }

        static void DuplicateArraysValue(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] *= 2;

        }
    }
}

