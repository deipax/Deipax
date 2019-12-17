using Deipax.DataAccess.Interfaces;
using System;
using System.Data;

namespace Deipax.DataAccess.Concretes
{
    public class Db : IDb
    {
        public Db(
            string name,
            string cs,
            string provider,
            Func<IDb, IDbConnection> factory)
        {
            Name = name;
            ConnectionString = cs;
            ProviderName = provider;
            Factory = factory;
        }

        #region IDb Members
        public string ConnectionString { get; private set; }
        public string Name { get; private set; }
        public string ProviderName { get; private set; }
        public Func<IDb, IDbConnection> Factory { get; private set; }
        #endregion
    }


}
