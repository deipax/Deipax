
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.705 ns | 0.0008 ns | 0.0007 ns |      - |       0 B |
     ToBoolNullable |  6.772 ns | 0.0043 ns | 0.0041 ns |      - |       0 B |
             ToChar |  4.268 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
     ToCharNullable |  7.027 ns | 0.0059 ns | 0.0050 ns |      - |       0 B |
            ToSByte |  4.448 ns | 0.0077 ns | 0.0068 ns |      - |       0 B |
    ToSByteNullable |  7.023 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
             ToByte |  4.227 ns | 0.0088 ns | 0.0078 ns |      - |       0 B |
     ToByteNullable |  7.025 ns | 0.0044 ns | 0.0039 ns |      - |       0 B |
            ToShort |  4.859 ns | 0.0045 ns | 0.0037 ns |      - |       0 B |
    ToShortNullable |  7.298 ns | 0.0037 ns | 0.0035 ns |      - |       0 B |
           ToUShort |  4.279 ns | 0.0101 ns | 0.0089 ns |      - |       0 B |
   ToUShortNullable |  7.023 ns | 0.0017 ns | 0.0013 ns |      - |       0 B |
              ToInt |  4.329 ns | 0.0056 ns | 0.0050 ns |      - |       0 B |
      ToIntNullable |  7.026 ns | 0.0036 ns | 0.0034 ns |      - |       0 B |
             ToUInt |  1.795 ns | 0.0061 ns | 0.0054 ns |      - |       0 B |
     ToUIntNullable |  4.725 ns | 0.0033 ns | 0.0029 ns |      - |       0 B |
             ToLong |  3.821 ns | 0.0074 ns | 0.0062 ns |      - |       0 B |
     ToLongNullable |  6.136 ns | 0.0074 ns | 0.0070 ns |      - |       0 B |
            ToULong |  3.838 ns | 0.0098 ns | 0.0087 ns |      - |       0 B |
    ToULongNullable |  5.879 ns | 0.0053 ns | 0.0044 ns |      - |       0 B |
            ToFloat |  3.847 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
    ToFloatNullable |  6.784 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
           ToDouble |  3.849 ns | 0.0047 ns | 0.0039 ns |      - |       0 B |
   ToDoubleNullable |  5.880 ns | 0.0054 ns | 0.0051 ns |      - |       0 B |
          ToDecimal |  6.913 ns | 0.0165 ns | 0.0154 ns |      - |       0 B |
  ToDecimalNullable | 15.979 ns | 0.0102 ns | 0.0090 ns |      - |       0 B |
         ToDateTime |  5.116 ns | 0.0092 ns | 0.0086 ns |      - |       0 B |
 ToDateTimeNullable |  6.146 ns | 0.0167 ns | 0.0157 ns |      - |       0 B |
           ToObject |  4.515 ns | 0.0016 ns | 0.0014 ns | 0.0057 |      24 B |
          To_String | 41.303 ns | 0.0586 ns | 0.0548 ns | 0.0076 |      32 B |
             ToEnum | 25.036 ns | 0.0459 ns | 0.0359 ns | 0.0057 |      24 B |
