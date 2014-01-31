using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class CutoffType
    {
        public CutoffType()
        {
            this.Billers = new List<Biller>();
        }

        public byte CutoffId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Biller> Billers { get; set; }
    }
}
