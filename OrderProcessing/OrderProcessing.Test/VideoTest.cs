using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrderProcessing.Core;
using OrderProcessing.Core.PackingSlipGenerator;
using OrderProcessing.Implementation;
using OrderProcessing.Interfaces;
using OrderProcessing.ProductTypeInterfaces;
using System;
using System.IO;
using Xunit;

namespace OrderProcessing.Test
{
    [TestClass]
    public class VideoProductTest
    {
        private VideoProcessor videoProcessor;

        public VideoProductTest()
        {
            videoProcessor = new VideoProcessor(VideoType.LearningToSki);          
        }

        [TestMethod]
        public void VideoProduct_ValidateConstructor()
        {
            Assert.IsNotNull(videoProcessor);
        }

        [TestMethod]
        public void Video_LearningToSki_Called()
        {           
            videoProcessor.AddFreeFirstAidVideo(VideoType.LearningToSki);
        }

        [TestMethod]
        public void Video_OtherThan_LearningToSki_Called()
        {
            videoProcessor.AddFreeFirstAidVideo(VideoType.Others);
        }
    }
}
