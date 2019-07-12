namespace TravelAgency.Domain.Entities
{
    public class Booking
    {
        public Customer Customer { get; set; }
        public bool IsCarNeeded { get; set; }
        public bool IsHotelNeeded { get; set; }
        public bool IsFligthNeeded { get; set; }
    }
}
