using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;

namespace Deipax.DataAccess.Common
{
	public delegate IDbCmd CreateDbCmdDelegate(IDb db);

	public static class DbCmdFactory
	{
		public static CreateDbCmdDelegate Override { get; set; }

		public static IDbCmd Create(
			IDb db)
		{
			return Override != null ?
				Override(db) :
				new DbCmd(db);
		}
	}
}