using System.Data;

namespace Deipax.DataAccess.Interfaces
{
	public interface IDbBatch
	{
		IDb Db { get; }
		IDbConnection Connection { get; set; }
		IDbTransaction Transaction { get; set; }
	}
}