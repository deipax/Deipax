
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool |  2.124 ns | 0.0291 ns | 0.0243 ns |      - |       0 B |
     ToBoolNullable |  4.766 ns | 0.0132 ns | 0.0111 ns |      - |       0 B |
             ToChar |  3.872 ns | 0.0213 ns | 0.0178 ns |      - |       0 B |
     ToCharNullable |  6.192 ns | 0.1358 ns | 0.1204 ns |      - |       0 B |
            ToSByte |  3.583 ns | 0.0101 ns | 0.0090 ns |      - |       0 B |
    ToSByteNullable |  6.145 ns | 0.1280 ns | 0.1134 ns |      - |       0 B |
             ToByte |  3.835 ns | 0.0292 ns | 0.0228 ns |      - |       0 B |
     ToByteNullable |  6.104 ns | 0.0420 ns | 0.0393 ns |      - |       0 B |
            ToShort |  3.844 ns | 0.0237 ns | 0.0198 ns |      - |       0 B |
    ToShortNullable |  6.077 ns | 0.0437 ns | 0.0341 ns |      - |       0 B |
           ToUShort |  3.951 ns | 0.1055 ns | 0.0987 ns |      - |       0 B |
   ToUShortNullable |  6.203 ns | 0.1563 ns | 0.1535 ns |      - |       0 B |
              ToInt |  2.075 ns | 0.0605 ns | 0.0566 ns |      - |       0 B |
      ToIntNullable |  4.818 ns | 0.0200 ns | 0.0167 ns |      - |       0 B |
             ToUInt |  2.598 ns | 0.0111 ns | 0.0098 ns |      - |       0 B |
     ToUIntNullable |  5.352 ns | 0.1002 ns | 0.0937 ns |      - |       0 B |
             ToLong |  2.064 ns | 0.0114 ns | 0.0101 ns |      - |       0 B |
     ToLongNullable |  3.394 ns | 0.1064 ns | 0.0995 ns |      - |       0 B |
            ToULong |  2.573 ns | 0.0234 ns | 0.0207 ns |      - |       0 B |
    ToULongNullable |  3.891 ns | 0.0639 ns | 0.0567 ns |      - |       0 B |
            ToFloat |  2.049 ns | 0.0052 ns | 0.0046 ns |      - |       0 B |
    ToFloatNullable |  4.939 ns | 0.0636 ns | 0.0563 ns |      - |       0 B |
           ToDouble |  2.077 ns | 0.0234 ns | 0.0219 ns |      - |       0 B |
   ToDoubleNullable |  3.441 ns | 0.1020 ns | 0.0904 ns |      - |       0 B |
          ToDecimal |  6.796 ns | 0.0117 ns | 0.0104 ns |      - |       0 B |
  ToDecimalNullable | 18.953 ns | 0.1508 ns | 0.1337 ns |      - |       0 B |
         ToDateTime |  2.575 ns | 0.0097 ns | 0.0086 ns |      - |       0 B |
 ToDateTimeNullable |  8.692 ns | 0.0953 ns | 0.0796 ns |      - |       0 B |
           ToObject |  5.079 ns | 0.0346 ns | 0.0323 ns | 0.0057 |      24 B |
          To_String | 72.580 ns | 1.0728 ns | 1.0035 ns | 0.0057 |      24 B |
             ToEnum |  2.174 ns | 0.0438 ns | 0.0409 ns |      - |       0 B |
     ToEnumNullable |  1.300 ns | 0.0504 ns | 0.0471 ns |      - |       0 B |
