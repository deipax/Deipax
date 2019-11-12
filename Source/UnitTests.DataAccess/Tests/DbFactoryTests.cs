using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using Xunit;

namespace UnitTests.DataAccess.Tests
{
    public class DbFactoryTests
    {
        [Fact]
        public void CreateDb()
        {
            DbFactory factory = new DbFactory();
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = factory.CreateDb(
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
        public void CreateOracleDb()
        {
            DbFactory factory = new DbFactory();
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = factory.CreateOracleDb(
                "name",
                "cs",
                func);

            Assert.Equal("name", db.Name);
            Assert.Equal("Oracle.DataAccess.Client", db.ProviderName);
            Assert.Equal("cs", db.ConnectionString);
            Assert.Same(func, db.ConnectionFactory);
        }

        [Fact]
        public void CreateManagedOracleDb()
        {
            DbFactory factory = new DbFactory();
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = factory.CreateManagedOracleDb(
                "name",
                "cs",
                func);

            Assert.Equal("name", db.Name);
            Assert.Equal("Oracle.ManagedDataAccess.Client", db.ProviderName);
            Assert.Equal("cs", db.ConnectionString);
            Assert.Same(func, db.ConnectionFactory);
        }

        [Fact]
        public void CreateSqLiteDb()
        {
            DbFactory factory = new DbFactory();
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = factory.CreateSqLiteDb(
                "name",
                "cs",
                func);

            Assert.Equal("name", db.Name);
            Assert.Equal("System.Data.SQLite", db.ProviderName);
            Assert.Equal("cs", db.ConnectionString);
            Assert.Same(func, db.ConnectionFactory);
        }

        [Fact]
        public void CreateSqlServerDb()
        {
            DbFactory factory = new DbFactory();
            Func<IDb, IDbConnection> func = ConnectionFactory;

            var db = factory.CreateSqlServerDb(
                "name",
                "cs",
                func);

            Assert.Equal("name", db.Name);
            Assert.Equal("System.Data.SqlClient", db.ProviderName);
            Assert.Equal("cs", db.ConnectionString);
            Assert.Same(func, db.ConnectionFactory);
        }

        #region Private Members
        private IDbConnection ConnectionFactory(IDb db)
        {
            return null;
        }
        #endregion
    }
}
