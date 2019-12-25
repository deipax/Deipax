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
        public IDbCmd DbCmd { get; set; }
        public IDbCommand DbCommand { get; set; }
        public IDataReader Reader { get; set; }
        public bool Diposed { get; private set; } = false;

        public IEnumerator<T> GetEnumerator()
        {
            try
            {
                var token = DbCmd.CancellationToken ?? new CancellationToken(false);

                using (DbCommand)
                using (Reader)
                {
                    if (Reader.FieldCount == 0)
                    {
                        yield break;
                    }

                    var cache = new DataReaderCache(Reader);
                    Func<IDataRecord, T> map = DataRecordMap<T>.Create(cache);

                    while (!token.IsCancellationRequested && Reader.Read())
                    {
                        yield return map(Reader);
                    }

                    while (!token.IsCancellationRequested && Reader.NextResult()) { /* ignore subsequent result sets */ }
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
                DbCmd = null;
                DbCommand?.Dispose();
                DbCommand = null;
                Reader?.Dispose();
                Reader = null;
                Diposed = true;
            }
        }
    }

    public sealed class ManagedEnumerable : IManagedEnumerable<object>
    {
        public IDbCmd DbCmd { get; set; }
        public IDbCommand DbCommand { get; set; }
        public IDataReader Reader { get; set; }
        public bool Diposed { get; private set; } = false;

        public IEnumerator<object> GetEnumerator()
        {
            try
            {
                var token = DbCmd.CancellationToken ?? new CancellationToken(false);

                using (DbCommand)
                using (Reader)
                {
                    if (Reader.FieldCount == 0)
                    {
                        yield break;
                    }

                    var cache = new DataReaderCache(Reader);
                    var map = DynamicMap.CreateMap(cache);

                    while (!token.IsCancellationRequested && Reader.Read())
                    {
                        yield return map(Reader);
                    }

                    while (!token.IsCancellationRequested && Reader.NextResult()) { /* ignore subsequent result sets */ }
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
                DbCmd = null;
                DbCommand?.Dispose();
                DbCommand = null;
                Reader?.Dispose();
                Reader = null;
                Diposed = true;
            }
        }
    }
}
