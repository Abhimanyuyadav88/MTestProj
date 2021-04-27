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
        /// If the payment is for a physical product, generate a packing slip for shipping.
        /// </summary>
        /// <param name="request">The request.</param>
        void GeneratePackingSlipForShipping(PhysicalProductRequestModel request);
    }
}
