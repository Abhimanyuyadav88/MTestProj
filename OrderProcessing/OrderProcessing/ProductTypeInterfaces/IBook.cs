using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ProductTypeInterfaces
{
    /// <summary>
    /// Interface IBook Processing
    /// </summary>
    /// <seealso cref="OrderProcessing.ProductTypeInterfaces.IPhysicalProduct" />
    public interface IBook : IPhysicalProduct
    {
        /// <summary>
        /// If the payment is for a book, create a duplicate packing slip for the royalty department
        /// </summary>  
        void CreateDuplicatePackingSlip();
    }
}
