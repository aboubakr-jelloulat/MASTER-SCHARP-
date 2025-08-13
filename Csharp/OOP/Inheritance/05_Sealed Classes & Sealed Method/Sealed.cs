using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance._05_Sealed_Classes___Sealed_Method
{
    /*
	    In C#, when we don't want a class to be inherited by another class, we can declare the class as a sealed class.
    */

    public sealed class CreditCardProcessor // A sealed class is a class that cannot be inherited.
    {
        public void ProcessPayment(string cardNumber, double amount)
        {
            Console.WriteLine($"Processing payment of ${amount} with card: {cardNumber}");
        }
    }


    // ❌ Error: cannot derive from sealed type 'CreditCardProcessor'

    public class MyFakeProcessor // : CreditCardProcessor
    {
        // not allowed
    }


    /* ***** [ Sealed Methode  ] **********   */




    /*
	🔐 What is a Sealed Method in C#?
		A sealed method is a method that cannot be overridden again in a derived class.

		🔸 You can only seal a method that overrides a method from a base class.
		🔸 You do this using the sealed keyword in combination with override.
    */



    public class Transport
    {
        public virtual void Drive()
        {
            Console.WriteLine("Generic transport is moving...");
        }
    }

    public class Car : Transport
    {
        public sealed override void Drive()
        {
            Console.WriteLine("Car is driving with GPS assistance...");
        }
    }


    public class Tesla : Car
    {
        // Error: cannot override sealed member 'Car.Drive()'
        // public override void Drive()
        // {
        //     Console.WriteLine("Tesla is driving itself...");
        // }
    }






}
