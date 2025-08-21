using Advanced_Csharp._03_Delegates;
using System;
using System.Collections.Generic;

namespace Advanced_Csharp._04_Events
{
    public class SalaryCalculator
    {
        public delegate bool ShouldCalculate(Employee employee);

        public event EmployeeCalculatedEventHandler EmployeeSalaryCalculated;

        public delegate void EmployeeCalculatedEventHandler(Employee employee, int salary);

        public  void CalculateSalary(List<Employee> employees, ShouldCalculate predicate)
        {
            foreach (var item in employees)
            {
                if (predicate(item))
                {
                    var salary = item.BasicsSalary + item.Bonus - item.Deductions;


                    EmployeeSalaryCalculated?.Invoke(item, salary);
                }
            }
        }
    }
}
