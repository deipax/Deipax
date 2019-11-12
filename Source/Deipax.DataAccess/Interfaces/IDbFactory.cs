using System;
using System.Data;

namespace Deipax.DataAccess.Interfaces
{
    public interface IDbFactory
    {
        IDb CreateDb(
            string name,
            string cs,
            string provider,
            Func<IDb, IDbConnection> connectionFactory);

        IDbCon CreateDbCon(IDb db);
        IDbBatch CreateDbBatch(IDb db);
        IDbCmd CreateDbCmd(IDb db);
    }
}
