using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class MemberActivityLog
    {
        public long LogId { get; set; }
        public System.DateTime LogTime { get; set; }
        public string Action { get; set; }
        public long UserId { get; set; }
        public byte ActivityTypeId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual UserActivityType UserActivityType { get; set; }
    }
}
