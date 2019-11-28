using System.Data.Common;

namespace Deipax.DataAccess.Interfaces
{
    public interface IDbBatch
    {
        IDb Db { get; }
        DbConnection Connection { get; set; }
        DbTransaction Transaction { get; set; }
    }
}