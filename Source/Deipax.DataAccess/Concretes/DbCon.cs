using System;
using System.Data;
using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;

namespace Deipax.DataAccess.Concretes
{
	public class DbCon : IDbCon
	{
		public DbCon(IDb db, Func<IDb, IDbConnection> factory)
		{
			this.Db = db;
			_factory = factory;
		}

		private DbCon()
		{
		}

		#region Field Members
		private Func<IDb, IDbConnection> _factory;
		private IDbConnection _con;
		private object _lock = new object();
		#endregion

		#region IDbCon Members
		public IDb Db { get; set; }

		public IDbConnection GetConnection()
		{
			if (_con == null)
			{
				lock (_lock)
				{
					if (_con == null)
					{
						_con = _factory(this.Db);
					}
				}
			}

			return _con;
		}

		public IDbBatch CreateDbBatch()
		{
			var con = GetConnection();

			if (con.State != ConnectionState.Open)
			{
				lock (_lock)
				{
					if (con.State != ConnectionState.Open)
					{
						using (var timer = new OpenTimer(this.Db))
						{
							con.Open();
						}
					}
				}
			}

			return new DbBatch(this.Db).SetConnection(con);
		}
		#endregion

		#region IDisposable Members
		public void Dispose()
		{
			if (_con != null)
			{
				if (_con.State != ConnectionState.Closed)
				{
					using (var time = new CloseTimer(this.Db))
					{
						_con.Close();
					}
				}

				_con.Dispose();
				_con = null;
			}
		}
		#endregion
	}
}