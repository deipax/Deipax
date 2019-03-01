
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9455 ns | 0.0225 ns | 0.0210 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9393 ns | 0.0345 ns | 0.0322 ns |           - |           - |           - |                   - |
             ToChar |  0.9417 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1585 ns | 0.0177 ns | 0.0165 ns |           - |           - |           - |                   - |
            ToSByte |  0.9398 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1493 ns | 0.0369 ns | 0.0345 ns |           - |           - |           - |                   - |
             ToByte |  0.9568 ns | 0.0146 ns | 0.0137 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1489 ns | 0.0178 ns | 0.0167 ns |           - |           - |           - |                   - |
            ToShort |  0.9369 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1454 ns | 0.0345 ns | 0.0322 ns |           - |           - |           - |                   - |
           ToUShort |  0.9415 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
   ToUShortNullable |  1.0975 ns | 0.0087 ns | 0.0082 ns |           - |           - |           - |                   - |
              ToInt |  0.9471 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1583 ns | 0.0269 ns | 0.0252 ns |           - |           - |           - |                   - |
             ToUInt |  1.0899 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1510 ns | 0.0205 ns | 0.0191 ns |           - |           - |           - |                   - |
             ToLong |  1.0225 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.8002 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
            ToULong |  0.9334 ns | 0.0118 ns | 0.0105 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.2457 ns | 0.0128 ns | 0.0113 ns |           - |           - |           - |                   - |
            ToFloat |  0.9683 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3768 ns | 0.0260 ns | 0.0243 ns |           - |           - |           - |                   - |
           ToDouble |  1.1093 ns | 0.0150 ns | 0.0141 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.0244 ns | 0.0108 ns | 0.0096 ns |           - |           - |           - |                   - |
          ToDecimal |  5.9155 ns | 0.0358 ns | 0.0335 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.5630 ns | 0.0419 ns | 0.0392 ns |           - |           - |           - |                   - |
         ToDateTime |  1.0962 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.7053 ns | 0.0628 ns | 0.0588 ns |           - |           - |           - |                   - |
           ToObject |  0.9412 ns | 0.0134 ns | 0.0126 ns |           - |           - |           - |                   - |
          To_String |  1.2719 ns | 0.0103 ns | 0.0097 ns |           - |           - |           - |                   - |
             ToEnum |  1.2416 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.3599 ns | 0.0206 ns | 0.0192 ns |           - |           - |           - |                   - |
