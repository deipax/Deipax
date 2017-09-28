using System.Collections.Generic;
using System.Data;

namespace Deipax.DataAccess.Interfaces
{
	public interface IDbCmd
	{
		IDb Db { get; }
		IDbConnection Connection { get; set; }
		IDbTransaction Transaction { get; set; }
		string Name { get; set; }
		string Sql { get; set; }
		CommandType CommandType { get; set; }
		int Timeout { get; set; }
		ICollection<IDbDataParameter> Parameters { get; }
	}
}