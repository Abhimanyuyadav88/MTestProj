using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Models
{
    /// <summary>
    /// Membership Order request
    /// </summary>
    /// <seealso cref="OrderProcessing.Models.OrderRequest" />
    public class MembershipRequestModel : OrderRequest
    {
        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email identifier.
        /// </value>
        public string EmailId { get; set; }
    }
}
