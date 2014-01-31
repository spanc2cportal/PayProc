using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class ClientType
    {
        public ClientType()
        {
            this.Clients = new List<Client>();
        }

        public byte ClientTypeId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
