using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using UnitTests.Common;

namespace Integration.DataAccess
{
    [TestClass]
    public class DbConfigTests : BaseTest
    {
        [TestMethod]
        public void DbConfigTests_DbBatchFactoryOverride()
        {
            try
            {
                DbConfig.DbBatchFactoryOverride = null;
                var dbBatch = DbConfig.CreateDbBatch(DbHelper.GetNorthwind());
                Assert.IsNotNull(dbBatch);
                Assert.IsNotInstanceOfType(dbBatch, typeof(DbBatchHelperClass));

                DbConfig.DbBatchFactoryOverride = (db) =>
                {
                    return new DbBatchHelperClass()
                    {
                        Db = db
                    };
                };

                var dbBatch2 = DbConfig.CreateDbBatch(DbHelper.GetNorthwind());

                Assert.IsNotNull(dbBatch2);
                Assert.IsInstanceOfType(dbBatch2, typeof(DbBatchHelperClass));
            }
            finally
            {
                DbConfig.DbBatchFactoryOverride = null;
            }
        }

        [TestMethod]
        public void DbConfigTests_DbCmdFactoryOverride()
        {
            try
            {
                DbConfig.DbCmdFactoryOverride = null;
                var dbCmd = DbConfig.CreateDbCmd(DbHelper.GetNorthwind());
                Assert.IsNotNull(dbCmd);
                Assert.IsNotInstanceOfType(dbCmd, typeof(DbCmdHelperClass));

                DbConfig.DbCmdFactoryOverride = (db) =>
                {
                    return new DbCmdHelperClass()
                    {
                        Db = db
                    };
                };

                var dbCmd2 = DbConfig.CreateDbCmd(DbHelper.GetNorthwind());

                Assert.IsNotNull(dbCmd2);
                Assert.IsInstanceOfType(dbCmd2, typeof(DbCmdHelperClass));
            }
            finally
            {
                DbConfig.DbCmdFactoryOverride = null;
            }
        }

        [TestMethod]
        public void DbConfigTests_DbConFactoryOverride()
        {
            try
            {
                DbConfig.DbConFactoryOverride = null;
                var dbCon1 = DbConfig.CreateDbCon(DbHelper.GetNorthwind());
                Assert.IsNotNull(dbCon1);
                Assert.IsNotInstanceOfType(dbCon1, typeof(DbConHelperClass));

                DbConfig.DbConFactoryOverride = (db) =>
                {
                    return new DbConHelperClass()
                    {
                        Db = db
                    };
                };

                var dbCon2 = DbConfig.CreateDbCon(DbHelper.GetNorthwind());

                Assert.IsNotNull(dbCon2);
                Assert.IsInstanceOfType(dbCon2, typeof(DbConHelperClass));
            }
            finally
            {
                DbConfig.DbConFactoryOverride = null;
            }
        }

        [TestMethod]
        public void DbConfigTests_DbFactoryOverride()
        {
            try
            {
                DbConfig.DbFactoryOverride = null;

                var db1 = DbConfig.CreateDb("jon", "cs", "pro");

                Assert.IsNotNull(db1);

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

                Assert.IsInstanceOfType(db2, typeof(DbHelperClass));
                Assert.AreEqual(db2.Name, "jon");
                Assert.AreEqual(db2.ConnectionFactory, db1.ConnectionFactory);
                Assert.AreEqual(db2.ConnectionString, "cs");
                Assert.AreEqual(db2.ProviderName, "pro");
            }
            finally
            {
                DbConfig.DbFactoryOverride = null;
            }
        }

        [TestMethod]
        public void DbConfigTests_CreateDb()
        {
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = DbConfig.CreateDb(
                "name",
                "cs",
                "provider",
                func);

            Assert.IsTrue(db.Name == "name");
            Assert.IsTrue(db.ProviderName == "provider");
            Assert.IsTrue(db.ConnectionString == "cs");
            Assert.AreSame(db.ConnectionFactory, func);
        }

        [TestMethod]
        public void DbConfigTests_CreateManagedOracleDb()
        {
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = DbConfig.CreateManagedOracleDb(
                "name",
                "cs",
                func);

            Assert.IsTrue(db.Name == "name");
            Assert.IsTrue(db.ProviderName == "Oracle.ManagedDataAccess.Client");
            Assert.IsTrue(db.ConnectionString == "cs");
            Assert.AreSame(db.ConnectionFactory, func);
        }

        [TestMethod]
        public void DbConfigTests_CreateOracleDb()
        {
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = DbConfig.CreateOracleDb(
                "name",
                "cs",
                func);

            Assert.IsTrue(db.Name == "name");
            Assert.IsTrue(db.ProviderName == "Oracle.DataAccess.Client");
            Assert.IsTrue(db.ConnectionString == "cs");
            Assert.AreSame(db.ConnectionFactory, func);
        }

        [TestMethod]
        public void DbConfigTests_CreateSqLiteDb()
        {
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = DbConfig.CreateSqLiteDb(
                "name",
                "cs",
                func);

            Assert.IsTrue(db.Name == "name");
            Assert.IsTrue(db.ProviderName == "System.Data.SQLite");
            Assert.IsTrue(db.ConnectionString == "cs");
            Assert.AreSame(db.ConnectionFactory, func);
        }

        [TestMethod]
        public void DbConfigTests_CreateSqlServerDb()
        {
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = DbConfig.CreateSqlServerDb(
                "name",
                "cs",
                func);

            Assert.IsTrue(db.Name == "name");
            Assert.IsTrue(db.ProviderName == "System.Data.SqlClient");
            Assert.IsTrue(db.ConnectionString == "cs");
            Assert.AreSame(db.ConnectionFactory, func);
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