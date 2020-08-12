using ExchangeContextShared.ValueObjects;
using Flunt.Validations;

namespace ExchangeContextDomain.ValueObjects.Entities
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Address," Email.Adress "," E-mail inválido ")
                );
        }

        public string Address { get; private set; }
    }
}
