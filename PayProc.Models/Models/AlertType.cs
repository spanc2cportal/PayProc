using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class AlertType
    {
        public AlertType()
        {
            this.UserAlerts = new List<UserAlert>();
        }

        public byte AlertTypeId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserAlert> UserAlerts { get; set; }
    }
}
