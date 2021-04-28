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

                //Select template based on membership type and get emailId from request
                notificationService.SendNotification(Constants.DummyEmailForProcessing);
            }

            if (membershipType == MembershipType.Premium)
            {
                Console.WriteLine(Constants.PremiumMembershipActivated);
                //Select template based on membership type and get emailId from request
                notificationService.SendNotification(Constants.DummyEmailForProcessing);
            }
        }

        public void PostOrderProcessing()
        {
            Console.WriteLine(Constants.ProcessingMemberShipOrder);
            ActivateMemberShip(membershipType);
        }
    }
}
