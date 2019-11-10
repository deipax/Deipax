using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnitTests.Common;
using UnitTests.DataAccess.BaseTests;
using Xunit;

namespace UnitTests.DataAccess
{
    public class DbConfigTests : BaseTest
    {
        [Fact]
        public void DbConfigTests_DbBatchFactoryOverride()
        {
            try
            {
                DbConfig.DbBatchFactoryOverride = null;
                var dbBatch = DbConfig.CreateDbBatch(DbHelper.GetNorthwind());
                Assert.NotNull(dbBatch);
                Assert.IsNotType<DbBatchHelperClass>(dbBatch);

                DbConfig.DbBatchFactoryOverride = (db) =>
                {
                    return new DbBatchHelperClass()
                    {
                        Db = db
                    };
                };

                var dbBatch2 = DbConfig.CreateDbBatch(DbHelper.GetNorthwind());

                Assert.NotNull(dbBatch2);
                Assert.IsType<DbBatchHelperClass>(dbBatch2);
            }
            finally
            {
                DbConfig.DbBatchFactoryOverride = null;
            }
        }

        [Fact]
        public void DbConfigTests_DbCmdFactoryOverride()
        {
            try
            {
                DbConfig.DbCmdFactoryOverride = null;
                var dbCmd = DbConfig.CreateDbCmd(DbHelper.GetNorthwind());
                Assert.NotNull(dbCmd);
                Assert.IsNotType<DbCmdHelperClass>(dbCmd);

                DbConfig.DbCmdFactoryOverride = (db) =>
                {
                    return new DbCmdHelperClass()
                    {
                        Db = db
                    };
                };

                var dbCmd2 = DbConfig.CreateDbCmd(DbHelper.GetNorthwind());

                Assert.NotNull(dbCmd2);
                Assert.IsType<DbCmdHelperClass>(dbCmd2);
            }
            finally
            {
                DbConfig.DbCmdFactoryOverride = null;
            }
        }

        [Fact]
        public void DbConfigTests_DbConFactoryOverride()
        {
            try
            {
                DbConfig.DbConFactoryOverride = null;
                var dbCon1 = DbConfig.CreateDbCon(DbHelper.GetNorthwind());
                Assert.NotNull(dbCon1);
                Assert.IsNotType<DbConHelperClass>(dbCon1);

                DbConfig.DbConFactoryOverride = (db) =>
                {
                    return new DbConHelperClass()
                    {
                        Db = db
                    };
                };

                var dbCon2 = DbConfig.CreateDbCon(DbHelper.GetNorthwind());

                Assert.NotNull(dbCon2);
                Assert.IsType<DbConHelperClass>(dbCon2);
            }
            finally
            {
                DbConfig.DbConFactoryOverride = null;
            }
        }

        [Fact]
        public void DbConfigTests_DbFactoryOverride()
        {
            try
            {
                DbConfig.DbFactoryOverride = null;

                var db1 = DbConfig.CreateDb("jon", "cs", "pro");

                Assert.NotNull(db1);

                DbConfig.DbFactoryOverride = (name, cs, provider, func) =>
                {
                    return new DbHelperClass()
                    {
                        Name = name,
                        ConnectionFactory = func,
                        ConnectionString = cs,
                        ProviderName = provider
                    };
                };

                var db2 = DbConfig.CreateDb("jon", "cs", "pro");

                Assert.IsType<DbHelperClass>(db2);
                Assert.Equal("jon", db2.Name);
                Assert.Same(db1.ConnectionFactory, db2.ConnectionFactory);
                Assert.Equal("cs", db2.ConnectionString);
                Assert.Equal("pro", db2.ProviderName);
            }
            finally
            {
                DbConfig.DbFactoryOverride = null;
            }
        }

        [Fact]
        public void DbConfigTests_CreateDb()
        {
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = DbConfig.CreateDb(
                "name",
                "cs",
                "provider",
                func);

            Assert.Equal("name", db.Name);
            Assert.Equal("provider", db.ProviderName);
            Assert.Equal("cs", db.ConnectionString);
            Assert.Same(func, db.ConnectionFactory);
        }

