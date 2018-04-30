
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.113 ns | 0.0051 ns | 0.0045 ns |      - |       0 B |
     ToBoolNullable |  6.516 ns | 0.0084 ns | 0.0070 ns |      - |       0 B |
             ToChar |  3.816 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
     ToCharNullable |  6.537 ns | 0.0087 ns | 0.0082 ns |      - |       0 B |
            ToSByte |  1.262 ns | 0.0024 ns | 0.0022 ns |      - |       0 B |
    ToSByteNullable |  4.491 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
             ToByte |  3.933 ns | 0.0039 ns | 0.0037 ns |      - |       0 B |
     ToByteNullable |  6.531 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
            ToShort |  3.055 ns | 0.0073 ns | 0.0069 ns |      - |       0 B |
    ToShortNullable |  6.535 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
           ToUShort |  3.712 ns | 0.0088 ns | 0.0074 ns |      - |       0 B |
   ToUShortNullable |  7.007 ns | 0.0448 ns | 0.0419 ns |      - |       0 B |
              ToInt |  3.055 ns | 0.0048 ns | 0.0040 ns |      - |       0 B |
      ToIntNullable |  6.530 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
             ToUInt |  3.871 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
     ToUIntNullable |  6.532 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
             ToLong |  3.073 ns | 0.0035 ns | 0.0031 ns |      - |       0 B |
     ToLongNullable |  5.894 ns | 0.0037 ns | 0.0029 ns |      - |       0 B |
            ToULong |  3.713 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
    ToULongNullable |  6.402 ns | 0.0106 ns | 0.0099 ns |      - |       0 B |
            ToFloat |  3.074 ns | 0.0087 ns | 0.0081 ns |      - |       0 B |
    ToFloatNullable |  6.532 ns | 0.0026 ns | 0.0023 ns |      - |       0 B |
           ToDouble |  3.217 ns | 0.0049 ns | 0.0041 ns |      - |       0 B |
   ToDoubleNullable |  5.635 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
          ToDecimal |  6.135 ns | 0.0029 ns | 0.0027 ns |      - |       0 B |
  ToDecimalNullable | 15.733 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
         ToDateTime |  4.353 ns | 0.0075 ns | 0.0070 ns |      - |       0 B |
 ToDateTimeNullable |  6.165 ns | 0.0086 ns | 0.0081 ns |      - |       0 B |
           ToObject |  3.768 ns | 0.0026 ns | 0.0025 ns | 0.0057 |      24 B |
          To_String | 45.178 ns | 0.0355 ns | 0.0332 ns | 0.0076 |      32 B |
             ToEnum | 22.642 ns | 0.1760 ns | 0.1470 ns | 0.0057 |      24 B |
