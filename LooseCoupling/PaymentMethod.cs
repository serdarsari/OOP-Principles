using System;

namespace LooseCoupling
{
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
}