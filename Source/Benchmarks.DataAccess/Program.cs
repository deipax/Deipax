using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using Benchmarks.DataAccess.Dapper;
using Benchmarks.DataAccess.Deipax;
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

            BenchmarkRunner.Run<DeipaxDynamicSelect>(config);
            BenchmarkRunner.Run<DeipaxMultipleFieldClassSelect>(config);
            BenchmarkRunner.Run<DeipaxMultipleFieldClassConvertSelect>(config);
            BenchmarkRunner.Run<DeipaxMultipleFieldStructSelect>(config);
            BenchmarkRunner.Run<DeipaxMultipleFieldStructConvertSelect>(config);

            BenchmarkRunner.Run<DapperDynamicSelect>(config);
            BenchmarkRunner.Run<DapperMultipleFieldClassSelect>(config);
            BenchmarkRunner.Run<DapperMultipleFieldClassConvertSelect>(config);
            BenchmarkRunner.Run<DapperMultipleFieldStructSelect>(config);
            BenchmarkRunner.Run<DapperMultipleFieldStructConvertSelect>(config);
        }
    }
}