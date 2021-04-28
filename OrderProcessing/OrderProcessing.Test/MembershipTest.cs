using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrderProcessing.Core;
using OrderProcessing.Core.PackingSlipGenerator;
using OrderProcessing.Implementation;
using OrderProcessing.Interfaces;
using OrderProcessing.ProductTypeInterfaces;
using System;
using System.IO;
using Xunit;

namespace OrderProcessing.Test
{
    [TestClass]
    public class MembershipProductTest
    {

        private readonly Mock<INotificationService> notificationServiceMock;
        private MembershipProcessor membershipProductProcessor;

        public MembershipProductTest()
        {
            notificationServiceMock = new Mock<INotificationService>();
            membershipProductProcessor = new MembershipProcessor(notificationServiceMock.Object, MembershipType.Basic);
        }

        [TestMethod]
        public void MembershipProductTest_ValidateConstructor()
        {
            Assert.IsNotNull(membershipProductProcessor);
        }

        [TestMethod]
        public void Validate_Basic_ActivateMembership_Processing()
        {

            membershipProductProcessor.ActivateMemberShip(MembershipType.Basic);

            this.notificationServiceMock.Setup(x => x.SendNotification(It.IsAny<string>())).Verifiable();
            this.notificationServiceMock.Verify(x => x.SendNotification(It.IsAny<string>()), Times.Exactly(1));
        }

        [TestMethod]
        public void Validate_Premium_ActivateMembership_Processing()
        {
            membershipProductProcessor.ActivateMemberShip(MembershipType.Premium);

            this.notificationServiceMock.Setup(x => x.SendNotification(It.IsAny<string>())).Verifiable();
            this.notificationServiceMock.Verify(x => x.SendNotification(It.IsAny<string>()), Times.Exactly(1));
        }
    }
}
