
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   1.0620 ns | 0.0164 ns | 0.0154 ns |           - |           - |           - |                   - |
     ToBoolNullable |   4.7611 ns | 0.0109 ns | 0.0091 ns |           - |           - |           - |                   - |
             ToChar |   0.6222 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
     ToCharNullable |   4.1655 ns | 0.0285 ns | 0.0266 ns |           - |           - |           - |                   - |
            ToSByte |   3.6185 ns | 0.0226 ns | 0.0211 ns |           - |           - |           - |                   - |
    ToSByteNullable |   6.7362 ns | 0.0558 ns | 0.0522 ns |           - |           - |           - |                   - |
             ToByte |   3.5131 ns | 0.0301 ns | 0.0281 ns |           - |           - |           - |                   - |
     ToByteNullable |   6.7422 ns | 0.0468 ns | 0.0438 ns |           - |           - |           - |                   - |
            ToShort |   3.6322 ns | 0.0257 ns | 0.0241 ns |           - |           - |           - |                   - |
    ToShortNullable |   6.7390 ns | 0.0461 ns | 0.0431 ns |           - |           - |           - |                   - |
           ToUShort |   3.6208 ns | 0.0220 ns | 0.0206 ns |           - |           - |           - |                   - |
   ToUShortNullable |   6.7589 ns | 0.0620 ns | 0.0550 ns |           - |           - |           - |                   - |
              ToInt |   3.2425 ns | 0.0217 ns | 0.0192 ns |           - |           - |           - |                   - |
      ToIntNullable |   6.0771 ns | 0.0228 ns | 0.0214 ns |           - |           - |           - |                   - |
             ToUInt |   3.4325 ns | 0.0357 ns | 0.0334 ns |           - |           - |           - |                   - |
     ToUIntNullable |   6.0772 ns | 0.0267 ns | 0.0250 ns |           - |           - |           - |                   - |
             ToLong |   3.8074 ns | 0.0263 ns | 0.0246 ns |           - |           - |           - |                   - |
     ToLongNullable |   5.3222 ns | 0.0313 ns | 0.0292 ns |           - |           - |           - |                   - |
            ToULong |   3.6727 ns | 0.0245 ns | 0.0229 ns |           - |           - |           - |                   - |
    ToULongNullable |   5.3391 ns | 0.0260 ns | 0.0243 ns |           - |           - |           - |                   - |
            ToFloat |   1.8470 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
    ToFloatNullable |   0.9055 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
           ToDouble |   1.0875 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   2.1961 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
          ToDecimal |  23.2277 ns | 0.0988 ns | 0.0876 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  32.3177 ns | 0.1571 ns | 0.1392 ns |           - |           - |           - |                   - |
         ToDateTime |   1.0697 ns | 0.0151 ns | 0.0141 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   8.4035 ns | 0.1058 ns | 0.0990 ns |           - |           - |           - |                   - |
           ToObject |   3.7699 ns | 0.0333 ns | 0.0311 ns |      0.0038 |           - |           - |                24 B |
          To_String | 262.3791 ns | 1.4521 ns | 1.3583 ns |      0.0048 |           - |           - |                32 B |
             ToEnum |  16.3512 ns | 0.1115 ns | 0.1043 ns |           - |           - |           - |                   - |
     ToEnumNullable |  20.8209 ns | 0.1353 ns | 0.1265 ns |           - |           - |           - |                   - |
