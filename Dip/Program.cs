using Dip.Payment;
using System;

// Dependency Inversion Principle
namespace Dip
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess payment = new PaymentProcess();
            payment.Pay("ABC123");

            Console.ReadLine();
        }
    }
}
