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
		private OpenTimer(IDb db)
		{
			_db = db;
		}

		private OpenTimer()
		{
		}

		private DateTime _start = DateTime.Now;
		private IDb _db;

		public static OpenTimer Create(IDb db)
		{
			return new OpenTimer(db);
		}

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
		private CloseTimer(IDb db)
		{
			_db = db;
		}

		private CloseTimer()
		{
		}

		private DateTime _start = DateTime.Now;
		private IDb _db;

		public static CloseTimer Create(IDb db)
		{
			return new CloseTimer(db);
		}

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
		private RunTimer(IDbCmd dbCmd)
		{
			_dbCmd = dbCmd;		
		}

		private RunTimer()
		{
		}

		private DateTime _start = DateTime.Now;
		private IDbCmd _dbCmd;

		public static RunTimer Create(IDbCmd dbCmd)
		{
			dbCmd.Open();
			return new RunTimer(dbCmd);
		}

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