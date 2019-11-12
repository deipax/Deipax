using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using System.Linq;
using Xunit;

namespace UnitTests.DataAccess.Tests
{
    public class DbAccessTests
    {
        public DbAccessTests()
        {
            _access = new DbAccess();
            _access.Add(new DbHelperClass()
            {
                Name= "NorthWind"
            });
        }

        #region Field Members
        private DbAccess _access;
        #endregion

        [Fact]
        public void Get()
        {
            var db1 = _access.Get("NorthWind");
            Assert.NotNull(db1);

            var db2 = _access.Get("BogusName");
            Assert.Null(db2);

            var db3 = _access.Get("NorthWind");
            Assert.Same(db1, db3);
        }

        [Fact]
        public void GetAll()
        {
            var dbs = _access.GetAll();

            Assert.NotNull(dbs);
            Assert.True(dbs.Count() > 0);
        }

        [Fact]
        public void Add()
        {
            var dbs = _access.GetAll();
            Assert.True(dbs.Count() == 1);

            _access.Add(new DbHelperClass()
            {
                Name= "NorthWind"
            });

             Assert.True(dbs.Count() == 1);

            _access.Add(new DbHelperClass()
            {
                Name= "BogusName"
            });

            Assert.True(dbs.Count() == 2);
        }

        #region Helpers
        class DbHelperClass : IDb
        {
            public string ConnectionString { get; set; }
            public string Name { get; set; }
            public string ProviderName { get; set; }
            public IDbFactory DbFactory { get; set; }
            public Func<IDb, IDbConnection> ConnectionFactory { get; set; }
        }
        #endregion
    }
}
