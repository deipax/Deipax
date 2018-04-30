
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   4.761 ns | 0.0218 ns | 0.0193 ns |      - |       0 B |
     ToBoolNullable |   7.328 ns | 0.0213 ns | 0.0200 ns |      - |       0 B |
             ToChar |   3.530 ns | 0.0209 ns | 0.0174 ns |      - |       0 B |
     ToCharNullable |   6.892 ns | 0.1236 ns | 0.1096 ns |      - |       0 B |
            ToSByte |   8.919 ns | 0.0136 ns | 0.0120 ns |      - |       0 B |
    ToSByteNullable |  10.463 ns | 0.0173 ns | 0.0154 ns |      - |       0 B |
             ToByte |   8.975 ns | 0.0054 ns | 0.0045 ns |      - |       0 B |
     ToByteNullable |   9.856 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
            ToShort |   8.915 ns | 0.0140 ns | 0.0131 ns |      - |       0 B |
    ToShortNullable |  10.127 ns | 0.0248 ns | 0.0220 ns |      - |       0 B |
           ToUShort |   8.786 ns | 0.0112 ns | 0.0105 ns |      - |       0 B |
   ToUShortNullable |   9.689 ns | 0.0149 ns | 0.0139 ns |      - |       0 B |
              ToInt |   7.430 ns | 0.0026 ns | 0.0021 ns |      - |       0 B |
      ToIntNullable |   8.797 ns | 0.0052 ns | 0.0043 ns |      - |       0 B |
             ToUInt |   7.433 ns | 0.0008 ns | 0.0006 ns |      - |       0 B |
     ToUIntNullable |   8.610 ns | 0.0411 ns | 0.0364 ns |      - |       0 B |
             ToLong |   7.828 ns | 0.0094 ns | 0.0088 ns |      - |       0 B |
     ToLongNullable |  11.219 ns | 0.0417 ns | 0.0390 ns |      - |       0 B |
            ToULong |   8.212 ns | 0.0013 ns | 0.0011 ns |      - |       0 B |
    ToULongNullable |  11.055 ns | 0.0561 ns | 0.0468 ns |      - |       0 B |
            ToFloat |   4.438 ns | 0.0068 ns | 0.0064 ns |      - |       0 B |
    ToFloatNullable |   6.925 ns | 0.0298 ns | 0.0264 ns |      - |       0 B |
           ToDouble |   1.997 ns | 0.0031 ns | 0.0029 ns |      - |       0 B |
   ToDoubleNullable |   2.298 ns | 0.0007 ns | 0.0006 ns |      - |       0 B |
          ToDecimal |  65.582 ns | 0.2021 ns | 0.1578 ns |      - |       0 B |
  ToDecimalNullable |  70.687 ns | 0.0442 ns | 0.0369 ns |      - |       0 B |
         ToDateTime |   4.862 ns | 0.0078 ns | 0.0073 ns |      - |       0 B |
 ToDateTimeNullable |   5.890 ns | 0.0049 ns | 0.0043 ns |      - |       0 B |
           ToObject |   4.862 ns | 0.0084 ns | 0.0070 ns | 0.0057 |      24 B |
          To_String | 258.540 ns | 0.2552 ns | 0.2263 ns | 0.0072 |      32 B |
             ToEnum |  29.759 ns | 0.0090 ns | 0.0084 ns | 0.0057 |      24 B |
