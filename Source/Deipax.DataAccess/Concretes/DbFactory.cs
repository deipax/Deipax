using Deipax.DataAccess.Interfaces;
using System;
using System.Data;

namespace Deipax.DataAccess.Concretes
{
    public class DbFactory : IDbFactory
    {
        public static IDbFactory Instance { get; set; } = new DbFactory();

        public IDb CreateDb(
            string name, 
            string cs, 
            string provider, 
            Func<IDb, IDbConnection> factory)
        {
            return new Db(name, cs, provider, factory);
        }

        public IDbCmd CreateDbCmd()
        {
            return new DbCmd();
        }
    }
}
