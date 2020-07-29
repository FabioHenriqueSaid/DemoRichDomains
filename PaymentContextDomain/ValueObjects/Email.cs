using PaymentContextShared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Flunt.Validations;

namespace PaymentContextDomain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string address)
        {
            Address = address;


            /*Add

            AddNotifications(new Contract()
                .Requires
                .IsEmail(Address,"Email.Adress","E-mail inválido" )
               );*/
        }

        public string Address { get; private set; }
    }
}
