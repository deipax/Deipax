
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.097 ns | 0.0038 ns | 0.0034 ns |      - |       0 B |
     ToBoolNullable |  6.517 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
             ToChar |  3.600 ns | 0.0058 ns | 0.0054 ns |      - |       0 B |
     ToCharNullable |  6.528 ns | 0.0034 ns | 0.0030 ns |      - |       0 B |
            ToSByte |  3.618 ns | 0.0070 ns | 0.0066 ns |      - |       0 B |
    ToSByteNullable |  6.526 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
             ToByte |  3.771 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
     ToByteNullable |  6.534 ns | 0.0069 ns | 0.0065 ns |      - |       0 B |
            ToShort |  4.082 ns | 0.0067 ns | 0.0062 ns |      - |       0 B |
    ToShortNullable |  7.296 ns | 0.0031 ns | 0.0026 ns |      - |       0 B |
           ToUShort |  3.597 ns | 0.0040 ns | 0.0037 ns |      - |       0 B |
   ToUShortNullable |  6.534 ns | 0.0075 ns | 0.0067 ns |      - |       0 B |
              ToInt |  3.553 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
      ToIntNullable |  6.533 ns | 0.0019 ns | 0.0017 ns |      - |       0 B |
             ToUInt |  1.279 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
     ToUIntNullable |  4.489 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
             ToLong |  3.247 ns | 0.0069 ns | 0.0065 ns |      - |       0 B |
     ToLongNullable |  5.631 ns | 0.0024 ns | 0.0019 ns |      - |       0 B |
            ToULong |  3.072 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
    ToULongNullable |  5.623 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
            ToFloat |  3.100 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
    ToFloatNullable |  6.534 ns | 0.0029 ns | 0.0024 ns |      - |       0 B |
           ToDouble |  3.235 ns | 0.0049 ns | 0.0046 ns |      - |       0 B |
   ToDoubleNullable |  5.637 ns | 0.0065 ns | 0.0057 ns |      - |       0 B |
          ToDecimal |  6.151 ns | 0.0064 ns | 0.0053 ns |      - |       0 B |
  ToDecimalNullable | 15.728 ns | 0.0093 ns | 0.0083 ns |      - |       0 B |
         ToDateTime |  4.352 ns | 0.0053 ns | 0.0049 ns |      - |       0 B |
 ToDateTimeNullable |  5.922 ns | 0.0147 ns | 0.0138 ns |      - |       0 B |
           ToObject |  3.800 ns | 0.0056 ns | 0.0052 ns | 0.0057 |      24 B |
          To_String | 40.452 ns | 0.0554 ns | 0.0491 ns | 0.0076 |      32 B |
             ToEnum | 23.171 ns | 0.0162 ns | 0.0152 ns | 0.0057 |      24 B |
