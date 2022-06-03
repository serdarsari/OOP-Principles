using System;

namespace InterfaceAndPolymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS.");
        }
    }
}
