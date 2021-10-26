using System;

namespace Lsp.Payments
{
    public class CreditCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando limite...");
            Console.WriteLine("Limite Ok!");
        }
    }
}
