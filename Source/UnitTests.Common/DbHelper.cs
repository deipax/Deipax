using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace UnitTests.Common
{
    public static class DbHelper
    {
        public static IDb GetNorthwind()
        {
            return DbManager.Get("Northwind");
        }

        public static void SetDefaultConnectionFactory()
        {
            DbConfig.DefaultDbConnectionFactory = CreateDbConnection;
        }

        public static void SetDbInitializer()
        {
            DbConfig.DbInitializer = Initialize;
        }

        #region Private Members
        private static IDbConnection CreateDbConnection(IDb db)
        {
            var con = DbProviderFactories
                .GetFactory(db.ProviderName)
                .CreateConnection();
            con.ConnectionString = db.ConnectionString;
            return con;
        }

        private static IReadOnlyDictionary<string, IDb> Initialize()
        {
            return ConfigurationManager
                .ConnectionStrings
                .Cast<ConnectionStringSettings>()
                .Select(x => DbConfig.CreateDb(x.Name, x.ConnectionString, x.ProviderName))
                .Where(x => x != null)
                .ToDictionary(x => x.Name, x => x);
        }
        #endregion
    }
}