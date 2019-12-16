using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace Deipax.DataAccess.Extensions
{
    public static class IDbCommandExtensions
    {
        public static IDataReader ExecuteReader(
            this IDbCommand source,
            IDbCmd dbCmd)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (dbCmd == null) throw new ArgumentNullException(nameof(dbCmd));

            return dbCmd.CommandBehavior.HasValue
                ? source.ExecuteReader(dbCmd.CommandBehavior.Value)
                : source.ExecuteReader();
        }

        public static async Task<DbDataReader> ExecuteReaderAsync(
             this IDbCommand source,
             IDbCmd dbCmd)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (dbCmd == null) throw new ArgumentNullException(nameof(dbCmd));

            if (source is DbCommand dbCommand)
            {
                Task<DbDataReader> task;

                if (dbCmd.CommandBehavior.HasValue)
                {
                    task = dbCmd.CancellationToken.HasValue
                        ? dbCommand.ExecuteReaderAsync(dbCmd.CommandBehavior.Value, dbCmd.CancellationToken.Value)
                        : dbCommand.ExecuteReaderAsync(dbCmd.CommandBehavior.Value);
                }
                else
                {
                    task = dbCmd.CancellationToken.HasValue
                        ? dbCommand.ExecuteReaderAsync(dbCmd.CancellationToken.Value)
                        : dbCommand.ExecuteReaderAsync();
                }

                return await task.ConfigureAwait(false);
            }

            throw new InvalidOperationException("Async operations require use of a DbConnection or an IDbConnection where .CreateCommand() returns a DbCommand");
        }

        public static IDbDataParameter CreateParameter(
            this IDbCommand source,
            string name = default,
            object value = default,
            ParameterDirection? direction = default,
            DbType? dbType = default,
            int? size = default,
            byte? scale = default,
            byte? precision = default,
            DataRowVersion? sourceVersion = default,
            string sourceColumn = default)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            var p = source.CreateParameter();
            if (!string.IsNullOrEmpty(name)) p.ParameterName = name;
            p.Value = value ?? DBNull.Value;
            if (direction.HasValue) p.Direction = direction.Value;
            if (dbType.HasValue) p.DbType = dbType.Value;
            if (size.HasValue) p.Size = size.Value;
            if (scale.HasValue) p.Scale = scale.Value;
            if (precision.HasValue) p.Precision = precision.Value;
            if (sourceVersion.HasValue) p.SourceVersion = sourceVersion.Value;
            if (!string.IsNullOrEmpty(sourceColumn)) p.SourceColumn = sourceColumn;
            return p;
        }
    }
}
