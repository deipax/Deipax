using Deipax.DataAccess.Common;
using UnitTests.Common;

namespace UnitTests.DataAccess.BaseTests
{
    public abstract class BaseTest
    {
        public BaseTest()
        {
            DbConfig.SetDbInitializer(DbHelper.Initialize);
            DbConfig.DbConnectionFactory = DbHelper.CreateDbConnection;
        }
    }
}