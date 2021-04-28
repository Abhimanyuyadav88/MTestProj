using OrderProcessing.Core;
using OrderProcessing.Core.PackingSlipGenerator;
using OrderProcessing.Models;
using OrderProcessing.ProductTypeInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class PhysicalProduct : IPhysicalProduct
    {
        private IPackingSlipGenerator packingSlipGenerator;

        public PhysicalProduct(IPackingSlipGenerator slipGenerator)
        {
            packingSlipGenerator = slipGenerator;
        }

        /// <summary>
        /// If the payment is for a physical product, generate a packing slip for shipping.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void GeneratePackingSlipForShipping()
        {
            packingSlipGenerator.GeneratePackingSlip(PackingSlipType.Shipping);
        }


        /// <summary>
        /// Pays the commision payment.
        /// </summary>
        /// <param name="commisionPercentage">The commision percentage.</param>
        public void PayAgentCommisionPayment(int commisionPercentage)
        {
            Console.WriteLine(Constants.PayCommisionToAgent, commisionPercentage);
        }

        /// <summary>
        /// Process Order for physical payment
        /// </summary>
        public void PostOrderProcessing()
        {
            Console.WriteLine(Constants.ProcessingPhysicalOrder);
            GeneratePackingSlipForShipping();
            PayAgentCommisionPayment(2); // 2% commision to agent
        }


    }
}
