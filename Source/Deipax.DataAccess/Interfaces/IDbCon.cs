using System;
using System.Data.Common;

namespace Deipax.DataAccess.Interfaces
{
    public interface IDbCon : IDisposable
    {
        IDb Db { get; }
        DbConnection GetConnection();
    }
}