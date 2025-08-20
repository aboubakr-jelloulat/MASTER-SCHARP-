using System;
using System.Collections.Generic;

namespace Advanced_Csharp._03_Delegates
{


    public class clsIntroToDdelegate
    {

        delegate void GreetDelegate(string name);


        static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }


        static void SayHej(string name)
        {
            Console.WriteLine("Hej " + name);
        }


        static void SayBonjour(string name)
        {
            Console.WriteLine($"Bonjour {name}");
        }

        public static void IntroToDdelegate()
        {
            GreetDelegate dlg = SayHello;

            dlg("Aboubakr");

            dlg = SayHej;

            dlg("Finaceiz");

            dlg = SayBonjour;

            dlg("Froncoi");


        }


    }


    public class Employee
    {

        delegate bool ShouldCalculate(Employee employees);
        public string Name { get; set; }
        public int BasicsSalary { get; set; }
        public int Deductions { get; set; }
        public int Bonus { get; set; }

        private static void DisplayEmployees(List<Employee> employees, ShouldCalculate predicate)
        {
            foreach (var item in employees)
            {
                if (predicate(item))
                {
                    var result = item.BasicsSalary + item.Bonus - item.Deductions;

                    Console.WriteLine($"Basics Salary For Employees [{item.Name}]  =  {item.BasicsSalary}");

                }
            }
        }
        public static void AnyThings()
        {
            Random rnd = new Random();
            var employees = new List<Employee>();

            for (int i = 1; i <= 50; i++)
            {
                employees.Add(new Employee
                {
                    Name = $"Employee {i}",
                    BasicsSalary = rnd.Next(1000, 5001),
                    Deductions = rnd.Next(0, 501),
                    Bonus = rnd.Next(0, 101)
                });
            }

            DisplayEmployees(employees, e => e.BasicsSalary <= 2000);
        }
    }


    public class Delegates
    {

        /* 
            You want to call someone to do a job for you. But you don’t want to decide which person right now—you just want to say “Whoever I give this phone number to, they’ll do the job later.”
              That phone number is like a delegate. It points to a method (a person).
            
         */


       /* 
          A delegate is like a pointer to a function.
        */



        public delegate int CalculateDelegate(int nb1, int nb2);

        public void MulticastingDelegate()
        {
            int nb1 = 10, nb2 = 5;

            CalculateDelegate dlg = sum;
            dlg += sub;
            dlg += mul;
            dlg += div;

            Console.WriteLine("Invoking multicast delegate:");
            int result = dlg(nb1, nb2); // All methods execute, but only last result is returned
            Console.WriteLine($"Final returned result = {result}");

            // Remove a method from the invocation list
            dlg -= div;

            Console.WriteLine("\nAfter removing div :");
            result = dlg(nb1, nb2);
            Console.WriteLine($"Final returned result = {result}");
        }

        public void TestClaculate()
        {
            int nb1 = 10, nb2 = 2;

            // Using a named method (method group reference)
            Calculate(nb1, nb2, sum);

            // Using an anonymous method (older syntax, introduced in C# 2.0)
            Calculate(nb1, nb2, delegate (int n1, int n2) { return n1 - n2; });

            // Using a lambda expression (modern, concise style)
            Calculate(nb1, nb2, (int num1, int num2) => num1 * num2);

            // Using a lambda expression with type inference (best practice)
            Calculate(nb1, nb2, (x, y) => x / y);
        }

        public void Calculate(int nb1, int nb2, CalculateDelegate dlg)
        {
            int result = dlg(nb1, nb2);
            Console.WriteLine($"Result = {result}");
        }

        // Named methods that match the delegate signature

        int sum(int nb1, int nb2)
        {
            int result = nb1 + nb2;
            Console.WriteLine($"{nb1} + {nb2} = {result}");
            return result;
        }

        int sub(int nb1, int nb2)
        {
            int result = nb1 - nb2;
            Console.WriteLine($"{nb1} - {nb2} = {result}");
            return result;
        }

        int mul(int nb1, int nb2)
        {
            int result = nb1 * nb2;
            Console.WriteLine($"{nb1} * {nb2} = {result}");
            return result;
        }

        int div(int nb1, int nb2)
        {
            int result = nb1 / nb2;
            Console.WriteLine($"{nb1} / {nb2} = {result}");
            return result;
        }
    }
}
