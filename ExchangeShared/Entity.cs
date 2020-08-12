using System;
namespace ExchangeContextShared
{
    public abstract class Entity
    {
        public Entity() {
            Id = Id;
        }
        public Guid Id { get; set; }
    }
}
