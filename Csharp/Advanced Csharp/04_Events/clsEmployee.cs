using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csharp._04_Events
{
    public class Employee
    {

        delegate bool ShouldCalculate(Employee employees);
        public string Name { get; set; }
        public int BasicsSalary { get; set; }
        public int Deductions { get; set; }
        public int Bonus { get; set; }

    
    }

}
