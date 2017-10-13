using System;
using Deipax.DataAccess.Interfaces;

namespace Deipax.DataAccess.Common
{
	public static class DbTimings
	{
		public static Action<IDb, double> Open { get; set; }
		public static Action<IDbCmd, double> RunQuery { get; set; }
		public static Action<IDb, double> Close { get; set; }
	}

	public class OpenTimer : IDisposable
	{
		public OpenTimer(IDb db)
		{
			_db = db;
		}

		private DateTime _start = DateTime.Now;
		private IDb _db;

		public void Dispose()
		{
			if (DbTimings.Open != null && _db != null)
			{
				var elapsed = DateTime.Now.Subtract(_start).TotalMilliseconds;
				DbTimings.Open(_db, elapsed);
			}
		}
	}

	public class CloseTimer : IDisposable
	{
		public CloseTimer(IDb db)
		{
			_db = db;
		}

		private DateTime _start = DateTime.Now;
		private IDb _db;

		public void Dispose()
		{
			if (DbTimings.Close != null && _db != null)
			{
				var elapsed = DateTime.Now.Subtract(_start).TotalMilliseconds;
				DbTimings.Close(_db, elapsed);
			}
		}
	}

	public class RunTimer : IDisposable
	{
		public RunTimer(IDbCmd dbCmd)
		{
			_dbCmd = dbCmd;
			dbCmd.Open();
			_start = DateTime.Now;
		}

		private DateTime _start;
		private IDbCmd _dbCmd;

		public void Dispose()
		{
			if (DbTimings.RunQuery != null && _dbCmd != null)
			{
				var elapsed = DateTime.Now.Subtract(_start).TotalMilliseconds;
				DbTimings.RunQuery(_dbCmd, elapsed);
			}
		}
	}
}