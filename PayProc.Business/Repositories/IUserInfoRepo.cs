namespace PayProc.Domain.Contract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PayProc.Models;
    using PayProc.Models.ViewModel;
    using System.Linq.Expressions;

    public interface IUserInfoRepo : IBaseRepo<UserInfo>
    {
        List<UserInfo> UserInfoList(long? userId);
        List<UserInfo> UserInfoList<KProperty>(int pageIndex, int pageCount, Expression<Func<UserInfo, KProperty>> orderByExpression, bool ascending);
    }
}
