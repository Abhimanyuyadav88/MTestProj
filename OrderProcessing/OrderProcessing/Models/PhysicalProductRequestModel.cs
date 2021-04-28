using OrderProcessing.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Models
{
    public class PhysicalProductRequestModel : OrderRequest
    {
        public PackingSlipType PackingSlipType { get; set; }
    }
}
