using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class ApplicationRole
    {
        public ApplicationRole()
        {
            this.ApplicationUsers = new List<ApplicationUser>();
            this.RoleMenus = new List<RoleMenu>();
        }

        public byte RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IsActive { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public virtual ICollection<RoleMenu> RoleMenus { get; set; }
    }
}
