using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeThiMinhTuoi_2231200122_Lab2.Q7
{
    internal class AdvancedNotificationService : NotificationService
    {
        public override void SendNotification(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss") + $"[Notification] { message}";
            string priority = "[Highest Priority]";

            Console.WriteLine($"{priority} {timestamp}");
        }
    }
}
