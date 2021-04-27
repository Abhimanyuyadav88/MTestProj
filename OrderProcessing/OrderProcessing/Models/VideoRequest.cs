using OrderProcessing.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Models
{
    /// <summary>
    /// Video request
    /// </summary>
    /// <seealso cref="OrderProcessing.Models.OrderRequest" />
    public class VideoRequest : OrderRequest
    {
        /// <summary>
        /// Gets or sets the email identifier.
        /// </summary>
        /// <value>
        /// The email identifier.
        /// </value>
        public string  EmailId { get; set; }

        /// <summary>
        /// Gets or sets the type of the video.
        /// </summary>
        /// <value>
        /// The type of the video.
        /// </value>
        public VideoType VideoType { get; set; }
    }
}
