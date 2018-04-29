
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435884 Hz, Resolution=291.0459 ns, Timer=TSC
.NET Core SDK=2.1.103
  [Host]     : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT


             Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
------------------- |----------:|----------:|----------:|-------:|----------:|
             ToBool | 14.873 ns | 0.1167 ns | 0.0975 ns |      - |       0 B |
     ToBoolNullable | 20.174 ns | 0.0197 ns | 0.0184 ns |      - |       0 B |
             ToChar |  4.380 ns | 0.0083 ns | 0.0078 ns |      - |       0 B |
     ToCharNullable |  7.046 ns | 0.0168 ns | 0.0157 ns |      - |       0 B |
            ToSByte | 25.232 ns | 0.0212 ns | 0.0198 ns |      - |       0 B |
    ToSByteNullable | 27.286 ns | 0.0455 ns | 0.0425 ns |      - |       0 B |
             ToByte | 24.680 ns | 0.0464 ns | 0.0434 ns |      - |       0 B |
     ToByteNullable | 27.014 ns | 0.0496 ns | 0.0440 ns |      - |       0 B |
            ToShort | 23.246 ns | 0.0398 ns | 0.0372 ns |      - |       0 B |
    ToShortNullable | 29.188 ns | 0.0406 ns | 0.0380 ns |      - |       0 B |
           ToUShort | 22.998 ns | 0.0575 ns | 0.0538 ns |      - |       0 B |
   ToUShortNullable | 28.979 ns | 0.0545 ns | 0.0483 ns |      - |       0 B |
              ToInt | 24.471 ns | 0.0344 ns | 0.0321 ns |      - |       0 B |
      ToIntNullable | 26.220 ns | 0.0278 ns | 0.0260 ns |      - |       0 B |
             ToUInt | 24.190 ns | 0.0178 ns | 0.0157 ns |      - |       0 B |
     ToUIntNullable | 27.756 ns | 0.0314 ns | 0.0293 ns |      - |       0 B |
             ToLong | 24.393 ns | 0.0302 ns | 0.0282 ns |      - |       0 B |
     ToLongNullable | 23.932 ns | 0.0455 ns | 0.0426 ns |      - |       0 B |
            ToULong | 22.447 ns | 0.0283 ns | 0.0265 ns |      - |       0 B |
    ToULongNullable | 23.870 ns | 0.0481 ns | 0.0450 ns |      - |       0 B |
            ToFloat | 23.478 ns | 0.0129 ns | 0.0121 ns |      - |       0 B |
    ToFloatNullable | 28.985 ns | 0.0272 ns | 0.0255 ns |      - |       0 B |
           ToDouble | 20.038 ns | 0.0178 ns | 0.0167 ns |      - |       0 B |
   ToDoubleNullable | 21.710 ns | 0.0511 ns | 0.0478 ns |      - |       0 B |
          ToDecimal |  4.346 ns | 0.0090 ns | 0.0084 ns |      - |       0 B |
  ToDecimalNullable |  3.581 ns | 0.0081 ns | 0.0072 ns |      - |       0 B |
         ToDateTime |  6.142 ns | 0.0159 ns | 0.0149 ns |      - |       0 B |
 ToDateTimeNullable |  6.930 ns | 0.0328 ns | 0.0307 ns |      - |       0 B |
           ToObject |  5.617 ns | 0.0061 ns | 0.0048 ns | 0.0076 |      32 B |
          To_String | 80.530 ns | 0.2127 ns | 0.1989 ns | 0.0075 |      32 B |
             ToEnum | 44.630 ns | 0.0334 ns | 0.0260 ns | 0.0075 |      32 B |
