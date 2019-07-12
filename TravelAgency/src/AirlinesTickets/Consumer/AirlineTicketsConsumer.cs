using System;
using System.Threading.Tasks;
using MassTransit;
using TravelAgency.Shared.Commands;

namespace AirlinesTickets.Consumer
{
    public class AirlineTicketsConsumer : IConsumer<IProcessAirlineTicket>
    {
        public Task Consume(ConsumeContext<IProcessAirlineTicket> context)
        {
            return Task.Run(()=> Console.WriteLine("Novo ticket"));
            //throw new System.NotImplementedException();
        }
    }
}
