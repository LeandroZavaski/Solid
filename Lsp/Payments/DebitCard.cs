using System;

namespace Lsp.Payments
{
    public class DebitCard : NubankCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando saldo...");
            Console.WriteLine("Saldo disponivel!");
        }
    }
}
