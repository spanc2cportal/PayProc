namespace PayProc.Data.UnitOfWork
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PayProc.Domain.Contract;
    using PayProc.Models;
    using PayProc.Data.Helper;
    using PayProc.Data.Repositories;
    
    public class UserRegistrationUow : BaseUow, IUserRegistrationUow
    {
        public UserRegistrationUow()
        {
            
        }

        #region Class Types

        private IBaseRepo<ApplicationUser> appUser;
        private IBaseRepo<MemberAccount> memAccount;
        private IBaseRepo<UserStatusType> usrStatusTyp;
        private IBaseRepo<UserType> usrTyp;
        private IBaseRepo<ApplicationRole> appRoles;
        private IUserInfoRepo userinfo;
        #endregion

        #region Repositories

        public IBaseRepo<ApplicationUser> AppUser
        {
            get
            {
                if (appUser == null)
                {
                    appUser = new BaseRepo<ApplicationUser>(DbContext);
                }
                return appUser;
            }
        }

        public IBaseRepo<MemberAccount> MemAccount
        {
            get
            {
                if (memAccount == null)
                {
                    memAccount = new BaseRepo<MemberAccount>(DbContext);
                }
                return memAccount;
            }
        }

        public IBaseRepo<UserStatusType> UsrStatusTyp
        {
            get
            {
                if (usrStatusTyp == null)
                {
                    usrStatusTyp = new BaseRepo<UserStatusType>(DbContext);
                }
                return usrStatusTyp;
            }
        }

        public IBaseRepo<UserType> UsrTyp
        {
            get
            {
                if (usrTyp == null)
                {
                    usrTyp = new BaseRepo<UserType>(DbContext);
                }
                return usrTyp;
            }
        }

        public IBaseRepo<ApplicationRole> AppRoles
        {
            get
            {
                if (appRoles == null)
                {
                    appRoles = new BaseRepo<ApplicationRole>(DbContext);
                }
                return appRoles;
            }
        }

        public IUserInfoRepo UserInfo
        {
            get
            {
                if (userinfo == null)
                {
                    userinfo = new UserInfoRepo(DbContext);
                }

                return userinfo;
            }
        }

        public void Commit()
        {
            base.Commit();
        }

        void IDisposable.Dispose()
        {
            base.Dispose();
        }

        #endregion
        
    }
}
