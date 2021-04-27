using OrderProcessing.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Models
{
    /// <summary>
    /// Order Request
    /// </summary>
    public class OrderRequest
    {
        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>
        /// The order identifier.
        /// </value>
        public Guid OrderId => new Guid();

        /// <summary>
        /// Gets or sets the type of the product.
        /// </summary>
        /// <value>
        /// The type of the product.
        /// </value>
        public ProductTypes ProductType { get; set; }
    }
}
