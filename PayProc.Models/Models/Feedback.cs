using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class Feedback
    {
        public long FeedbackId { get; set; }
        public string FeedbackText { get; set; }
        public Nullable<System.DateTime> FeedbackTime { get; set; }
        public string FeedbackMailId { get; set; }
        public Nullable<long> UserId { get; set; }
        public byte ResponseTypeId { get; set; }
        public Nullable<System.DateTime> ResponseTs { get; set; }
        public Nullable<long> RespondedBy { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ApplicationUser ApplicationUser1 { get; set; }
        public virtual ResponseType ResponseType { get; set; }
    }
}
