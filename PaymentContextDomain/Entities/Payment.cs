﻿using PaymentContextDomain.ValueObjects;
using System;

namespace PaymentContextDomain.Entities
{
    public abstract class Payment 
    {
        protected Payment(
            DateTime paidDate, 
            DateTime expireDate, 
            decimal total,
            decimal totalPaid, 
            string owner, 
            Document document,
            string address
            )
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Owner = owner;
            Document = document;
            Address = address;
        }

       public string Number { get; private set; }
       public DateTime PaidDate { get; private set; }
       public DateTime ExpireDate { get; private set; }
       public decimal Total { get; private set; }
       public decimal TotalPaid { get; private set; }
       public string Owner { get; private set; }
       public Document Document { get; private set; }
       public string Address { get; private set; }
    }
}