
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9761 ns | 0.0159 ns | 0.0149 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.4294 ns | 0.0232 ns | 0.0206 ns |           - |           - |           - |                   - |
             ToChar |  2.2172 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.0759 ns | 0.0233 ns | 0.0218 ns |           - |           - |           - |                   - |
            ToSByte |  2.1830 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.0440 ns | 0.0237 ns | 0.0222 ns |           - |           - |           - |                   - |
             ToByte |  2.1780 ns | 0.0240 ns | 0.0225 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.0373 ns | 0.0237 ns | 0.0222 ns |           - |           - |           - |                   - |
            ToShort |  1.7674 ns | 0.0164 ns | 0.0146 ns |           - |           - |           - |                   - |
    ToShortNullable |  0.8889 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
           ToUShort |  2.0047 ns | 0.0196 ns | 0.0174 ns |           - |           - |           - |                   - |
   ToUShortNullable |  5.0538 ns | 0.0200 ns | 0.0178 ns |           - |           - |           - |                   - |
              ToInt |  1.1238 ns | 0.0131 ns | 0.0122 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1946 ns | 0.0209 ns | 0.0195 ns |           - |           - |           - |                   - |
             ToUInt |  2.1664 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.8437 ns | 0.0285 ns | 0.0266 ns |           - |           - |           - |                   - |
             ToLong |  1.0774 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.2207 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
            ToULong |  2.1829 ns | 0.0147 ns | 0.0137 ns |           - |           - |           - |                   - |
    ToULongNullable |  3.4949 ns | 0.0192 ns | 0.0179 ns |           - |           - |           - |                   - |
            ToFloat |  0.9992 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.5802 ns | 0.0459 ns | 0.0407 ns |           - |           - |           - |                   - |
           ToDouble |  1.0606 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.6587 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
          ToDecimal |  6.0964 ns | 0.0383 ns | 0.0358 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.2016 ns | 0.1138 ns | 0.1065 ns |           - |           - |           - |                   - |
         ToDateTime |  0.9476 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.8883 ns | 0.0507 ns | 0.0474 ns |           - |           - |           - |                   - |
           ToObject |  3.5048 ns | 0.0224 ns | 0.0210 ns |      0.0038 |           - |           - |                24 B |
          To_String | 31.1548 ns | 0.1977 ns | 0.1849 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 14.0513 ns | 0.0882 ns | 0.0825 ns |           - |           - |           - |                   - |
     ToEnumNullable | 18.4504 ns | 0.0882 ns | 0.0825 ns |           - |           - |           - |                   - |
