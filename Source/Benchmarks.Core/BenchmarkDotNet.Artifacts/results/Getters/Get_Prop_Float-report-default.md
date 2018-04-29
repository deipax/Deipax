
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |-----------:|----------:|----------:|-------:|----------:|
             ToBool |   3.868 ns | 0.0069 ns | 0.0065 ns |      - |       0 B |
     ToBoolNullable |   6.793 ns | 0.0085 ns | 0.0075 ns |      - |       0 B |
             ToChar |   3.567 ns | 0.0045 ns | 0.0040 ns |      - |       0 B |
     ToCharNullable |   6.807 ns | 0.0219 ns | 0.0195 ns |      - |       0 B |
            ToSByte |   7.953 ns | 0.0119 ns | 0.0099 ns |      - |       0 B |
    ToSByteNullable |  10.723 ns | 0.1428 ns | 0.1336 ns |      - |       0 B |
             ToByte |   8.079 ns | 0.0278 ns | 0.0247 ns |      - |       0 B |
     ToByteNullable |  10.938 ns | 0.2847 ns | 0.3703 ns |      - |       0 B |
            ToShort |   8.137 ns | 0.0422 ns | 0.0395 ns |      - |       0 B |
    ToShortNullable |  10.671 ns | 0.1484 ns | 0.1388 ns |      - |       0 B |
           ToUShort |   7.999 ns | 0.0816 ns | 0.0724 ns |      - |       0 B |
   ToUShortNullable |  10.738 ns | 0.0642 ns | 0.0601 ns |      - |       0 B |
              ToInt |   6.059 ns | 0.0391 ns | 0.0347 ns |      - |       0 B |
      ToIntNullable |   8.623 ns | 0.0649 ns | 0.0575 ns |      - |       0 B |
             ToUInt |   6.258 ns | 0.0340 ns | 0.0318 ns |      - |       0 B |
     ToUIntNullable |   8.618 ns | 0.0716 ns | 0.0670 ns |      - |       0 B |
             ToLong |   7.237 ns | 0.0396 ns | 0.0351 ns |      - |       0 B |
     ToLongNullable |  11.336 ns | 0.0818 ns | 0.0725 ns |      - |       0 B |
            ToULong |   6.909 ns | 0.0357 ns | 0.0334 ns |      - |       0 B |
    ToULongNullable |  10.650 ns | 0.0453 ns | 0.0401 ns |      - |       0 B |
            ToFloat |   1.812 ns | 0.0426 ns | 0.0398 ns |      - |       0 B |
    ToFloatNullable |   4.727 ns | 0.0034 ns | 0.0032 ns |      - |       0 B |
           ToDouble |   3.855 ns | 0.0054 ns | 0.0048 ns |      - |       0 B |
   ToDoubleNullable |   5.908 ns | 0.0195 ns | 0.0182 ns |      - |       0 B |
          ToDecimal |  27.622 ns | 0.1060 ns | 0.0992 ns |      - |       0 B |
  ToDecimalNullable |  33.925 ns | 0.0680 ns | 0.0636 ns |      - |       0 B |
         ToDateTime |   5.154 ns | 0.0119 ns | 0.0099 ns |      - |       0 B |
 ToDateTimeNullable |   6.515 ns | 0.0269 ns | 0.0238 ns |      - |       0 B |
           ToObject |   4.589 ns | 0.0104 ns | 0.0092 ns | 0.0057 |      24 B |
          To_String | 225.312 ns | 0.6278 ns | 0.5873 ns | 0.0074 |      32 B |
             ToEnum |  25.503 ns | 0.0674 ns | 0.0630 ns | 0.0057 |      24 B |
