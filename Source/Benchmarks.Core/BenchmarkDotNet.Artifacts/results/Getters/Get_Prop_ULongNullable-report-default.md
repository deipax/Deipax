
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.030 ns | 0.0034 ns | 0.0028 ns |      - |       0 B |
     ToBoolNullable |  4.772 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
             ToChar |  3.570 ns | 0.0089 ns | 0.0079 ns |      - |       0 B |
     ToCharNullable |  6.019 ns | 0.0023 ns | 0.0020 ns |      - |       0 B |
            ToSByte |  2.543 ns | 0.0055 ns | 0.0051 ns |      - |       0 B |
    ToSByteNullable |  5.508 ns | 0.0023 ns | 0.0022 ns |      - |       0 B |
             ToByte |  3.827 ns | 0.0041 ns | 0.0036 ns |      - |       0 B |
     ToByteNullable |  6.020 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
            ToShort |  3.816 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
    ToShortNullable |  6.023 ns | 0.0107 ns | 0.0094 ns |      - |       0 B |
           ToUShort |  3.817 ns | 0.0027 ns | 0.0025 ns |      - |       0 B |
   ToUShortNullable |  6.019 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
              ToInt |  3.817 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
      ToIntNullable |  6.018 ns | 0.0013 ns | 0.0010 ns |      - |       0 B |
             ToUInt |  2.556 ns | 0.0029 ns | 0.0027 ns |      - |       0 B |
     ToUIntNullable |  5.509 ns | 0.0039 ns | 0.0037 ns |      - |       0 B |
             ToLong |  2.555 ns | 0.0028 ns | 0.0026 ns |      - |       0 B |
     ToLongNullable |  3.584 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
            ToULong |  1.952 ns | 0.0039 ns | 0.0035 ns |      - |       0 B |
    ToULongNullable |  2.554 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
            ToFloat |  2.566 ns | 0.0059 ns | 0.0049 ns |      - |       0 B |
    ToFloatNullable |  5.029 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
           ToDouble |  2.552 ns | 0.0094 ns | 0.0078 ns |      - |       0 B |
   ToDoubleNullable |  3.834 ns | 0.0038 ns | 0.0035 ns |      - |       0 B |
          ToDecimal |  6.791 ns | 0.0167 ns | 0.0156 ns |      - |       0 B |
  ToDecimalNullable | 18.781 ns | 0.0132 ns | 0.0124 ns |      - |       0 B |
         ToDateTime |  2.555 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
 ToDateTimeNullable |  8.450 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
           ToObject |  4.938 ns | 0.0043 ns | 0.0039 ns | 0.0057 |      24 B |
          To_String | 43.416 ns | 0.0715 ns | 0.0669 ns | 0.0076 |      32 B |
             ToEnum | 14.996 ns | 0.0273 ns | 0.0256 ns |      - |       0 B |
     ToEnumNullable | 20.730 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
