using Deipax.DataAccess.Interfaces;
using System.Data.Common;

namespace Deipax.DataAccess.Concretes
{
    public class DbBatch : IDbBatch
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
        public DbConnection Connection { get; set; }
        public DbTransaction Transaction { get; set; }
        #endregion
    }
}