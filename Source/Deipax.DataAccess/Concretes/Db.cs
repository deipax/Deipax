using Deipax.DataAccess.Interfaces;
using System;
using System.Data.Common;

namespace Deipax.DataAccess.Concretes
{
    public class Db : IDb
    {
        public Db(
            string name,
            string cs,
            string provider,
            IDbFactory dbFactory,
            Func<IDb, DbConnection> conFactory)
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
        public Func<IDb, DbConnection> ConnectionFactory { get; private set; }
        public IDbFactory DbFactory { get; private set; }
        #endregion
    }
}