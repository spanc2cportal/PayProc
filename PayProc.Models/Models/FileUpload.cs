using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class FileUpload
    {
        public FileUpload()
        {
            this.MemberBills = new List<MemberBill>();
        }

        public long FileId { get; set; }
        public string FileName { get; set; }
        public Nullable<System.DateTime> UploadTime { get; set; }
        public Nullable<int> BillCount { get; set; }
        public Nullable<int> SuccessCount { get; set; }
        public virtual ICollection<MemberBill> MemberBills { get; set; }
    }
}
