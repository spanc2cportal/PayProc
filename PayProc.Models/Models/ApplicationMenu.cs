using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class ApplicationMenu
    {
        public ApplicationMenu()
        {
            this.RoleMenus = new List<RoleMenu>();
        }

        public byte MenuId { get; set; }
        public string GroupName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }
        public virtual ICollection<RoleMenu> RoleMenus { get; set; }
    }
}
