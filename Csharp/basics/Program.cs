using System;
using System.Runtime;
using System.Text;


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


            /*

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




            */




            // *****************     string [Split   join]       *********************


            /*  

            Console.WriteLine("*** 1) - split *** \n\nEnter list of numbers separated by comma : \n");

            string input = Console.ReadLine();

            string[] numbers = input.Split(",");

            int sum = 0;

            foreach (string nb in numbers)
                sum += int.Parse(nb);

            Console.WriteLine("\nThe total sum of array is : {0}", sum);



            Console.WriteLine("\n\n**** 2) - join  string : \n");

            string[] words = { "hello", "Azure", "tech world"};

            string hello = string.Join(" ", words);

            Console.WriteLine(hello); 



            */




            /*  **********  String Builder ********** */

            /*  



            string str = "Hello";
            str = "Hello world";    //  not modified
            str += " , Ilove .Net"; // created in new memory


            // How to Avoid This?  -> using string builder


            StringBuilder sb = new(); // include System.Text;

            Console.WriteLine("Length = " + sb.Length);
            Console.WriteLine("Capacity = " + sb.Capacity);
            Console.WriteLine("MaxCapacity = " + sb.MaxCapacity); // around 4 GB 

            sb.Append("Hello, world!");
            sb.Append("\tI Love .Net ");
            sb.Append("community ");

            Console.WriteLine(sb.ToString());






            */




            /*  ********  Constants  & Read-Only Variables   */


            /*

             * const: A compile-time constant. Must be assigned at declaration and cannot change later.
             * 
             * readonly: A runtime constant. Can be assigned at declaration or in the constructor, but not changed after.
             * 
             * const is implicitly static and shared across all instances.
             * 
             * Use const for fixed values (Pi, days ...), and readonly for values set during object creation.
             * 
             * readonly supports reference types and values known only at runtime.
             * 
             * we can modify the readonly variables only in ***cunstractor ****

              */


            /*

                * Compile-time: When the code is being **translated** into machine code by the compiler.
                * The compiler checks for syntax errors and sets fixed values like const.
                *
                * Run-time: When the program is actually **running** on your computer.
                * The program creates objects, takes input, and can assign readonly values.

             */





            /*  **************  ref    &  out  Keywords   **************  */


            /*
                * ref: Passes a variable by reference. The variable must be initialized before passing.
                * out: Also passes by reference, but the variable does NOT need to be initialized before.
                *
                * Both allow a method to modify the original variable outside the method.
                *
                * Key difference:
                * - ref: The caller MUST initialize the variable before passing.
                * - out: The method MUST assign a value before returning.
             */




            // TestRef();

            // TestOut();


            /* Example    */


            /*

            Console.Write("Enter a number :  ");

            bool isSuccessful = int.TryParse(Console.ReadLine(), out int num);  


            Console.WriteLine($"is Successful : {isSuccessful}");

            Console.WriteLine($"num = {num}");


            */








            /* **************  Exceptions **************   */


            /* 

            try
            {
                Console.WriteLine(Divide(10, 2));
                Console.WriteLine(Divide(5, 0));

            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(ex.Message); // Attempted to divide by zero.

                Console.WriteLine(ex.ToString()); // stack trace   good practice

                Console.ForegroundColor = ConsoleColor.White;

            }

            finally
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("\nFinally I'm Done ");

                Console.ForegroundColor = ConsoleColor.White;

            }



            */


            /* 

            try
            {
                Console.WriteLine("Please Enter a 5 characters string : ");
                var input = Console.ReadLine();

                if (input.Length != 5)
                    throw new Exception("String must be 5 characteres long");

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;


                Console.WriteLine(ex.ToString()); // stack trace   good practice

                Console.ForegroundColor = ConsoleColor.White;
            }
            
            */




            /*  *********   Enums  ********* */


            /*  
             
            Console.WriteLine("Print enums Values : \n");

            foreach (var color in Enum.GetNames(typeof(Color)))
            {
                Console.WriteLine($"{color} = {(int)Enum.Parse(typeof(Color), color)}");
            }

            Console.WriteLine("\n\nPractice Allow user to change console backround & foreground colors : \n");

            while (true)
            {
                Console.WriteLine("Please Enter an Option : ");
                Console.WriteLine("[1] Change Background Color\n[2] Change Fpreground Color");

                string userOption = Console.ReadLine();

                foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                {
                    Console.WriteLine($"{color}");
                }

                Console.WriteLine("Please Enter Color Name : ");

                string ColorName = Console.ReadLine();

                ConsoleColor SelectedColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ColorName, true); // true : ignore case 

                if (userOption == "1")
                    Console.BackgroundColor = SelectedColor;

                else if (userOption == "2")
                    Console.ForegroundColor = SelectedColor;

                else
                    Console.WriteLine("Invalid Option ");

            }



            */


            /* **************** File System Command Line    **************** */


            while (true)
            {
                Console.WriteLine(">>  ");
                var input = Console.ReadLine().Trim();

                var whiteSpace = input.IndexOf(' ');

                var command = input.Substring(0, whiteSpace);

                var path = input.Substring(whiteSpace + 1).Trim();

                //Console.WriteLine($"Command = {command}\nPath = {path}");

                if (command == "list")
                {
                    foreach (var entry in Directory.GetDirectories(path))
                        Console.WriteLine("\t[Dir ] : {0}", entry);

                    foreach (var entry in Directory.GetFiles(path))
                        Console.WriteLine("\t[Files ] : {0}", entry);

                }
                else if (command == "info")
                {
                    if (Directory.Exists(path))
                    {
                        var dirinfo = new DirectoryInfo(path);

                        Console.WriteLine("Type : Directory");
                        Console.WriteLine($"Created At : {dirinfo.CreationTime}");
                        Console.WriteLine($"Last Modified At : {dirinfo.LastWriteTime}");
                    }
                    else if (File.Exists(path))
                    {
                        var fileInfo = new FileInfo(path);

                        Console.WriteLine("Type : File");
                        Console.WriteLine($"Created At : {fileInfo.CreationTime}");
                        Console.WriteLine($"Last Modified At : {fileInfo.LastWriteTime}");
                        Console.WriteLine($"Size : {fileInfo.Length}");

                    }

                    else
                        Console.WriteLine("no such file or directory :  {0}", path);
                }
                else if (command == "mkdir")
                {
                    Directory.CreateDirectory(path);
                }
                else if (command == "rm")
                {
                    if (Directory.Exists(path))
                        Directory.Delete(path, true); // true delete the folder contents

                    else if (File.Exists(path))
                        File.Delete(path);

                }
                if (command == "print")
                {
                    if (File.Exists(path))
                    {
                        var content = File.ReadAllText(path);

                        Console.WriteLine(content);
                        // appand write .... 
                    }
                }
                else if (command == "exit")
                {
                    break;
                }


            }






            Console.ReadKey();

        }


        // Enums


        public enum Color
        {
            Red,
            Green,
            Yellow
        }



        //  Exceptions



        static int Divide(int nb, int div)
        {
            return nb / div;
        }




        //  ref    &  out  Keywords



        static void TestRef()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            bool isSuccessful = true;

            var result = Divideref(10, 0, ref isSuccessful);

            Console.WriteLine($"is Successful : {isSuccessful}");
            Console.WriteLine($"result  : {result}");

        }

        static double Divideref (double number, double divisor, ref bool isSuccessful)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can't divide on Zero !");
                isSuccessful = false;
                return 0;
            }

            isSuccessful = true;
            return number / divisor;
        }



        static void TestOut()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            bool isSuccessful = true;

            var result = DivideOut(10, 0, out isSuccessful);

            Console.WriteLine($"is Successful : {isSuccessful}");
            Console.WriteLine($"result  : {result}");

        }

        static double DivideOut(double number, double divisor, out bool isSuccessful)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can't divide on Zero !");
                isSuccessful = false;
                return 0;
            }

            isSuccessful = true;
            return number / divisor;
        }





        // constant

        public const string MyConstVar = "hello";

        public const int Myschool = 1337;


        // ReadOnly Variables 

        private readonly string _message = "Hello world";


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

