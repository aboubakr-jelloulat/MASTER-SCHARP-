using System;
using System.Threading.Tasks;

namespace Advanced_Csharp._07_Enumerables
{
    public class Enumerables
    {

        public static async Task TestEnumerables()
        {
            var employee = new Employee();

            employee.AddPayItem("Basics Salary", 1000);
            employee.AddPayItem("Housing", 500);
            employee.AddPayItem("Transportation", 200);
            employee.AddPayItem("Insurance", 300);

        }

    }
}
