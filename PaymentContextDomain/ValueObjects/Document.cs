using Flunt.Validations;
using PaymentContextDomain.Enums;
using PaymentContextShared.ValueObjects;

namespace PaymentContextDomain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(), "Document.Number", "Documento inválido")
                );
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }


        //Temporário
        public bool Validate() 
        {
            if (Type == EDocumentType.CNPJ && Number.Length == 14)
                return true;

            if (Type == EDocumentType.CPF && Number.Length == 11)
                return true;

            return false;
        }
    }
}
