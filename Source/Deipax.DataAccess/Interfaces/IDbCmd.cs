using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace Deipax.DataAccess.Interfaces
{
    public interface IDbCmd
    {
        /// <summary>
        /// If present, this value will be set on the command
        /// </summary>
        IDbConnection Connection { get; set; }

        /// <summary>
        /// If present, this value will be set on the command
        /// </summary>
        IDbTransaction Transaction { get; set; }

        /// <summary>
        /// If present, this value will be set on the command
        /// </summary>
        string CommandText { get; set; }

        /// <summary>
        /// If present, these values will be set on the command
        /// </summary>
        ICollection<IDbDataParameter> Parameters { get; }

        /// <summary>
        /// If present, this will be passed to underlying calls
        /// and checked were appropriate.
        /// </summary>
        CancellationToken? CancellationToken { get; set; }

        /// <summary>
        /// If present, this value will be passed to the reader.
        /// </summary>
        CommandBehavior? CommandBehavior { get; set; }

        /// <summary>
        /// If present, this value will be set on the command.
        /// </summary>
        CommandType? CommandType { get; set; }

        /// <summary>
        /// If present, this value will be set on the command.
        /// </summary>
        int? CommandTimeout { get; set; }
    }
}