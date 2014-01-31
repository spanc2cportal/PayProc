using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class Client
    {
        public Client()
        {
            this.ClientTemplates = new List<ClientTemplate>();
        }

        public int ClientId { get; set; }
        public int BillerId { get; set; }
        public byte ClientTypeId { get; set; }
        public virtual Biller Biller { get; set; }
        public virtual ClientType ClientType { get; set; }
        public virtual ICollection<ClientTemplate> ClientTemplates { get; set; }
    }
}
