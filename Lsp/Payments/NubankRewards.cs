using System;
using System.Collections.Generic;
using System.Text;

namespace Lsp.Payments
{
    public class NubankRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
            Console.WriteLine("Pontuação creditada!");
        }

        public void Validate()
        {
            Console.WriteLine("Limite OK, Rewards Ok!");
        }
    }
}
