using System;
using System.Data;

namespace Deipax.DataAccess.Interfaces
{
    public static class IDbExtensions
    {
        #region Public Members
        public static IDb CreateDb(
            this IDb source,
            string name = null,
            string cs = null,
            string provider = null,
            Func<IDb, IDbConnection> factory = null)
        {
            return source.DbFactory.CreateDb(
                name ?? source.Name,
                cs ?? source.ConnectionString,
                provider ?? source.ProviderName,
                factory ?? source.ConnectionFactory);
        }

        public static IDbCon CreateDbCon(
            this IDb source)
        {
            return source.DbFactory.CreateDbCon(source);
        }

        public static IDbBatch CreateDbBatch(
            this IDb source)
        {
            return source.DbFactory.CreateDbBatch(source);
        }

        public static IDbCmd CreateDbCmd(
            this IDb source)
        {
            return source.DbFactory.CreateDbCmd(source);
        }

        public static void AsTransaction(
            this IDb source,
            Action<IDbBatch> func)
        {
            using (var con = source.CreateDbCon())
            {
                con.AsTransaction(func);
            }
        }

        public static void AsTransaction(
            this IDb source,
            IsolationLevel isolationLevel,
            Action<IDbBatch> func)
        {
            using (var con = source.CreateDbCon())
            {
                con.AsTransaction(isolationLevel, func);
            }
        }

        public static T AsTransaction<T>(
            this IDb source,
            Func<IDbBatch, T> func)
        {
            using (var con = source.CreateDbCon())
            {
                return con.AsTransaction<T>(func);
            }
        }

        public static T AsTransaction<T>(
            this IDb source,
            IsolationLevel isolationLevel,
            Func<IDbBatch, T> func)
        {
            using (var con = source.CreateDbCon())
            {
                return con.AsTransaction<T>(isolationLevel, func);
            }
        }

        public static void AsBatch(
            this IDb source,
            Action<IDbBatch> func)
        {
            using (var con = source.CreateDbCon())
            {
                con.AsBatch(func);
            }
        }

        public static T AsBatch<T>(
            this IDb source,
            Func<IDbBatch, T> func)
        {
            using (var con = source.CreateDbCon())
            {
                return con.AsBatch(func);
            }
        }
        #endregion
    }
}