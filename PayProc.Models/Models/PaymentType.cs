using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            this.Payments = new List<Payment>();
        }

        public byte PaymentTypeId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
