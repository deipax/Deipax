
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  4.330 ns | 0.0006 ns | 0.0005 ns |      - |       0 B |
     ToBoolNullable |  7.009 ns | 0.0122 ns | 0.0114 ns |      - |       0 B |
             ToChar |  4.326 ns | 0.0011 ns | 0.0009 ns |      - |       0 B |
     ToCharNullable |  6.805 ns | 0.0037 ns | 0.0035 ns |      - |       0 B |
            ToSByte |  4.843 ns | 0.0074 ns | 0.0070 ns |      - |       0 B |
    ToSByteNullable |  7.307 ns | 0.0073 ns | 0.0065 ns |      - |       0 B |
             ToByte |  2.811 ns | 0.0081 ns | 0.0076 ns |      - |       0 B |
     ToByteNullable |  1.793 ns | 0.0016 ns | 0.0014 ns |      - |       0 B |
            ToShort |  4.582 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
    ToShortNullable |  6.804 ns | 0.0280 ns | 0.0234 ns |      - |       0 B |
           ToUShort |  4.603 ns | 0.0071 ns | 0.0056 ns |      - |       0 B |
   ToUShortNullable |  6.789 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
              ToInt |  4.627 ns | 0.0828 ns | 0.0692 ns |      - |       0 B |
      ToIntNullable |  6.777 ns | 0.0175 ns | 0.0164 ns |      - |       0 B |
             ToUInt |  4.639 ns | 0.0476 ns | 0.0398 ns |      - |       0 B |
     ToUIntNullable |  6.782 ns | 0.0073 ns | 0.0061 ns |      - |       0 B |
             ToLong |  4.687 ns | 0.0538 ns | 0.0477 ns |      - |       0 B |
     ToLongNullable |  6.391 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
            ToULong |  4.676 ns | 0.0562 ns | 0.0470 ns |      - |       0 B |
    ToULongNullable |  6.401 ns | 0.0153 ns | 0.0136 ns |      - |       0 B |
            ToFloat |  4.673 ns | 0.0615 ns | 0.0546 ns |      - |       0 B |
    ToFloatNullable |  6.848 ns | 0.0467 ns | 0.0414 ns |      - |       0 B |
           ToDouble |  4.679 ns | 0.0758 ns | 0.0672 ns |      - |       0 B |
   ToDoubleNullable |  7.019 ns | 0.0763 ns | 0.0676 ns |      - |       0 B |
          ToDecimal |  8.320 ns | 0.0621 ns | 0.0449 ns |      - |       0 B |
  ToDecimalNullable | 16.507 ns | 0.0276 ns | 0.0244 ns |      - |       0 B |
         ToDateTime |  5.119 ns | 0.0106 ns | 0.0088 ns |      - |       0 B |
 ToDateTimeNullable |  6.573 ns | 0.2211 ns | 0.2365 ns |      - |       0 B |
           ToObject |  5.364 ns | 0.0927 ns | 0.0774 ns | 0.0057 |      24 B |
          To_String | 47.454 ns | 0.2776 ns | 0.2596 ns | 0.0076 |      32 B |
             ToEnum | 27.901 ns | 0.0459 ns | 0.0429 ns | 0.0057 |      24 B |
