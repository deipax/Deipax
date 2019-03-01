
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   0.3938 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
     ToBoolNullable |   3.9042 ns | 0.0283 ns | 0.0264 ns |           - |           - |           - |                   - |
             ToChar |   0.4044 ns | 0.0066 ns | 0.0062 ns |           - |           - |           - |                   - |
     ToCharNullable |   3.9114 ns | 0.0304 ns | 0.0284 ns |           - |           - |           - |                   - |
            ToSByte |   0.4056 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
    ToSByteNullable |   3.8995 ns | 0.0293 ns | 0.0274 ns |           - |           - |           - |                   - |
             ToByte |   0.4090 ns | 0.0115 ns | 0.0107 ns |           - |           - |           - |                   - |
     ToByteNullable |   3.8971 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
            ToShort |   0.4150 ns | 0.0064 ns | 0.0059 ns |           - |           - |           - |                   - |
    ToShortNullable |   3.9343 ns | 0.0351 ns | 0.0328 ns |           - |           - |           - |                   - |
           ToUShort |   0.4000 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
   ToUShortNullable |   3.9073 ns | 0.0243 ns | 0.0228 ns |           - |           - |           - |                   - |
              ToInt |   0.4051 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
      ToIntNullable |   3.9047 ns | 0.0248 ns | 0.0232 ns |           - |           - |           - |                   - |
             ToUInt |   0.4160 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
     ToUIntNullable |   3.9245 ns | 0.0231 ns | 0.0216 ns |           - |           - |           - |                   - |
             ToLong |   0.4074 ns | 0.0049 ns | 0.0046 ns |           - |           - |           - |                   - |
     ToLongNullable |   1.3991 ns | 0.0125 ns | 0.0110 ns |           - |           - |           - |                   - |
            ToULong |   0.7210 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
    ToULongNullable |   1.6083 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
            ToFloat |   0.5803 ns | 0.0071 ns | 0.0066 ns |           - |           - |           - |                   - |
    ToFloatNullable |   4.1340 ns | 0.0265 ns | 0.0248 ns |           - |           - |           - |                   - |
           ToDouble |   0.4111 ns | 0.0072 ns | 0.0068 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.3397 ns | 0.0106 ns | 0.0094 ns |           - |           - |           - |                   - |
          ToDecimal |   5.6493 ns | 0.0457 ns | 0.0427 ns |           - |           - |           - |                   - |
  ToDecimalNullable |   1.5572 ns | 0.0177 ns | 0.0165 ns |           - |           - |           - |                   - |
         ToDateTime |   1.5078 ns | 0.0214 ns | 0.0200 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   5.8383 ns | 0.0215 ns | 0.0191 ns |           - |           - |           - |                   - |
           ToObject |   2.4404 ns | 0.0302 ns | 0.0282 ns |      0.0038 |           - |           - |                24 B |
          To_String | 301.8872 ns | 1.7004 ns | 1.5906 ns |      0.0300 |           - |           - |               192 B |
             ToEnum |  10.7312 ns | 0.0581 ns | 0.0544 ns |           - |           - |           - |                   - |
     ToEnumNullable |  11.1666 ns | 0.0675 ns | 0.0631 ns |           - |           - |           - |                   - |
