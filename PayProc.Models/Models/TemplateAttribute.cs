using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class TemplateAttribute
    {
        public int TemplateAttributeId { get; set; }
        public int TemplateId { get; set; }
        public byte OrderSequence { get; set; }
        public byte AttributeId { get; set; }
        public string IsReadOnly { get; set; }
        public string Caption { get; set; }
        public virtual Attribute Attribute { get; set; }
        public virtual Template Template { get; set; }
    }
}
