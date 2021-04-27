using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Core.PackingSlipGenerator
{
    public class PackingSlipGenerator : IPackingSlipGenerator
    {
        public void GeneratePackingSlip(PackingSlipType packingSlipType)
        {
            if (packingSlipType == PackingSlipType.Shipping)
            {
                Console.WriteLine(Constants.PackingSlipGenerated);
            }

            if (packingSlipType == PackingSlipType.Royalty)
            {
                Console.WriteLine(Constants.RoyaltySlipGenerated);
            }
        }
    }
}
