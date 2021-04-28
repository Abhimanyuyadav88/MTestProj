using System;
using Microsoft.Extensions.DependencyInjection;
using OrderProcessing.Core;
using OrderProcessing.Core.PackingSlipGenerator;
using OrderProcessing.Implementation;
using OrderProcessing.Interfaces;
using OrderProcessing.Models;

namespace OrderProcessing
{
    class OrderProcessing
    {
        static void Main(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();

            //// Adding dependency
            serviceCollection.AddTransient<IPackingSlipGenerator, PackingSlipGenerator>();
            serviceCollection.AddTransient<INotificationService, NotificationService>();

            ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            OrderProcessingHandler orderProcessingHandler = ActivatorUtilities.CreateInstance<OrderProcessingHandler>(serviceProvider);
            orderProcessingHandler.InitializeOrderProcessing();

        }
    }
}
