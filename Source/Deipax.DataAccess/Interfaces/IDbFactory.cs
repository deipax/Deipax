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
            Func<IDb, IDbConnection> factory);

        IDbCmd CreateDbCmd();
    }
}
