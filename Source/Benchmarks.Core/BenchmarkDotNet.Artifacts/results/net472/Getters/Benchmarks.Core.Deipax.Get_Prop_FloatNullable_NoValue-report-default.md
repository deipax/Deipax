
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.6453 ns | 0.0218 ns | 0.0204 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.1398 ns | 0.0213 ns | 0.0189 ns |           - |           - |           - |                   - |
             ToChar |  0.6138 ns | 0.0089 ns | 0.0084 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1558 ns | 0.0322 ns | 0.0301 ns |           - |           - |           - |                   - |
            ToSByte |  0.8365 ns | 0.0097 ns | 0.0086 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.3587 ns | 0.0286 ns | 0.0267 ns |           - |           - |           - |                   - |
             ToByte |  0.6797 ns | 0.0075 ns | 0.0067 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.3288 ns | 0.0269 ns | 0.0239 ns |           - |           - |           - |                   - |
            ToShort |  0.6521 ns | 0.0159 ns | 0.0149 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.3422 ns | 0.0251 ns | 0.0235 ns |           - |           - |           - |                   - |
           ToUShort |  0.6423 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.3496 ns | 0.0233 ns | 0.0218 ns |           - |           - |           - |                   - |
              ToInt |  0.8455 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.3379 ns | 0.0293 ns | 0.0274 ns |           - |           - |           - |                   - |
             ToUInt |  0.8393 ns | 0.0096 ns | 0.0089 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.3439 ns | 0.0272 ns | 0.0254 ns |           - |           - |           - |                   - |
             ToLong |  0.8407 ns | 0.0104 ns | 0.0097 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.9735 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
            ToULong |  0.6573 ns | 0.0098 ns | 0.0087 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.9751 ns | 0.0091 ns | 0.0081 ns |           - |           - |           - |                   - |
            ToFloat |  0.9115 ns | 0.0097 ns | 0.0091 ns |           - |           - |           - |                   - |
    ToFloatNullable |  0.8998 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
           ToDouble |  0.8453 ns | 0.0177 ns | 0.0165 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.9925 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6519 ns | 0.0203 ns | 0.0180 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.5368 ns | 0.0427 ns | 0.0378 ns |           - |           - |           - |                   - |
         ToDateTime |  1.4095 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.9815 ns | 0.0573 ns | 0.0508 ns |           - |           - |           - |                   - |
           ToObject |  0.9113 ns | 0.0164 ns | 0.0153 ns |           - |           - |           - |                   - |
          To_String |  1.1217 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
             ToEnum |  1.1234 ns | 0.0096 ns | 0.0085 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.5732 ns | 0.0262 ns | 0.0245 ns |           - |           - |           - |                   - |
