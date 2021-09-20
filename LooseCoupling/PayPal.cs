using System;

namespace LooseCoupling
{
    public class PayPal : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Payment completed with PayPal.");
        }
    }
}