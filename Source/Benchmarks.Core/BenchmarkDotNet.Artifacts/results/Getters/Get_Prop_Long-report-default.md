
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.593 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
     ToBoolNullable |  6.771 ns | 0.0143 ns | 0.0127 ns |      - |       0 B |
             ToChar |  4.870 ns | 0.0014 ns | 0.0012 ns |      - |       0 B |
     ToCharNullable |  7.294 ns | 0.0099 ns | 0.0093 ns |      - |       0 B |
            ToSByte |  4.879 ns | 0.0108 ns | 0.0101 ns |      - |       0 B |
    ToSByteNullable |  7.301 ns | 0.0080 ns | 0.0075 ns |      - |       0 B |
             ToByte |  4.878 ns | 0.0103 ns | 0.0091 ns |      - |       0 B |
     ToByteNullable |  7.282 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
            ToShort |  4.876 ns | 0.0071 ns | 0.0063 ns |      - |       0 B |
    ToShortNullable |  7.304 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
           ToUShort |  4.889 ns | 0.0126 ns | 0.0111 ns |      - |       0 B |
   ToUShortNullable |  7.295 ns | 0.0042 ns | 0.0040 ns |      - |       0 B |
              ToInt |  4.882 ns | 0.0139 ns | 0.0123 ns |      - |       0 B |
      ToIntNullable |  7.304 ns | 0.0086 ns | 0.0080 ns |      - |       0 B |
             ToUInt |  4.865 ns | 0.0107 ns | 0.0095 ns |      - |       0 B |
     ToUIntNullable |  7.294 ns | 0.0032 ns | 0.0028 ns |      - |       0 B |
             ToLong |  1.788 ns | 0.0005 ns | 0.0005 ns |      - |       0 B |
     ToLongNullable |  3.576 ns | 0.0004 ns | 0.0003 ns |      - |       0 B |
            ToULong |  4.423 ns | 0.0009 ns | 0.0007 ns |      - |       0 B |
    ToULongNullable |  6.902 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
            ToFloat |  3.834 ns | 0.0030 ns | 0.0028 ns |      - |       0 B |
    ToFloatNullable |  6.770 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
           ToDouble |  3.834 ns | 0.0031 ns | 0.0028 ns |      - |       0 B |
   ToDoubleNullable |  6.394 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
          ToDecimal |  7.160 ns | 0.0095 ns | 0.0089 ns |      - |       0 B |
  ToDecimalNullable | 16.473 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
         ToDateTime |  5.414 ns | 0.0048 ns | 0.0037 ns |      - |       0 B |
 ToDateTimeNullable |  6.387 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
           ToObject |  4.297 ns | 0.0029 ns | 0.0025 ns | 0.0057 |      24 B |
          To_String | 49.246 ns | 0.0463 ns | 0.0433 ns | 0.0076 |      32 B |
             ToEnum | 25.181 ns | 0.0193 ns | 0.0181 ns | 0.0057 |      24 B |
