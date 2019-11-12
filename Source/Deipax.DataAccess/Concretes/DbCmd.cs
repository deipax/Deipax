using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using Deipax.DataAccess.Interfaces;

namespace Deipax.DataAccess.Concretes
{
	internal class DbCmd : IDbCmd
	{
		public DbCmd(IDb db)
		{
			Db = db;
			Parameters = new Collection<IDbDataParameter>();
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
		public ICollection<IDbDataParameter> Parameters { get; private set; }
		public string Sql { get; set; }
		public IDbConnection Connection { get; set; }
		public IDbTransaction Transaction { get; set; }
		#endregion
	}
}