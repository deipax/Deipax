using Deipax.DataAccess.Extensions;
using System;
using System.Data;
using System.Threading;

namespace Deipax.DataAccess.Common
{
    public class DataReaderCache
    {
        public DataReaderCache(IDataReader reader)
        {
            Reader = reader;
            _columnHash = new Lazy<int>(() =>
                Reader.GetColumnHash(),
                LazyThreadSafetyMode.ExecutionAndPublication);
        }

        #region Private Members
        private readonly Lazy<int> _columnHash;
        #endregion

        #region Public Members
        public IDataReader Reader { get; private set; }

        public int GetColumnHash()
        {
            return _columnHash.Value;
        }
        #endregion
    }
}
