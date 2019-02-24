﻿using BenchmarkDotNet.Configs;
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
                .With(DefaultConfig.Instance.GetValidators().ToArray())
                .With(MarkdownExporter.Default)
                .With(MemoryDiagnoser.Default);

            //RunSetterBenchmarks(config);
            RunGetterBenchmarks(config);
            RunConvertBenchmarks(config);
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

        private static void RunConvertBenchmarks(IConfig config = null)
        {
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
        }
        #endregion
    }
}