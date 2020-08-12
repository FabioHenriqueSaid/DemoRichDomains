using ExchangeContextDomain.ValueObjects.Enums;
using ExchangeContextShared.ValueObjects;

namespace ExchangeContextDomain.ValueObjects.Entities
{
    public class Document : ValueObject
    {
        public Document(string number)
        {
            Number = number;
        }
        public string Number { get; private set; }
        public EDocumentType MyProperty { get; private set; }
    }
}
