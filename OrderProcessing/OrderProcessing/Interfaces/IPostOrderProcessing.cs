using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Interfaces
{   
    /// <summary>
    /// Interface Post Order Processing 
    /// </summary>
    public interface IPostOrderProcessing
    {
        /// <summary>
        /// Process Order
        /// </summary>
        public void PostOrderProcessing();
    }
}
