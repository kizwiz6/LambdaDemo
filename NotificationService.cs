using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    /// <summary>
    /// this class implements both methods, but a client that only needs to send email notifications doesn't have to depend on the unnecessary SendSms method
    /// </summary>
    class NotificationService : INotificationService
    {
        public void SendEmail(string email, string message)
        {
            // send an email
        }

        public void SendSms(string phone, string message)
        {
            // send an SMS
        }
    }
}
