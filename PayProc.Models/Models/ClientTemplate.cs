using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class ClientTemplate
    {
        public int ClientTemplateId { get; set; }
        public int TemplateId { get; set; }
        public int ClientId { get; set; }
        public byte PaymentFlowId { get; set; }
        public byte PostTypeId { get; set; }
        public virtual Client Client { get; set; }
        public virtual ClientPostType ClientPostType { get; set; }
        public virtual Template Template { get; set; }
        public virtual PaymentFlow PaymentFlow { get; set; }
    }
}
