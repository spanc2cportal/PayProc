using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayProc.Models.ViewModel
{
    public class BaseViewModel
    {
        public DateTime CreatedDateTime { get; set; }
        public long CreatedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public long ModifiedBy { get; set; }
    }
}
