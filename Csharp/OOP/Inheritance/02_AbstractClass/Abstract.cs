using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance._02_AbstractClass
{

    /*
     
        The abstract keyword is used for classes and methods:

        *** Abstract class: is a restricted class that cannot be used to create objects     (to  access it, it must be inherited from another class).

        *** Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).



    */





    public abstract class AbsPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected string Department { get; set; }


        public abstract void WhoAmi();


        public  AbsPerson(string FirstName, string LastName, string Department)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Department = Department;

        }

        public void hej()
        {
            Console.WriteLine("Hej! I'm Person Class");
        }


    }


    public class AbsStudent : AbsPerson
    {

        public AbsStudent(string FirstName, string LastName, string Department) : base (FirstName, LastName, Department)
        {

        }

        public override void WhoAmi()
        {
            Console.WriteLine($"Hey im {FirstName} - {LastName} im Study {Department}");
        }

    }

}
