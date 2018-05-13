
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.294 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
     ToBoolNullable |  4.457 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
             ToChar |  1.295 ns | 0.0031 ns | 0.0027 ns |      - |       0 B |
     ToCharNullable |  4.468 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
            ToSByte |  2.061 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
    ToSByteNullable |  4.712 ns | 0.0043 ns | 0.0040 ns |      - |       0 B |
             ToByte |  1.369 ns | 0.0045 ns | 0.0042 ns |      - |       0 B |
     ToByteNullable |  4.470 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
            ToShort |  1.288 ns | 0.0065 ns | 0.0054 ns |      - |       0 B |
    ToShortNullable |  4.473 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
           ToUShort |  1.290 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
   ToUShortNullable |  4.470 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
              ToInt |  1.298 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
      ToIntNullable |  4.470 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
             ToUInt |  1.276 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
     ToUIntNullable |  4.471 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
             ToLong |  1.280 ns | 0.0028 ns | 0.0021 ns |      - |       0 B |
     ToLongNullable |  2.558 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
            ToULong |  1.279 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
    ToULongNullable |  2.555 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
            ToFloat |  1.534 ns | 0.0063 ns | 0.0059 ns |      - |       0 B |
    ToFloatNullable |  4.470 ns | 0.0023 ns | 0.0022 ns |      - |       0 B |
           ToDouble |  1.536 ns | 0.0009 ns | 0.0009 ns |      - |       0 B |
   ToDoubleNullable |  2.812 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
          ToDecimal |  7.800 ns | 0.0032 ns | 0.0029 ns |      - |       0 B |
  ToDecimalNullable | 20.808 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
         ToDateTime |  3.070 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
 ToDateTimeNullable |  8.828 ns | 0.0164 ns | 0.0153 ns |      - |       0 B |
           ToObject |  3.790 ns | 0.0034 ns | 0.0028 ns | 0.0057 |      24 B |
          To_String | 41.753 ns | 0.0146 ns | 0.0114 ns | 0.0076 |      32 B |
             ToEnum | 11.611 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
     ToEnumNullable | 17.408 ns | 0.0039 ns | 0.0033 ns |      - |       0 B |
