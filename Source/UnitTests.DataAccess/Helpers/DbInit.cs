using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;

namespace UnitTests.DataAccess
{
    public static class DbInit
    {
        #region Field Members
        private static IReadOnlyDictionary<string, DbProviderFactory> _dbProviders;
        #endregion

        public static IDbConnection CreateDbConnection(IDb db)
        {
            var factory = _dbProviders[db.ProviderName];
            var con = factory.CreateConnection();
            con.ConnectionString = db.ConnectionString;
            return con;
        }

        public static IReadOnlyDictionary<string, IDb> Initialize()
        {
            // Ideally, DbProviders and Connection information
            // should be driven in a late bound config manner according
            // to the acceptable technique per targetframework.  Since
            // this project supports multiple frameworks and is for 
            // unit tests only, it will not support the short commings
            // for the framesworks that do not provide a DbProviderFactories.
            // This is a quick and dirty solution.
            _dbProviders = new Dictionary<string, DbProviderFactory>()
            {
                { "System.Data.SQLite", SQLiteFactory.Instance }
            };

            var connections = new List<ConnectionInfo>()
            {
                new ConnectionInfo()
                {
                    Name = "Northwind",
                    ConnectionString = "Data Source=.\\Resources\\Northwind_small.sqlite;Version=3;",
                    ProviderName = "System.Data.SQLite"
                }
            };

            return connections
                .Where(x =>
                    x != null &&
                    !string.IsNullOrEmpty(x.ConnectionString) &&
                    !string.IsNullOrEmpty(x.Name) &&
                    !string.IsNullOrEmpty(x.ProviderName))
                .ToDictionary(x => x.Name, x => DbConfig.CreateDb(x.Name, x.ConnectionString, x.ProviderName));
        }

        #region Helpers
        private class ConnectionInfo
        {
            public string Name { get; set; }
            public string ProviderName { get; set; }
            public string ConnectionString { get; set; }
        }
        #endregion
    }
}
