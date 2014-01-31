using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class State
    {
        public State()
        {
            this.MemberAccounts = new List<MemberAccount>();
            this.MemberBillers = new List<MemberBiller>();
        }

        public int StateId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MemberAccount> MemberAccounts { get; set; }
        public virtual ICollection<MemberBiller> MemberBillers { get; set; }
    }
}
