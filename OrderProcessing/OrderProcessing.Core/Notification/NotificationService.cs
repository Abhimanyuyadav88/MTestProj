using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Core
{
    /// <summary>
    /// Notification service
    /// </summary>
    /// <seealso cref="OrderProcessing.Core.INotificationService" />
    public class NotificationService : INotificationService
    {
        /// <summary>
        /// Sends the notification.
        /// </summary>
        /// <param name="emailId">The email identifier.</param>
        public void SendNotification(string emailId)
        {
            Console.WriteLine(Constants.EmailNotificationText, emailId);
        }
    }
}
