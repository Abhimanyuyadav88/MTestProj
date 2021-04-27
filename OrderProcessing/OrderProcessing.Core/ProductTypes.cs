using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Core
{
    /// <summary>
    /// Product Types
    /// </summary>
    public enum ProductTypes
    {
        PhysicalProduct = 1,
        Book = 2,
        Membership = 3,
        UpgradeMembership = 4,
        Video = 5
    }

    /// <summary>
    /// Video type
    /// </summary>
    public enum VideoType
    {
        LearningToSki = 1,
        Others = 2
    }

    /// <summary>
    /// Packing slip type
    /// </summary>
    public enum PackingSlipType
    {
        Shipping = 1,
        Royalty = 2
    }
}
