using Flunt.Notifications;
using System;

namespace ExchangeContextShared
{
    public abstract class Entity : Notifiable
    {
        public Entity() {
            Id = Id;
        }
        public Guid Id { get; set; }
    }
}
