using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Core
{
    /// <summary>
    /// INotification Service
    /// </summary>
    public interface INotificationService
    {
        /// <summary>
        /// Sends the notification.
        /// </summary>
        /// <param name="emailId">The email identifier.</param>
        void SendNotification(string emailId);
    }
}
