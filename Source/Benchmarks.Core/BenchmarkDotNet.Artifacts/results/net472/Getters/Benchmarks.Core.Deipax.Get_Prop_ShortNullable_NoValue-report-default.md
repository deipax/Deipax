
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9190 ns | 0.0177 ns | 0.0165 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9133 ns | 0.0384 ns | 0.0359 ns |           - |           - |           - |                   - |
             ToChar |  0.9120 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1230 ns | 0.0278 ns | 0.0260 ns |           - |           - |           - |                   - |
            ToSByte |  0.9243 ns | 0.0146 ns | 0.0137 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1495 ns | 0.0289 ns | 0.0271 ns |           - |           - |           - |                   - |
             ToByte |  0.9203 ns | 0.0146 ns | 0.0136 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1348 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
            ToShort |  0.8953 ns | 0.0110 ns | 0.0097 ns |           - |           - |           - |                   - |
    ToShortNullable |  0.8834 ns | 0.0112 ns | 0.0104 ns |           - |           - |           - |                   - |
           ToUShort |  0.9206 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1334 ns | 0.0375 ns | 0.0313 ns |           - |           - |           - |                   - |
              ToInt |  0.9118 ns | 0.0105 ns | 0.0099 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1390 ns | 0.0267 ns | 0.0250 ns |           - |           - |           - |                   - |
             ToUInt |  0.8922 ns | 0.0096 ns | 0.0089 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1084 ns | 0.0217 ns | 0.0203 ns |           - |           - |           - |                   - |
             ToLong |  0.9220 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.9955 ns | 0.0192 ns | 0.0179 ns |           - |           - |           - |                   - |
            ToULong |  0.8875 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.1525 ns | 0.0174 ns | 0.0155 ns |           - |           - |           - |                   - |
            ToFloat |  0.9407 ns | 0.0108 ns | 0.0095 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3269 ns | 0.0208 ns | 0.0194 ns |           - |           - |           - |                   - |
           ToDouble |  0.9459 ns | 0.0116 ns | 0.0108 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.9913 ns | 0.0169 ns | 0.0150 ns |           - |           - |           - |                   - |
          ToDecimal |  5.8718 ns | 0.0226 ns | 0.0212 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.6234 ns | 0.0775 ns | 0.0725 ns |           - |           - |           - |                   - |
         ToDateTime |  0.9546 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 11.5503 ns | 0.0564 ns | 0.0527 ns |           - |           - |           - |                   - |
           ToObject |  0.9034 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
          To_String |  1.2480 ns | 0.0174 ns | 0.0163 ns |           - |           - |           - |                   - |
             ToEnum |  1.2146 ns | 0.0111 ns | 0.0103 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.3333 ns | 0.0327 ns | 0.0306 ns |           - |           - |           - |                   - |
