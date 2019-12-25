using Deipax.Convert;
using Deipax.DataAccess.Common;
using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using CmdBehavior = System.Data.CommandBehavior;

namespace Deipax.DataAccess.Extensions
{
    public static class IDbCmdExtensions
    {
        #region Field Members
        private static readonly Dictionary<Type, Action<IDbCommand>> _cache = new Dictionary<Type, Action<IDbCommand>>();
        private static readonly object _lock = new object();
        #endregion

        #region Fluent Extensions
        public static IDbCmd CommandBehavior(
            this IDbCmd source,
            CmdBehavior? behavior)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            source.CommandBehavior = source.CommandBehavior.HasValue
                ? source.CommandBehavior | behavior
                : behavior;

            return source;
        }

        public static IDbCmd Connection(
            this IDbCmd source,
            IDbConnection con)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            source.Connection = con;
            return source;
        }

        public static IDbCmd Transaction(
            this IDbCmd source,
            IDbTransaction trans)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            source.Transaction = trans;
            return source;
        }

        public static IDbCmd CommandText(
            this IDbCmd source,
            string text)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            source.CommandText = text;
            return source;
        }

        public static IDbCmd CommandType(
            this IDbCmd source,
            CommandType? type)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            source.CommandType = type;
            return source;
        }

        public static IDbCmd CommandTimeout(
            this IDbCmd source,
            int? timeout)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            source.CommandTimeout = timeout;
            return source;
        }

        public static IDbCmd CancellationToken(
            this IDbCmd source,
            CancellationToken? token)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            source.CancellationToken = token;
            return source;
        }

        public static IDbCmd AddParameter(
            this IDbCmd source,
            params IDbDataParameter[] parameters)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (parameters == null) throw new ArgumentNullException(nameof(parameters));

            foreach (var parameter in parameters)
            {
                if (parameter != null) source.Parameters.Add(parameter);
            }

            return source;
        }
        #endregion

        #region Database Extensions
        /// <summary>
        /// Either read all items or use a using block to ensure all
        /// resources are fully cleaned up.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IManagedEnumerable<dynamic> AsEnumerable(
            this IDbCmd source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            source.CommandBehavior(CmdBehavior.SingleResult);
            var cmd = source.CreateAndOpen();
            var reader = cmd.ExecuteReader(source);
            return new ManagedEnumerable
            {
                DbCmd = source,
                DbCommand = cmd,
                Reader = reader
            };
        }

        /// <summary>
        /// Either read all items or use a using block to ensure all
        /// resources are fully cleaned up.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IManagedEnumerable<T> AsEnumerable<T>(
            this IDbCmd source) where T : new()
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            source.CommandBehavior(CmdBehavior.SingleResult);
            var cmd = source.CreateAndOpen();
            var reader = cmd.ExecuteReader(source);
            return new ManagedEnumerable<T>
            {
                DbCmd = source,
                DbCommand = cmd,
                Reader = reader
            };
        }

        public static int ExecuteNonQuery(
            this IDbCmd source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            using (var cmd = source.CreateAndOpen())
            {
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(
            this IDbCmd source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            using (var cmd = source.CreateAndOpen())
            {
                var obj = cmd.ExecuteScalar();
                return DBNull.Value.Equals(obj) ? null : obj;
            }
        }

        public static T ExecuteScalar<T>(
            this IDbCmd source)
        {
            var obj = source.ExecuteScalar();
            return ConvertTo<T, object>.From(obj);
        }

        public static void Execute(
            this IDbCmd source,
            Action<IDbCommand> action)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (action == null) throw new ArgumentNullException(nameof(action));

            using (var dbCmd = source.CreateAndOpen())
            {
                action(dbCmd);
            }
        }

        public static T Execute<T>(
            this IDbCmd source,
            Func<IDbCommand, T> func)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (func == null) throw new ArgumentNullException(nameof(func));

            using (var dbCmd = source.CreateAndOpen())
            {
                return func(dbCmd);
            }
        }
        #endregion

        #region Database Extensions Async
        /// <summary>
        /// Either read all items or use a using block to ensure all
        /// resources are fully cleaned up.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static async Task<IManagedEnumerable<dynamic>> AsEnumerableAsync(
            this IDbCmd source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            source.CommandBehavior(CmdBehavior.SingleResult);
            var cmd = await source.CreateAndOpenAsync().ConfigureAwait(false);
            var reader = await cmd.ExecuteReaderAsync(source).ConfigureAwait(false);
            return new ManagedEnumerable
            {
                DbCmd = source,
                DbCommand = cmd,
                Reader = reader
            };
        }

        /// <summary>
        /// Either read all items or use a using block to ensure all
        /// resources are fully cleaned up.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static async Task<IManagedEnumerable<T>> AsEnumerableAsync<T>(
            this IDbCmd source) where T : new()
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            source.CommandBehavior(CmdBehavior.SingleResult);
            var cmd = await source.CreateAndOpenAsync().ConfigureAwait(false);
            var reader = await cmd.ExecuteReaderAsync(source).ConfigureAwait(false);
            return new ManagedEnumerable<T>
            {
                DbCmd = source,
                DbCommand = cmd,
                Reader = reader
            };
        }

        public static async Task<int> ExecuteNonQueryAsync(
            this IDbCmd source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            using (var cmd = await source.CreateAndOpenAsync().ConfigureAwait(false))
            {
                return source.CancellationToken.HasValue
                    ? await cmd.ExecuteNonQueryAsync(source.CancellationToken.Value).ConfigureAwait(false)
                    : await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
            }
        }

        public static async Task<object> ExecuteScalarAsync(
            this IDbCmd source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            using (var cmd = await source.CreateAndOpenAsync().ConfigureAwait(false))
            {
                var obj = source.CancellationToken.HasValue
                    ? await cmd.ExecuteScalarAsync(source.CancellationToken.Value).ConfigureAwait(false)
                    : await cmd.ExecuteScalarAsync().ConfigureAwait(false);

                return DBNull.Value.Equals(obj) ? null : obj;
            }
        }

        public static async Task<T> ExecuteScalarAsync<T>(
            this IDbCmd source)
        {
            var obj = await source.ExecuteScalarAsync().ConfigureAwait(false);
            return ConvertTo<T, object>.From(obj);
        }

        public static async void ExecuteAsync(
            this IDbCmd source,
            Action<DbCommand> action)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (action == null) throw new ArgumentNullException(nameof(action));

            using (var dbCmd = await source.CreateAndOpenAsync().ConfigureAwait(false))
            {
                action(dbCmd);
            }
        }

        public static async Task<T> ExecuteAsync<T>(
            this IDbCmd source,
            Func<DbCommand, T> func)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (func == null) throw new ArgumentNullException(nameof(func));

            using (var dbCmd = await source.CreateAndOpenAsync().ConfigureAwait(false))
            {
                return await source.CreateTask(func, dbCmd).ConfigureAwait(false);
            }
        }
        #endregion

        #region Private Members
        private static IDbCommand CreateAndOpen(
            this IDbCmd source)
        {
            var cmd = source.CreateCommand();
            cmd.Connection.EnsureOpen();
            return cmd;
        }

        private static async Task<DbCommand> CreateAndOpenAsync(
            this IDbCmd source)
        {
            var cmd = source.CreateCommand();
            await cmd.Connection.EnsureOpenAsync(source.CancellationToken).ConfigureAwait(false);

            if (cmd is DbCommand dbCommand)
            {
                return dbCommand;
            }
            else
            {
                throw new InvalidOperationException("Async operations require use of a DbCommand");
            }
        }

        private static IDbCommand CreateCommand(
            this IDbCmd source)
        {
            var cmd = source.Connection.CreateCommand();

            var init = GetInit(cmd.GetType());
            init?.Invoke(cmd);

            if (source.CommandType.HasValue) cmd.CommandType = source.CommandType.Value;
            if (source.CommandTimeout.HasValue) cmd.CommandTimeout = source.CommandTimeout.Value;
            cmd.Transaction = source.Transaction;
            cmd.CommandText = source.CommandText;
            cmd.Connection = source.Connection;

            cmd.Parameters.Clear();

            foreach (var p in source.Parameters)
            {
                cmd.Parameters.Add(p);
            }

            return cmd;
        }

        private static Task<T> CreateTask<T>(
            this IDbCmd source,
            Func<DbCommand, T> func,
            DbCommand dbCmd)
        {
            return Task.Factory.StartNew(() =>
            {
                return func(dbCmd);
            },
            source.CancellationToken ?? System.Threading.CancellationToken.None,
            TaskCreationOptions.None,
            TaskScheduler.Default);
        }

        private static Action<IDbCommand> GetInit(
            Type type)
        {
            if (!_cache.TryGetValue(type, out Action<IDbCommand> value))
            {
                lock (_lock)
                {
                    if (!_cache.TryGetValue(type, out value))
                    {
                        value = CreateInit(type);
                        _cache.Add(type, value);
                    }
                }
            }

            return value;
        }

        private static Action<IDbCommand> CreateInit(
            Type type)
        {
            var expressions = new List<Expression>();
            var command = Expression.Variable(typeof(IDbCommand), "command");

            FieldInfo bindByName = type.GetField("BindByName");
            FieldInfo fetchSize = type.GetField("InitialLONGFetchSize");

            if (bindByName != null)
            {
                expressions.Add(Expression.Assign(
                    Expression.MakeMemberAccess(command, bindByName),
                    Expression.Constant(true)));
            }

            if (fetchSize != null)
            {
                expressions.Add(Expression.Assign(
                    Expression.MakeMemberAccess(command, fetchSize),
                    Expression.Constant(-1)));
            }

            Action<IDbCommand> value = null;

            if (expressions.Count > 0)
            {
                BlockExpression block = Expression.Block(
                new[] { command },
                expressions);

                var lambda = Expression.Lambda<Action<IDbCommand>>(
                    block,
                    command);

                value = lambda.Compile();
            }

            return value;
        }
        #endregion
    }
}
