
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9293 ns | 0.0224 ns | 0.0210 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9152 ns | 0.0164 ns | 0.0128 ns |           - |           - |           - |                   - |
             ToChar |  0.9339 ns | 0.0177 ns | 0.0165 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1212 ns | 0.0222 ns | 0.0208 ns |           - |           - |           - |                   - |
            ToSByte |  0.9364 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1149 ns | 0.0255 ns | 0.0226 ns |           - |           - |           - |                   - |
             ToByte |  1.3411 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1515 ns | 0.0209 ns | 0.0195 ns |           - |           - |           - |                   - |
            ToShort |  0.9354 ns | 0.0093 ns | 0.0087 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1405 ns | 0.0292 ns | 0.0274 ns |           - |           - |           - |                   - |
           ToUShort |  0.9380 ns | 0.0155 ns | 0.0137 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1578 ns | 0.0478 ns | 0.0447 ns |           - |           - |           - |                   - |
              ToInt |  0.9383 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1212 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
             ToUInt |  0.9196 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.2943 ns | 0.0731 ns | 0.0648 ns |           - |           - |           - |                   - |
             ToLong |  0.9482 ns | 0.0317 ns | 0.0296 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.8684 ns | 0.0349 ns | 0.0309 ns |           - |           - |           - |                   - |
            ToULong |  0.9017 ns | 0.0195 ns | 0.0172 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.8729 ns | 0.0212 ns | 0.0188 ns |           - |           - |           - |                   - |
            ToFloat |  0.9800 ns | 0.0106 ns | 0.0094 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.4855 ns | 0.0383 ns | 0.0359 ns |           - |           - |           - |                   - |
           ToDouble |  0.9705 ns | 0.0173 ns | 0.0162 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.9987 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
          ToDecimal |  5.7062 ns | 0.0213 ns | 0.0189 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.6694 ns | 0.0705 ns | 0.0659 ns |           - |           - |           - |                   - |
         ToDateTime |  0.9624 ns | 0.0110 ns | 0.0102 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.1669 ns | 0.0561 ns | 0.0498 ns |           - |           - |           - |                   - |
           ToObject |  0.9441 ns | 0.0111 ns | 0.0103 ns |           - |           - |           - |                   - |
          To_String |  1.2523 ns | 0.0121 ns | 0.0114 ns |           - |           - |           - |                   - |
             ToEnum |  1.2637 ns | 0.0103 ns | 0.0097 ns |           - |           - |           - |                   - |
     ToEnumNullable |  0.9126 ns | 0.0117 ns | 0.0110 ns |           - |           - |           - |                   - |
