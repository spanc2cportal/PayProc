using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class UserActivityType
    {
        public UserActivityType()
        {
            this.MemberActivityLogs = new List<MemberActivityLog>();
        }

        public byte ActivityTypeId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<MemberActivityLog> MemberActivityLogs { get; set; }
    }
}
