using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance._00_Declaration
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        protected decimal Salary { get; set; }

        private int Age { get; set; }

        public Person(int id, string firstName, decimal salary, int age)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.Salary = salary;
            this.Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {FirstName}");
        }
    }

    public class Student : Person
    {
        public string ClassName { get; set; }

        public Student(int id, string firstName, decimal salary, int age, string className) : base(id, firstName, salary, age) // Call Person constructor
        {
            ClassName = className;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {FirstName}, Class: {ClassName}");

            Console.WriteLine($"Salary: {Salary}");

        }
    }

    

}
