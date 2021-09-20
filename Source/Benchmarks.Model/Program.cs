using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.CsProj;
using Benchmarks.Model.Deipax;
using System.Linq;

namespace Benchmarks.Model
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

            RunSetterBenchmarks(config);
            RunGetterBenchmarks(config);
        }

        #region Private Members
        private static void RunSetterBenchmarks(IConfig config = null)
        {
            BenchmarkRunner.Run<Set_Prop_Bool>(config);
            BenchmarkRunner.Run<Set_Prop_BoolNullable>(config);
            BenchmarkRunner.Run<Set_Prop_BoolNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_Char>(config);
            BenchmarkRunner.Run<Set_Prop_CharNullable>(config);
            BenchmarkRunner.Run<Set_Prop_CharNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_SByte>(config);
            BenchmarkRunner.Run<Set_Prop_SByteNullable>(config);
            BenchmarkRunner.Run<Set_Prop_SByteNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_Byte>(config);
            BenchmarkRunner.Run<Set_Prop_ByteNullable>(config);
            BenchmarkRunner.Run<Set_Prop_ByteNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_Short>(config);
            BenchmarkRunner.Run<Set_Prop_ShortNullable>(config);
            BenchmarkRunner.Run<Set_Prop_ShortNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_UShort>(config);
            BenchmarkRunner.Run<Set_Prop_UShortNullable>(config);
            BenchmarkRunner.Run<Set_Prop_UShortNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_Int>(config);
            BenchmarkRunner.Run<Set_Prop_IntNullable>(config);
            BenchmarkRunner.Run<Set_Prop_IntNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_UInt>(config);
            BenchmarkRunner.Run<Set_Prop_UIntNullable>(config);
            BenchmarkRunner.Run<Set_Prop_UIntNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_Long>(config);
            BenchmarkRunner.Run<Set_Prop_LongNullable>(config);
            BenchmarkRunner.Run<Set_Prop_LongNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_ULong>(config);
            BenchmarkRunner.Run<Set_Prop_ULongNullable>(config);
            BenchmarkRunner.Run<Set_Prop_ULongNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_Float>(config);
            BenchmarkRunner.Run<Set_Prop_FloatNullable>(config);
            BenchmarkRunner.Run<Set_Prop_FloatNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_Double>(config);
            BenchmarkRunner.Run<Set_Prop_DoubleNullable>(config);
            BenchmarkRunner.Run<Set_Prop_DoubleNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_Decimal>(config);
            BenchmarkRunner.Run<Set_Prop_DecimalNullable>(config);
            BenchmarkRunner.Run<Set_Prop_DecimalNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_DateTime>(config);
            BenchmarkRunner.Run<Set_Prop_DateTimeNullable>(config);
            BenchmarkRunner.Run<Set_Prop_DateTimeNullable_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_String>(config);
            BenchmarkRunner.Run<Set_Prop_String_Empty>(config);
            BenchmarkRunner.Run<Set_Prop_String_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_Object>(config);
            BenchmarkRunner.Run<Set_Prop_Object_NoValue>(config);

            BenchmarkRunner.Run<Set_Prop_Enum>(config);
            BenchmarkRunner.Run<Set_Prop_EnumNullable>(config);
            BenchmarkRunner.Run<Set_Prop_EnumNullable_NoValue>(config);
        }

        private static void RunGetterBenchmarks(IConfig config = null)
        {
            BenchmarkRunner.Run<Get_Prop_Bool>(config);
            BenchmarkRunner.Run<Get_Prop_BoolNullable>(config);
            BenchmarkRunner.Run<Get_Prop_BoolNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_Char>(config);
            BenchmarkRunner.Run<Get_Prop_CharNullable>(config);
            BenchmarkRunner.Run<Get_Prop_CharNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_SByte>(config);
            BenchmarkRunner.Run<Get_Prop_SByteNullable>(config);
            BenchmarkRunner.Run<Get_Prop_SByteNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_Byte>(config);
            BenchmarkRunner.Run<Get_Prop_ByteNullable>(config);
            BenchmarkRunner.Run<Get_Prop_ByteNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_Short>(config);
            BenchmarkRunner.Run<Get_Prop_ShortNullable>(config);
            BenchmarkRunner.Run<Get_Prop_ShortNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_UShort>(config);
            BenchmarkRunner.Run<Get_Prop_UShortNullable>(config);
            BenchmarkRunner.Run<Get_Prop_UShortNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_Int>(config);
            BenchmarkRunner.Run<Get_Prop_IntNullable>(config);
            BenchmarkRunner.Run<Get_Prop_IntNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_UInt>(config);
            BenchmarkRunner.Run<Get_Prop_UIntNullable>(config);
            BenchmarkRunner.Run<Get_Prop_UIntNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_Long>(config);
            BenchmarkRunner.Run<Get_Prop_LongNullable>(config);
            BenchmarkRunner.Run<Get_Prop_LongNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_ULong>(config);
            BenchmarkRunner.Run<Get_Prop_ULongNullable>(config);
            BenchmarkRunner.Run<Get_Prop_ULongNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_Float>(config);
            BenchmarkRunner.Run<Get_Prop_FloatNullable>(config);
            BenchmarkRunner.Run<Get_Prop_FloatNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_Double>(config);
            BenchmarkRunner.Run<Get_Prop_DoubleNullable>(config);
            BenchmarkRunner.Run<Get_Prop_DoubleNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_Decimal>(config);
            BenchmarkRunner.Run<Get_Prop_DecimalNullable>(config);
            BenchmarkRunner.Run<Get_Prop_DecimalNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_DateTime>(config);
            BenchmarkRunner.Run<Get_Prop_DateTimeNullable>(config);
            BenchmarkRunner.Run<Get_Prop_DateTimeNullable_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_String>(config);
            BenchmarkRunner.Run<Get_Prop_String_Empty>(config);
            BenchmarkRunner.Run<Get_Prop_String_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_Object>(config);
            BenchmarkRunner.Run<Get_Prop_Object_NoValue>(config);

            BenchmarkRunner.Run<Get_Prop_Enum>(config);
            BenchmarkRunner.Run<Get_Prop_EnumNullable>(config);
            BenchmarkRunner.Run<Get_Prop_EnumNullable_NoValue>(config);
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