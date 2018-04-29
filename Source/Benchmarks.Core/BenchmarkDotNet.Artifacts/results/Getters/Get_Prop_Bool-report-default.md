
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435883 Hz, Resolution=291.0460 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  1.795 ns | 0.0015 ns | 0.0012 ns |      - |       0 B |
     ToBoolNullable |  4.712 ns | 0.0047 ns | 0.0041 ns |      - |       0 B |
             ToChar |  3.853 ns | 0.0043 ns | 0.0038 ns |      - |       0 B |
     ToCharNullable |  6.818 ns | 0.0522 ns | 0.0436 ns |      - |       0 B |
            ToSByte |  4.364 ns | 0.0054 ns | 0.0051 ns |      - |       0 B |
    ToSByteNullable |  6.811 ns | 0.0462 ns | 0.0386 ns |      - |       0 B |
             ToByte |  4.521 ns | 0.1212 ns | 0.1488 ns |      - |       0 B |
     ToByteNullable |  6.777 ns | 0.0083 ns | 0.0077 ns |      - |       0 B |
            ToShort |  4.361 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
    ToShortNullable |  6.777 ns | 0.0113 ns | 0.0100 ns |      - |       0 B |
           ToUShort |  4.363 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
   ToUShortNullable |  6.775 ns | 0.0099 ns | 0.0088 ns |      - |       0 B |
              ToInt |  4.363 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
      ToIntNullable |  6.773 ns | 0.0062 ns | 0.0055 ns |      - |       0 B |
             ToUInt |  4.345 ns | 0.0061 ns | 0.0057 ns |      - |       0 B |
     ToUIntNullable |  6.777 ns | 0.0109 ns | 0.0096 ns |      - |       0 B |
             ToLong |  4.786 ns | 0.0042 ns | 0.0037 ns |      - |       0 B |
     ToLongNullable |  6.923 ns | 0.0255 ns | 0.0199 ns |      - |       0 B |
            ToULong |  4.350 ns | 0.0062 ns | 0.0051 ns |      - |       0 B |
    ToULongNullable |  6.910 ns | 0.0126 ns | 0.0117 ns |      - |       0 B |
            ToFloat |  4.635 ns | 0.0282 ns | 0.0250 ns |      - |       0 B |
    ToFloatNullable |  6.775 ns | 0.0084 ns | 0.0079 ns |      - |       0 B |
           ToDouble |  4.633 ns | 0.0331 ns | 0.0293 ns |      - |       0 B |
   ToDoubleNullable |  7.155 ns | 0.0029 ns | 0.0025 ns |      - |       0 B |
          ToDecimal |  8.227 ns | 0.0469 ns | 0.0416 ns |      - |       0 B |
  ToDecimalNullable | 16.216 ns | 0.0025 ns | 0.0021 ns |      - |       0 B |
         ToDateTime |  5.370 ns | 0.0087 ns | 0.0072 ns |      - |       0 B |
 ToDateTimeNullable |  6.647 ns | 0.0068 ns | 0.0057 ns |      - |       0 B |
           ToObject |  4.511 ns | 0.0028 ns | 0.0024 ns | 0.0057 |      24 B |
          To_String |  6.388 ns | 0.0020 ns | 0.0016 ns |      - |       0 B |
             ToEnum | 23.785 ns | 0.0726 ns | 0.0644 ns | 0.0057 |      24 B |
