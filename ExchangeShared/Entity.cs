using ExchangeContextShared.ValueObjects;
using Flunt.Notifications;
using System;

namespace ExchangeContextShared
{
    public abstract class Entity : ValueObject
    {
        public Entity() {
            Id = Id;
        }
        public Guid Id { get; set; }
    }
}
