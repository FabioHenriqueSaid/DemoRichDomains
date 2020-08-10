using System.Collections.Generic;
using System.Linq;

namespace ExchangeContextDomain.Entities
{
    public class Wallet
    {
        public IList<Order> _orders;
        public string CodeWallet { get; private set; }
        public string BitcoinBalance { get; private set; }
        public string Reaisbalance { get; private set; }

        //Retorna todas as ordens
        public  IReadOnlyCollection<Order> Orders { get { return _orders.ToArray();  } }

        public void BuyBitcoin(string valor) {
            //Verificar se possui saldo
            //Quando compra adiciona uma ordem de compra    
            //Gerar numero de ordem
        }
        public void SellBitcoin() { 
           //Verificar se possui saldo
           //Quando vende adiciona uma ordem de venda
        }
    }
}
