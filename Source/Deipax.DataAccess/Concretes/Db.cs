using System;
using System.Data;
using System.Data.Common;
using Deipax.DataAccess.Interfaces;

namespace Deipax.DataAccess.Concretes
{
	internal class Db : IDb
	{
		public Db(
			string name,
			string cs,
			string provider,
			Func<IDb, IDbConnection> factory)
		{
			this.Name = name;
			this.ConnectionString = cs;
			this.ProviderName = provider;
			this.ConnectionFactory = factory;
		}

		private Db()
		{
		}

		#region Public Members

		#endregion

		#region IDb Members
		public string ConnectionString { get; private set; }
		public string Name { get; private set; }
		public string ProviderName { get; private set; }
		public Func<IDb, IDbConnection> ConnectionFactory { get; private set; }

		public IDbCon CreateDbCon()
		{
			return new DbCon(this);
		}
		#endregion
	}
}