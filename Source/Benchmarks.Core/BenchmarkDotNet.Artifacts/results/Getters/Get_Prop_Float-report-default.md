
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   3.274 ns | 0.0457 ns | 0.0405 ns |      - |       0 B |
     ToBoolNullable |   6.785 ns | 0.0258 ns | 0.0229 ns |      - |       0 B |
             ToChar |   2.903 ns | 0.0094 ns | 0.0074 ns |      - |       0 B |
     ToCharNullable |   6.520 ns | 0.0078 ns | 0.0070 ns |      - |       0 B |
            ToSByte |   7.303 ns | 0.0630 ns | 0.0559 ns |      - |       0 B |
    ToSByteNullable |  13.577 ns | 0.0702 ns | 0.0657 ns |      - |       0 B |
             ToByte |   7.263 ns | 0.0112 ns | 0.0099 ns |      - |       0 B |
     ToByteNullable |   9.092 ns | 0.0147 ns | 0.0123 ns |      - |       0 B |
            ToShort |   7.169 ns | 0.0232 ns | 0.0206 ns |      - |       0 B |
    ToShortNullable |   9.076 ns | 0.0115 ns | 0.0107 ns |      - |       0 B |
           ToUShort |   7.223 ns | 0.0059 ns | 0.0046 ns |      - |       0 B |
   ToUShortNullable |   9.077 ns | 0.0121 ns | 0.0101 ns |      - |       0 B |
              ToInt |   5.389 ns | 0.0147 ns | 0.0130 ns |      - |       0 B |
      ToIntNullable |   8.310 ns | 0.0116 ns | 0.0103 ns |      - |       0 B |
             ToUInt |   5.624 ns | 0.0065 ns | 0.0055 ns |      - |       0 B |
     ToUIntNullable |   8.315 ns | 0.0118 ns | 0.0099 ns |      - |       0 B |
             ToLong |   6.424 ns | 0.0052 ns | 0.0049 ns |      - |       0 B |
     ToLongNullable |   9.700 ns | 0.0099 ns | 0.0083 ns |      - |       0 B |
            ToULong |   6.195 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
    ToULongNullable |   9.957 ns | 0.0355 ns | 0.0296 ns |      - |       0 B |
            ToFloat |   1.279 ns | 0.0018 ns | 0.0016 ns |      - |       0 B |
    ToFloatNullable |   4.473 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
           ToDouble |   3.185 ns | 0.0078 ns | 0.0069 ns |      - |       0 B |
   ToDoubleNullable |   6.167 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
          ToDecimal |  27.563 ns | 0.0780 ns | 0.0730 ns |      - |       0 B |
  ToDecimalNullable |  33.373 ns | 0.0165 ns | 0.0147 ns |      - |       0 B |
         ToDateTime |   4.623 ns | 0.0136 ns | 0.0127 ns |      - |       0 B |
 ToDateTimeNullable |   6.410 ns | 0.0060 ns | 0.0056 ns |      - |       0 B |
           ToObject |   3.781 ns | 0.0064 ns | 0.0060 ns | 0.0057 |      24 B |
          To_String | 221.879 ns | 0.2593 ns | 0.2299 ns | 0.0074 |      32 B |
             ToEnum |  25.766 ns | 0.2458 ns | 0.2179 ns | 0.0057 |      24 B |
