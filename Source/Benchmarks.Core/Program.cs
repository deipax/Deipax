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

            //BenchmarkRunner.Run<AdHoc>(config);

            BenchmarkRunner.Run<Bool_ModelAccess>(config);
            BenchmarkRunner.Run<BoolNullable_ModelAccess>(config);
            BenchmarkRunner.Run<Char_ModelAccess>(config);
            BenchmarkRunner.Run<CharNullable_ModelAccess>(config);
            BenchmarkRunner.Run<Sbyte_ModelAccess>(config);
            BenchmarkRunner.Run<SbyteNullable_ModelAccess>(config);
            BenchmarkRunner.Run<Byte_ModelAccess>(config);
            BenchmarkRunner.Run<ByteNullable_ModelAccess>(config);
            BenchmarkRunner.Run<Short_ModelAccess>(config);
            BenchmarkRunner.Run<ShortNullable_ModelAccess>(config);
            BenchmarkRunner.Run<Int_ModelAccess>(config);
            BenchmarkRunner.Run<IntNullable_ModelAccess>(config);
            BenchmarkRunner.Run<UInt_ModelAccess>(config);
            BenchmarkRunner.Run<UIntNullable_ModelAccess>(config);
            BenchmarkRunner.Run<Long_ModelAccess>(config);
            BenchmarkRunner.Run<LongNullable_ModelAccess>(config);
            BenchmarkRunner.Run<ULong_ModelAccess>(config);
            BenchmarkRunner.Run<ULongNullable_ModelAccess>(config);
            BenchmarkRunner.Run<Float_ModelAccess>(config);
            BenchmarkRunner.Run<FloatNullable_ModelAccess>(config);
            BenchmarkRunner.Run<Double_ModelAccess>(config);
            BenchmarkRunner.Run<DoubleNullable_ModelAccess>(config);
            BenchmarkRunner.Run<Decimal_ModelAccess>(config);
            BenchmarkRunner.Run<DecimalNullable_ModelAccess>(config);
            BenchmarkRunner.Run<DateTime_ModelAccess>(config);
            BenchmarkRunner.Run<DateTimeNullable_ModelAccess>(config);
            BenchmarkRunner.Run<String_ModelAccess>(config);
            BenchmarkRunner.Run<Object_ModelAccess>(config);
            BenchmarkRunner.Run<Enum_ModelAccess>(config);

            /*
            BenchmarkRunner.Run<ConvertTo2_Bool>(config);
            BenchmarkRunner.Run<ConvertTo2_BoolNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_Char>(config);
            BenchmarkRunner.Run<ConvertTo2_CharNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_SByte>(config);
            BenchmarkRunner.Run<ConvertTo2_SByteNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_Byte>(config);
            BenchmarkRunner.Run<ConvertTo2_ByteNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_Short>(config);
            BenchmarkRunner.Run<ConvertTo2_ShortNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_UShort>(config);
            BenchmarkRunner.Run<ConvertTo2_UShortNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_Int>(config);
            BenchmarkRunner.Run<ConvertTo2_IntNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_UInt>(config);
            BenchmarkRunner.Run<ConvertTo2_UIntNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_Long>(config);
            BenchmarkRunner.Run<ConvertTo2_LongNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_ULong>(config);
            BenchmarkRunner.Run<ConvertTo2_ULongNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_Float>(config);
            BenchmarkRunner.Run<ConvertTo2_FloatNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_Double>(config);
            BenchmarkRunner.Run<ConvertTo2_DoubleNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_Decimal>(config);
            BenchmarkRunner.Run<ConvertTo2_DecimalNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_DateTime>(config);
            BenchmarkRunner.Run<ConvertTo2_DateTimeNullable>(config);
            BenchmarkRunner.Run<ConvertTo2_String>(config);
            BenchmarkRunner.Run<ConvertTo2_Object>(config);
            BenchmarkRunner.Run<ConvertTo2_Enum>(config);
            BenchmarkRunner.Run<ConvertTo2_IParent>(config);
            */

            /*
            BenchmarkRunner.Run<ConvertTo_Bool>(config);
            BenchmarkRunner.Run<ConvertTo_BoolNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Char>(config);
            BenchmarkRunner.Run<ConvertTo_CharNullable>(config);
            BenchmarkRunner.Run<ConvertTo_SByte>(config);
            BenchmarkRunner.Run<ConvertTo_SByteNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Byte>(config);
            BenchmarkRunner.Run<ConvertTo_ByteNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Short>(config);
            BenchmarkRunner.Run<ConvertTo_ShortNullable>(config);
            BenchmarkRunner.Run<ConvertTo_UShort>(config);
            BenchmarkRunner.Run<ConvertTo_UShortNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Int>(config);
            BenchmarkRunner.Run<ConvertTo_IntNullable>(config);
            BenchmarkRunner.Run<ConvertTo_UInt>(config);
            BenchmarkRunner.Run<ConvertTo_UIntNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Long>(config);
            BenchmarkRunner.Run<ConvertTo_LongNullable>(config);
            BenchmarkRunner.Run<ConvertTo_ULong>(config);
            BenchmarkRunner.Run<ConvertTo_ULongNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Float>(config);
            BenchmarkRunner.Run<ConvertTo_FloatNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Double>(config);
            BenchmarkRunner.Run<ConvertTo_DoubleNullable>(config);
            BenchmarkRunner.Run<ConvertTo_Decimal>(config);
            BenchmarkRunner.Run<ConvertTo_DecimalNullable>(config);
            BenchmarkRunner.Run<ConvertTo_DateTime>(config);
            BenchmarkRunner.Run<ConvertTo_DateTimeNullable>(config);
            BenchmarkRunner.Run<ConvertTo_String>(config);
            BenchmarkRunner.Run<ConvertTo_Object>(config);
            BenchmarkRunner.Run<ConvertTo_Enum>(config);
            BenchmarkRunner.Run<ConvertTo_IParent>(config);
            */
        }
    }
}