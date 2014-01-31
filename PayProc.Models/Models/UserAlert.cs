using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class UserAlert
    {
        public long UserId { get; set; }
        public byte AlertTypeId { get; set; }
        public long UserId1 { get; set; }
        public virtual AlertType AlertType { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
