

using ExchangeContextDomain.ValueObjects.Enums;
using System.Diagnostics.Contracts;
using ExchangeContextShared.ValueObjects;
using Flunt.Validations;
namespace ExchangeContextDomain.ValueObjects.Entities
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

           AddNotifications(new Contract()
                .Requires
                .IsTrue(Validate(), "Document.Number","Documento inválido")
                );

        }
        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        public bool Validate()
        {
            //Validação Temporaria
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;

            if (Type == EDocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }
    }
}
