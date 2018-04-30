
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.959 ns | 0.0025 ns | 0.0023 ns |      - |       0 B |
     ToBoolNullable |  6.542 ns | 0.0160 ns | 0.0150 ns |      - |       0 B |
             ToChar |  2.103 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
     ToCharNullable |  1.277 ns | 0.0021 ns | 0.0018 ns |      - |       0 B |
            ToSByte |  4.582 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
    ToSByteNullable |  6.795 ns | 0.0181 ns | 0.0161 ns |      - |       0 B |
             ToByte |  4.334 ns | 0.0070 ns | 0.0065 ns |      - |       0 B |
     ToByteNullable |  6.796 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
            ToShort |  4.335 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
    ToShortNullable |  6.827 ns | 0.0040 ns | 0.0033 ns |      - |       0 B |
           ToUShort |  3.824 ns | 0.0035 ns | 0.0033 ns |      - |       0 B |
   ToUShortNullable |  6.540 ns | 0.0019 ns | 0.0018 ns |      - |       0 B |
              ToInt |  3.813 ns | 0.0016 ns | 0.0012 ns |      - |       0 B |
      ToIntNullable |  6.562 ns | 0.0035 ns | 0.0027 ns |      - |       0 B |
             ToUInt |  3.828 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
     ToUIntNullable |  6.543 ns | 0.0021 ns | 0.0020 ns |      - |       0 B |
             ToLong |  3.994 ns | 0.0316 ns | 0.0280 ns |      - |       0 B |
     ToLongNullable |  6.683 ns | 0.0095 ns | 0.0080 ns |      - |       0 B |
            ToULong |  3.855 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
    ToULongNullable |  6.179 ns | 0.0120 ns | 0.0106 ns |      - |       0 B |
            ToFloat |  3.066 ns | 0.0012 ns | 0.0009 ns |      - |       0 B |
    ToFloatNullable |  6.528 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
           ToDouble |  3.328 ns | 0.1178 ns | 0.1044 ns |      - |       0 B |
   ToDoubleNullable |  5.899 ns | 0.0066 ns | 0.0061 ns |      - |       0 B |
          ToDecimal |  6.133 ns | 0.0011 ns | 0.0010 ns |      - |       0 B |
  ToDecimalNullable |  5.634 ns | 0.0047 ns | 0.0042 ns |      - |       0 B |
         ToDateTime |  4.349 ns | 0.0073 ns | 0.0068 ns |      - |       0 B |
 ToDateTimeNullable |  5.911 ns | 0.0103 ns | 0.0096 ns |      - |       0 B |
           ToObject |  4.903 ns | 0.0051 ns | 0.0045 ns | 0.0057 |      24 B |
          To_String |  7.643 ns | 0.0130 ns | 0.0121 ns | 0.0076 |      32 B |
             ToEnum | 25.363 ns | 0.0414 ns | 0.0387 ns | 0.0057 |      24 B |
