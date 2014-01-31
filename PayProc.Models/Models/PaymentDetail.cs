using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class PaymentDetail
    {
        public long PaymentId { get; set; }
        public string StringValue1 { get; set; }
        public string StringValue2 { get; set; }
        public string StringValue3 { get; set; }
        public string StringValue4 { get; set; }
        public string StringValue5 { get; set; }
        public string StringValue6 { get; set; }
        public string StringValue7 { get; set; }
        public Nullable<long> Integer1 { get; set; }
        public Nullable<long> Integer2 { get; set; }
        public Nullable<long> Integer3 { get; set; }
        public Nullable<decimal> Decimal1 { get; set; }
        public Nullable<decimal> Decimal2 { get; set; }
        public Nullable<decimal> Decimal3 { get; set; }
        public Nullable<System.DateTime> Date1 { get; set; }
        public Nullable<System.DateTime> Date2 { get; set; }
        public Nullable<System.DateTime> Date3 { get; set; }
        public string Encrypted1 { get; set; }
        public string Encrypted2 { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
