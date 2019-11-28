using System;
using System.Data.Common;

namespace Deipax.DataAccess.Interfaces
{
    public static class IDbFactoryExtensions
    {
        public static IDb CreateSqLiteDb(
            this IDbFactory source,
            string name,
            string cs,
            Func<IDb, DbConnection> connectionFactory)
        {
            return source.CreateDb(name, cs, "System.Data.SQLite", connectionFactory);
        }

        public static IDb CreateSqlServerDb(
            this IDbFactory source,
            string name,
            string cs,
            Func<IDb, DbConnection> connectionFactory)
        {
            return source.CreateDb(name, cs, "System.Data.SqlClient", connectionFactory);
        }

        public static IDb CreateOracleDb(
            this IDbFactory source,
            string name,
            string cs,
            Func<IDb, DbConnection> connectionFactory)
        {
            return source.CreateDb(name, cs, "Oracle.DataAccess.Client", connectionFactory);
        }

        public static IDb CreateManagedOracleDb(
            this IDbFactory source,
            string name,
            string cs,
            Func<IDb, DbConnection> connectionFactory)
        {
            return source.CreateDb(name, cs, "Oracle.ManagedDataAccess.Client", connectionFactory);
        }
    }
}
