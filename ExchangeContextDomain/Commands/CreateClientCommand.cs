using Flunt.Validations;
using System;
using Flunt.Notifications;
using ExchangeContextShared.Commands;

namespace ExchangeContextDomain.Commands
{
    public class CreateClientCommand : Notifiable, ICommand
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; set; }
        public string Email { get; set; }


        public DateTime CreationDate { get; set; }
        public DateTime BirthDate { get; private set; }
        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
            );
        }
    }
}
