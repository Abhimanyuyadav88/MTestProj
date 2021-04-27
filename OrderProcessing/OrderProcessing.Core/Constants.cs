using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Core
{
    /// <summary>
    /// Constant class
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The email notification text
        /// </summary>
        public const string EmailNotificationText = "Email Notification Sent to {0}";

        /// <summary>
        /// The packing slip generated
        /// </summary>
        public const string PackingSlipGenerated = "Packing slip generated for shipping";

        /// <summary>
        /// The royalty slip generated
        /// </summary>
        public const string RoyaltySlipGenerated = "Duplicate packing slip created for Royalty department";
    }
}
