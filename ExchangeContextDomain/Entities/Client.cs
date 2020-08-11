using ExchangeContextDomain.ValueObjects.Entities;
using System;
namespace ExchangeContextDomain.Entities
{
    public class Client
    {
        public Client(Name name, Document document, Email email, DateTime birthDate)
        {
            CreationDate = DateTime.Now;
            FirstName = name;
            LastName = name;
            Document = document;
            Email = email;
            BirthDate = birthDate;
        }

        public DateTime CreationDate { get; set; }
        public Name FirstName { get; private set; }
        public Name LastName { get; private set; }
        public Document Document { get; set; }
        public Email Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Wallet Wallet { get; set; }
    }
}