using Deipax.DataAccess.Interfaces;
using System;
using System.Data;

namespace Deipax.DataAccess.Concretes
{
    internal class Db : IDb
    {
        public Db(
            string name,
            string cs,
            string provider,
            IDbFactory dbFactory,
            Func<IDb, IDbConnection> conFactory)
        {
            Name = name;
            ConnectionString = cs;
            ProviderName = provider;
            DbFactory = dbFactory;
            ConnectionFactory = conFactory;
        }

        private Db()
        {
        }

        #region IDb Members
        public string ConnectionString { get; private set; }
        public string Name { get; private set; }
        public string ProviderName { get; private set; }
        public Func<IDb, IDbConnection> ConnectionFactory { get; private set; }
        public IDbFactory DbFactory { get; private set; }
        #endregion
    }
}