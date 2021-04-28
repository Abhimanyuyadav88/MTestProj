using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrderProcessing.Core;
using OrderProcessing.Core.PackingSlipGenerator;
using OrderProcessing.Implementation;
using System.IO;

namespace OrderProcessing.Test
{
    [TestClass]
    public class BookTest
    {
        private readonly Mock<IPackingSlipGenerator> packingSlipGeneratorMock;
        private PhysicalProductProcessor bookProductProcessor;

        public BookTest()
        {
            packingSlipGeneratorMock = new Mock<IPackingSlipGenerator>();
            bookProductProcessor = new PhysicalProductProcessor(packingSlipGeneratorMock.Object);          
        }

        [TestMethod]
        public void BookTest_ValidateConstructor()
        {
            Assert.IsNotNull(bookProductProcessor);
        }

        [TestMethod]
        public void PhysicalProduct_ValidatePhysicalProduct_GenerateSlip_Processing()
        {
           
            bookProductProcessor.GeneratePackingSlipForShipping();

           this.packingSlipGeneratorMock.Setup(x => x.GeneratePackingSlip(It.IsAny<PackingSlipType>())).Verifiable();
            this.packingSlipGeneratorMock.Verify(x => x.GeneratePackingSlip(It.IsAny<PackingSlipType>()), Times.Exactly(1));
        }        
    }
}
