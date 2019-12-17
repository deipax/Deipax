using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace Deipax.DataAccess.Interfaces
{
    public interface IDbCmd
    {
        IDbConnection Connection { get; set; }
        IDbTransaction Transaction { get; set; }
        string CommandText { get; set; }
        ICollection<IDbDataParameter> Parameters { get; }
        CancellationToken? CancellationToken { get; set; }
        CommandBehavior? CommandBehavior { get; set; }
        CommandType? CommandType { get; set; }
        int? CommandTimeout { get; set; }
    }
}