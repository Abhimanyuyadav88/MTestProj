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
    public class PhysicalProductTest
    {
        private readonly Mock<IPackingSlipGenerator> packingSlipGeneratorMock;
        private PhysicalProductProcessor physicalProductProcessor;

        public PhysicalProductTest()
        {
            packingSlipGeneratorMock = new Mock<IPackingSlipGenerator>();
            physicalProductProcessor = new PhysicalProductProcessor(packingSlipGeneratorMock.Object);
        }

        [TestMethod]
        public void PhysicalProduct_ValidateConstructor()
        {
            Assert.IsNotNull(physicalProductProcessor);
        }

        [TestMethod]
        public void PhysicalProduct_ValidatePhysicalProduct_GenerateSlip_Processing()
        {

            physicalProductProcessor.GeneratePackingSlipForShipping();

            this.packingSlipGeneratorMock.Setup(x => x.GeneratePackingSlip(It.IsAny<PackingSlipType>())).Verifiable();
            this.packingSlipGeneratorMock.Verify(x => x.GeneratePackingSlip(It.IsAny<PackingSlipType>()), Times.Exactly(1));
        }
    }
}
