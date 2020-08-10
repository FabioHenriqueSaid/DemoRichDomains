using System.Collections.Generic;

namespace ExchangeContextDomain.Entities
{
    public class Wallet
    {
        public string CodeWallet { get; private set; }
        public string BitcoinBalance { get; private set; }
        public string Reaisbalance { get; private set; }
        public List<Order> Orders { get; private set; }
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
