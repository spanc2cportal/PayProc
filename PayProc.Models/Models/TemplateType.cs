using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class TemplateType
    {
        public TemplateType()
        {
            this.Templates = new List<Template>();
        }

        public byte TemplateTypeId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
    }
}
