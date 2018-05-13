
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.297 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
     ToBoolNullable |  4.471 ns | 0.0021 ns | 0.0020 ns |      - |       0 B |
             ToChar |  1.810 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
     ToCharNullable |  4.709 ns | 0.0004 ns | 0.0004 ns |      - |       0 B |
            ToSByte |  3.084 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
    ToSByteNullable |  5.241 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
             ToByte |  3.081 ns | 0.0010 ns | 0.0009 ns |      - |       0 B |
     ToByteNullable |  5.238 ns | 0.0120 ns | 0.0112 ns |      - |       0 B |
            ToShort |  1.293 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
    ToShortNullable |  4.474 ns | 0.0012 ns | 0.0011 ns |      - |       0 B |
           ToUShort |  2.060 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
   ToUShortNullable |  4.733 ns | 0.0033 ns | 0.0031 ns |      - |       0 B |
              ToInt |  1.295 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
      ToIntNullable |  4.476 ns | 0.0021 ns | 0.0020 ns |      - |       0 B |
             ToUInt |  2.043 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
     ToUIntNullable |  4.718 ns | 0.0115 ns | 0.0102 ns |      - |       0 B |
             ToLong |  1.278 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
     ToLongNullable |  2.554 ns | 0.0005 ns | 0.0004 ns |      - |       0 B |
            ToULong |  2.047 ns | 0.0030 ns | 0.0028 ns |      - |       0 B |
    ToULongNullable |  3.321 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
            ToFloat |  1.279 ns | 0.0020 ns | 0.0019 ns |      - |       0 B |
    ToFloatNullable |  4.469 ns | 0.0006 ns | 0.0004 ns |      - |       0 B |
           ToDouble |  1.280 ns | 0.0022 ns | 0.0021 ns |      - |       0 B |
   ToDoubleNullable |  2.555 ns | 0.0004 ns | 0.0004 ns |      - |       0 B |
          ToDecimal |  6.502 ns | 0.0070 ns | 0.0065 ns |      - |       0 B |
  ToDecimalNullable | 18.499 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
         ToDateTime |  3.065 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
 ToDateTimeNullable |  8.303 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
           ToObject |  3.800 ns | 0.0020 ns | 0.0017 ns | 0.0057 |      24 B |
          To_String | 42.244 ns | 0.1928 ns | 0.1804 ns | 0.0076 |      32 B |
             ToEnum | 11.608 ns | 0.0113 ns | 0.0106 ns |      - |       0 B |
     ToEnumNullable | 17.407 ns | 0.0031 ns | 0.0024 ns |      - |       0 B |
