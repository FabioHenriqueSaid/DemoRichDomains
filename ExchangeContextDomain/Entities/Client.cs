using System;
namespace ExchangeContextDomain.Entities
{
    public class Client
    {
        public Client(string firstName, string lastName, string document, string email, DateTime birthDate)
        {
            CreationDate = DateTime.Now;
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;
            BirthDate = birthDate;
        }

        public DateTime CreationDate { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        //Carteira
        //Endereco
    }
}