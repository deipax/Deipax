using Deipax.DataAccess.Common;
using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;

namespace UnitTests.Common
{
    public static class DbHelper
    {
        static DbHelper()
        {
            _dbProviders = new Dictionary<string, DbProviderFactory>()
            {
                { "System.Data.SQLite", SQLiteFactory.Instance }
            };

            DbFactory factory = new DbFactory();
            _dbCache = new DbCache();
            _dbCache.Add(factory.CreateDb(
                "Northwind",
                "Data Source=.\\Resources\\Northwind_small.sqlite;Version=3;",
                "System.Data.SQLite",
                CreateDbConnection));
        }

        #region Field Members
        private static readonly DbCache _dbCache;
        private static readonly IReadOnlyDictionary<string, DbProviderFactory> _dbProviders;
        #endregion

        #region Public Members
        public static IDb GetNorthwind()
        {
            return _dbCache.Get("Northwind");
        }
        #endregion

        #region Private Members
        private static DbConnection CreateDbConnection(IDb db)
        {
            var factory = _dbProviders[db.ProviderName];
            var con = factory.CreateConnection();
            con.ConnectionString = db.ConnectionString;
            return con;
        }
        #endregion
    }
}