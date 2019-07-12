using TravelAgency.Domain.ValueObjects;

namespace TravelAgency.Domain.Entities
{
    public class Customer
    {
        public Name Name { get; set; }
        public Email Email { get; set; }
    }
}
