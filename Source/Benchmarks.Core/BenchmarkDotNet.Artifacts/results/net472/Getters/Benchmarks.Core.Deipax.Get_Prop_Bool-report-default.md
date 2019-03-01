
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.6746 ns | 0.0113 ns | 0.0100 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9530 ns | 0.0349 ns | 0.0326 ns |           - |           - |           - |                   - |
             ToChar |  0.6828 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
     ToCharNullable |  3.9236 ns | 0.0273 ns | 0.0255 ns |           - |           - |           - |                   - |
            ToSByte |  0.8798 ns | 0.0084 ns | 0.0079 ns |           - |           - |           - |                   - |
    ToSByteNullable |  3.9189 ns | 0.0256 ns | 0.0214 ns |           - |           - |           - |                   - |
             ToByte |  0.8765 ns | 0.0104 ns | 0.0097 ns |           - |           - |           - |                   - |
     ToByteNullable |  3.9764 ns | 0.0407 ns | 0.0360 ns |           - |           - |           - |                   - |
            ToShort |  0.9011 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
    ToShortNullable |  3.9291 ns | 0.0413 ns | 0.0386 ns |           - |           - |           - |                   - |
           ToUShort |  0.9078 ns | 0.0117 ns | 0.0110 ns |           - |           - |           - |                   - |
   ToUShortNullable |  3.9519 ns | 0.0263 ns | 0.0233 ns |           - |           - |           - |                   - |
              ToInt |  0.8901 ns | 0.0205 ns | 0.0191 ns |           - |           - |           - |                   - |
      ToIntNullable |  3.9456 ns | 0.0190 ns | 0.0159 ns |           - |           - |           - |                   - |
             ToUInt |  0.8720 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
     ToUIntNullable |  3.9467 ns | 0.0277 ns | 0.0259 ns |           - |           - |           - |                   - |
             ToLong |  0.8966 ns | 0.0114 ns | 0.0101 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.1907 ns | 0.0139 ns | 0.0124 ns |           - |           - |           - |                   - |
            ToULong |  0.9047 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.8046 ns | 0.0148 ns | 0.0138 ns |           - |           - |           - |                   - |
            ToFloat |  0.8805 ns | 0.0117 ns | 0.0104 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3684 ns | 0.0260 ns | 0.0217 ns |           - |           - |           - |                   - |
           ToDouble |  0.8751 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.1630 ns | 0.0199 ns | 0.0186 ns |           - |           - |           - |                   - |
          ToDecimal |  5.4987 ns | 0.0473 ns | 0.0443 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.6354 ns | 0.0593 ns | 0.0495 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1119 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.4971 ns | 0.0409 ns | 0.0383 ns |           - |           - |           - |                   - |
           ToObject |  2.4662 ns | 0.0267 ns | 0.0250 ns |      0.0038 |           - |           - |                24 B |
          To_String |  2.4500 ns | 0.0265 ns | 0.0248 ns |           - |           - |           - |                   - |
             ToEnum | 11.4308 ns | 0.0811 ns | 0.0758 ns |           - |           - |           - |                   - |
     ToEnumNullable | 15.8914 ns | 0.0886 ns | 0.0829 ns |           - |           - |           - |                   - |
