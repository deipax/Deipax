using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;

namespace Deipax.DataAccess.Common
{
	public delegate IDbBatch CreateDbBatchDelegate(IDb db);

	public static class DbBatchFactory
	{
		public static CreateDbBatchDelegate Override { get; set; }

		public static IDbBatch Create(
			IDb db)
		{
			return Override != null ?
				Override(db) :
				new DbBatch(db);
		}
	}
}