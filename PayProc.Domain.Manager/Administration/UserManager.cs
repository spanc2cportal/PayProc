namespace PayProc.Domain.Manager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PayProc.Domain.Contract;
    using PayProc.Models.ViewModel;
    using PayProc.Data.UnitOfWork;
    using PayProc.Models;
    using PayProc.Domain.Manager.Resources;
    using PayProc.Domain.Manager.Converter;

    public class UserManager: IUserManager
    {
        #region IUserManager Members

        public UserInfo FindUserById(long id)
        {
            throw new NotImplementedException();
        }

        public void SaveUserInfo(UserInfo userInfo)
        {
            using (IUserRegistrationUow userRegInfoUow = new UserRegistrationUow())
            {
                BaseConverter<UserInfo, ApplicationUser> viewModelToAppUserModelConv= new BaseConverter<UserInfo, ApplicationUser>();
                var appUserDetails = viewModelToAppUserModelConv.SourceModelToTargetModel(userInfo, new ApplicationUser());
                appUserDetails.LoginId = "test";
                appUserDetails.LoginKey = "1";
                appUserDetails.IsSysGenerated = "Y";
                appUserDetails.RoleId = 1;
                appUserDetails.Email = "test@test.com";
                appUserDetails.StatusId = 1;
                appUserDetails.UserTypeId = 1;
                userRegInfoUow.AppUser.Add(appUserDetails);

                BaseConverter<UserInfo, MemberAccount> viewModelToMemAccModelConv = new BaseConverter<UserInfo, MemberAccount>();
                var memAccDetails = viewModelToMemAccModelConv.SourceModelToTargetModel(userInfo, new MemberAccount());
                memAccDetails.CreatedBy = 1;
                memAccDetails.CreatedTime = DateTime.Now;
                memAccDetails.Email = "test@test.com";
                userRegInfoUow.MemAccount.Add(memAccDetails);

                userRegInfoUow.Commit();
            }
        }

        public void UpdateUserInfo(long id, UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserInfo(long id)
        {
            throw new NotImplementedException();
        }

        public List<UserInfo> FindUserList(int pageIndex, int pageCount)
        {
            if (pageIndex < 0 || pageCount <= 0)
                throw new ArgumentException(Messages.UserListTypeWarning);

            List<UserInfo> userInfoDetails = new List<UserInfo>();
            using (IUserRegistrationUow userRegInfoUow = new UserRegistrationUow())
            {
                userInfoDetails = userRegInfoUow.UserInfo.UserInfoList<DateTime>(pageIndex, pageCount, o => o.CreatedDateTime, false);
            }
            return userInfoDetails;
        }

        #endregion

    }
}
