using AirlinesTickets.Consumer;
using MassTransit;
using MassTransit.Util;
using System;
using System.Configuration;

namespace AirlinesTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Airlines booking service up.");
            ConfigureAndStartBus();
            Console.ReadLine();
        }

        static void ConfigureAndStartBus()
        {
            var rabbitHost = new Uri(ConfigurationManager.AppSettings["rabbitHost"]);
            var user = ConfigurationManager.AppSettings["rabbitUser"];
            var password = ConfigurationManager.AppSettings["rabbitPassword"];
            var inputQueue = ConfigurationManager.AppSettings["rabbitQueue"];
            var bus = Bus.Factory.CreateUsingRabbitMq(configurator =>
            {
            var host = configurator.Host(rabbitHost, h =>
                {
                    h.Username(user);
                    h.Password(password);
                });

                configurator.ReceiveEndpoint(host, inputQueue, c =>
                {
                    c.Consumer(() => new AirlineTicketsConsumer());
                });
            });
            TaskUtil.Await(() => bus.StartAsync());
        }
    }
}
