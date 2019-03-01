
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.172 ns | 0.0040 ns | 0.0037 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.590 ns | 0.0048 ns | 0.0043 ns |           - |           - |           - |                   - |
             ToChar |  1.169 ns | 0.0024 ns | 0.0023 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.603 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
            ToSByte |  2.054 ns | 0.0019 ns | 0.0016 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.281 ns | 0.0091 ns | 0.0086 ns |           - |           - |           - |                   - |
             ToByte |  2.250 ns | 0.0029 ns | 0.0026 ns |           - |           - |           - |                   - |
     ToByteNullable |  1.170 ns | 0.0030 ns | 0.0026 ns |           - |           - |           - |                   - |
            ToShort |  1.406 ns | 0.0240 ns | 0.0224 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.641 ns | 0.0185 ns | 0.0164 ns |           - |           - |           - |                   - |
           ToUShort |  1.414 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.627 ns | 0.0057 ns | 0.0045 ns |           - |           - |           - |                   - |
              ToInt |  1.143 ns | 0.0051 ns | 0.0045 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.401 ns | 0.0220 ns | 0.0195 ns |           - |           - |           - |                   - |
             ToUInt |  1.404 ns | 0.0255 ns | 0.0239 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.407 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
             ToLong |  1.405 ns | 0.0137 ns | 0.0122 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.882 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
            ToULong |  1.176 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.434 ns | 0.0087 ns | 0.0073 ns |           - |           - |           - |                   - |
            ToFloat |  1.389 ns | 0.0107 ns | 0.0095 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.855 ns | 0.0102 ns | 0.0091 ns |           - |           - |           - |                   - |
           ToDouble |  1.143 ns | 0.0058 ns | 0.0052 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.663 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
          ToDecimal |  6.518 ns | 0.0360 ns | 0.0336 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.256 ns | 0.0541 ns | 0.0480 ns |           - |           - |           - |                   - |
         ToDateTime |  1.394 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.295 ns | 0.0686 ns | 0.0641 ns |           - |           - |           - |                   - |
           ToObject |  3.640 ns | 0.0436 ns | 0.0408 ns |      0.0038 |           - |           - |                24 B |
          To_String | 33.818 ns | 0.0974 ns | 0.0813 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 14.980 ns | 0.1609 ns | 0.1505 ns |           - |           - |           - |                   - |
     ToEnumNullable | 19.490 ns | 0.0313 ns | 0.0262 ns |           - |           - |           - |                   - |
