using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class ClientPostType
    {
        public ClientPostType()
        {
            this.ClientTemplates = new List<ClientTemplate>();
        }

        public byte PostTypeId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ClientTemplate> ClientTemplates { get; set; }
    }
}
