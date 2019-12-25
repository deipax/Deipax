using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;

namespace Deipax.DataAccess.Concretes
{
    public sealed class ManagedEnumerable<T> : IManagedEnumerable<T> where T : new()
    {
        public ManagedEnumerable(
            IDbCmd dbCmd,
            IDbCommand dbCommand,
            IDataReader reader)
        {
            _dbCmd = dbCmd;
            _dbCommand = dbCommand;
            _reader = reader;
        }

        #region Field Members
        private IDbCmd _dbCmd;
        private IDbCommand _dbCommand;
        private IDataReader _reader;
        #endregion

        public bool Diposed { get; private set; } = false;

        public IEnumerator<T> GetEnumerator()
        {
            try
            {
                var token = _dbCmd.CancellationToken ?? new CancellationToken(false);

                using (_dbCommand)
                using (_reader)
                {
                    if (_reader.FieldCount == 0)
                    {
                        yield break;
                    }

                    var cache = new DataReaderCache(_reader);
                    Func<IDataRecord, T> map = DataRecordMap<T>.Create(cache);

                    while (!token.IsCancellationRequested && _reader.Read())
                    {
                        yield return map(_reader);
                    }
                }
            }
            finally
            {
                Dispose();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            if (!Diposed)
            {
                _dbCmd = null;
                _dbCommand?.Dispose();
                _dbCommand = null;
                _reader?.Dispose();
                _reader = null;
                Diposed = true;
            }
        }
    }

    public sealed class ManagedEnumerable : IManagedEnumerable<object>
    {
        public ManagedEnumerable(
            IDbCmd dbCmd,
            IDbCommand dbCommand,
            IDataReader reader)
        {
            _dbCmd = dbCmd;
            _dbCommand = dbCommand;
            _reader = reader;
        }

        #region Field Members
        private IDbCmd _dbCmd;
        private IDbCommand _dbCommand;
        private IDataReader _reader;
        #endregion

        public bool Diposed { get; private set; } = false;

        public IEnumerator<object> GetEnumerator()
        {
            try
            {
                var token = _dbCmd.CancellationToken ?? new CancellationToken(false);

                using (_dbCommand)
                using (_reader)
                {
                    if (_reader.FieldCount == 0)
                    {
                        yield break;
                    }

                    var cache = new DataReaderCache(_reader);
                    var map = DynamicMap.CreateMap(cache);

                    while (!token.IsCancellationRequested && _reader.Read())
                    {
                        yield return map(_reader);
                    }
                }
            }
            finally
            {
                Dispose();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            if (!Diposed)
            {
                _dbCmd = null;
                _dbCommand?.Dispose();
                _dbCommand = null;
                _reader?.Dispose();
                _reader = null;
                Diposed = true;
            }
        }
    }
}
