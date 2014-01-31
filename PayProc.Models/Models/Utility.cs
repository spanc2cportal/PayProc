using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class Utility
    {
        public Utility()
        {
            this.Billers = new List<Biller>();
        }

        public int UtilityId { get; set; }
        public string Description { get; set; }
        public int DefaultTemplateId { get; set; }
        public virtual ICollection<Biller> Billers { get; set; }
        public virtual Template Template { get; set; }
    }
}
