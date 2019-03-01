
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.7150 ns | 0.0084 ns | 0.0074 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.1873 ns | 0.0189 ns | 0.0176 ns |           - |           - |           - |                   - |
             ToChar |  1.6366 ns | 0.0085 ns | 0.0079 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.9122 ns | 0.0377 ns | 0.0353 ns |           - |           - |           - |                   - |
            ToSByte |  0.7060 ns | 0.0038 ns | 0.0030 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.2029 ns | 0.0355 ns | 0.0332 ns |           - |           - |           - |                   - |
             ToByte |  1.6861 ns | 0.0599 ns | 0.0560 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.8726 ns | 0.0216 ns | 0.0202 ns |           - |           - |           - |                   - |
            ToShort |  0.7210 ns | 0.0085 ns | 0.0076 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.2028 ns | 0.0420 ns | 0.0372 ns |           - |           - |           - |                   - |
           ToUShort |  1.8785 ns | 0.0172 ns | 0.0153 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.8729 ns | 0.0145 ns | 0.0136 ns |           - |           - |           - |                   - |
              ToInt |  0.6899 ns | 0.0067 ns | 0.0060 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1824 ns | 0.0099 ns | 0.0092 ns |           - |           - |           - |                   - |
             ToUInt |  1.7172 ns | 0.0229 ns | 0.0214 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.6379 ns | 0.0112 ns | 0.0093 ns |           - |           - |           - |                   - |
             ToLong |  0.7155 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.1038 ns | 0.0199 ns | 0.0187 ns |           - |           - |           - |                   - |
            ToULong |  1.6533 ns | 0.0146 ns | 0.0130 ns |           - |           - |           - |                   - |
    ToULongNullable |  3.1341 ns | 0.0446 ns | 0.0417 ns |           - |           - |           - |                   - |
            ToFloat |  0.9144 ns | 0.0057 ns | 0.0047 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.4207 ns | 0.0168 ns | 0.0157 ns |           - |           - |           - |                   - |
           ToDouble |  0.7051 ns | 0.0056 ns | 0.0050 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.7355 ns | 0.0249 ns | 0.0221 ns |           - |           - |           - |                   - |
          ToDecimal |  5.8297 ns | 0.0250 ns | 0.0222 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 19.0362 ns | 0.1544 ns | 0.1369 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1831 ns | 0.0058 ns | 0.0048 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.1539 ns | 0.0277 ns | 0.0259 ns |           - |           - |           - |                   - |
           ToObject |  2.7085 ns | 0.0074 ns | 0.0069 ns |      0.0038 |           - |           - |                24 B |
          To_String | 33.3152 ns | 0.0456 ns | 0.0356 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.5624 ns | 0.1609 ns | 0.1505 ns |           - |           - |           - |                   - |
     ToEnumNullable | 17.0485 ns | 0.0154 ns | 0.0129 ns |           - |           - |           - |                   - |
