using Deipax.DataAccess.Interfaces;
using System;
using System.Data.Common;

namespace Deipax.DataAccess.Concretes
{
    public class DbFactory : IDbFactory
    {
        #region IDbFactory Members
        public IDb CreateDb(
            string name,
            string cs,
            string provider,
            Func<IDb, DbConnection> connectionFactory)
        {
            return new Db(
                name ?? string.Empty,
                cs ?? string.Empty,
                provider ?? string.Empty,
                this,
                connectionFactory);
        }

        public IDbBatch CreateDbBatch(IDb db)
        {
            return new DbBatch(db);
        }

        public IDbCmd CreateDbCmd(IDb db)
        {
            return new DbCmd(db);
        }

        public IDbCon CreateDbCon(IDb db)
        {
            return new DbCon(db);
        }
        #endregion
    }
}
