using Flunt.Validations;

namespace TravelAgency.Domain.ValueObjects
{
    public class Name : ValueObject
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Fisrt name must have at least 3 characters.")
                .HasMinLen(LastName, 3, "Name.LastName", "Last name must have at least 3 characters.")
            );

        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
