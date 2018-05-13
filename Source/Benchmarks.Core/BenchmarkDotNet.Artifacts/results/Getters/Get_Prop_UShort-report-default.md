
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.294 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
     ToBoolNullable |  4.474 ns | 0.0041 ns | 0.0039 ns |      - |       0 B |
             ToChar |  1.285 ns | 0.0025 ns | 0.0022 ns |      - |       0 B |
     ToCharNullable |  4.471 ns | 0.0028 ns | 0.0025 ns |      - |       0 B |
            ToSByte |  2.056 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
    ToSByteNullable |  4.712 ns | 0.0033 ns | 0.0031 ns |      - |       0 B |
             ToByte |  2.043 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
     ToByteNullable |  4.710 ns | 0.0030 ns | 0.0027 ns |      - |       0 B |
            ToShort |  2.049 ns | 0.0068 ns | 0.0064 ns |      - |       0 B |
    ToShortNullable |  4.711 ns | 0.0032 ns | 0.0030 ns |      - |       0 B |
           ToUShort |  1.292 ns | 0.0037 ns | 0.0033 ns |      - |       0 B |
   ToUShortNullable |  4.472 ns | 0.0027 ns | 0.0024 ns |      - |       0 B |
              ToInt |  1.293 ns | 0.0018 ns | 0.0015 ns |      - |       0 B |
      ToIntNullable |  4.470 ns | 0.0022 ns | 0.0020 ns |      - |       0 B |
             ToUInt |  1.268 ns | 0.0059 ns | 0.0055 ns |      - |       0 B |
     ToUIntNullable |  4.470 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
             ToLong |  1.281 ns | 0.0030 ns | 0.0024 ns |      - |       0 B |
     ToLongNullable |  2.566 ns | 0.0047 ns | 0.0044 ns |      - |       0 B |
            ToULong |  1.284 ns | 0.0053 ns | 0.0047 ns |      - |       0 B |
    ToULongNullable |  2.567 ns | 0.0222 ns | 0.0196 ns |      - |       0 B |
            ToFloat |  1.532 ns | 0.0002 ns | 0.0002 ns |      - |       0 B |
    ToFloatNullable |  4.483 ns | 0.0024 ns | 0.0023 ns |      - |       0 B |
           ToDouble |  1.532 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
   ToDoubleNullable |  3.069 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
          ToDecimal |  7.772 ns | 0.0007 ns | 0.0005 ns |      - |       0 B |
  ToDecimalNullable | 18.567 ns | 0.0197 ns | 0.0185 ns |      - |       0 B |
         ToDateTime |  3.069 ns | 0.0057 ns | 0.0054 ns |      - |       0 B |
 ToDateTimeNullable |  8.827 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
           ToObject |  4.111 ns | 0.0020 ns | 0.0018 ns | 0.0057 |      24 B |
          To_String | 37.778 ns | 0.0633 ns | 0.0561 ns | 0.0076 |      32 B |
             ToEnum | 11.580 ns | 0.0225 ns | 0.0210 ns |      - |       0 B |
     ToEnumNullable | 17.439 ns | 0.0121 ns | 0.0107 ns |      - |       0 B |
