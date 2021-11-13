using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using Benchmarks.Core.Deipax;
using System.Linq;

namespace Benchmarks.DataAccess
{
    class Program
    {
        static void Main()
        {
            var config = ManualConfig
                .CreateEmpty()
                .AddAnalyser(DefaultConfig.Instance.GetAnalysers().ToArray())
                .AddColumnProvider(DefaultConfig.Instance.GetColumnProviders().ToArray())
                .AddDiagnoser(DefaultConfig.Instance.GetDiagnosers().ToArray())
                .AddFilter(DefaultConfig.Instance.GetFilters().ToArray())
                .AddHardwareCounters(DefaultConfig.Instance.GetHardwareCounters().ToArray())
                .AddJob(
                    Job.ShortRun.WithToolchain(CsProjCoreToolchain.NetCoreApp31).AsBaseline(),
                    Job.ShortRun.WithToolchain(CsProjCoreToolchain.NetCoreApp50))
                .AddLogger(DefaultConfig.Instance.GetLoggers().ToArray())
                .AddValidator(DefaultConfig.Instance.GetValidators().ToArray())
                .AddExporter(MarkdownExporter.Default)
                .AddDiagnoser(MemoryDiagnoser.Default)
                .AddColumn(
                    StatisticColumn.Min,
                    StatisticColumn.Max,
                    StatisticColumn.Mean,
                    StatisticColumn.Median,
                    BaselineRatioColumn.RatioMean);

            BenchmarkRunner.Run<SymbolCacheBenchmarks>(config);
        }
    }
}