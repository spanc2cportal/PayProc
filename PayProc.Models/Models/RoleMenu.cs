using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class RoleMenu
    {
        public byte RoleId { get; set; }
        public byte MenuId { get; set; }
        public string IsAllowUpdate { get; set; }
        public virtual ApplicationMenu ApplicationMenu { get; set; }
        public virtual ApplicationRole ApplicationRole { get; set; }
    }
}
