
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.7275 ns | 0.0053 ns | 0.0044 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.2189 ns | 0.0104 ns | 0.0098 ns |           - |           - |           - |                   - |
             ToChar |  0.7334 ns | 0.0103 ns | 0.0097 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.2163 ns | 0.0263 ns | 0.0246 ns |           - |           - |           - |                   - |
            ToSByte |  1.6231 ns | 0.0073 ns | 0.0065 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.9480 ns | 0.0279 ns | 0.0261 ns |           - |           - |           - |                   - |
             ToByte |  0.7035 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1872 ns | 0.0116 ns | 0.0103 ns |           - |           - |           - |                   - |
            ToShort |  0.7242 ns | 0.0088 ns | 0.0082 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1962 ns | 0.0199 ns | 0.0166 ns |           - |           - |           - |                   - |
           ToUShort |  0.7263 ns | 0.0054 ns | 0.0051 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.2258 ns | 0.0598 ns | 0.0559 ns |           - |           - |           - |                   - |
              ToInt |  0.6966 ns | 0.0049 ns | 0.0041 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1992 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
             ToUInt |  0.6962 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1905 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
             ToLong |  0.7295 ns | 0.0092 ns | 0.0082 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.7054 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
            ToULong |  0.7294 ns | 0.0074 ns | 0.0069 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.7255 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
            ToFloat |  0.7695 ns | 0.0426 ns | 0.0663 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.4524 ns | 0.0454 ns | 0.0425 ns |           - |           - |           - |                   - |
           ToDouble |  0.7013 ns | 0.0092 ns | 0.0077 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.6880 ns | 0.0036 ns | 0.0032 ns |           - |           - |           - |                   - |
          ToDecimal |  5.7387 ns | 0.0049 ns | 0.0043 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.3042 ns | 0.0141 ns | 0.0125 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1670 ns | 0.0033 ns | 0.0027 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.8567 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
           ToObject |  2.7885 ns | 0.0080 ns | 0.0075 ns |      0.0038 |           - |           - |                24 B |
          To_String | 32.1996 ns | 0.0457 ns | 0.0405 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.0070 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.9524 ns | 0.0234 ns | 0.0218 ns |           - |           - |           - |                   - |
