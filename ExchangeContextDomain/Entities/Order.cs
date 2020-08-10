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
        public DateTime EndDate { get; private set; }
        public bool Active { get; private set; }
        public string BitcoinQuote { get; private set; }

        public void CancelOrder() {
            EndDate = DateTime.Now;
            Active = false;
        }


        /*
           Cancelar Ordem (usuario),
           Cancelar Ordem (Porque foi executada),
           Tipo de ordem (Compra/Venda),
           Rate
         */
    }
}
