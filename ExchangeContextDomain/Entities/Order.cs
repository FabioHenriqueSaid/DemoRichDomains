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
        public DateTime CreateDate { get; private set; }
        public bool Active { get; private set; }
        public string BitcoinQuote { get; private set; }

        /*
           Cancelar Ordem (usuario),
           Cancelar Ordem (Porque foi executada)
           Tipo de ordem (Compra/Venda)
         */
    }
}
