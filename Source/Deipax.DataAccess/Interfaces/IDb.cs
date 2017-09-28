using System;
using System.Data;

namespace Deipax.DataAccess.Interfaces
{
	public interface IDb
	{
		string Name { get; }
		string ConnectionString { get; }
		string ProviderName { get; }
		Func<IDb, IDbConnection> ConnectionFactory { get; }
		IDb CreateDb(
			string name = null,
			string cs = null,
			string provider = null,
			Func<IDb, IDbConnection> factory = null);
		IDbCon CreateDbCon();
	}
}