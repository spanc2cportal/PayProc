using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayProc.Domain.Contract;

namespace PayProc.Data.Helper
{
    public abstract class BaseUow : IDisposable
    {
        protected BaseDBContext DbContext { get; set; }

        public BaseUow()
        {
            CreateDbContext();
        }

        /// <summary>
        /// Save pending changes to the database
        /// </summary>
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        protected void CreateDbContext()
        {
            DbContext = new BaseDBContext();
            DbContext.Configuration.ProxyCreationEnabled = false;
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Configuration.ValidateOnSaveEnabled = false;
            //Enable the below configuration for performance enablement
            //DbContext.Configuration.AutoDetectChangesEnabled = false;
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }

        #endregion
    }
}
