using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class Template
    {
        public Template()
        {
            this.ClientTemplates = new List<ClientTemplate>();
            this.TemplateAttributes = new List<TemplateAttribute>();
            this.Utilities = new List<Utility>();
        }

        public int TemplateId { get; set; }
        public byte TemplateTypeId { get; set; }
        public string TemplatePath { get; set; }
        public byte AttributeCount { get; set; }
        public virtual ICollection<ClientTemplate> ClientTemplates { get; set; }
        public virtual ICollection<TemplateAttribute> TemplateAttributes { get; set; }
        public virtual TemplateType TemplateType { get; set; }
        public virtual ICollection<Utility> Utilities { get; set; }
    }
}
