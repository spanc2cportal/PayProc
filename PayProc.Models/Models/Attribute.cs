using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class Attribute
    {
        public Attribute()
        {
            this.TemplateAttributes = new List<TemplateAttribute>();
        }

        public byte AttributeId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Precision { get; set; }
        public Nullable<byte> Scale { get; set; }
        public byte AttributeTypeId { get; set; }
        public virtual AttributeType AttributeType { get; set; }
        public virtual ICollection<TemplateAttribute> TemplateAttributes { get; set; }
    }
}
