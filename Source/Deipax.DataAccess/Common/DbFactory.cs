using Deipax.DataAccess.Concretes;
using Deipax.DataAccess.Interfaces;
using System;
using System.Data;

namespace Deipax.DataAccess.Common
{
    public static class DbFactory
    {
         public delegate IDb DbCreateDelegate(
            string name,
            string cs,
            string provider,
            Func<IDb, IDbConnection> factory);

        public delegate IDbCmd DbCmdDelegate();

        public static DbCreateDelegate UserDb { get; set; }
        public static DbCmdDelegate UserDbCmd { get; set; }

        public static IDb CreateDb(
            string name,
            string cs,
            string provider,
            Func<IDb, IDbConnection> factory)
        {
            return UserDb != null
                ? UserDb(name, cs, provider, factory)
                : new Db(name, cs, provider, factory);
        }

        public static IDbCmd CreateDbCmd()
        {
            return UserDbCmd != null
                ? UserDbCmd()
                : new DbCmd();
        }
    }
}
