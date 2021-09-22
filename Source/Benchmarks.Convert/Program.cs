using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using Benchmarks.Convert.Deipax;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Benchmarks.Convert
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
                })
                .WithOrderer(new CustomOrderer());

            RunConvertBenchmarks(config);
        }

        #region Private Members
        private static void RunConvertBenchmarks(IConfig config = null)
        {
            /*BenchmarkRunner.Run<ConvertToBoolNullable>(config);
            BenchmarkRunner.Run<ConvertToBool>(config);
            BenchmarkRunner.Run<ConvertToByteNullable>(config);
            BenchmarkRunner.Run<ConvertToByte>(config);
            BenchmarkRunner.Run<ConvertToCharNullable>(config);
            BenchmarkRunner.Run<ConvertToChar>(config);
            BenchmarkRunner.Run<ConvertToDateTimeNullable>(config);
            BenchmarkRunner.Run<ConvertToDateTime>(config);
            BenchmarkRunner.Run<ConvertToDecimalNullable>(config);
            BenchmarkRunner.Run<ConvertToDecimal>(config);
            BenchmarkRunner.Run<ConvertToDoubleNullable>(config);
            BenchmarkRunner.Run<ConvertToDouble>(config);
            BenchmarkRunner.Run<ConvertToEnumNullable>(config);
            BenchmarkRunner.Run<ConvertToEnum>(config);
            BenchmarkRunner.Run<ConvertToFloatNullable>(config);
            BenchmarkRunner.Run<ConvertToFloat>(config);
            BenchmarkRunner.Run<ConvertToIntNullable>(config);
            BenchmarkRunner.Run<ConvertToInt>(config);
            BenchmarkRunner.Run<ConvertToIParent>(config);
            BenchmarkRunner.Run<ConvertToLongNullable>(config);
            BenchmarkRunner.Run<ConvertToLong>(config);
            BenchmarkRunner.Run<ConvertToObject>(config);
            BenchmarkRunner.Run<ConvertToSByteNullable>(config);
            BenchmarkRunner.Run<ConvertToSByte>(config);
            BenchmarkRunner.Run<ConvertToShortNullable>(config);
            BenchmarkRunner.Run<ConvertToShort>(config);
            BenchmarkRunner.Run<ConvertToString>(config);*/
            BenchmarkRunner.Run<ConvertToUIntNullable>(config);
            BenchmarkRunner.Run<ConvertToUInt>(config);
            BenchmarkRunner.Run<ConvertToULongNullable>(config);
            BenchmarkRunner.Run<ConvertToULong>(config);
            BenchmarkRunner.Run<ConvertToUShortNullable>(config);
            BenchmarkRunner.Run<ConvertToUShort>(config);
        }
        #endregion
    }

    public class CustomOrderer : DefaultOrderer
    {
        public override IEnumerable<BenchmarkCase> GetSummaryOrder(ImmutableArray<BenchmarkCase> benchmarksCases, Summary summary)
        {
            var groups = benchmarksCases
                .GroupBy(x => new { Method = x.Descriptor.WorkloadMethodDisplayInfo, Parameter = x.Parameters.DisplayInfo})
                .OrderBy(x => x.Key.Method);

            foreach (var group in groups)
            foreach (var benchmark in group.OrderBy(x => x.Job.Infrastructure.Toolchain.Name))
                yield return benchmark;
        }
    }
}