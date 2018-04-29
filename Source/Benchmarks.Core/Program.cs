using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Running;
using Benchmarks.Core.Deipax;
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

            RunGetterBenchmarks(config);

            //BenchmarkRunner.Run<AdHoc>(config);
        }

        #region Private Members
        private static void RunGetterBenchmarks(IConfig config = null)
        {
            /*
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
            */
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

        private static void RunConvertBenchmarks(IConfig config = null)
        {
            BenchmarkRunner.Run<ConvertToBool>(config);
            BenchmarkRunner.Run<ConvertToBoolNullable>(config);
            BenchmarkRunner.Run<ConvertToChar>(config);
            BenchmarkRunner.Run<ConvertToCharNullable>(config);
            BenchmarkRunner.Run<ConvertToSByte>(config);
            BenchmarkRunner.Run<ConvertToSByteNullable>(config);
            BenchmarkRunner.Run<ConvertToByte>(config);
            BenchmarkRunner.Run<ConvertToByteNullable>(config);
            BenchmarkRunner.Run<ConvertToShort>(config);
            BenchmarkRunner.Run<ConvertToShortNullable>(config);
            BenchmarkRunner.Run<ConvertToUShort>(config);
            BenchmarkRunner.Run<ConvertToUShortNullable>(config);
            BenchmarkRunner.Run<ConvertToInt>(config);
            BenchmarkRunner.Run<ConvertToIntNullable>(config);
            BenchmarkRunner.Run<ConvertToUInt>(config);
            BenchmarkRunner.Run<ConvertToUIntNullable>(config);
            BenchmarkRunner.Run<ConvertToLong>(config);
            BenchmarkRunner.Run<ConvertToLongNullable>(config);
            BenchmarkRunner.Run<ConvertToULong>(config);
            BenchmarkRunner.Run<ConvertToULongNullable>(config);
            BenchmarkRunner.Run<ConvertToFloat>(config);
            BenchmarkRunner.Run<ConvertToFloatNullable>(config);
            BenchmarkRunner.Run<ConvertToDouble>(config);
            BenchmarkRunner.Run<ConvertToDoubleNullable>(config);
            BenchmarkRunner.Run<ConvertToDecimal>(config);
            BenchmarkRunner.Run<ConvertToDecimalNullable>(config);
            BenchmarkRunner.Run<ConvertToDateTime>(config);
            BenchmarkRunner.Run<ConvertToDateTimeNullable>(config);
            BenchmarkRunner.Run<ConvertToString>(config);
            BenchmarkRunner.Run<ConvertToObject>(config);
            BenchmarkRunner.Run<ConvertToEnum>(config);
            BenchmarkRunner.Run<ConvertToIParent>(config);
        }
        #endregion
    }
}