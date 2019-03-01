
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9216 ns | 0.0129 ns | 0.0114 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.5490 ns | 0.0285 ns | 0.0266 ns |           - |           - |           - |                   - |
             ToChar |  1.6911 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.0020 ns | 0.0436 ns | 0.0408 ns |           - |           - |           - |                   - |
            ToSByte |  1.6957 ns | 0.0130 ns | 0.0115 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.0105 ns | 0.0223 ns | 0.0209 ns |           - |           - |           - |                   - |
             ToByte |  1.9602 ns | 0.0174 ns | 0.0163 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.9852 ns | 0.0354 ns | 0.0331 ns |           - |           - |           - |                   - |
            ToShort |  1.9348 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
    ToShortNullable |  5.0277 ns | 0.0441 ns | 0.0412 ns |           - |           - |           - |                   - |
           ToUShort |  1.9365 ns | 0.0147 ns | 0.0131 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.9888 ns | 0.0256 ns | 0.0240 ns |           - |           - |           - |                   - |
              ToInt |  2.1498 ns | 0.0150 ns | 0.0141 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.7638 ns | 0.0198 ns | 0.0175 ns |           - |           - |           - |                   - |
             ToUInt |  1.9233 ns | 0.0104 ns | 0.0092 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.9872 ns | 0.0319 ns | 0.0298 ns |           - |           - |           - |                   - |
             ToLong |  1.9333 ns | 0.0146 ns | 0.0136 ns |           - |           - |           - |                   - |
     ToLongNullable |  3.1235 ns | 0.0212 ns | 0.0199 ns |           - |           - |           - |                   - |
            ToULong |  1.8597 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.3133 ns | 0.0117 ns | 0.0104 ns |           - |           - |           - |                   - |
            ToFloat |  1.0806 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.7718 ns | 0.0265 ns | 0.0248 ns |           - |           - |           - |                   - |
           ToDouble |  1.2663 ns | 0.0133 ns | 0.0125 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.3896 ns | 0.0161 ns | 0.0142 ns |           - |           - |           - |                   - |
          ToDecimal |  5.8785 ns | 0.0235 ns | 0.0220 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.8215 ns | 0.0867 ns | 0.0769 ns |           - |           - |           - |                   - |
         ToDateTime |  0.9443 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.8730 ns | 0.0426 ns | 0.0377 ns |           - |           - |           - |                   - |
           ToObject |  3.4411 ns | 0.0273 ns | 0.0255 ns |      0.0038 |           - |           - |                24 B |
          To_String | 29.8784 ns | 0.1247 ns | 0.1166 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 15.3036 ns | 0.2491 ns | 0.2330 ns |           - |           - |           - |                   - |
     ToEnumNullable | 18.7980 ns | 0.1031 ns | 0.0965 ns |           - |           - |           - |                   - |
