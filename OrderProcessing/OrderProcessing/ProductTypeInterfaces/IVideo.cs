using OrderProcessing.Core;
using OrderProcessing.Interfaces;
using OrderProcessing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ProductTypeInterfaces
{
    /// <summary>
    /// Video Interface
    /// </summary>
    /// <seealso cref="OrderProcessing.Interfaces.IPostOrderProcessing" />
    public interface IVideo : IPostOrderProcessing
    {
        /// <summary>
        /// Adds the free first aid video.
        /// </summary>
        /// <param name="videoType">Type of the video.</param>
        void AddFreeFirstAidVideo(VideoType videoType);
    }   
}
