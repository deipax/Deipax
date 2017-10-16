using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;

namespace Deipax.DataAccess.Common
{
	public delegate IDbCon CreateDbConDelegate(IDb db);

	public static class DbConFactory
	{
		public static CreateDbConDelegate Override { get; set; }

		public static IDbCon Create(
			IDb db)
		{
			return Override != null ?
				Override(db) :
				new DbCon(db);
		}
	}
}