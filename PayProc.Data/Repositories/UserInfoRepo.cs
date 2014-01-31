namespace PayProc.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PayProc.Domain.Contract;
    using PayProc.Models;
    using PayProc.Models.ViewModel;
    using System.Data.Entity;
    using System.Linq.Expressions;

    public class UserInfoRepo : BaseRepo<UserInfo>, IUserInfoRepo
    {
        public UserInfoRepo(DbContext context)
            : base(context)
        {
            
        }

        public List<UserInfo> UserInfoList(long? userId)
        {
            return (from appUser in base.BaseDbContext.Set<ApplicationUser>()
                    join memAccnt in base.BaseDbContext.Set<MemberAccount>() on appUser.UserId equals memAccnt.UserId
                    where appUser.UserId == userId
                    select new UserInfo
                    {
                        UserId = appUser.UserId,
                        FirstName = memAccnt.FirstName,
                        LastName = memAccnt.LastName,
                        Phone = memAccnt.Phone,
                        EmailId = memAccnt.Email,
                        AddressOne = memAccnt.AddressLine1,
                        City = memAccnt.City,
                        AddressTwo = memAccnt.AddressLine2,
                        ZipCode = memAccnt.ZipCode,
                        StateId = memAccnt.StateId,
                        StatusId = appUser.StatusId,
                        UserTypeId = appUser.UserTypeId,
                        AppRoleId = appUser.RoleId,
                        CreatedDateTime = memAccnt.CreatedTime,
                        CreatedBy = memAccnt.CreatedBy
                    }).ToList();
        }

        public List<UserInfo> UserInfoList<KProperty>(int pageIndex, int pageCount, Expression<Func<UserInfo, KProperty>> orderByExpression, bool ascending)
        {
            if (ascending)
            {
                return (from appUser in base.BaseDbContext.Set<ApplicationUser>()
                                  join memAccnt in base.BaseDbContext.Set<MemberAccount>() on appUser.UserId equals memAccnt.UserId
                                  select new UserInfo
                                  {
                                      UserId = appUser.UserId,
                                      FirstName = memAccnt.FirstName,
                                      LastName = memAccnt.LastName,
                                      Phone = memAccnt.Phone,
                                      EmailId = memAccnt.Email,
                                      AddressOne = memAccnt.AddressLine1,
                                      City = memAccnt.City,
                                      AddressTwo = memAccnt.AddressLine2,
                                      ZipCode = memAccnt.ZipCode,
                                      StateId = memAccnt.StateId,
                                      StatusId = appUser.StatusId,
                                      UserTypeId = appUser.UserTypeId,
                                      AppRoleId = appUser.RoleId,
                                      CreatedDateTime = memAccnt.CreatedTime,
                                      CreatedBy = memAccnt.CreatedBy
                                  }).OrderBy(orderByExpression)
                                .Skip(pageCount * pageIndex).Take(pageCount).ToList();
            }
            else
            {
                return (from appUser in base.BaseDbContext.Set<ApplicationUser>()
                                  join memAccnt in base.BaseDbContext.Set<MemberAccount>() on appUser.UserId equals memAccnt.UserId
                                  select new UserInfo
                                  {
                                      UserId = appUser.UserId,
                                      FirstName = memAccnt.FirstName,
                                      LastName = memAccnt.LastName,
                                      Phone = memAccnt.Phone,
                                      EmailId = memAccnt.Email,
                                      AddressOne = memAccnt.AddressLine1,
                                      City = memAccnt.City,
                                      AddressTwo = memAccnt.AddressLine2,
                                      ZipCode = memAccnt.ZipCode,
                                      StateId = memAccnt.StateId,
                                      StatusId = appUser.StatusId,
                                      UserTypeId = appUser.UserTypeId,
                                      AppRoleId = appUser.RoleId,
                                      CreatedDateTime = memAccnt.CreatedTime,
                                      CreatedBy = memAccnt.CreatedBy
                                  }).OrderBy(orderByExpression)
                                .Skip(pageCount * pageIndex)
                          .Take(pageCount).ToList();
            }
        }
    }
}
