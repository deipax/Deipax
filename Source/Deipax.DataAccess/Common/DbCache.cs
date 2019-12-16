using Deipax.DataAccess.Interfaces;
using System;
using System.Collections.Generic;

namespace Deipax.DataAccess.Common
{
    public class DbCache
    {
        #region Field Members
        private readonly Dictionary<string, IDb> _dbs = new Dictionary<string, IDb>();
        #endregion

        #region Public Members
        public void Add(IDb db)
        {
            if (db == null) throw new ArgumentNullException(nameof(db));

            if (!_dbs.ContainsKey(db.Name))
            {
                _dbs.Add(db.Name, db);
            }
        }

        public IDb Get(string name)
        {
            _dbs.TryGetValue(name, out IDb db);
            return db;
        }

        public IEnumerable<IDb> GetAll()
        {
            return _dbs.Values;
        }
        #endregion
    }
}