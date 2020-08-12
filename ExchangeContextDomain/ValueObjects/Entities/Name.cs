using ExchangeContextShared.ValueObjects;
using Flunt.Validations;

namespace ExchangeContextDomain.ValueObjects.Entities
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AddNotifications(new Contract()
                 .Requires()
                 .HasMinLen(FirstName,3,"Name.FirstName","Nome deve conter pelo menos 3 caracteres ")
                 .HasMaxLen(FirstName,3,"Name.FirstName","Nome deve conter no máximo 10 caracteres ")

                 .HasMaxLen(LastName,3,"Name.LastName","SobreNome deve  conter no máximo 10 caracteres")
                 .HasMinLen(LastName,3,"Name.LastName","SobreNome deve conter pelo menos  3 caracteres ")
                );
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
