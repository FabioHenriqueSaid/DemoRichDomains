using ExchangeContextDomain.ValueObjects.Enums;
using System;

namespace ExchangeContextDomain.Entities
{
    public class Wallet
    {
        public Wallet(
            string bitcoinBalance, 
            string reaisbalance,
            Client client
            )
        {
            CodeWallet = Guid.NewGuid().ToString();
            BitcoinBalance = bitcoinBalance;
            Reaisbalance = reaisbalance;
            Client = client;
        }

        public string CodeWallet { get; private set; }
        public string BitcoinBalance { get; private set; }
        public string Reaisbalance { get; private set; }
        public ETypeOrder TypeOrder { get; private set; }

        public Client Client { get; private set; }

        public void BuyBitcoin(string valor) 
        {
            //Verificar se possui saldo
            //Quando compra adiciona uma ordem de compra    
            //Gerar numero de ordem
        }
        public void SellBitcoin() 
        { 
           //Verificar se possui saldo
           //Quando vende adiciona uma ordem de venda
        }
    }
}
