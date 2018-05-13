
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.295 ns | 0.0029 ns | 0.0026 ns |      - |       0 B |
     ToBoolNullable |  4.471 ns | 0.0025 ns | 0.0024 ns |      - |       0 B |
             ToChar |  3.087 ns | 0.0072 ns | 0.0068 ns |      - |       0 B |
     ToCharNullable |  5.235 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
            ToSByte |  2.830 ns | 0.0062 ns | 0.0058 ns |      - |       0 B |
    ToSByteNullable |  5.236 ns | 0.0033 ns | 0.0030 ns |      - |       0 B |
             ToByte |  3.087 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
     ToByteNullable |  5.247 ns | 0.0138 ns | 0.0122 ns |      - |       0 B |
            ToShort |  3.080 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
    ToShortNullable |  5.244 ns | 0.0106 ns | 0.0094 ns |      - |       0 B |
           ToUShort |  3.083 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
   ToUShortNullable |  5.262 ns | 0.0186 ns | 0.0165 ns |      - |       0 B |
              ToInt |  1.294 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
      ToIntNullable |  4.471 ns | 0.0034 ns | 0.0031 ns |      - |       0 B |
             ToUInt |  1.790 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
     ToUIntNullable |  4.709 ns | 0.0025 ns | 0.0024 ns |      - |       0 B |
             ToLong |  1.280 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
     ToLongNullable |  2.554 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
            ToULong |  1.787 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
    ToULongNullable |  3.323 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
            ToFloat |  1.279 ns | 0.0038 ns | 0.0035 ns |      - |       0 B |
    ToFloatNullable |  4.471 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
           ToDouble |  1.283 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
   ToDoubleNullable |  2.565 ns | 0.0075 ns | 0.0071 ns |      - |       0 B |
          ToDecimal |  6.495 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
  ToDecimalNullable | 20.872 ns | 0.0117 ns | 0.0110 ns |      - |       0 B |
         ToDateTime |  3.067 ns | 0.0034 ns | 0.0032 ns |      - |       0 B |
 ToDateTimeNullable |  8.834 ns | 0.0121 ns | 0.0113 ns |      - |       0 B |
           ToObject |  3.771 ns | 0.0019 ns | 0.0015 ns | 0.0057 |      24 B |
          To_String | 41.660 ns | 0.0502 ns | 0.0445 ns | 0.0076 |      32 B |
             ToEnum | 14.197 ns | 0.0024 ns | 0.0018 ns |      - |       0 B |
     ToEnumNullable | 19.976 ns | 0.0150 ns | 0.0133 ns |      - |       0 B |
