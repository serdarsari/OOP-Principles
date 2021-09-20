using System;

namespace LooseCoupling
{
    public class CreditCard : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Payment completed with Credit Card.");
        }
    }
}