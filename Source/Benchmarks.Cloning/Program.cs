using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using Benchmarks.Cloning.Deipax;
using System.Linq;

namespace Benchmarks.Cloning
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
                    ConfigureJob(Job.ShortRun.WithToolchain(CsProjCoreToolchain.NetCoreApp31)).AsBaseline(),
                    ConfigureJob(Job.ShortRun.WithToolchain(CsProjCoreToolchain.NetCoreApp50)),
                })
                .AddLogger(DefaultConfig.Instance.GetLoggers().ToArray())
                .AddValidator(DefaultConfig.Instance.GetValidators().ToArray())
                .AddExporter(MarkdownExporter.Default)
                .AddDiagnoser(MemoryDiagnoser.Default)
                .AddColumn(new IColumn[]
                {
                    StatisticColumn.Mean,
                    StatisticColumn.Error,
                    StatisticColumn.StdDev,
                    StatisticColumn.Median,
                    BaselineRatioColumn.RatioMean,
                    BaselineRatioColumn.RatioStdDev
                });

            RunDeipaxBenchmarks(config);
        }

        #region Private Members
        private static void RunDeipaxBenchmarks(IConfig config = null)
        {
            BenchmarkRunner.Run<IntDeipax>(config);
            BenchmarkRunner.Run<StringDeipax>(config);
            BenchmarkRunner.Run<ComplexClassDeipax>(config);
            BenchmarkRunner.Run<ComplexStructDeipax>(config);
            BenchmarkRunner.Run<SimpleClassDeipax>(config);
            BenchmarkRunner.Run<SimpleStructDeipax>(config);
            BenchmarkRunner.Run<DoubleSimpleClassDeipax>(config);
            BenchmarkRunner.Run<NullableIntDeipax>(config);
            BenchmarkRunner.Run<NullableSimpleStructDeipax>(config);
            BenchmarkRunner.Run<NullableComplexStructDeipax>(config);

            BenchmarkRunner.Run<AbstractDeipax>(config);
            BenchmarkRunner.Run<ArrayDeipax>(config);
            BenchmarkRunner.Run<ComplexRefTypeDeipax>(config);
            BenchmarkRunner.Run<ComplexValueTypeDeipax>(config);
            BenchmarkRunner.Run<KeyValueDeipax>(config);
            BenchmarkRunner.Run<NullableDeipax>(config);
            BenchmarkRunner.Run<PrimitiveDeipax>(config);
            BenchmarkRunner.Run<TupleDeipax>(config);
            BenchmarkRunner.Run<CanShallowCloneDeipax>(config);
        }

        private static Job ConfigureJob(Job source)
        {
            return source;
            /*
            return source
                .WithIterationCount(1)
                .WithWarmupCount(1);*/
        }
        #endregion
    }
}