using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;

namespace UnitTests.Common
{
	public static class DbHelper
	{
		public static IDb GetNorthwind()
		{
			return DbManager.Get("Northwind");
		}
	}
}