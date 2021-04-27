using OrderProcessing.Interfaces;
using OrderProcessing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.ProductTypeInterfaces
{    
    public interface IVideo : IPostOrderProcessing
    {
        void AddFreeFirstAidVideo(VideoRequest request);
    }   
}
