using System;
using System.Data;

namespace UnitTests.Integration.Concretes
{
	public class TestTransaction : IDbTransaction
	{
		public IDbConnection Connection
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public IsolationLevel IsolationLevel
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public void Commit()
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void Rollback()
		{
			throw new NotImplementedException();
		}
	}
}