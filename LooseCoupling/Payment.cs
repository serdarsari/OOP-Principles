using System;

namespace LooseCoupling
{
    public class Payment
    {
        private readonly IPaymentMethod _paymentMethod;

        public Payment(IPaymentMethod paymentMethod = null)
        {
            _paymentMethod = paymentMethod;
        }

        public void Pay(decimal amount)
        {
            _paymentMethod.Pay(amount);
        }
    }
}