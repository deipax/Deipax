using System;
using System.Data;
using System.Data.Common;

namespace UnitTests.DataAccess.Concretes
{
    public class TestTransaction : DbTransaction
    {
        public override IsolationLevel IsolationLevel { get; }
        protected override DbConnection DbConnection { get; }

        public override void Commit()
        {
            throw new NotImplementedException();
        }

        public override void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}