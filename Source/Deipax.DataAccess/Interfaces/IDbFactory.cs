using System;
using System.Data.Common;

namespace Deipax.DataAccess.Interfaces
{
    public interface IDbFactory
    {
        IDb CreateDb(
            string name,
            string cs,
            string provider,
            Func<IDb, DbConnection> connectionFactory);

        IDbCon CreateDbCon(IDb db);
        IDbBatch CreateDbBatch(IDb db);
        IDbCmd CreateDbCmd(IDb db);
    }
}
