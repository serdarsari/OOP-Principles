using System.Collections.Generic;

namespace InterfaceAndPolymorphism
{

    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;
        //Çalışma zamanında farklı yerlerden, AYNI anda bildirim göndermek istediğimizi varsayıyoruz.
        //Bu yüzden generic list olarak tanımladık.
        //enumerate ederek üye olan kanallara bildirim gönderilecek.

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            foreach (INotificationChannel channel in _notificationChannels)     //burada üye olan channel'ları gezerek Send metodunu çalıştırıyoruz.
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel notificationChannel)
        {
            _notificationChannels.Add(notificationChannel);     //Channel'a yeni bir notification yöntemi eklemek istediğimizde kullanacağımız metot.
        }
    }
}
