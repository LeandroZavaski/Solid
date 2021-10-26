using Lsp.Payments;
using System;

// Liskov Substitution Principle
namespace Lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var card = new CreditCard();
            //var card = new DebitCard();
            NubankRewards card = new NubankRewards();

            card.Validate();
            card.CollectPayment();

            Console.ReadLine();
        }
    }
}
