using System;
using System.Collections.Generic;
using System.Data;

namespace Deipax.DataAccess.Interfaces
{
    public static class IDbConExtensions
    {
        public static IDbBatch CreateDbBatch(
            this IDbCon source)
        {
            return source
                .Db
                .CreateDbBatch()
                .SetConnection(source.GetConnection());
        }

        public static IDbCmd CreateDbCmd(
            this IDbCon source)
        {
            var con = source
                .GetConnection()
                .OpenSafe(source.Db);

            return source
                .Db
                .CreateDbCmd()
                .SetConnection(con);
        }

        public static IDbDataParameter CreateParameter(
            this IDbCon source,
            string name = null,
            object value = null,
            ParameterDirection? direction = default,
            DbType? dbType = default,
            int? size = default)
        {
            return source
                .GetConnection()
                .CreateParameter(name, value, direction, dbType, size);
        }

        public static IEnumerable<IDbDataParameter> CreateParameters(
            this IDbCon source,
            string baseName,
            IEnumerable<object> values)
        {
            return source
                .GetConnection()
                .CreateParameters(baseName, values);
        }

        public static void AsBatch(
            this IDbCon source,
            Action<IDbBatch> func)
        {
            func(source.CreateDbBatch());
        }

        public static T AsBatch<T>(
            this IDbCon source,
            Func<IDbBatch, T> func)
        {
            return func(source.CreateDbBatch());
        }

        public static void AsTransaction(
            this IDbCon source,
            Action<IDbBatch> func)
        {
            var batch = source.CreateDbBatch();
            batch.Connection.OpenSafe(source.Db);

            using (var trans = batch.Connection.BeginTransaction())
            {
                try
                {
                    func(batch.SetTransaction(trans));
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public static void AsTransaction(
            this IDbCon source,
            IsolationLevel isolationLevel,
            Action<IDbBatch> func)
        {
            var batch = source.CreateDbBatch();
            batch.Connection.OpenSafe(source.Db);

            using (var trans = batch.Connection.BeginTransaction(isolationLevel))
            {
                try
                {
                    func(batch.SetTransaction(trans));
                    trans.Commit();
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        public static T AsTransaction<T>(
            this IDbCon source,
            Func<IDbBatch, T> func)
        {
            var batch = source.CreateDbBatch();
            batch.Connection.OpenSafe(source.Db);

            using (var trans = batch.Connection.BeginTransaction())
            {
                try
                {
                    T retVal = func(batch.SetTransaction(trans));
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

        public static T AsTransaction<T>(
            this IDbCon source,
            IsolationLevel isolationLevel,
            Func<IDbBatch, T> func)
        {
            var batch = source.CreateDbBatch();
            batch.Connection.OpenSafe(source.Db);

            using (var trans = batch.Connection.BeginTransaction(isolationLevel))
            {
                try
                {
                    T retVal = func(batch.SetTransaction(trans));
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
    }
}