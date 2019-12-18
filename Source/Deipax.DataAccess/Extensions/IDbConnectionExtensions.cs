using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Deipax.DataAccess.Extensions
{
    public static class IDbConnectionExtensions
    {
        #region Fluent Extensions
        public static IDbCmd CommandBehavior(
            this IDbConnection source,
            CommandBehavior? behavior)
        {
            return DbFactory.Instance.CreateDbCmd().Connection(source).CommandBehavior(behavior);
        }

        public static IDbCmd Transaction(
            this IDbConnection source,
            IDbTransaction trans)
        {
            return DbFactory.Instance.CreateDbCmd().Connection(source).Transaction(trans);
        }

        public static IDbCmd CommandText(
            this IDbConnection source,
            string text)
        {
            return DbFactory.Instance.CreateDbCmd().Connection(source).CommandText(text);
        }

        public static IDbCmd CommandType(
            this IDbConnection source,
            CommandType? type)
        {
            return DbFactory.Instance.CreateDbCmd().Connection(source).CommandType(type);
        }

        public static IDbCmd CommandTimeout(
            this IDbConnection source,
            int? timeout)
        {
            return DbFactory.Instance.CreateDbCmd().Connection(source).CommandTimeout(timeout);
        }

        public static IDbCmd CancellationToken(
            this IDbConnection source,
            CancellationToken? token)
        {
            return DbFactory.Instance.CreateDbCmd().Connection(source).CancellationToken(token);
        }

        public static IDbCmd AddParameter(
            this IDbConnection source,
            params IDbDataParameter[] parameters)
        {
            return DbFactory.Instance.CreateDbCmd().Connection(source).AddParameter(parameters);
        }
        #endregion

        #region Public Members
        public static IDbConnection EnsureOpen(
            this IDbConnection source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (source.State == ConnectionState.Closed) source.Open();
            return source;
        }

        public async static Task<DbConnection> EnsureOpenAsync(
            this IDbConnection source,
            CancellationToken? token = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            if (source is DbConnection dbConn)
            {
                if (source.State == ConnectionState.Closed)
                {
                    var task = token.HasValue
                        ? dbConn.OpenAsync(token.Value)
                        : dbConn.OpenAsync();

                    await task.ConfigureAwait(false);
                }

                return dbConn;
            }

            throw new InvalidOperationException("Async operations require use of a DbConnection or an already-open IDbConnection");
        }

        public static IDbDataParameter CreateParameter(
            this IDbConnection source,
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

            using (IDbCommand cmd = source.CreateCommand())
            {
                return cmd.CreateParameter(name, value, direction, dbType, size, scale, precision, sourceVersion, sourceColumn);
            }
        }
        #endregion
    }
}
