using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data.Common;
using Xunit;

namespace UnitTests.DataAccess
{
    public class DbFactoryTests
    {
        IDbFactory subject = new DbFactory();

        [Fact]
        public void CreateDb()
        {
            Func<IDb, DbConnection> func = (x) =>
            {
                return null;
            };

            var db = subject.CreateDb(
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
        public void CreateDbCmd()
        {
            IDbCmd cmd = subject.CreateDbCmd();
            Assert.NotNull(cmd);
        }
    }
}
