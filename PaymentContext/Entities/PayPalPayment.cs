using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContextDomain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionCode,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string owner,
            string document,
            string address
            ) : base 
            ( paidDate,
             expireDate,
             total,
             totalPaid,
             owner,
             document,
             address )
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }
    }
}
