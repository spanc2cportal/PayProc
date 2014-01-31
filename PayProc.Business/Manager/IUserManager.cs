using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayProc.Models.ViewModel;

namespace PayProc.Domain.Contract
{
    public interface IUserManager
    {
        List<UserInfo> FindUserList(int pageIndex, int pageCount);
        UserInfo FindUserById(long id);
        void SaveUserInfo(UserInfo userInfo);
        void UpdateUserInfo(long id, UserInfo userInfo);
        void DeleteUserInfo(long id);
    }
}
