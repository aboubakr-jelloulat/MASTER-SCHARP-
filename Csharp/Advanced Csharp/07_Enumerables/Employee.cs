using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csharp._07_Enumerables
{
    public class Employee
    {
        private readonly List<PayItem> _payItems = new List<PayItem>();

        public string Name { get; set; }


        public  void AddPayItem(string name, int value)
        {
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentException("Name is Null or Empty");

            _payItems.Add(new PayItem {Name = name , Value = value});
        }



    }
}
