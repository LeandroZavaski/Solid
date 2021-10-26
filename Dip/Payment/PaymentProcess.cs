using Dip.Factory;
using Dip.Model;
using System;

namespace Dip.Payment
{
    public class PaymentProcess
    {
        public void Pay(string id)
        {
            IDbProduct product = DbProductFactory.Create();
            var productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}
