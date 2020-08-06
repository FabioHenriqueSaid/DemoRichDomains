using Flunt.Notifications;
using System;

namespace PaymentContextShared.Entities
{
    public abstract class Entity : Notifiable
    {
        public Entity() {
            Id = Guid.NewGuid();
        }
        public Guid Id { get;  private set; }
    }
}
