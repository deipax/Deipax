using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
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

        #region Database Extensions
        /// <summary>
        /// Either read all items or use a using block to ensure all resources are fully cleaned up.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static IManagedEnumerable<T> AsEnumerable<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null) where T : new()
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerable<T>();
        }

        /// <summary>
        /// Either read all items or use a using block to ensure all resources are fully cleaned up.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static IEnumerable<dynamic> AsEnumerable(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerable();
        }

        public static T First<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null) where T : new()
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerable<T>()
                .ExecuteFirst();
        }

        public static dynamic First(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerable()
                .ExecuteFirst();
        }

        public static T FirstOrDefault<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null) where T : new()
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerable<T>()
                .ExecuteFirstOrDefault();
        }

        public static dynamic FirstOrDefault(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerable()
                .ExecuteFirstOrDefault();
        }

        public static T Single<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null) where T : new()
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerable<T>()
                .ExecuteSingle();
        }

        public static dynamic Single(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerable()
                .ExecuteSingle();
        }

        public static T SingleOrDefault<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null) where T : new()
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerable<T>()
                .ExecuteSingleOrDefault();
        }

        public static dynamic SingleOrDefault(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerable()
                .ExecuteSingleOrDefault();
        }

        public static int ExecuteNonQuery(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .ExecuteNonQuery();
        }

        public static object ExecuteScalar(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .ExecuteScalar();
        }

        public static T ExecuteScalar<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .ExecuteScalar<T>();
        }

        public static void Execute(
            this IDbConnection source,
            string sql,
            Action<IDbCommand> action,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .Execute(action);
        }

        public static T Execute<T>(
            this IDbConnection source,
            string sql,
            Func<IDbCommand, T> func,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .Execute(func);
        }
        #endregion

        #region Database Extensions Async
        /// <summary>
        /// Either read all items or use a using block to ensure all resources are fully cleaned up.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> AsEnumerableAsync<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null) where T : new()
        {
            return await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerableAsync<T>()
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Either read all items or use a using block to ensure all resources are fully cleaned up.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static async Task<IEnumerable<dynamic>> AsEnumerableAsync(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerableAsync()
                .ConfigureAwait(false);
        }

        public static async Task<T> FirstAsync<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null) where T : new()
        {
            return (await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerableAsync<T>()
                .ConfigureAwait(false))
                .ExecuteFirst();
        }

        public static async Task<dynamic> FirstAsync(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return (await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerableAsync()
                .ConfigureAwait(false))
                .ExecuteFirst();
        }

        public static async Task<T> FirstOrDefaultAsync<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null) where T : new()
        {
            return (await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerableAsync<T>()
                .ConfigureAwait(false))
                .ExecuteFirstOrDefault();
        }

        public static async Task<dynamic> FirstOrDefaultAsync(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return (await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerableAsync()
                .ConfigureAwait(false))
                .ExecuteFirstOrDefault();
        }

        public static async Task<T> SingleAsync<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null) where T : new()
        {
            return (await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerableAsync<T>()
                .ConfigureAwait(false))
                .ExecuteSingle();
        }

        public static async Task<dynamic> SingleAsync(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return (await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerableAsync()
                .ConfigureAwait(false))
                .ExecuteSingle();
        }

        public static async Task<T> SingleOrDefaultAsync<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null) where T : new()
        {
            return (await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerableAsync<T>()
                .ConfigureAwait(false))
                .ExecuteSingleOrDefault();
        }

        public static async Task<dynamic> SingleOrDefaultAsync(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return (await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .AsEnumerableAsync()
                .ConfigureAwait(false))
                .ExecuteSingleOrDefault();
        }

        public static async Task<int> ExecuteNonQueryAsync(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .ExecuteNonQueryAsync()
                .ConfigureAwait(false);
        }

        public static async Task<object> ExecuteScalarAsync(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .ExecuteScalarAsync()
                .ConfigureAwait(false);
        }

        public static async Task<T> ExecuteScalarAsync<T>(
            this IDbConnection source,
            string sql,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .ExecuteScalarAsync<T>()
                .ConfigureAwait(false);
        }

        public static void ExecuteAsync(
            this IDbConnection source,
            string sql,
            Action<DbCommand> action,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .ExecuteAsync(action);
        }

        public static async Task<T> ExecuteAsync<T>(
            this IDbConnection source,
            string sql,
            Func<DbCommand, T> func,
            IDbDataParameter[] parameters = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            return await DbFactory
                .Instance
                .CreateDbCmd()
                .Connection(source)
                .CommandText(sql)
                .AddParameter(parameters)
                .Transaction(transaction)
                .CommandTimeout(commandTimeout)
                .CommandType(commandType)
                .ExecuteAsync(func)
                .ConfigureAwait(false);
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
