using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace Deipax.DataAccess.Common
{
    public delegate IDb CreateDbDelegate(
        string name,
        string cs,
        string provider,
        Func<IDb, IDbConnection> factory = null);

    public delegate IDbCon CreateDbConDelegate(IDb db);
    public delegate IDbBatch CreateDbBatchDelegate(IDb db);
    public delegate IDbCmd CreateDbCmdDelegate(IDb db);

    public static class DbConfig
    {
        /// <summary>
        /// Used to populate the DbManager.  This must be set.
        /// </summary>
        public static Func<IReadOnlyDictionary<string, IDb>> DbInitializer { get; set; }

        /// <summary>
        /// The default method to create a DbConnection.  This must be set.
        /// </summary>
        public static Func<IDb, IDbConnection> DefaultDbConnectionFactory { get; set; }

        /// <summary>
        /// Set this if you want to provide your own implementation of a IDb.
        /// </summary>
        public static CreateDbDelegate DbFactoryOverride { get; set; }

        /// <summary>
        /// Set this if you want to provide your own implementation of a IDbCon.
        /// </summary>
        public static CreateDbConDelegate DbConFactoryOverride { get; set; }

        /// <summary>
        /// Set this if you want to provide your own implementation of a IDbBatch.
        /// </summary>
        public static CreateDbBatchDelegate DbBatchFactoryOverride { get; set; }

        /// <summary>
        /// Set this if you want to provide your own implementation of a IDbCmd.
        /// </summary>
        public static CreateDbCmdDelegate DbCmdFactoryOverride { get; set; }

        public static IDb CreateDb(
            string name,
            string cs,
            string provider,
            Func<IDb, IDbConnection> connectionFactory = null)
        {
            if (DbFactoryOverride != null)
            {
                return DbFactoryOverride(
                    name ?? string.Empty,
                    cs ?? string.Empty,
                    provider ?? string.Empty,
                    connectionFactory ?? DbConfig.DefaultDbConnectionFactory);
            }

            return new Db(
                name ?? string.Empty,
                cs ?? string.Empty,
                provider ?? string.Empty,
                connectionFactory ?? DbConfig.DefaultDbConnectionFactory);
        }

        public static IDb CreateSqLiteDb(
            string name,
            string cs,
            Func<IDb, IDbConnection> connectionFactory = null)
        {
            return CreateDb(name, cs, "System.Data.SQLite", connectionFactory);
        }

        public static IDb CreateSqlServerDb(
            string name,
            string cs,
            Func<IDb, IDbConnection> connectionFactory = null)
        {
            return CreateDb(name, cs, "System.Data.SqlClient", connectionFactory);
        }

        public static IDb CreateOracleDb(
            string name,
            string cs,
            Func<IDb, IDbConnection> connectionFactory = null)
        {
            return CreateDb(name, cs, "Oracle.DataAccess.Client", connectionFactory);
        }

        public static IDb CreateManagedOracleDb(
            string name,
            string cs,
            Func<IDb, IDbConnection> connectionFactory = null)
        {
            return CreateDb(name, cs, "Oracle.ManagedDataAccess.Client", connectionFactory);
        }

        public static IDbCon CreateDbCon(
            IDb db)
        {
            return DbConFactoryOverride != null ?
                DbConFactoryOverride(db) :
                new DbCon(db);
        }

        public static IDbBatch CreateDbBatch(
            IDb db)
        {
            return DbBatchFactoryOverride != null ?
                DbBatchFactoryOverride(db) :
                new DbBatch(db);
        }

        public static IDbCmd CreateDbCmd(
            IDb db)
        {
            return DbCmdFactoryOverride != null ?
                DbCmdFactoryOverride(db) :
                new DbCmd(db);
        }
    }
}