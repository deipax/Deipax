
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   3.791 ns | 0.0144 ns | 0.0128 ns |      - |       0 B |
     ToBoolNullable |   6.840 ns | 0.0863 ns | 0.0721 ns |      - |       0 B |
             ToChar |   2.987 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
     ToCharNullable |   6.516 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
            ToSByte |   7.039 ns | 0.0047 ns | 0.0037 ns |      - |       0 B |
    ToSByteNullable |   9.070 ns | 0.0067 ns | 0.0056 ns |      - |       0 B |
             ToByte |   7.067 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
     ToByteNullable |   9.089 ns | 0.0300 ns | 0.0281 ns |      - |       0 B |
            ToShort |   7.134 ns | 0.0077 ns | 0.0072 ns |      - |       0 B |
    ToShortNullable |   9.074 ns | 0.0032 ns | 0.0025 ns |      - |       0 B |
           ToUShort |   7.132 ns | 0.0954 ns | 0.0892 ns |      - |       0 B |
   ToUShortNullable |   9.240 ns | 0.1103 ns | 0.0978 ns |      - |       0 B |
              ToInt |   5.350 ns | 0.0709 ns | 0.0592 ns |      - |       0 B |
      ToIntNullable |   8.368 ns | 0.0588 ns | 0.0550 ns |      - |       0 B |
             ToUInt |   5.455 ns | 0.0753 ns | 0.0667 ns |      - |       0 B |
     ToUIntNullable |   8.198 ns | 0.1126 ns | 0.0998 ns |      - |       0 B |
             ToLong |   6.432 ns | 0.0784 ns | 0.0733 ns |      - |       0 B |
     ToLongNullable |   9.618 ns | 0.2172 ns | 0.2502 ns |      - |       0 B |
            ToULong |   6.124 ns | 0.1981 ns | 0.1853 ns |      - |       0 B |
    ToULongNullable |   9.587 ns | 0.1610 ns | 0.1428 ns |      - |       0 B |
            ToFloat |   3.029 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
    ToFloatNullable |   6.527 ns | 0.0179 ns | 0.0167 ns |      - |       0 B |
           ToDouble |   1.283 ns | 0.0145 ns | 0.0136 ns |      - |       0 B |
   ToDoubleNullable |   2.561 ns | 0.0074 ns | 0.0065 ns |      - |       0 B |
          ToDecimal |  64.466 ns | 0.1344 ns | 0.1192 ns |      - |       0 B |
  ToDecimalNullable |  70.347 ns | 0.0497 ns | 0.0465 ns |      - |       0 B |
         ToDateTime |   4.691 ns | 0.1049 ns | 0.0981 ns |      - |       0 B |
 ToDateTimeNullable |   6.356 ns | 0.1675 ns | 0.1720 ns |      - |       0 B |
           ToObject |   3.842 ns | 0.0222 ns | 0.0196 ns | 0.0057 |      24 B |
          To_String | 259.177 ns | 1.3316 ns | 1.2455 ns | 0.0072 |      32 B |
             ToEnum |  24.612 ns | 0.1079 ns | 0.1009 ns | 0.0057 |      24 B |