        [Fact]
        public void DbConfigTests_CreateManagedOracleDb()
        {
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = DbConfig.CreateManagedOracleDb(
                "name",
                "cs",
                func);

            Assert.Equal("name", db.Name);
            Assert.Equal("Oracle.ManagedDataAccess.Client", db.ProviderName);
            Assert.Equal("cs", db.ConnectionString);
            Assert.Same(func, db.ConnectionFactory);
        }

        [Fact]
        public void DbConfigTests_CreateOracleDb()
        {
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = DbConfig.CreateOracleDb(
                "name",
                "cs",
                func);

            Assert.Equal("name", db.Name);
            Assert.Equal("Oracle.DataAccess.Client", db.ProviderName);
            Assert.Equal("cs", db.ConnectionString);
            Assert.Same(func, db.ConnectionFactory);
        }

        [Fact]
        public void DbConfigTests_CreateSqLiteDb()
        {
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = DbConfig.CreateSqLiteDb(
                "name",
                "cs",
                func);

            Assert.Equal("name", db.Name);
            Assert.Equal("System.Data.SQLite", db.ProviderName);
            Assert.Equal("cs", db.ConnectionString);
            Assert.Same(func, db.ConnectionFactory);
        }

        [Fact]
        public void DbConfigTests_CreateSqlServerDb()
        {
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = DbConfig.CreateSqlServerDb(
                "name",
                "cs",
                func);

            Assert.Equal("name", db.Name);
            Assert.Equal("System.Data.SqlClient", db.ProviderName);
            Assert.Equal("cs", db.ConnectionString);
            Assert.Same(func, db.ConnectionFactory);
        }

        [Fact]
        public void DbConfigTests_Get()
        {
            var db1 = DbConfig.Get("Northwind");
            Assert.NotNull(db1);

            var db2 = DbConfig.Get("BogusName");
            Assert.Null(db2);

            var db3 = DbConfig.Get("Northwind");
            Assert.Same(db1, db3);
        }

        [Fact]
        public void DbConfigTests_GetAll()
        {
            var dbs = DbConfig.GetAll();

            Assert.NotNull(dbs);
            Assert.True(dbs.Count() > 0);
        }

        [Fact]
        public void DbConfigTests_Clear()
        {
            var db1 = DbConfig.Get("Northwind");
            // Verify that resetting the initializer, clears the IDbs.
            DbConfig.SetDbInitializer(DbHelper.Initialize);
            var db2 = DbHelper.GetNorthwind();
            Assert.NotNull(db1);
            Assert.NotNull(db2);
            Assert.NotSame(db1, db2);
        }

        #region Private Members
        private IDbConnection ConnectionFactory(IDb db)
        {
            return null;
        }
        #endregion

        #region Helpers
        class DbBatchHelperClass : IDbBatch
        {
            public IDbConnection Connection { get; set; }
            public IDb Db { get; set; }
            public IDbTransaction Transaction { get; set; }
        }

        class DbCmdHelperClass : IDbCmd
        {
            public CommandType CommandType { get; set; }
            public IDbConnection Connection { get; set; }
            public IDb Db { get; set; }
            public string Name { get; set; }
            public ICollection<IDbDataParameter> Parameters { get; set; }
            public string Sql { get; set; }
            public int Timeout { get; set; }
            public IDbTransaction Transaction { get; set; }
        }

        class DbConHelperClass : IDbCon
        {
            public IDb Db { get; set; }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public IDbConnection GetConnection()
            {
                throw new NotImplementedException();
            }
        }

        class DbHelperClass : IDb
        {
            public Func<IDb, IDbConnection> ConnectionFactory { get; set; }
            public string ConnectionString { get; set; }
            public string Name { get; set; }
            public string ProviderName { get; set; }
        }
        #endregion
    }
}