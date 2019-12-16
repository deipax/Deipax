using Deipax.DataAccess.Common;
using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data.Common;
using Xunit;

namespace UnitTests.DataAccess
{
    [Collection("Sequential")]
    public class DbFactoryTests : IDisposable
    {
        public DbFactoryTests()
        {
            DbFactory.UserDb = null;
            DbFactory.UserDbCmd = null;
        }

        [Fact]
        public void CreateDb_Default()
        {
            Func<IDb, DbConnection> func = (x) =>
            {
                return null;
            };

            var db = DbFactory.CreateDb(
                "name",
                "cs",
                "provider",
                func);

            Assert.NotNull(db);
            Assert.IsType<Db>(db);
            Assert.Equal("name", db.Name);
            Assert.Equal("provider", db.ProviderName);
            Assert.Equal("cs", db.ConnectionString);
            Assert.Same(func, db.Factory);
        }

        [Fact]
        public void CreateDb_Custom()
        {
            Db db = new Db("name", "cs", "provider", null);

            DbFactory.UserDb = (name, cs, provider, factory) =>
            {
                return db;
            };

            var tmp = DbFactory.CreateDb("x", "y", "z", null);

            Assert.Same(db, tmp);
        }

        [Fact]
        public void CreateDbCmd_Default()
        {
            IDbCmd cmd = DbFactory.CreateDbCmd();
            Assert.NotNull(cmd);
        }

        [Fact]
        public void CreateDbCmd_Custom()
        {
            DbCmd dbCmd = new DbCmd();

            DbFactory.UserDbCmd = () =>
            {
                return dbCmd;
            };

            var tmp = DbFactory.CreateDbCmd();

            Assert.Same(dbCmd, tmp);
        }

        public void Dispose()
        {
            DbFactory.UserDb = null;
            DbFactory.UserDbCmd = null;
        }
    }
}
