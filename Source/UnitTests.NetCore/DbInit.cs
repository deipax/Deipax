using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace UnitTests.NetCore
{
    public static class DbInit
    {
        public static IDbConnection CreateDbConnection(IDb db)
        {
            var con = DbProviderFactories
                .GetFactory(db.ProviderName)
                .CreateConnection();
            con.ConnectionString = db.ConnectionString;
            return con;
        }

        public static IReadOnlyDictionary<string, IDb> Initialize()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

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