using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    /// <summary>
    /// Interface Segregation Principle - clients should not be forced to depend on interfaces they don't use
    /// </summary>
    interface INotificationService
    {
        void SendEmail(string email, string message);
        void SendSms(string phone, string message);
    }
}
