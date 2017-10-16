using Deipax.DataAccess.Common;
using System.Collections.Generic;
using System.Data;

namespace Deipax.DataAccess.Interfaces
{
	public static class IDbBatchExtensions
	{
		public static IDbBatch SetTransaction(
			this IDbBatch source,
			IDbTransaction transaction)
		{
			source.Transaction = transaction;
			return source;
		}

		public static IDbBatch SetConnection(
			this IDbBatch source,
			IDbConnection connection)
		{
			source.Connection = connection;
			return source;
		}

		public static IDbDataParameter CreateParameter(
			this IDbBatch source,
			string name = null,
			object value = null,
			ParameterDirection? direction = default(ParameterDirection?),
			DbType? dbType = default(DbType?),
			int? size = default(int?))
		{
			return source.Connection.CreateParameter(name, value, direction, dbType, size);
		}

		public static IEnumerable<IDbDataParameter> CreateParameters(
			this IDbBatch source,
			string baseName,
			IEnumerable<object> values)
		{
			return source.Connection.CreateParameters(baseName, values);
		}
	}
}