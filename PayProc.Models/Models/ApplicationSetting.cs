using System;
using System.Collections.Generic;

namespace PayProc.Models
{
    public partial class ApplicationSetting
    {
        public byte SettingId { get; set; }
        public string DisclaimerPath { get; set; }
        public string PrivacyPolicyPath { get; set; }
        public string TermsPath { get; set; }
    }
}
