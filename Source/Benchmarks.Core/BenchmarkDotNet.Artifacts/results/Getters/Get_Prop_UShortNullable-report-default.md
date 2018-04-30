
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  3.740 ns | 0.1268 ns | 0.1357 ns |      - |       0 B |
     ToBoolNullable |  6.851 ns | 0.1293 ns | 0.1146 ns |      - |       0 B |
             ToChar |  3.620 ns | 0.0181 ns | 0.0160 ns |      - |       0 B |
     ToCharNullable |  6.527 ns | 0.0158 ns | 0.0148 ns |      - |       0 B |
            ToSByte |  4.154 ns | 0.0385 ns | 0.0321 ns |      - |       0 B |
    ToSByteNullable |  6.784 ns | 0.0112 ns | 0.0093 ns |      - |       0 B |
             ToByte |  4.342 ns | 0.0559 ns | 0.0467 ns |      - |       0 B |
     ToByteNullable |  6.805 ns | 0.0498 ns | 0.0466 ns |      - |       0 B |
            ToShort |  4.168 ns | 0.0505 ns | 0.0473 ns |      - |       0 B |
    ToShortNullable |  6.861 ns | 0.1057 ns | 0.0988 ns |      - |       0 B |
           ToUShort |  2.090 ns | 0.0174 ns | 0.0155 ns |      - |       0 B |
   ToUShortNullable |  1.266 ns | 0.0036 ns | 0.0028 ns |      - |       0 B |
              ToInt |  3.858 ns | 0.0134 ns | 0.0119 ns |      - |       0 B |
      ToIntNullable |  6.523 ns | 0.0039 ns | 0.0035 ns |      - |       0 B |
             ToUInt |  3.873 ns | 0.0037 ns | 0.0031 ns |      - |       0 B |
     ToUIntNullable |  6.529 ns | 0.0116 ns | 0.0109 ns |      - |       0 B |
             ToLong |  4.045 ns | 0.0161 ns | 0.0151 ns |      - |       0 B |
     ToLongNullable |  6.686 ns | 0.0102 ns | 0.0095 ns |      - |       0 B |
            ToULong |  3.830 ns | 0.0019 ns | 0.0015 ns |      - |       0 B |
    ToULongNullable |  6.656 ns | 0.0026 ns | 0.0022 ns |      - |       0 B |
            ToFloat |  3.833 ns | 0.0039 ns | 0.0035 ns |      - |       0 B |
    ToFloatNullable |  6.807 ns | 0.0030 ns | 0.0025 ns |      - |       0 B |
           ToDouble |  3.832 ns | 0.0055 ns | 0.0049 ns |      - |       0 B |
   ToDoubleNullable |  6.722 ns | 0.0409 ns | 0.0383 ns |      - |       0 B |
          ToDecimal |  7.418 ns | 0.0095 ns | 0.0085 ns |      - |       0 B |
  ToDecimalNullable | 16.563 ns | 0.0115 ns | 0.0096 ns |      - |       0 B |
         ToDateTime |  4.610 ns | 0.0055 ns | 0.0052 ns |      - |       0 B |
 ToDateTimeNullable |  6.411 ns | 0.0022 ns | 0.0018 ns |      - |       0 B |
           ToObject |  4.898 ns | 0.0031 ns | 0.0024 ns | 0.0057 |      24 B |
          To_String | 40.622 ns | 0.0367 ns | 0.0326 ns | 0.0076 |      32 B |
             ToEnum | 26.564 ns | 0.0797 ns | 0.0666 ns | 0.0057 |      24 B |
