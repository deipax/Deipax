using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace UnitTests.Common
{
    public static class DbHelper
    {
        public static IDb GetNorthwind()
        {
            return DbConfig.Get("Northwind");
        }

        public static void SetDefaultConnectionFactory()
        {
            DbConfig.DbConnectionFactory = CreateDbConnection;
        }

        public static void SetDbInitializer()
        {
            DbConfig.SetDbInitializer(Initialize);
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
            var config = GetConfig();

            config.GetSection("DbProviders")
                .Get<List<DbProviderInfo>>()
                .ForEach(x => DbProviderFactories.RegisterFactory(x.Invariant, x.Type));

            return config
                .GetSection("Connections")
                .Get<List<ConnectionInfo>>()
                .Where(x =>
                    x != null &&
                    !string.IsNullOrEmpty(x.ConnectionString) &&
                    !string.IsNullOrEmpty(x.Name) &&
                    !string.IsNullOrEmpty(x.ProviderName))
                .ToDictionary(x => x.Name, x => DbConfig.CreateDb(x.Name, x.ConnectionString, x.ProviderName));
        }

        private static IConfiguration GetConfig()
        {
            return new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
        }
        #endregion

        #region Helpers
        private class ConnectionInfo
        {
            public string Name { get; set; }
            public string ProviderName { get; set; }
            public string ConnectionString { get; set; }
        }

        private class DbProviderInfo
        {
            public string Name { get; set; }
            public string Invariant { get; set; }
            public string Description { get; set; }
            public string Type { get; set; }
        }
        #endregion
    }
}