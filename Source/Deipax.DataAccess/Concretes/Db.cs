using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Threading;

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

    public class DbCmd : IDbCmd
    {
        public DbCmd()
        {
            Parameters = new Collection<IDbDataParameter>();
        }

        #region IDbCmd Members
        public ICollection<IDbDataParameter> Parameters { get; }
        public IDbConnection Connection { get; set; }
        public IDbTransaction Transaction { get; set; }
        public string CommandText { get; set; }
        public CommandType? CommandType { get; set; }
        public int? CommandTimeout { get; set; }        
        public CancellationToken? CancellationToken { get; set; }
        public CommandBehavior? CommandBehavior { get; set; }
        #endregion
    }
}
