﻿using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data;
using System.Linq;
using Xunit;

namespace UnitTests.DataAccess
{
    public class DbAccessTests
    {
        public DbAccessTests()
        {
            _access = new DbCache();
            _access.Add(new CustomDb()
            {
                Name = "NorthWind"
            });
        }

        #region Field Members
        private readonly DbCache _access;
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

            _access.Add(new CustomDb()
            {
                Name = "NorthWind"
            });

            Assert.True(dbs.Count() == 1);

            _access.Add(new CustomDb()
            {
                Name = "BogusName"
            });

            Assert.True(dbs.Count() == 2);
        }

        #region Helpers
        class CustomDb : IDb
        {
            public string ConnectionString { get; set; }
            public string Name { get; set; }
            public string ProviderName { get; set; }
            public Func<IDb, IDbConnection> Factory { get; set; }
        }
        #endregion
    }
}
