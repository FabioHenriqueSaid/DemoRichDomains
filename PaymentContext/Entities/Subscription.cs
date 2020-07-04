using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContextDomain.Entities
{
    public class Subscription
    {
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
