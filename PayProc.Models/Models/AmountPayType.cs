using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class AmountPayType
    {
        public AmountPayType()
        {
            this.Billers = new List<Biller>();
        }

        public byte PayTypeId { get; set; }
        public string Desctription { get; set; }
        public virtual ICollection<Biller> Billers { get; set; }
    }
}
