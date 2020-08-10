using System;
namespace ExchangeContextDomain.Entities
{
    public class Client
    {
        public DateTime CreationDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        //Carteira
        //Endereco
    }
}