using OrderProcessing.Core;
using OrderProcessing.Interfaces;
using OrderProcessing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ProductTypeInterfaces
{
    /// <summary>
    /// IPhysical Product Interface
    /// </summary>
    /// <seealso cref="OrderProcessing.Interfaces.IPostOrderProcessing" />
    public interface IPhysicalProduct : IPostOrderProcessing
    {
        /// <summary>
        /// Generates the packing slip for shipping.
        /// </summary>
        void GeneratePackingSlipForShipping();

        /// <summary>
        /// Pays the commision payment.
        /// </summary>
        /// <param name="commisionPercentage">The commision percentage.</param>
        void PayAgentCommisionPayment(int commisionPercentage);
    }
}
