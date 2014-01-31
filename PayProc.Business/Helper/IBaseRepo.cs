namespace PayProc.Domain.Contract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBaseRepo<T> where T : class
    {
        /// <summary>
        /// Get All Method
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    } 
}
