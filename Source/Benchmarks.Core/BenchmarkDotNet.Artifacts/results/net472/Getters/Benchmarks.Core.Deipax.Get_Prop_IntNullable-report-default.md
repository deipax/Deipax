
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.121 ns | 0.0179 ns | 0.0168 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.548 ns | 0.0260 ns | 0.0243 ns |           - |           - |           - |                   - |
             ToChar |  2.256 ns | 0.0469 ns | 0.0416 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.011 ns | 0.0355 ns | 0.0332 ns |           - |           - |           - |                   - |
            ToSByte |  2.191 ns | 0.0182 ns | 0.0171 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.016 ns | 0.0395 ns | 0.0370 ns |           - |           - |           - |                   - |
             ToByte |  2.196 ns | 0.0158 ns | 0.0148 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.002 ns | 0.0357 ns | 0.0316 ns |           - |           - |           - |                   - |
            ToShort |  2.189 ns | 0.0178 ns | 0.0167 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.974 ns | 0.0233 ns | 0.0206 ns |           - |           - |           - |                   - |
           ToUShort |  2.423 ns | 0.0221 ns | 0.0207 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.998 ns | 0.0340 ns | 0.0318 ns |           - |           - |           - |                   - |
              ToInt |  1.760 ns | 0.0111 ns | 0.0103 ns |           - |           - |           - |                   - |
      ToIntNullable |  1.079 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
             ToUInt |  2.178 ns | 0.0065 ns | 0.0058 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.795 ns | 0.0352 ns | 0.0329 ns |           - |           - |           - |                   - |
             ToLong |  1.334 ns | 0.0116 ns | 0.0103 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.970 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
            ToULong |  1.980 ns | 0.0169 ns | 0.0159 ns |           - |           - |           - |                   - |
    ToULongNullable |  3.007 ns | 0.0221 ns | 0.0207 ns |           - |           - |           - |                   - |
            ToFloat |  1.332 ns | 0.0160 ns | 0.0149 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.765 ns | 0.0279 ns | 0.0261 ns |           - |           - |           - |                   - |
           ToDouble |  1.102 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.387 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
          ToDecimal |  5.883 ns | 0.0420 ns | 0.0393 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.973 ns | 0.1242 ns | 0.1161 ns |           - |           - |           - |                   - |
         ToDateTime |  1.064 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.113 ns | 0.0490 ns | 0.0435 ns |           - |           - |           - |                   - |
           ToObject |  3.549 ns | 0.0244 ns | 0.0228 ns |      0.0038 |           - |           - |                24 B |
          To_String | 30.874 ns | 0.1374 ns | 0.1285 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 14.620 ns | 0.0826 ns | 0.0732 ns |           - |           - |           - |                   - |
     ToEnumNullable | 18.358 ns | 0.0767 ns | 0.0717 ns |           - |           - |           - |                   - |
