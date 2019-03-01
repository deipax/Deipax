
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   0.8760 ns | 0.0221 ns | 0.0206 ns |           - |           - |           - |                   - |
     ToBoolNullable |   4.5483 ns | 0.0230 ns | 0.0204 ns |           - |           - |           - |                   - |
             ToChar |   0.6800 ns | 0.0112 ns | 0.0104 ns |           - |           - |           - |                   - |
     ToCharNullable |   4.1185 ns | 0.0246 ns | 0.0230 ns |           - |           - |           - |                   - |
            ToSByte |   3.4822 ns | 0.0378 ns | 0.0335 ns |           - |           - |           - |                   - |
    ToSByteNullable |   6.2903 ns | 0.0448 ns | 0.0419 ns |           - |           - |           - |                   - |
             ToByte |   3.1557 ns | 0.0317 ns | 0.0297 ns |           - |           - |           - |                   - |
     ToByteNullable |   6.1968 ns | 0.0461 ns | 0.0431 ns |           - |           - |           - |                   - |
            ToShort |   3.1700 ns | 0.0225 ns | 0.0210 ns |           - |           - |           - |                   - |
    ToShortNullable |   6.3399 ns | 0.0604 ns | 0.0565 ns |           - |           - |           - |                   - |
           ToUShort |   3.5498 ns | 0.0221 ns | 0.0207 ns |           - |           - |           - |                   - |
   ToUShortNullable |   6.2796 ns | 0.0291 ns | 0.0272 ns |           - |           - |           - |                   - |
              ToInt |   1.7579 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
      ToIntNullable |   5.4180 ns | 0.0267 ns | 0.0250 ns |           - |           - |           - |                   - |
             ToUInt |   1.9710 ns | 0.0094 ns | 0.0083 ns |           - |           - |           - |                   - |
     ToUIntNullable |   5.6335 ns | 0.0269 ns | 0.0251 ns |           - |           - |           - |                   - |
             ToLong |   3.2862 ns | 0.0219 ns | 0.0194 ns |           - |           - |           - |                   - |
     ToLongNullable |   4.2690 ns | 0.0299 ns | 0.0279 ns |           - |           - |           - |                   - |
            ToULong |   3.3297 ns | 0.0202 ns | 0.0168 ns |           - |           - |           - |                   - |
    ToULongNullable |   4.4548 ns | 0.0295 ns | 0.0276 ns |           - |           - |           - |                   - |
            ToFloat |   0.8815 ns | 0.0079 ns | 0.0074 ns |           - |           - |           - |                   - |
    ToFloatNullable |   4.1185 ns | 0.0213 ns | 0.0189 ns |           - |           - |           - |                   - |
           ToDouble |   0.6743 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.6817 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
          ToDecimal |  51.3773 ns | 0.2469 ns | 0.2309 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  61.1510 ns | 0.3092 ns | 0.2892 ns |           - |           - |           - |                   - |
         ToDateTime |   1.0579 ns | 0.0093 ns | 0.0082 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   7.5105 ns | 0.0444 ns | 0.0394 ns |           - |           - |           - |                   - |
           ToObject |   2.7140 ns | 0.0245 ns | 0.0217 ns |      0.0038 |           - |           - |                24 B |
          To_String | 275.9552 ns | 1.0434 ns | 0.9760 ns |      0.0048 |           - |           - |                32 B |
             ToEnum |  13.6132 ns | 0.0607 ns | 0.0568 ns |           - |           - |           - |                   - |
     ToEnumNullable |  18.0115 ns | 0.0603 ns | 0.0564 ns |           - |           - |           - |                   - |
