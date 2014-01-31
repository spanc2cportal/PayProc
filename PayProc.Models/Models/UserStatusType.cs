using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class UserStatusType
    {
        public UserStatusType()
        {
            this.ApplicationUsers = new List<ApplicationUser>();
        }

        public byte StatusId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
