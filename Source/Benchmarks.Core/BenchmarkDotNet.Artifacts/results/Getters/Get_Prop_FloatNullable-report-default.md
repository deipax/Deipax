
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   4.053 ns | 0.0015 ns | 0.0013 ns |      - |       0 B |
     ToBoolNullable |   7.032 ns | 0.0124 ns | 0.0110 ns |      - |       0 B |
             ToChar |   2.964 ns | 0.0910 ns | 0.0851 ns |      - |       0 B |
     ToCharNullable |   6.529 ns | 0.0198 ns | 0.0176 ns |      - |       0 B |
            ToSByte |   7.842 ns | 0.0659 ns | 0.0616 ns |      - |       0 B |
    ToSByteNullable |   9.733 ns | 0.1363 ns | 0.1208 ns |      - |       0 B |
             ToByte |   8.154 ns | 0.0066 ns | 0.0055 ns |      - |       0 B |
     ToByteNullable |   9.729 ns | 0.1231 ns | 0.1091 ns |      - |       0 B |
            ToShort |   7.884 ns | 0.1518 ns | 0.1267 ns |      - |       0 B |
    ToShortNullable |   9.671 ns | 0.0135 ns | 0.0105 ns |      - |       0 B |
           ToUShort |   7.783 ns | 0.0693 ns | 0.0614 ns |      - |       0 B |
   ToUShortNullable |   9.593 ns | 0.0161 ns | 0.0125 ns |      - |       0 B |
              ToInt |   7.030 ns | 0.0445 ns | 0.0394 ns |      - |       0 B |
      ToIntNullable |   9.361 ns | 0.0469 ns | 0.0415 ns |      - |       0 B |
             ToUInt |   6.809 ns | 0.0107 ns | 0.0100 ns |      - |       0 B |
     ToUIntNullable |   8.579 ns | 0.0059 ns | 0.0052 ns |      - |       0 B |
             ToLong |   7.165 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
     ToLongNullable |  10.755 ns | 0.0345 ns | 0.0322 ns |      - |       0 B |
            ToULong |   6.647 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
    ToULongNullable |  11.023 ns | 0.0365 ns | 0.0324 ns |      - |       0 B |
            ToFloat |   2.098 ns | 0.0003 ns | 0.0003 ns |      - |       0 B |
    ToFloatNullable |   1.537 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
           ToDouble |   4.014 ns | 0.0010 ns | 0.0008 ns |      - |       0 B |
   ToDoubleNullable |   6.943 ns | 0.0255 ns | 0.0239 ns |      - |       0 B |
          ToDecimal |  27.469 ns | 0.0075 ns | 0.0063 ns |      - |       0 B |
  ToDecimalNullable |  33.592 ns | 0.0102 ns | 0.0091 ns |      - |       0 B |
         ToDateTime |   4.599 ns | 0.0019 ns | 0.0016 ns |      - |       0 B |
 ToDateTimeNullable |   6.167 ns | 0.0149 ns | 0.0140 ns |      - |       0 B |
           ToObject |   4.850 ns | 0.0058 ns | 0.0054 ns | 0.0057 |      24 B |
          To_String | 222.070 ns | 0.2800 ns | 0.2482 ns | 0.0074 |      32 B |
             ToEnum |  29.381 ns | 0.0875 ns | 0.0818 ns | 0.0057 |      24 B |
