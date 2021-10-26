using System;

namespace Lsp.Payments
{
    public abstract class NubankCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento Realizado!");
        }

        public virtual void Validate()
        {
            // Validação básica cartão
        }
    }
}
