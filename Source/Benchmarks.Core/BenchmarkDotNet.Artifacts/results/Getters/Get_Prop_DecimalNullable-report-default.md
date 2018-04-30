
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435893 Hz, Resolution=291.0452 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool | 16.147 ns | 0.2204 ns | 0.2062 ns |      - |       0 B |
     ToBoolNullable | 20.383 ns | 0.0432 ns | 0.0383 ns |      - |       0 B |
             ToChar |  3.810 ns | 0.0780 ns | 0.0730 ns |      - |       0 B |
     ToCharNullable |  7.251 ns | 0.0245 ns | 0.0217 ns |      - |       0 B |
            ToSByte | 25.448 ns | 0.3265 ns | 0.2894 ns |      - |       0 B |
    ToSByteNullable | 29.345 ns | 0.0327 ns | 0.0273 ns |      - |       0 B |
             ToByte | 22.998 ns | 0.2001 ns | 0.1872 ns |      - |       0 B |
     ToByteNullable | 26.720 ns | 0.0372 ns | 0.0311 ns |      - |       0 B |
            ToShort | 22.990 ns | 0.0255 ns | 0.0199 ns |      - |       0 B |
    ToShortNullable | 27.231 ns | 0.0137 ns | 0.0107 ns |      - |       0 B |
           ToUShort | 22.931 ns | 0.0265 ns | 0.0248 ns |      - |       0 B |
   ToUShortNullable | 29.298 ns | 0.1686 ns | 0.1577 ns |      - |       0 B |
              ToInt | 22.283 ns | 0.1288 ns | 0.1141 ns |      - |       0 B |
      ToIntNullable | 28.256 ns | 0.0851 ns | 0.0796 ns |      - |       0 B |
             ToUInt | 21.977 ns | 0.1306 ns | 0.1158 ns |      - |       0 B |
     ToUIntNullable | 27.814 ns | 0.1299 ns | 0.1085 ns |      - |       0 B |
             ToLong | 22.101 ns | 0.0205 ns | 0.0181 ns |      - |       0 B |
     ToLongNullable | 23.625 ns | 0.0173 ns | 0.0153 ns |      - |       0 B |
            ToULong | 22.301 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
    ToULongNullable | 23.352 ns | 0.0156 ns | 0.0138 ns |      - |       0 B |
            ToFloat | 23.236 ns | 0.0017 ns | 0.0014 ns |      - |       0 B |
    ToFloatNullable | 27.244 ns | 0.0144 ns | 0.0120 ns |      - |       0 B |
           ToDouble | 22.024 ns | 0.0057 ns | 0.0051 ns |      - |       0 B |
   ToDoubleNullable | 21.821 ns | 0.2744 ns | 0.2432 ns |      - |       0 B |
          ToDecimal |  2.814 ns | 0.0046 ns | 0.0043 ns |      - |       0 B |
  ToDecimalNullable |  2.557 ns | 0.0017 ns | 0.0015 ns |      - |       0 B |
         ToDateTime |  5.124 ns | 0.0050 ns | 0.0047 ns |      - |       0 B |
 ToDateTimeNullable |  6.635 ns | 0.0507 ns | 0.0474 ns |      - |       0 B |
           ToObject |  5.320 ns | 0.0103 ns | 0.0091 ns | 0.0076 |      32 B |
          To_String | 77.090 ns | 0.1335 ns | 0.1249 ns | 0.0075 |      32 B |
             ToEnum | 44.677 ns | 0.0195 ns | 0.0172 ns | 0.0076 |      32 B |
