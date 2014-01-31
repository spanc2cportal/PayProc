using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class MemberAccount
    {
        public MemberAccount()
        {
            this.MemberBillers = new List<MemberBiller>();
            this.Payments = new List<Payment>();
        }

        public long AccountId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public Nullable<int> StateId { get; set; }
        public string Phone { get; set; }
        public long UserId { get; set; }
        public System.DateTime CreatedTime { get; set; }
        public long CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedTime { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<MemberBiller> MemberBillers { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
