using System;
using System.Collections.Concurrent;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.CsProj;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Deipax.Core.Common;

namespace Benchmarks.DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ManualConfig
                .CreateEmpty()
                .AddAnalyser(DefaultConfig.Instance.GetAnalysers().ToArray())
                .AddColumnProvider(DefaultConfig.Instance.GetColumnProviders().ToArray())
                .AddDiagnoser(DefaultConfig.Instance.GetDiagnosers().ToArray())
                .AddFilter(DefaultConfig.Instance.GetFilters().ToArray())
                .AddHardwareCounters(DefaultConfig.Instance.GetHardwareCounters().ToArray())
                .AddJob(new Job[]
                {
                    Job.ShortRun.WithToolchain(CsProjCoreToolchain.NetCoreApp31).AsBaseline(),
                    Job.ShortRun.WithToolchain(CsProjCoreToolchain.NetCoreApp50),
                })
                .AddLogger(DefaultConfig.Instance.GetLoggers().ToArray())
                .AddValidator(DefaultConfig.Instance.GetValidators().ToArray())
                .AddExporter(MarkdownExporter.Default)
                .AddDiagnoser(MemoryDiagnoser.Default)
                .AddColumn(new IColumn[]
                {
                    StatisticColumn.Min,
                    StatisticColumn.Max,
                    StatisticColumn.Mean,
                    StatisticColumn.Median,
                    BaselineRatioColumn.RatioMean,
                });

            BenchmarkRunner.Run<TestBenchmark>(config);
        }
    }

    public class TestBenchmark
    {
        [GlobalSetup]
        public void Setup()
        {
            _getKey = new object();
            _addKey = new object();
            _getOrAddKey = new object();
            _value = new object();

            _concurrent = new ConcurrentDictionary<object, object>(8, 16, ReferenceEqualsComparer.Instance);
            _quickCache = new QuickCache<object, object>(8, ReferenceEqualsComparer.Instance);

            _concurrent.TryAdd(_getKey, _value);
            _quickCache.TryAdd(_getKey, _value);
        }

        private object _getKey;
        private object _addKey;
        private object _getOrAddKey;
        private object _value;
        private object _returnValue;
        private ConcurrentDictionary<object, object> _concurrent;
        private QuickCache<object, object> _quickCache;
        private static Func<object, object> _create = Create;

        [Benchmark]
        public object Conncurrent_TryGetValue() => _concurrent.TryGetValue(_getKey, out _returnValue);

        [Benchmark]
        public object Quick_TryGetValue() => _quickCache.TryGetValue(_getKey, out _returnValue);

        [Benchmark]
        public object Conncurrent_GetOrAdd() => _concurrent.GetOrAdd(_getOrAddKey, _create);

        [Benchmark]
        public object Quick_GetOrAdd() => _quickCache.GetOrAdd(_getOrAddKey, _create);

        private static object Create(object key)
        {
            return new object();
        }
    }
}