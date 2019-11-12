using Deipax.DataAccess.Interfaces;
using System.Data;

namespace Deipax.DataAccess.Concretes
{
    internal class DbBatch : IDbBatch
    {
        public DbBatch(IDb db)
        {
            Db = db;
        }

        private DbBatch()
        {
        }

        #region IDbCon Members
        public IDb Db { get; set; }
        public IDbConnection Connection { get; set; }
        public IDbTransaction Transaction { get; set; }
        #endregion
    }
}