namespace PayProc.Models.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class UserInfo : BaseViewModel
    {
        public long UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string EmailId { get; set; }

        public string AddressOne { get; set; }

        public string City { get; set; }

        public string AddressTwo { get; set; }

        public string ZipCode { get; set; }

        public string Captcha { get; set; }

        public bool IsAgreeToTerms { get; set; }

        public Int32? StateId { get; set; }

        public Int16 StatusId { get; set; }

        public char IsActive { get; set; }

        public Int16 UserTypeId { get; set; }

        public Int16 AppRoleId { get; set; }
     
        public List<State> UserStates { get; set; }

        public List<UserType> UserTypeValues { get; set; }

        public List<UserStatusType> UserStatusValues { get; set; }

        public List<ApplicationRole> ApplicationRoles { get; set; }
    }
}