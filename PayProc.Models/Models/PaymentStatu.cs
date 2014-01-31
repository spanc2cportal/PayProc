using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class PaymentStatu
    {
        public PaymentStatu()
        {
            this.Payments = new List<Payment>();
        }

        public short PaymentStatusId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
