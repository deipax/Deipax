
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.4060 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9253 ns | 0.0122 ns | 0.0108 ns |           - |           - |           - |                   - |
             ToChar |  1.7131 ns | 0.0102 ns | 0.0090 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.3740 ns | 0.0224 ns | 0.0199 ns |           - |           - |           - |                   - |
            ToSByte |  1.4945 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.5844 ns | 0.0318 ns | 0.0298 ns |           - |           - |           - |                   - |
             ToByte |  1.5076 ns | 0.0149 ns | 0.0140 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.3442 ns | 0.0231 ns | 0.0216 ns |           - |           - |           - |                   - |
            ToShort |  1.7833 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.5929 ns | 0.0289 ns | 0.0257 ns |           - |           - |           - |                   - |
           ToUShort |  1.7033 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.3838 ns | 0.0535 ns | 0.0500 ns |           - |           - |           - |                   - |
              ToInt |  1.2852 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.3743 ns | 0.0300 ns | 0.0280 ns |           - |           - |           - |                   - |
             ToUInt |  0.4168 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
     ToUIntNullable |  3.9385 ns | 0.0317 ns | 0.0297 ns |           - |           - |           - |                   - |
             ToLong |  0.4080 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.7106 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
            ToULong |  0.4157 ns | 0.0082 ns | 0.0077 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.5381 ns | 0.0127 ns | 0.0112 ns |           - |           - |           - |                   - |
            ToFloat |  0.6401 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.5678 ns | 0.0157 ns | 0.0131 ns |           - |           - |           - |                   - |
           ToDouble |  0.4182 ns | 0.0067 ns | 0.0062 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.5188 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6950 ns | 0.0245 ns | 0.0229 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.5089 ns | 0.1243 ns | 0.1163 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1005 ns | 0.0147 ns | 0.0137 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.7589 ns | 0.0564 ns | 0.0527 ns |           - |           - |           - |                   - |
           ToObject |  2.4123 ns | 0.0179 ns | 0.0167 ns |      0.0038 |           - |           - |                24 B |
          To_String | 29.1468 ns | 0.1696 ns | 0.1586 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 11.6244 ns | 0.0522 ns | 0.0463 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.3341 ns | 0.1397 ns | 0.1307 ns |           - |           - |           - |                   - |
