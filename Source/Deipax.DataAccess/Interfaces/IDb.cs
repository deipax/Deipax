using System;
using System.Data;

namespace Deipax.DataAccess.Interfaces
{
	public interface IDb
	{
		string Name { get; }
		string ConnectionString { get; }
		string ProviderName { get; }
        IDbFactory DbFactory { get; }
		Func<IDb, IDbConnection> ConnectionFactory { get; }
	}
}