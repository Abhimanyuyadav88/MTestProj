using OrderProcessing.Core;
using OrderProcessing.Models;
using OrderProcessing.ProductTypeInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Implementation
{
    public class VideoProcessor : IVideo
    {
        public VideoType videoType { get; set; }

        public VideoProcessor(VideoType type)
        {
            videoType = type;
        }

        public void AddFreeFirstAidVideo(VideoType videoType)
        {
            Console.WriteLine(Constants.VideoFirstAidFree);
        }

        public void PostOrderProcessing()
        {
            Console.WriteLine(Constants.ProcessingVideoOrder);

            if (videoType == VideoType.LearningToSki)
            {
                AddFreeFirstAidVideo(videoType);
            }
            else
            {
                Console.WriteLine(Constants.VideoOtherThanLearningToSki);
            }

        }
    }
}
