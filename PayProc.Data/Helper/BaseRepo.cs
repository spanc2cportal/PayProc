namespace PayProc.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data;
    using PayProc.Domain.Contract;
    using System.Linq.Expressions;

    /// <summary>
    /// The EF-dependent, generic repository for data access
    /// </summary>
    /// <typeparam name="T">Type of entity for this Repository.</typeparam>
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public BaseRepo(DbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("Null DbContext");
            BaseDbContext = dbContext;
            BaseDbSet = dbContext.Set<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        protected DbContext BaseDbContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected DbSet<T> BaseDbSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<T> GetAll()
        {
            return BaseDbSet;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetById(int id)
        {
            return BaseDbSet.Find(id);
        }

        /// <summary>
        /// Get all elements of type T in repository
        /// </summary>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageCount">Number of elements in each page</param>
        /// <param name="orderByExpression">Order by expression for this query</param>
        /// <param name="ascending">Specify if order is ascending</param>
        /// <returns>List of selected elements</returns>
        public virtual IEnumerable<T> GetPaged<KProperty>(int pageIndex, int pageCount, 
            Expression<Func<T, KProperty>> orderByExpression, bool ascending)
        {
            if (ascending)
            {
                return BaseDbSet.OrderBy(orderByExpression)
                          .Skip(pageCount * pageIndex)
                          .Take(pageCount);
            }
            else
            {
                return BaseDbSet.OrderByDescending(orderByExpression)
                          .Skip(pageCount * pageIndex)
                          .Take(pageCount);
            }
        }

        /// <summary>
        /// Get  elements of type T in repository
        /// </summary>
        /// <param name="filter">Filter that each element do match</param>
        /// <returns>List of selected elements</returns>
        public virtual IEnumerable<T> GetFiltered(Expression<Func<T, bool>> filter)
        {
            return BaseDbSet.Where(filter);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(T entity)
        {
            DbEntityEntry dbEntityEntry = BaseDbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                BaseDbSet.Add(entity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Update(T entity)
        {
            DbEntityEntry dbEntityEntry = BaseDbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                BaseDbSet.Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = BaseDbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                BaseDbSet.Attach(entity);
                BaseDbSet.Remove(entity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(int id)
        {
            var entity = GetById(id);
            if (entity == null) return; // not found; assume already deleted.
            Delete(entity);
        }

    }
}
