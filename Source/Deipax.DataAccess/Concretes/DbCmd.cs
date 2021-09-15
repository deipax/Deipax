using Deipax.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Threading;

namespace Deipax.DataAccess.Concretes
{
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
