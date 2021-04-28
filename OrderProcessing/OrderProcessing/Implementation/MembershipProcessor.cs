using OrderProcessing.Core;
using OrderProcessing.ProductTypeInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class MembershipProcessor : IMembership
    {
        private INotificationService notificationService { get; set; }
        private MembershipType membershipType { get; set; }

        public MembershipProcessor(INotificationService notification, MembershipType memType)
        {
            notificationService = notification;
            membershipType = memType;
        }

        public void ActivateMemberShip(MembershipType membershipType)
        {
            if (membershipType == MembershipType.Basic)
            {
                Console.WriteLine(Constants.BasicMembershipActivated);
            }

            if (membershipType == MembershipType.Premium)
            {
                Console.WriteLine(Constants.PremiumMembershipActivated);
            }
        }

        public void PostOrderProcessing()
        {
            Console.WriteLine(Constants.ProcessingMemberShipOrder);
            ActivateMemberShip(membershipType);
            //Capture emailId from request and validate it
            notificationService.SendNotification(Constants.DummyEmailForProcessing);
        }
    }
}
