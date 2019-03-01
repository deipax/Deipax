
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.123 ns | 0.0193 ns | 0.0180 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.359 ns | 0.0279 ns | 0.0261 ns |           - |           - |           - |                   - |
             ToChar |  1.126 ns | 0.0177 ns | 0.0166 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.160 ns | 0.0183 ns | 0.0171 ns |           - |           - |           - |                   - |
            ToSByte |  1.963 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.041 ns | 0.0228 ns | 0.0213 ns |           - |           - |           - |                   - |
             ToByte |  2.182 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.003 ns | 0.0253 ns | 0.0237 ns |           - |           - |           - |                   - |
            ToShort |  2.414 ns | 0.0126 ns | 0.0112 ns |           - |           - |           - |                   - |
    ToShortNullable |  5.039 ns | 0.0375 ns | 0.0351 ns |           - |           - |           - |                   - |
           ToUShort |  1.757 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
   ToUShortNullable |  1.103 ns | 0.0088 ns | 0.0082 ns |           - |           - |           - |                   - |
              ToInt |  1.331 ns | 0.0156 ns | 0.0146 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.141 ns | 0.0301 ns | 0.0282 ns |           - |           - |           - |                   - |
             ToUInt |  1.525 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.178 ns | 0.0301 ns | 0.0281 ns |           - |           - |           - |                   - |
             ToLong |  1.111 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.251 ns | 0.0147 ns | 0.0138 ns |           - |           - |           - |                   - |
            ToULong |  1.334 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.458 ns | 0.0193 ns | 0.0181 ns |           - |           - |           - |                   - |
            ToFloat |  1.148 ns | 0.0176 ns | 0.0164 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.605 ns | 0.0281 ns | 0.0263 ns |           - |           - |           - |                   - |
           ToDouble |  1.308 ns | 0.0161 ns | 0.0151 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.455 ns | 0.0252 ns | 0.0236 ns |           - |           - |           - |                   - |
          ToDecimal |  6.332 ns | 0.0404 ns | 0.0358 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.681 ns | 0.0949 ns | 0.0841 ns |           - |           - |           - |                   - |
         ToDateTime |  1.106 ns | 0.0166 ns | 0.0155 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.704 ns | 0.0593 ns | 0.0555 ns |           - |           - |           - |                   - |
           ToObject |  3.513 ns | 0.0369 ns | 0.0345 ns |      0.0038 |           - |           - |                24 B |
          To_String | 29.433 ns | 0.1640 ns | 0.1534 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 14.071 ns | 0.1006 ns | 0.0941 ns |           - |           - |           - |                   - |
     ToEnumNullable | 18.391 ns | 0.0887 ns | 0.0830 ns |           - |           - |           - |                   - |
