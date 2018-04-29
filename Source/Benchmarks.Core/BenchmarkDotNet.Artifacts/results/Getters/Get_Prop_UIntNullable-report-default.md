
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |    Median |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
             ToBool |  4.371 ns | 0.0048 ns | 0.0044 ns |  4.371 ns |      - |       0 B |
     ToBoolNullable |  6.788 ns | 0.0186 ns | 0.0165 ns |  6.789 ns |      - |       0 B |
             ToChar |  4.888 ns | 0.0058 ns | 0.0051 ns |  4.887 ns |      - |       0 B |
     ToCharNullable |  7.270 ns | 0.0146 ns | 0.0129 ns |  7.271 ns |      - |       0 B |
            ToSByte |  4.880 ns | 0.0040 ns | 0.0036 ns |  4.879 ns |      - |       0 B |
    ToSByteNullable |  7.263 ns | 0.0007 ns | 0.0006 ns |  7.263 ns |      - |       0 B |
             ToByte |  4.877 ns | 0.0099 ns | 0.0088 ns |  4.880 ns |      - |       0 B |
     ToByteNullable |  7.264 ns | 0.0012 ns | 0.0011 ns |  7.264 ns |      - |       0 B |
            ToShort |  6.155 ns | 0.0068 ns | 0.0063 ns |  6.157 ns |      - |       0 B |
    ToShortNullable |  7.535 ns | 0.0017 ns | 0.0014 ns |  7.535 ns |      - |       0 B |
           ToUShort |  4.878 ns | 0.0122 ns | 0.0108 ns |  4.874 ns |      - |       0 B |
   ToUShortNullable |  7.264 ns | 0.0009 ns | 0.0008 ns |  7.264 ns |      - |       0 B |
              ToInt |  4.880 ns | 0.0033 ns | 0.0029 ns |  4.878 ns |      - |       0 B |
      ToIntNullable |  7.263 ns | 0.0008 ns | 0.0007 ns |  7.263 ns |      - |       0 B |
             ToUInt |  2.819 ns | 0.0045 ns | 0.0035 ns |  2.818 ns |      - |       0 B |
     ToUIntNullable |  2.048 ns | 0.0048 ns | 0.0045 ns |  2.044 ns |      - |       0 B |
             ToLong |  4.658 ns | 0.0023 ns | 0.0020 ns |  4.658 ns |      - |       0 B |
     ToLongNullable |  6.653 ns | 0.0137 ns | 0.0115 ns |  6.654 ns |      - |       0 B |
            ToULong |  4.610 ns | 0.0033 ns | 0.0031 ns |  4.610 ns |      - |       0 B |
    ToULongNullable |  6.897 ns | 0.0148 ns | 0.0139 ns |  6.887 ns |      - |       0 B |
            ToFloat |  4.865 ns | 0.0050 ns | 0.0046 ns |  4.864 ns |      - |       0 B |
    ToFloatNullable |  7.025 ns | 0.0016 ns | 0.0014 ns |  7.025 ns |      - |       0 B |
           ToDouble |  4.865 ns | 0.0093 ns | 0.0087 ns |  4.867 ns |      - |       0 B |
   ToDoubleNullable |  6.897 ns | 0.0025 ns | 0.0019 ns |  6.898 ns |      - |       0 B |
          ToDecimal |  7.678 ns | 0.0037 ns | 0.0032 ns |  7.679 ns |      - |       0 B |
  ToDecimalNullable | 16.215 ns | 0.0007 ns | 0.0007 ns | 16.215 ns |      - |       0 B |
         ToDateTime |  5.379 ns | 0.0022 ns | 0.0020 ns |  5.379 ns |      - |       0 B |
 ToDateTimeNullable |  6.386 ns | 0.0015 ns | 0.0011 ns |  6.386 ns |      - |       0 B |
           ToObject |  5.344 ns | 0.0047 ns | 0.0042 ns |  5.343 ns | 0.0057 |      24 B |
          To_String | 41.429 ns | 0.0086 ns | 0.0076 ns | 41.429 ns | 0.0076 |      32 B |
             ToEnum | 28.567 ns | 0.0130 ns | 0.0116 ns | 28.567 ns | 0.0057 |      24 B |
