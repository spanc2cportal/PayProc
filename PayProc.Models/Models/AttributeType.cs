using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class AttributeType
    {
        public AttributeType()
        {
            this.Attributes = new List<Attribute>();
        }

        public byte AttributeTypeId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Attribute> Attributes { get; set; }
    }
}
