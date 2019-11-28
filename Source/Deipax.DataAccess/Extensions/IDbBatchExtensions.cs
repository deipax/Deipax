using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Deipax.DataAccess.Interfaces
{
    public static class IDbBatchExtensions
    {
        public static IDbCmd CreateDbCmd(
            this IDbBatch dbBatch)
        {
            dbBatch.Connection.OpenSafe();

            return dbBatch
                .Db
                .CreateDbCmd()
                .SetConnection(dbBatch.Connection)
                .SetTransaction(dbBatch.Transaction);
        }

        public static IDbBatch SetTransaction(
            this IDbBatch source,
            DbTransaction transaction)
        {
            source.Transaction = transaction;
            return source;
        }

        public static IDbBatch SetConnection(
            this IDbBatch source,
            DbConnection connection)
        {
            source.Connection = connection;
            return source;
        }

        public static DbParameter CreateParameter(
            this IDbBatch source,
            string name = null,
            object value = null,
            ParameterDirection? direction = default,
            DbType? dbType = default,
            int? size = default)
        {
            return source.Connection.CreateParameter(name, value, direction, dbType, size);
        }

        public static IEnumerable<DbParameter> CreateParameters(
            this IDbBatch source,
            string baseName,
            IEnumerable<object> values)
        {
            return source.Connection.CreateParameters(baseName, values);
        }
    }
}