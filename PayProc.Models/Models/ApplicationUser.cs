using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class ApplicationUser
    {
        public ApplicationUser()
        {
            this.Feedbacks = new List<Feedback>();
            this.Feedbacks1 = new List<Feedback>();
            this.MemberAccounts = new List<MemberAccount>();
            this.MemberActivityLogs = new List<MemberActivityLog>();
            this.UserAlerts = new List<UserAlert>();
        }

        public long UserId { get; set; }
        public byte UserTypeId { get; set; }
        public string LoginId { get; set; }
        public string LoginKey { get; set; }
        public Nullable<System.DateTime> KeyChangeTime { get; set; }
        public string IsSysGenerated { get; set; }
        public Nullable<short> FailureCount { get; set; }
        public byte StatusId { get; set; }
        public string Email { get; set; }
        public byte RoleId { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public virtual ApplicationRole ApplicationRole { get; set; }
        public virtual UserStatusType UserStatusType { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Feedback> Feedbacks1 { get; set; }
        public virtual ICollection<MemberAccount> MemberAccounts { get; set; }
        public virtual ICollection<MemberActivityLog> MemberActivityLogs { get; set; }
        public virtual ICollection<UserAlert> UserAlerts { get; set; }
    }
}
