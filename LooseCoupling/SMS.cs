using System;

namespace LooseCoupling
{
    public class SMS : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine("Payment completed with SMS.");
        }
    }
}