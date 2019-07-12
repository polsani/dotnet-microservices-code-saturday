using MassTransit;
using System;
using System.Threading.Tasks;
using TravelAgency.Shared.Commands;

namespace HotelReservation.Consumer
{
    public class HotelReservationConsumer : IConsumer<IProcessHotelReservation>
    {
        public Task Consume(ConsumeContext<IProcessHotelReservation> context)
        {
            throw new NotImplementedException();
        }
    }
}
