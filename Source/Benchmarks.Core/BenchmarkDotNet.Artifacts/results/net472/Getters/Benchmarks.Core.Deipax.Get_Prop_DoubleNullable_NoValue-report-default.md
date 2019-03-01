
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.8368 ns | 0.0192 ns | 0.0180 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.1219 ns | 0.0275 ns | 0.0257 ns |           - |           - |           - |                   - |
             ToChar |  0.5099 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1436 ns | 0.0164 ns | 0.0137 ns |           - |           - |           - |                   - |
            ToSByte |  0.6226 ns | 0.0113 ns | 0.0105 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.3465 ns | 0.0303 ns | 0.0283 ns |           - |           - |           - |                   - |
             ToByte |  0.8332 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.3471 ns | 0.0147 ns | 0.0138 ns |           - |           - |           - |                   - |
            ToShort |  0.6132 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.3473 ns | 0.0251 ns | 0.0234 ns |           - |           - |           - |                   - |
           ToUShort |  0.6199 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.3653 ns | 0.0366 ns | 0.0342 ns |           - |           - |           - |                   - |
              ToInt |  0.8425 ns | 0.0100 ns | 0.0083 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.3657 ns | 0.0307 ns | 0.0287 ns |           - |           - |           - |                   - |
             ToUInt |  0.8329 ns | 0.0117 ns | 0.0109 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.3483 ns | 0.0258 ns | 0.0242 ns |           - |           - |           - |                   - |
             ToLong |  0.9620 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.9806 ns | 0.0196 ns | 0.0184 ns |           - |           - |           - |                   - |
            ToULong |  0.8404 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.1548 ns | 0.0182 ns | 0.0171 ns |           - |           - |           - |                   - |
            ToFloat |  0.8804 ns | 0.0145 ns | 0.0135 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3358 ns | 0.0186 ns | 0.0174 ns |           - |           - |           - |                   - |
           ToDouble |  0.9044 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.4105 ns | 0.0172 ns | 0.0161 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6563 ns | 0.0229 ns | 0.0215 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.5821 ns | 0.0791 ns | 0.0739 ns |           - |           - |           - |                   - |
         ToDateTime |  1.0800 ns | 0.0133 ns | 0.0118 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.9188 ns | 0.0630 ns | 0.0590 ns |           - |           - |           - |                   - |
           ToObject |  0.8967 ns | 0.0088 ns | 0.0083 ns |           - |           - |           - |                   - |
          To_String |  1.1192 ns | 0.0090 ns | 0.0085 ns |           - |           - |           - |                   - |
             ToEnum |  1.1299 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.5722 ns | 0.0215 ns | 0.0201 ns |           - |           - |           - |                   - |
