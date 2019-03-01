
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.103 ns | 0.0176 ns | 0.0165 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.550 ns | 0.0231 ns | 0.0193 ns |           - |           - |           - |                   - |
             ToChar |  2.399 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.977 ns | 0.0373 ns | 0.0349 ns |           - |           - |           - |                   - |
            ToSByte |  5.526 ns | 0.0294 ns | 0.0275 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.972 ns | 0.0225 ns | 0.0210 ns |           - |           - |           - |                   - |
             ToByte |  2.398 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.994 ns | 0.0240 ns | 0.0213 ns |           - |           - |           - |                   - |
            ToShort |  2.160 ns | 0.0097 ns | 0.0086 ns |           - |           - |           - |                   - |
    ToShortNullable |  5.022 ns | 0.0255 ns | 0.0226 ns |           - |           - |           - |                   - |
           ToUShort |  2.408 ns | 0.0186 ns | 0.0174 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.961 ns | 0.0199 ns | 0.0176 ns |           - |           - |           - |                   - |
              ToInt |  2.201 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.771 ns | 0.0271 ns | 0.0240 ns |           - |           - |           - |                   - |
             ToUInt |  1.767 ns | 0.0236 ns | 0.0221 ns |           - |           - |           - |                   - |
     ToUIntNullable |  1.057 ns | 0.0118 ns | 0.0111 ns |           - |           - |           - |                   - |
             ToLong |  1.333 ns | 0.0109 ns | 0.0096 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.978 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
            ToULong |  1.302 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.125 ns | 0.0173 ns | 0.0162 ns |           - |           - |           - |                   - |
            ToFloat |  1.113 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.755 ns | 0.0182 ns | 0.0162 ns |           - |           - |           - |                   - |
           ToDouble |  1.100 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.404 ns | 0.0261 ns | 0.0244 ns |           - |           - |           - |                   - |
          ToDecimal |  5.875 ns | 0.0254 ns | 0.0212 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.597 ns | 0.0947 ns | 0.0886 ns |           - |           - |           - |                   - |
         ToDateTime |  1.043 ns | 0.0080 ns | 0.0075 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.703 ns | 0.0472 ns | 0.0441 ns |           - |           - |           - |                   - |
           ToObject |  4.027 ns | 0.0237 ns | 0.0221 ns |      0.0038 |           - |           - |                24 B |
          To_String | 29.842 ns | 0.2128 ns | 0.1990 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 14.685 ns | 0.0843 ns | 0.0788 ns |           - |           - |           - |                   - |
     ToEnumNullable | 18.770 ns | 0.0932 ns | 0.0872 ns |           - |           - |           - |                   - |
