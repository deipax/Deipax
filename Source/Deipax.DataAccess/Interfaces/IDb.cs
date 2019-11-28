using System;
using System.Data.Common;

namespace Deipax.DataAccess.Interfaces
{
    public interface IDb
    {
        string Name { get; }
        string ConnectionString { get; }
        string ProviderName { get; }
        IDbFactory DbFactory { get; }
        Func<IDb, DbConnection> ConnectionFactory { get; }
    }
}