using Deipax.DataAccess.Common;
using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System.Data;
using System.Data.SQLite;

namespace UnitTests.Common
{
    public static class DbHelper
    {
        static DbHelper()
        {
            _dbCache = new DbCache();
            _dbCache.Add(DbFactory.Instance.CreateDb(
                "Northwind",
                "Data Source=.\\Resources\\Northwind_small.sqlite;Version=3;",
                "System.Data.SQLite",
                CreateSqliteConnection));
        }

        #region Field Members
        private static readonly DbCache _dbCache;
        #endregion

        #region Public Members
        public static IDb GetNorthwind()
        {
            return _dbCache.Get("Northwind");
        }
        #endregion

        #region Private Members
        private static IDbConnection CreateSqliteConnection(IDb db)
        {
            var con = SQLiteFactory.Instance.CreateConnection();
            con.ConnectionString = db.ConnectionString;
            return con;
        }
        #endregion
    }
}