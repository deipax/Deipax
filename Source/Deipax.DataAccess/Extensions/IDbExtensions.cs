using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Deipax.DataAccess.Extensions
{
    public static class IDbExtensions
    {
        #region Public Members
        public static IDbConnection CreateConnection(
            this IDb source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            return source.Factory(source);
        }

        public static IDbConnection Open(
            this IDb source)
        {
            return source.CreateConnection().EnsureOpen();
        }

        public static async Task<IDbConnection> OpenAsync(
            this IDb source,
            CancellationToken? token = default)
        {
            return await source.CreateConnection().EnsureOpenAsync(token).ConfigureAwait(false);
        }
        #endregion

        #region Database Extensions
        public static void Execute(
            this IDb source,
            Action<IDbConnection> action)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (action == null) throw new ArgumentNullException(nameof(action));

            using (var con = source.CreateConnection())
            {
                action(con);
            }
        }

        public static T Execute<T>(
            this IDb source,
            Func<IDbConnection, T> func)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (func == null) throw new ArgumentNullException(nameof(func));

            using (var con = source.CreateConnection())
            {
                return func(con);
            }
        }

        public static void Execute(
            this IDb source,
            Action<IDbConnection, IDbTransaction> action,
            IsolationLevel? isolationLevel = default)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (action == null) throw new ArgumentNullException(nameof(action));

            using (var con = source.Open())
            using (var trans = con.StartTrans(isolationLevel))
            {
                try
                {
                    action(con, trans);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public static T Execute<T>(
            this IDb source,
            Func<IDbConnection, IDbTransaction, T> func,
            IsolationLevel? isolationLevel = default)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (func == null) throw new ArgumentNullException(nameof(func));

            using (var con = source.Open())
            using (var trans = con.StartTrans(isolationLevel))
            {
                try
                {
                    T retVal = func(con, trans);
                    trans.Commit();
                    return retVal;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
        #endregion

        #region Database Extensions Async
        public static async void ExecuteAsync(
            this IDb source,
            Action<IDbConnection> action,
            CancellationToken? token = default)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (action == null) throw new ArgumentNullException(nameof(action));

            using (var con = await source.OpenAsync(token).ConfigureAwait(false))
            {
                action(con);
            }
        }

        public static async Task<T> ExecuteAsync<T>(
            this IDb source,
            Func<IDbConnection, T> func,
            CancellationToken? token = default)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (func == null) throw new ArgumentNullException(nameof(func));

            using (var con = await source.OpenAsync(token).ConfigureAwait(false))
            {
                return func(con);
            }
        }

        public static async void ExecuteAsync(
            this IDb source,
            Action<IDbConnection, IDbTransaction> action,
            CancellationToken? token = default,
            IsolationLevel? isolationLevel = default)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (action == null) throw new ArgumentNullException(nameof(action));

            using (var con = await source.OpenAsync(token).ConfigureAwait(false))
            using (var trans = con.StartTrans(isolationLevel))
            {
                try
                {
                    action(con, trans);
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public static async Task<T> ExecuteAsync<T>(
            this IDb source,
            Func<IDbConnection, IDbTransaction, T> func,
            CancellationToken? token = default,
            IsolationLevel? isolationLevel = default)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (func == null) throw new ArgumentNullException(nameof(func));

            using (var con = await source.OpenAsync(token).ConfigureAwait(false))
            using (var trans = con.StartTrans(isolationLevel))
            {
                try
                {
                    T retVal = func(con, trans);
                    trans.Commit();
                    return retVal;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
        #endregion

        #region Private Members
        private static IDbTransaction StartTrans(
            this IDbConnection source,
            IsolationLevel? isolationLevel = default)
        {
            return isolationLevel.HasValue
                ? source.BeginTransaction(isolationLevel.Value)
                : source.BeginTransaction();
        }
        #endregion
    }
}
