﻿using Deipax.DataAccess.Interfaces;
using System;
using System.Data;

namespace Deipax.DataAccess.Concretes
{
    public sealed class DbCon : IDbCon
    {
        public DbCon(IDb db)
        {
            Db = db;
            _factory = db.ConnectionFactory;
        }

        private DbCon()
        {
        }

        #region Field Members
        private readonly Func<IDb, IDbConnection> _factory;
        private IDbConnection _con;
        private readonly object _lock = new object();
        #endregion

        #region IDbCon Members
        public IDb Db { get; private set; }

        public IDbConnection GetConnection()
        {
            if (_con == null)
            {
                lock (_lock)
                {
                    if (_con == null)
                    {
                        _con = _factory(Db);
                    }
                }
            }

            return _con;
        }
        #endregion

        #region IDisposable Members
        public void Dispose()
        {
            if (_con != null)
            {
                lock (_lock)
                {
                    if (_con != null)
                    {
                        if (_con.State != ConnectionState.Closed)
                        {
                            _con.Close();
                        }

                        _con.Dispose();
                        _con = null;
                    }
                }
            }
        }
        #endregion
    }
}