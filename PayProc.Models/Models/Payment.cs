using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class Payment
    {
        public Payment()
        {
            this.MemberBillers = new List<MemberBiller>();
        }

        public long PaymentId { get; set; }
        public int BillerId { get; set; }
        public Nullable<long> AccountId { get; set; }
        public Nullable<long> MemberBillId { get; set; }
        public string ReferenceNumber { get; set; }
        public string PaymentNumber { get; set; }
        public Nullable<System.DateTime> PaymentTime { get; set; }
        public short PaymentStatusId { get; set; }
        public byte PaymentTypeId { get; set; }
        public string ClientIp { get; set; }
        public byte PaymentFlowId { get; set; }
        public virtual Biller Biller { get; set; }
        public virtual MemberAccount MemberAccount { get; set; }
        public virtual MemberBill MemberBill { get; set; }
        public virtual ICollection<MemberBiller> MemberBillers { get; set; }
        public virtual PaymentDetail PaymentDetail { get; set; }
        public virtual PaymentFlow PaymentFlow { get; set; }
        public virtual PaymentStatu PaymentStatu { get; set; }
        public virtual PaymentType PaymentType { get; set; }
    }
}
