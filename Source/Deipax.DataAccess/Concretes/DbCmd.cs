using Deipax.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;

namespace Deipax.DataAccess.Concretes
{
    public class DbCmd : IDbCmd
    {
        public DbCmd(IDb db)
        {
            Db = db;
            Parameters = new Collection<DbParameter>();
            CommandType = CommandType.Text;
            Timeout = -1;
        }

        private DbCmd()
        {
        }

        #region IDbCmd Members
        public IDb Db { get; private set; }
        public CommandType CommandType { get; set; }
        public string Name { get; set; }
        public int Timeout { get; set; }
        public ICollection<DbParameter> Parameters { get; private set; }
        public string Sql { get; set; }
        public DbConnection Connection { get; set; }
        public DbTransaction Transaction { get; set; }
        #endregion
    }
}