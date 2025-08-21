using System;
using System.Collections.Generic;

namespace Advanced_Csharp._04_Events
{
    public class clsEvents
    {
        public static void TestEvents()
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



            var calculator = new SalaryCalculator();

            calculator.EmployeeSalaryCalculated += Calculator_EmployeeSalaryCalculated;
            calculator.EmployeeSalaryCalculated += (employee, salary) => Console.WriteLine($"\n*** *** Payslip Sent to Employee {employee.Name}*** *** \n");
            calculator.CalculateSalary(employees, e => e.BasicsSalary > 2000);
        }

        private static void Calculator_EmployeeSalaryCalculated(Employee employee, int salary)
        {
            Console.WriteLine($"Salary for Employee [ {employee.Name} ]  = [ {salary} ]");
        }
    }

}
