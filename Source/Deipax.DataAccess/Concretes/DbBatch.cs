using Deipax.DataAccess.Interfaces;
using System.Data;

namespace Deipax.DataAccess.Concretes
{
	public class DbBatch : IDbBatch
	{
		public DbBatch(IDb db)
		{
			this.Db = db;
		}

		private DbBatch()
		{
		}

		#region IDbCon Members
		public IDb Db { get; set; }
		public IDbConnection Connection { get; set; }
		public IDbTransaction Transaction { get; set; }

		public IDbCmd CreateDbCmd()
		{
			this.Connection.OpenSafe(this.Db);

			return new DbCmd(this.Db)
				.SetConnection(this.Connection)
				.SetTransaction(this.Transaction);
		}
		#endregion
	}
}