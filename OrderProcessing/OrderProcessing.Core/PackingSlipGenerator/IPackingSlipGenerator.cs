using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Core.PackingSlipGenerator
{
    /// <summary>
    /// IPacking slip generator
    /// </summary>
    public interface IPackingSlipGenerator
    {
        /// <summary>
        /// Generates the packing slip.
        /// </summary>
        /// <param name="packingSlipType">Type of the packing slip.</param>
        void GeneratePackingSlip(PackingSlipType packingSlipType);
    }
}
