
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.1025 ns | 0.0150 ns | 0.0141 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9262 ns | 0.0257 ns | 0.0241 ns |           - |           - |           - |                   - |
             ToChar |  0.8747 ns | 0.0218 ns | 0.0204 ns |           - |           - |           - |                   - |
     ToCharNullable |  3.9232 ns | 0.0299 ns | 0.0280 ns |           - |           - |           - |                   - |
            ToSByte |  1.2742 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1613 ns | 0.0318 ns | 0.0298 ns |           - |           - |           - |                   - |
             ToByte |  0.9305 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1500 ns | 0.0181 ns | 0.0161 ns |           - |           - |           - |                   - |
            ToShort |  0.9324 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1508 ns | 0.0296 ns | 0.0262 ns |           - |           - |           - |                   - |
           ToUShort |  1.2811 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1479 ns | 0.0295 ns | 0.0276 ns |           - |           - |           - |                   - |
              ToInt |  1.0691 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1568 ns | 0.0221 ns | 0.0207 ns |           - |           - |           - |                   - |
             ToUInt |  0.8821 ns | 0.0167 ns | 0.0148 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1799 ns | 0.0200 ns | 0.0177 ns |           - |           - |           - |                   - |
             ToLong |  1.2797 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.4087 ns | 0.0213 ns | 0.0199 ns |           - |           - |           - |                   - |
            ToULong |  1.2917 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.6453 ns | 0.0370 ns | 0.0346 ns |           - |           - |           - |                   - |
            ToFloat |  0.8978 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3504 ns | 0.0313 ns | 0.0293 ns |           - |           - |           - |                   - |
           ToDouble |  1.1072 ns | 0.0137 ns | 0.0129 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.1645 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6796 ns | 0.0310 ns | 0.0290 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.6367 ns | 0.0557 ns | 0.0521 ns |           - |           - |           - |                   - |
         ToDateTime |  1.5532 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.1121 ns | 0.0459 ns | 0.0407 ns |           - |           - |           - |                   - |
           ToObject |  0.8539 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
          To_String |  0.4235 ns | 0.0096 ns | 0.0089 ns |           - |           - |           - |                   - |
             ToEnum |  1.0792 ns | 0.0099 ns | 0.0087 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.1594 ns | 0.0325 ns | 0.0304 ns |           - |           - |           - |                   - |
