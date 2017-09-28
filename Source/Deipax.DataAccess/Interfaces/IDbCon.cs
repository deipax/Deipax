using System;
using System.Data;

namespace Deipax.DataAccess.Interfaces
{
	public interface IDbCon : IDisposable
	{
		IDb Db { get; }
		IDbConnection GetConnection();
		IDbBatch CreateDbBatch();
	}
}