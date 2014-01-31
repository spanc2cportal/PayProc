using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class Biller
    {
        public Biller()
        {
            this.Clients = new List<Client>();
            this.MemberBillers = new List<MemberBiller>();
            this.Payments = new List<Payment>();
        }

        public int BillerId { get; set; }
        public string BillerName { get; set; }
        public string BillerDescription { get; set; }
        public int UtilityId { get; set; }
        public string IsActive { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public Nullable<int> StateId { get; set; }
        public string Phone { get; set; }
        public string IsClient { get; set; }
        public byte CutoffId { get; set; }
        public string CutOffValue { get; set; }
        public byte PayTypeId { get; set; }
        public virtual AmountPayType AmountPayType { get; set; }
        public virtual Utility Utility { get; set; }
        public virtual CutoffType CutoffType { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<MemberBiller> MemberBillers { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
