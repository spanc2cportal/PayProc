namespace PayProc.Domain.Contract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PayProc.Models;

    public interface IUserRegistrationUow : IDisposable
    {
        // Repositories
        IBaseRepo<ApplicationUser> AppUser { get; }
        IBaseRepo<MemberAccount> MemAccount { get; }
        IBaseRepo<UserStatusType> UsrStatusTyp { get; }
        IBaseRepo<UserType> UsrTyp { get; }
        IBaseRepo<ApplicationRole> AppRoles { get; }
        IUserInfoRepo UserInfo { get; }
        void Commit();
    }
}
