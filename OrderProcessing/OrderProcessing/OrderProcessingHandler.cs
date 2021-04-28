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
    /// <summary>
    /// Order Processing handler
    /// </summary>
    public class OrderProcessingHandler
    {
        /// <summary>
        /// The packing slip generator
        /// </summary>
        private readonly IPackingSlipGenerator packingSlipGenerator;

        /// <summary>
        /// The notification service
        /// </summary>
        private readonly INotificationService notificationService;

        /// <summary>
        /// The post order processing
        /// </summary>
        private IPostOrderProcessing postOrderProcessing;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderProcessingHandler"/> class.
        /// </summary>
        /// <param name="slipGenerator">The slip generator.</param>
        /// <param name="notification">The notification.</param>
        public OrderProcessingHandler(IPackingSlipGenerator slipGenerator, INotificationService notification)
        {
            packingSlipGenerator = slipGenerator;
            notificationService = notification;
        }

        /// <summary>
        /// Initializes the order processing.
        /// </summary>
        public void InitializeOrderProcessing()
        {
            //Console.WriteLine("Press 1 to process PhysicalPayment.\nPress 2 to process Book payment. \nPress 3 to process basic MemeberShipPayment.", ConsoleColor.Blue);
            //Console.WriteLine("Press 4 to process Premium Membership payment.\nPress 5 to process LearningToSkiVideo. \nPress 6 to process OtherVideo.,\nPress -1 to Quit.", ConsoleColor.Blue);
            Console.WriteLine(Constants.ProductOptions);
            Console.WriteLine("Please enter type of payment to Process");

            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != -1)
            {
                // For demo process all requests
                switch (choice)
                {
                    case 0:
                        RunAllPaymentOrders();
                        break;
                    case 1:
                        postOrderProcessing = new PhysicalProductProcessor(packingSlipGenerator);
                        postOrderProcessing.PostOrderProcessing();
                        break;
                    case 2:
                        postOrderProcessing = new BookProcessing(packingSlipGenerator);
                        postOrderProcessing.PostOrderProcessing();
                        break;
                    case 3:
                        postOrderProcessing = new MembershipProcessor(notificationService, MembershipType.Basic);
                        postOrderProcessing.PostOrderProcessing();
                        break;
                    case 4:
                        postOrderProcessing = new MembershipProcessor(notificationService, MembershipType.Premium);
                        postOrderProcessing.PostOrderProcessing();
                        break;
                    case 5:
                        postOrderProcessing = new VideoProcessor(VideoType.LearningToSki);
                        postOrderProcessing.PostOrderProcessing();
                        break;
                    case 6:
                        postOrderProcessing = new VideoProcessor(VideoType.Others);
                        postOrderProcessing.PostOrderProcessing();
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
                Console.WriteLine("Please enter type of payment to Process");
                choice = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadLine();



        }

        /// <summary>
        /// Runs all payment orders. Demo purpose
        /// </summary>
        public void RunAllPaymentOrders()
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
            postOrderProcessing = new MembershipProcessor(notificationService, MembershipType.Basic);
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
    }
}
