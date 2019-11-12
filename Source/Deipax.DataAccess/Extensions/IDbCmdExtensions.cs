﻿using Deipax.Convert;
using Deipax.DataAccess.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Deipax.DataAccess.Interfaces
{
    public static class IDbCmdExtensions
    {
        #region Public Members
        public static IDbCmd SetTransaction(
            this IDbCmd source,
            IDbTransaction transaction)
        {
            source.Transaction = transaction;
            return source;
        }

        public static IDbCmd SetConnection(
            this IDbCmd source,
            IDbConnection connection)
        {
            source.Connection = connection;
            return source;
        }

        public static IDbCmd SetTimeout(
            this IDbCmd source,
            int timeout)
        {
            source.Timeout = timeout;
            return source;
        }

        public static IDbCmd SetName(
            this IDbCmd source,
            string name)
        {
            source.Name = name;
            return source;
        }

        public static IDbCmd SetCommandType(
            this IDbCmd source,
            CommandType command)
        {
            source.CommandType = command;
            return source;
        }

        public static IDbCmd SetSql(
            this IDbCmd source,
            string sql)
        {
            source.Sql = sql;
            return source;
        }

        public static IDbCmd AddParameter(
            this IDbCmd source,
            string name = null,
            object value = null,
            ParameterDirection? direction = default(ParameterDirection?),
            DbType? dbType = default(DbType?),
            int? size = default(int?))
        {
            source.AddParameter(source.Connection.CreateParameter(name, value, direction, dbType, size));
            return source;
        }

        public static IDbCmd AddParameter(
            this IDbCmd source,
            IDbDataParameter parameter)
        {
            source.Parameters.Add(parameter);
            return source;
        }

        public static IDbCmd AddParameters(
            this IDbCmd source,
            IEnumerable<IDbDataParameter> parameters)
        {
            foreach (var p in parameters)
            {
                source.Parameters.Add(p);
            }

            return source;
        }

        public static IDbCmd AddParameters(
            this IDbCmd source,
            string baseName,
            IEnumerable<object> values)
        {
            var parameters = source.Connection.CreateParameters(baseName, values);
            source.AddParameters(parameters);
            return source;
        }

        public static IEnumerable<dynamic> AsDynamicEnumerable(
            this IDbCmd source)
        {
            using (var timer = RunTimer.Create(source))
            using (var dbCmd = source.CreateCommand())
            using (var r = dbCmd.ExecuteReader())
            {
                if (r.FieldCount == 0)
                {
                    yield break;
                }

                var table = DynamicMap2.GetTable(r);
                var map = DynamicMap2.CreateMap(r);

                while (r.Read())
                {
                    yield return map(r, table);
                }
            }
        }

        public static List<dynamic> AsDynamicList(
            this IDbCmd source)
        {
            return source.AsDynamicEnumerable().ToList();
        }

        public static IEnumerable<T> AsEnumerable<T>(
            this IDbCmd source) where T : new()
        {
            using (var timer = RunTimer.Create(source))
            using (var dbCmd = source.CreateCommand())
            using (var r = dbCmd.ExecuteReader())
            {
                if (r.FieldCount == 0)
                {
                    yield break;
                }

                Func<IDataRecord, T> map = DataRecordMap<T>.Create(r);

                while (r.Read())
                {
                    yield return map(r);
                }
            }
        }

        public static List<T> AsList<T>(
            this IDbCmd source) where T : new()
        {
            return source.AsEnumerable<T>().ToList();
        }

        public static int ExecuteNonQuery(
            this IDbCmd source)
        {
            using (var timer = RunTimer.Create(source))
            using (var dbCmd = source.CreateCommand())
            {
                return dbCmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(
            this IDbCmd source)
        {
            using (var timer = RunTimer.Create(source))
            using (var dbCmd = source.CreateCommand())
            {
                var obj = dbCmd.ExecuteScalar();
                return DBNull.Value.Equals(obj) ? null : obj;
            }
        }

        public static T ExecuteScalar<T>(
            this IDbCmd source)
        {
            var obj = source.ExecuteScalar();
            return ConvertTo<T, object>.From(obj);
        }

        public static void ExecuteConnection(
            this IDbCmd source,
            Action<IDbConnection> func)
        {
            using (var timer = RunTimer.Create(source))
            {
                func(source.Connection);
            }
        }

        public static T ExecuteConnection<T>(
            this IDbCmd source,
            Func<IDbConnection, T> func)
        {
            using (var timer = RunTimer.Create(source))
            {
                return func(source.Connection);
            }
        }

        public static void ExecuteCommand(
            this IDbCmd source,
            Action<IDbCommand> action)
        {
            using (var timer = RunTimer.Create(source))
            using (var dbCmd = source.CreateCommand())
            {
                action(dbCmd);
            }
        }

        public static T ExecuteCommand<T>(
            this IDbCmd source,
            Func<IDbCommand, T> func)
        {
            using (var timer = RunTimer.Create(source))
            using (var dbCmd = source.CreateCommand())
            {
                return func(dbCmd);
            }
        }

        public static IDbCommand CreateCommand(
            this IDbCmd source)
        {
            var cmd = source.Connection.CreateCommand();

            var prop = cmd.GetType().GetProperty("BindByName");

            if (prop != null)
            {
                prop.SetValue(cmd, true);
            }

            if (source.Timeout > 0)
            {
                cmd.CommandTimeout = source.Timeout;
            }

            cmd.Transaction = source.Transaction;
            cmd.CommandText = source.Sql;
            cmd.CommandType = source.CommandType;
            cmd.Parameters.Clear();

            foreach (var p in source.Parameters)
            {
                cmd.Parameters.Add(p);
            }

            return cmd;
        }
        #endregion
    }
}