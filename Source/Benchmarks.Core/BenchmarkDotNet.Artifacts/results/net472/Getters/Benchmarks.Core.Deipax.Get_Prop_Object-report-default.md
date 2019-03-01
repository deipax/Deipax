
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  3.2900 ns | 0.0478 ns | 0.0447 ns |           - |           - |           - |                   - |
     ToBoolNullable |  6.3243 ns | 0.0538 ns | 0.0503 ns |           - |           - |           - |                   - |
             ToChar |  3.2566 ns | 0.0293 ns | 0.0274 ns |           - |           - |           - |                   - |
     ToCharNullable |  6.3387 ns | 0.0564 ns | 0.0527 ns |           - |           - |           - |                   - |
            ToSByte |  3.2835 ns | 0.0326 ns | 0.0305 ns |           - |           - |           - |                   - |
    ToSByteNullable |  6.2979 ns | 0.0472 ns | 0.0442 ns |           - |           - |           - |                   - |
             ToByte |  3.2666 ns | 0.0203 ns | 0.0180 ns |           - |           - |           - |                   - |
     ToByteNullable |  6.2962 ns | 0.0387 ns | 0.0362 ns |           - |           - |           - |                   - |
            ToShort |  3.2755 ns | 0.0375 ns | 0.0351 ns |           - |           - |           - |                   - |
    ToShortNullable |  6.3372 ns | 0.0509 ns | 0.0476 ns |           - |           - |           - |                   - |
           ToUShort |  3.2635 ns | 0.0338 ns | 0.0316 ns |           - |           - |           - |                   - |
   ToUShortNullable |  6.2923 ns | 0.0447 ns | 0.0396 ns |           - |           - |           - |                   - |
              ToInt |  3.3010 ns | 0.0271 ns | 0.0254 ns |           - |           - |           - |                   - |
      ToIntNullable |  6.2860 ns | 0.0323 ns | 0.0302 ns |           - |           - |           - |                   - |
             ToUInt |  3.3168 ns | 0.0280 ns | 0.0262 ns |           - |           - |           - |                   - |
     ToUIntNullable |  6.3173 ns | 0.0473 ns | 0.0442 ns |           - |           - |           - |                   - |
             ToLong |  3.1822 ns | 0.0194 ns | 0.0182 ns |           - |           - |           - |                   - |
     ToLongNullable |  4.8493 ns | 0.0294 ns | 0.0275 ns |           - |           - |           - |                   - |
            ToULong |  3.1966 ns | 0.0310 ns | 0.0290 ns |           - |           - |           - |                   - |
    ToULongNullable |  4.8770 ns | 0.0288 ns | 0.0270 ns |           - |           - |           - |                   - |
            ToFloat |  3.0158 ns | 0.0152 ns | 0.0135 ns |           - |           - |           - |                   - |
    ToFloatNullable |  6.5464 ns | 0.0411 ns | 0.0385 ns |           - |           - |           - |                   - |
           ToDouble |  3.3492 ns | 0.0349 ns | 0.0309 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  4.7855 ns | 0.0507 ns | 0.0474 ns |           - |           - |           - |                   - |
          ToDecimal |  7.5689 ns | 0.0425 ns | 0.0397 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 10.6903 ns | 0.0559 ns | 0.0495 ns |           - |           - |           - |                   - |
         ToDateTime |  3.6665 ns | 0.0263 ns | 0.0246 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 18.0106 ns | 0.0716 ns | 0.0670 ns |           - |           - |           - |                   - |
           ToObject |  0.7385 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
          To_String | 13.7820 ns | 0.0648 ns | 0.0606 ns |           - |           - |           - |                   - |
             ToEnum | 19.8215 ns | 0.1402 ns | 0.1243 ns |           - |           - |           - |                   - |
     ToEnumNullable | 20.9127 ns | 0.1584 ns | 0.1482 ns |           - |           - |           - |                   - |
