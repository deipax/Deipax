﻿using Deipax.DataAccess.Interfaces;
using System;
using System.Diagnostics;

namespace Deipax.DataAccess.Common
{
    public static class DbTimings
    {
        public static Action<IDb, double> Open { get; set; }
        public static Action<IDbCmd, double> RunQuery { get; set; }
        public static Action<IDb, double> Close { get; set; }
    }

    public sealed class OpenTimer : IDisposable
    {
        private OpenTimer(IDb db)
        {
            _db = db;
        }

        private OpenTimer()
        {
        }

        private readonly Stopwatch _watch = Stopwatch.StartNew();
        private readonly IDb _db;

        public static OpenTimer Create(IDb db)
        {
            return new OpenTimer(db);
        }

        public void Dispose()
        {
            if (DbTimings.Open != null && _db != null)
            {
                DbTimings.Open(_db, _watch.ElapsedMilliseconds);
            }
        }
    }

    public sealed class CloseTimer : IDisposable
    {
        private CloseTimer(IDb db)
        {
            _db = db;
        }

        private CloseTimer()
        {
        }

        private readonly Stopwatch _watch = Stopwatch.StartNew();
        private readonly IDb _db;

        public static CloseTimer Create(IDb db)
        {
            return new CloseTimer(db);
        }

        public void Dispose()
        {
            if (DbTimings.Close != null && _db != null)
            {
                DbTimings.Close(_db, _watch.ElapsedMilliseconds);
            }
        }
    }

    public sealed class RunTimer : IDisposable
    {
        private RunTimer(IDbCmd dbCmd)
        {
            _dbCmd = dbCmd;
        }

        private RunTimer()
        {
        }

        private readonly Stopwatch _watch = Stopwatch.StartNew();
        private readonly IDbCmd _dbCmd;

        public static RunTimer Create(IDbCmd dbCmd)
        {
            return new RunTimer(dbCmd);
        }

        public void Dispose()
        {
            if (DbTimings.RunQuery != null && _dbCmd != null)
            {
                DbTimings.RunQuery(_dbCmd, _watch.ElapsedMilliseconds);
            }
        }
    }
}