using System;

namespace LooseCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentMethod pm = new CreditCard();
            pm.Pay(50);

            pm = new SMS();
            pm.Pay(20);

            pm = new PayPal();
            pm.Pay(100);
        }
    }
}
