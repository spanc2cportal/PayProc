using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class MemberBill
    {
        public MemberBill()
        {
            this.Payments = new List<Payment>();
        }

        public long MemberBillId { get; set; }
        public string BillNumber { get; set; }
        public System.DateTime RecievedTime { get; set; }
        public string FileLocationPath { get; set; }
        public long BillerId { get; set; }
        public Nullable<decimal> BillAmount { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public long FileId { get; set; }
        public virtual FileUpload FileUpload { get; set; }
        public virtual MemberBiller MemberBiller { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
