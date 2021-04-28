using OrderProcessing.Core;
using OrderProcessing.Core.PackingSlipGenerator;
using OrderProcessing.ProductTypeInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    /// <summary>
    /// Process Book Product
    /// </summary>
    /// <seealso cref="OrderProcessing.ProductTypeInterfaces.IBook" />
    public class BookProcessing : IBook
    {
        /// <summary>
        /// The packing slip generator
        /// </summary>
        private IPackingSlipGenerator packingSlipGenerator;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookProcessing"/> class.
        /// </summary>
        /// <param name="slipGenerator">The slip generator.</param>
        public BookProcessing(IPackingSlipGenerator slipGenerator)
        {
            packingSlipGenerator = slipGenerator;
        }

        /// <summary>
        /// If the payment is for a book, create a duplicate packing slip for the royalty department
        /// </summary>
        /// <param name="OrderId">The order identifier.</param>
        public void CreateDuplicatePackingSlip()
        {
            packingSlipGenerator.GeneratePackingSlip(Core.PackingSlipType.Shipping);
        }

        /// <summary>
        /// Generates the packing slip for shipping.
        /// </summary>
        public void GeneratePackingSlipForShipping()
        {
            packingSlipGenerator.GeneratePackingSlip(Core.PackingSlipType.Royalty);
        }

        public void PayAgentCommisionPayment(int commisionPercentage)
        {
            Console.WriteLine(Constants.PayCommisionToAgent, commisionPercentage);
        }

        public void PostOrderProcessing()
        {
            Console.WriteLine(Constants.ProcessingPhysicalBookOrder);
            GeneratePackingSlipForShipping();
            CreateDuplicatePackingSlip();
            PayAgentCommisionPayment(2); // 2% commision to agent
        }
    }
}
