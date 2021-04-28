using OrderProcessing.Core;
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
    public interface IMembership : IPostOrderProcessing
    {
        /// <summary>
        /// Activates the member ship.
        /// </summary>
        /// <param name="membershipType">Type of the membership.</param>
        void ActivateMemberShip(MembershipType membershipType);
    }
}
