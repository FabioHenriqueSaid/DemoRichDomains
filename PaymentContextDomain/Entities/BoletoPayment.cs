using PaymentContextDomain.ValueObjects;
using System;

namespace PaymentContextDomain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            string barCode,
            string boletoNumber,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string owner,
            Document document,
            string address
            ) : base
            (paidDate,
             expireDate,
             total,
             totalPaid,
             owner,
             document,
             address)          
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }
        public string BarCode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}
