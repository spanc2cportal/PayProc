using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class ResponseType
    {
        public ResponseType()
        {
            this.Feedbacks = new List<Feedback>();
        }

        public byte ResponseTypeId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
