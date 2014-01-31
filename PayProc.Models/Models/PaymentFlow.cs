using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class PaymentFlow
    {
        public PaymentFlow()
        {
            this.ClientTemplates = new List<ClientTemplate>();
            this.Payments = new List<Payment>();
        }

        public byte PaymentFlowId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ClientTemplate> ClientTemplates { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
