using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeThiMinhTuoi_2231200122_Lab2.Q7
{
    internal class NotificationService
    {
        public virtual void SendNotification(string message)
        {
            Console.WriteLine($"[Notification] {message}");
        }

        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"[To {recipient}] {message}");
        }

        public void SendNotification(string message, List<string> recipients)
        {
            Console.WriteLine($"[Broadcast to {recipients.Count} recipients] {message}");
        }
    }
}
