using OrderProcessing.Core;
using OrderProcessing.Core.PackingSlipGenerator;
using OrderProcessing.Implementation;
using OrderProcessing.Interfaces;
using OrderProcessing.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public class OrderProcessingHandler
    {
        private readonly IPackingSlipGenerator packingSlipGenerator;
        private readonly INotificationService notificationService;

        private IPostOrderProcessing postOrderProcessing;


        public OrderProcessingHandler(IPackingSlipGenerator slipGenerator, INotificationService notification)
        {
            packingSlipGenerator = slipGenerator;
            notificationService = notification;
        }

        public void InitializeOrderProcessing()
        {
            Console.WriteLine("Press 1 to process PhysicalPayment.\n Press 2 to process Book payment. \nPress 3 to process MemeberShipPayment.");
            //Console.WriteLine("Press 4 to process PhysicalPayment.\n Press 2 to process Book payment. \nPress 3 to process MemeberShipPayment.");
            Console.WriteLine("Please enter type of payment to Process");

            int choice = Convert.ToInt32(Console.ReadLine());

            // For demo process all requests
            if (choice == 0)
            {
                Console.WriteLine("----------------------{0}----------------------------", "Process PhysicalOrder");
                //// Process PhysicalOrder
                postOrderProcessing = new PhysicalProductProcessor(packingSlipGenerator);
                postOrderProcessing.PostOrderProcessing();
                Console.WriteLine();

                Console.WriteLine("----------------------{0}----------------------------", "Process Book PhysicalOrder");
                //// Process Book Order
                postOrderProcessing = new BookProcessing(packingSlipGenerator);
                postOrderProcessing.PostOrderProcessing();
                Console.WriteLine();

                Console.WriteLine("----------------------{0}----------------------------", "Process Basic Membership Order");
                //// Process Basic Membership
                postOrderProcessing = new MembershipProcessor(notificationService,MembershipType.Basic);
                postOrderProcessing.PostOrderProcessing();
                Console.WriteLine();

                Console.WriteLine("----------------------{0}----------------------------", "Process Premium membership");
                //// Process Premium Membership
                postOrderProcessing = new MembershipProcessor(notificationService, MembershipType.Premium);
                postOrderProcessing.PostOrderProcessing();
                Console.WriteLine();

                Console.WriteLine("----------------------{0}----------------------------", "Process Learning to ski video");
                //// Process Learning to Ski video
                postOrderProcessing = new VideoProcessor(VideoType.LearningToSki);
                postOrderProcessing.PostOrderProcessing();
                Console.WriteLine();

                Console.WriteLine("----------------------{0}----------------------------", "Process Other Video");
                //// Process Learning to other video
                postOrderProcessing = new VideoProcessor(VideoType.Others);
                postOrderProcessing.PostOrderProcessing();
            }
            else if (choice == 1)
            {
                postOrderProcessing = new PhysicalProductProcessor(packingSlipGenerator);
                postOrderProcessing.PostOrderProcessing();
            }
            Console.ReadLine();



        }
    }
}
