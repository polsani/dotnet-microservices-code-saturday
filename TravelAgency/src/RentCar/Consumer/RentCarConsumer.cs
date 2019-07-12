using MassTransit;
using System;
using System.Threading.Tasks;
using TravelAgency.Shared.Commands;

namespace RentCar.Consumer
{
    public class RentCarConsumer : IConsumer<IProcessRentCar>
    {
        public Task Consume(ConsumeContext<IProcessRentCar> context)
        {
            throw new NotImplementedException();
        }
    }
}
