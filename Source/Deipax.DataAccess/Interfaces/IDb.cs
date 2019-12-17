using System;
using System.Data;

namespace Deipax.DataAccess.Interfaces
{
    public interface IDb
    {
        string Name { get; }
        string ConnectionString { get; }
        string ProviderName { get; }
        Func<IDb, IDbConnection> Factory { get; }
    }
}
