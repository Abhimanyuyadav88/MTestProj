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

        /// <summary>
        /// The processing physical order
        /// </summary>
        public const string ProcessingPhysicalOrder = "Processing Physical product order";

        /// <summary>
        /// The processing physical order
        /// </summary>
        public const string ProcessingMemberShipOrder = "Processing Membership product order";

        /// <summary>
        /// The processing physical order
        /// </summary>
        public const string ProcessingVideoOrder = "Processing video product order";

        /// <summary>
        /// The processing physical book order
        /// </summary>
        public const string ProcessingPhysicalBookOrder = "Processing Physical book order";

        /// <summary>
        /// The pay commision to agent
        /// </summary>
        public const string PayCommisionToAgent = "Payment for agent commision {0} percentage";

        /// <summary>
        /// The basic membership activated
        /// </summary>
        public const string BasicMembershipActivated = "Basic membership activated";

        /// <summary>
        /// The premium membership activated
        /// </summary>
        public const string PremiumMembershipActivated = "Premium membership activated";

        /// <summary>
        /// The dummy email for processing
        /// </summary>
        public const string DummyEmailForProcessing = "abc@abc.com";

        /// <summary>
        /// The video first aid free
        /// </summary>
        public const string VideoFirstAidFree = "Added first Aid free to packing slip";

        /// <summary>
        /// The video other than learning to ski
        /// </summary>
        public const string VideoOtherThanLearningToSki = "Video other than Learning to ski processed";

        /// <summary>
        /// The options
        /// </summary>
        public const string ProductOptions = "Press 1 to process PhysicalPayment.\nPress 2 to process Book payment. \nPress 3 to process basic MemeberShipPayment.Press 4 to process Premium Membership payment.\nPress 5 to process LearningToSkiVideo. \nPress 6 to process OtherVideo.,\nPress -1 to Quit.\n";
    }
}
