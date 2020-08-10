using System;

namespace ExchangeContextDomain.Entities
{
    public class Order
    {
        public Order()
        {
            CreateDate = DateTime.Now;
            Active = true;
        }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }
    }
}
