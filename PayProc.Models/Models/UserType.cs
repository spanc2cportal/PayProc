using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class UserType
    {
        public UserType()
        {
            this.ApplicationUsers = new List<ApplicationUser>();
        }

        public byte UserTypeId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
