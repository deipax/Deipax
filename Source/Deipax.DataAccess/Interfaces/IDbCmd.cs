using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Deipax.DataAccess.Interfaces
{
    public interface IDbCmd
    {
        IDb Db { get; }
        DbConnection Connection { get; set; }
        DbTransaction Transaction { get; set; }
        string Name { get; set; }
        string Sql { get; set; }
        CommandType CommandType { get; set; }
        int Timeout { get; set; }
        ICollection<DbParameter> Parameters { get; }
    }
}