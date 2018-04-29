
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.796 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
     ToBoolNullable |  6.782 ns | 0.0057 ns | 0.0051 ns |      - |       0 B |
             ToChar |  4.419 ns | 0.0758 ns | 0.0633 ns |      - |       0 B |
     ToCharNullable |  7.180 ns | 0.1704 ns | 0.1674 ns |      - |       0 B |
            ToSByte |  4.903 ns | 0.0646 ns | 0.0572 ns |      - |       0 B |
    ToSByteNullable |  7.319 ns | 0.0210 ns | 0.0175 ns |      - |       0 B |
             ToByte |  4.864 ns | 0.0264 ns | 0.0247 ns |      - |       0 B |
     ToByteNullable |  7.332 ns | 0.0334 ns | 0.0279 ns |      - |       0 B |
            ToShort |  1.782 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
    ToShortNullable |  4.732 ns | 0.0043 ns | 0.0036 ns |      - |       0 B |
           ToUShort |  4.463 ns | 0.0751 ns | 0.0702 ns |      - |       0 B |
   ToUShortNullable |  7.026 ns | 0.0023 ns | 0.0018 ns |      - |       0 B |
              ToInt |  3.822 ns | 0.0097 ns | 0.0076 ns |      - |       0 B |
      ToIntNullable |  6.784 ns | 0.0025 ns | 0.0020 ns |      - |       0 B |
             ToUInt |  4.345 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
     ToUIntNullable |  7.024 ns | 0.0014 ns | 0.0011 ns |      - |       0 B |
             ToLong |  3.962 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
     ToLongNullable |  6.131 ns | 0.0012 ns | 0.0010 ns |      - |       0 B |
            ToULong |  4.394 ns | 0.0298 ns | 0.0249 ns |      - |       0 B |
    ToULongNullable |  6.645 ns | 0.0023 ns | 0.0021 ns |      - |       0 B |
            ToFloat |  3.983 ns | 0.0232 ns | 0.0217 ns |      - |       0 B |
    ToFloatNullable |  6.778 ns | 0.0024 ns | 0.0021 ns |      - |       0 B |
           ToDouble |  3.896 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
   ToDoubleNullable |  6.161 ns | 0.0325 ns | 0.0288 ns |      - |       0 B |
          ToDecimal |  7.147 ns | 0.0450 ns | 0.0399 ns |      - |       0 B |
  ToDecimalNullable | 15.984 ns | 0.0098 ns | 0.0092 ns |      - |       0 B |
         ToDateTime |  5.167 ns | 0.0976 ns | 0.0913 ns |      - |       0 B |
 ToDateTimeNullable |  6.282 ns | 0.0793 ns | 0.0742 ns |      - |       0 B |
           ToObject |  4.317 ns | 0.0113 ns | 0.0100 ns | 0.0057 |      24 B |
          To_String | 47.115 ns | 0.0225 ns | 0.0210 ns | 0.0076 |      32 B |
             ToEnum | 23.461 ns | 0.0111 ns | 0.0098 ns | 0.0057 |      24 B |
