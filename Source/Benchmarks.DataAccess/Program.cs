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
                    StatisticColumn.Min,
                    StatisticColumn.Max,
                    StatisticColumn.Mean,
                    StatisticColumn.Median,
                    BaselineRatioColumn.RatioMean,
                });

            BenchmarkRunner.Run<DeipaxSelect>(config);
            BenchmarkRunner.Run<DapperSelect>(config);
        }

        #region Private Members
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