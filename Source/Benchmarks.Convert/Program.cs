using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using Benchmarks.Convert.Deipax;
using System.Linq;

namespace Benchmarks.Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ManualConfig
                .CreateEmpty()
                .With(DefaultConfig.Instance.GetAnalysers().ToArray())
                .With(DefaultConfig.Instance.GetColumnProviders().ToArray())
                .With(DefaultConfig.Instance.GetDiagnosers().ToArray())
                .With(DefaultConfig.Instance.GetFilters().ToArray())
                //.With(new AllCategoriesFilter(new string[] { "Enum" }))
                .With(DefaultConfig.Instance.GetHardwareCounters().ToArray())
                .With(new Job[]
                {
                    ConfigureJob(Job.Default.With(CsProjCoreToolchain.NetCoreApp20)).AsBaseline(),
                    ConfigureJob(Job.Default.With(CsProjCoreToolchain.NetCoreApp22)),
                    ConfigureJob(Job.Default.With(CsProjCoreToolchain.NetCoreApp30)),
                    ConfigureJob(Job.Default.With(CsProjClassicNetToolchain.Net462)),
                    ConfigureJob(Job.Default.With(CsProjClassicNetToolchain.Net472)),
                    ConfigureJob(Job.Default.With(CsProjClassicNetToolchain.Net48)),
                })
                .With(DefaultConfig.Instance.GetLoggers().ToArray())
                .With(DefaultConfig.Instance.GetValidators().ToArray())
                .With(MarkdownExporter.Default)
                .With(MemoryDiagnoser.Default)
                .With(new IColumn[]
                {
                    StatisticColumn.Mean,
                    StatisticColumn.Error,
                    StatisticColumn.StdDev,
                    StatisticColumn.Median,
                    BaselineRatioColumn.RatioMean,
                    BaselineRatioColumn.RatioStdDev
                });

            RunConvertBenchmarks(config);
        }

        #region Private Members
        private static void RunConvertBenchmarks(IConfig config = null)
        {
            BenchmarkRunner.Run<ConvertTo_BoolNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Bool>(config);
            BenchmarkRunner.Run<ConvertTo_ByteNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Byte>(config);
            BenchmarkRunner.Run<ConvertTo_CharNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Char>(config);
            BenchmarkRunner.Run<ConvertTo_DateTimeNullable>(config);
            BenchmarkRunner.Run<ConvertTo_DateTime>(config);
            BenchmarkRunner.Run<ConvertTo_DecimalNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Decimal>(config);
            BenchmarkRunner.Run<ConvertTo_DoubleNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Double>(config);
            BenchmarkRunner.Run<ConvertTo_EnumNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Enum>(config);
            BenchmarkRunner.Run<ConvertTo_FloatNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Float>(config);
            BenchmarkRunner.Run<ConvertTo_IntNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Int>(config);
            BenchmarkRunner.Run<ConvertTo_IParent>(config);
            BenchmarkRunner.Run<ConvertTo_LongNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Long>(config);
            BenchmarkRunner.Run<ConvertTo_Object>(config);
            BenchmarkRunner.Run<ConvertTo_SByteNullable>(config);
            BenchmarkRunner.Run<ConvertTo_SByte>(config);
            BenchmarkRunner.Run<ConvertTo_ShortNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Short>(config);
            BenchmarkRunner.Run<ConvertTo_String>(config);
            BenchmarkRunner.Run<ConvertTo_UIntNullable>(config);
            BenchmarkRunner.Run<ConvertTo_UInt>(config);
            BenchmarkRunner.Run<ConvertTo_ULongNullable>(config);
            BenchmarkRunner.Run<ConvertTo_ULong>(config);
            BenchmarkRunner.Run<ConvertTo_UShortNullable>(config);
            BenchmarkRunner.Run<ConvertTo_UShort>(config);
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