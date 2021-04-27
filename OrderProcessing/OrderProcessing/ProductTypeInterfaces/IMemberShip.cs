using OrderProcessing.Interfaces;
using OrderProcessing.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace OrderProcessing.ProductTypeInterfaces
{
    /// <summary>
    /// Membership request model
    /// </summary>
    /// <seealso cref="OrderProcessing.Interfaces.IPostOrderProcessing" />
    public interface IMemberShip : IPostOrderProcessing
    {
        /// <summary>
        /// Activates the member ship.
        /// </summary>
        /// <param name="request">The request.</param>
        void ActivateMemberShip(MembershipRequestModel request);
    }
}
