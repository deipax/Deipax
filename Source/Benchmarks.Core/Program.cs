using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Running;
using Benchmarks.Core.Deipax.Conversion;
using System.Linq;

namespace Benchmarks.Core
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
                .With(DefaultConfig.Instance.GetHardwareCounters().ToArray())
                .With(DefaultConfig.Instance.GetJobs().ToArray())
                .With(DefaultConfig.Instance.GetLoggers().ToArray())
                .With(DefaultConfig.Instance.GetOrderProvider())
                .With(DefaultConfig.Instance.GetValidators().ToArray())
                .With(MarkdownExporter.Default)
                .With(MemoryDiagnoser.Default);

            /*
            ManualConfig manualConfig = config as ManualConfig;
            manualConfig.Add(new CategoryFilter("Object"));
            */

            //BenchmarkRunner.Run<AdHoc>(config);

            //BenchmarkRunner.Run<ConvertTo2_Bool>(config);
            //BenchmarkRunner.Run<ConvertTo2_BoolNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_Char>(config);
            //BenchmarkRunner.Run<ConvertTo2_CharNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_SByte>(config);
            //BenchmarkRunner.Run<ConvertTo2_SByteNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_Byte>(config);
            //BenchmarkRunner.Run<ConvertTo2_ByteNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_Short>(config);
            //BenchmarkRunner.Run<ConvertTo2_ShortNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_UShort>(config);
            //BenchmarkRunner.Run<ConvertTo2_UShortNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_Int>(config);
            //BenchmarkRunner.Run<ConvertTo2_IntNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_UInt>(config);
            //BenchmarkRunner.Run<ConvertTo2_UIntNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_Long>(config);
            //BenchmarkRunner.Run<ConvertTo2_LongNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_ULong>(config);
            //BenchmarkRunner.Run<ConvertTo2_ULongNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_Float>(config);
            //BenchmarkRunner.Run<ConvertTo2_FloatNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_Double>(config);
            //BenchmarkRunner.Run<ConvertTo2_DoubleNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_Decimal>(config);
            //BenchmarkRunner.Run<ConvertTo2_DecimalNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_DateTime>(config);
            //BenchmarkRunner.Run<ConvertTo2_DateTimeNullable>(config);
            //BenchmarkRunner.Run<ConvertTo2_String>(config);


            //BenchmarkRunner.Run<ConvertTo_Bool>(config);
            //BenchmarkRunner.Run<ConvertTo_BoolNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_Char>(config);
            //BenchmarkRunner.Run<ConvertTo_CharNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_SByte>(config);
            //BenchmarkRunner.Run<ConvertTo_SByteNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_Byte>(config);
            //BenchmarkRunner.Run<ConvertTo_ByteNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_Short>(config);
            //BenchmarkRunner.Run<ConvertTo_ShortNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_UShort>(config);
            //BenchmarkRunner.Run<ConvertTo_UShortNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_Int>(config);
            //BenchmarkRunner.Run<ConvertTo_IntNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_UInt>(config);
            //BenchmarkRunner.Run<ConvertTo_UIntNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_Long>(config);
            //BenchmarkRunner.Run<ConvertTo_LongNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_ULong>(config);
            //BenchmarkRunner.Run<ConvertTo_ULongNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_Float>(config);
            //BenchmarkRunner.Run<ConvertTo_FloatNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_Double>(config);
            //BenchmarkRunner.Run<ConvertTo_DoubleNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_Decimal>(config);
            //BenchmarkRunner.Run<ConvertTo_DecimalNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_DateTime>(config);
            //BenchmarkRunner.Run<ConvertTo_DateTimeNullable>(config);
            //BenchmarkRunner.Run<ConvertTo_String>(config);
        }
    }
}