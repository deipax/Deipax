
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.6193 ns | 0.0138 ns | 0.0130 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9139 ns | 0.0317 ns | 0.0297 ns |           - |           - |           - |                   - |
             ToChar |  1.2787 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.3761 ns | 0.0312 ns | 0.0292 ns |           - |           - |           - |                   - |
            ToSByte |  1.2779 ns | 0.0118 ns | 0.0105 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.3588 ns | 0.0302 ns | 0.0282 ns |           - |           - |           - |                   - |
             ToByte |  1.2658 ns | 0.0098 ns | 0.0092 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.3539 ns | 0.0321 ns | 0.0285 ns |           - |           - |           - |                   - |
            ToShort |  1.2831 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.3412 ns | 0.0302 ns | 0.0283 ns |           - |           - |           - |                   - |
           ToUShort |  1.2729 ns | 0.0158 ns | 0.0147 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.3538 ns | 0.0280 ns | 0.0262 ns |           - |           - |           - |                   - |
              ToInt |  1.4936 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.3541 ns | 0.0332 ns | 0.0311 ns |           - |           - |           - |                   - |
             ToUInt |  1.2824 ns | 0.0149 ns | 0.0139 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.3374 ns | 0.0236 ns | 0.0221 ns |           - |           - |           - |                   - |
             ToLong |  1.2790 ns | 0.0172 ns | 0.0161 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.4250 ns | 0.0282 ns | 0.0264 ns |           - |           - |           - |                   - |
            ToULong |  0.4052 ns | 0.0080 ns | 0.0071 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.3413 ns | 0.0114 ns | 0.0106 ns |           - |           - |           - |                   - |
            ToFloat |  0.6207 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.5440 ns | 0.0228 ns | 0.0213 ns |           - |           - |           - |                   - |
           ToDouble |  0.6279 ns | 0.0134 ns | 0.0119 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.7807 ns | 0.0160 ns | 0.0149 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6493 ns | 0.0331 ns | 0.0294 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.3896 ns | 0.0832 ns | 0.0737 ns |           - |           - |           - |                   - |
         ToDateTime |  0.8751 ns | 0.0149 ns | 0.0140 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.6945 ns | 0.0537 ns | 0.0502 ns |           - |           - |           - |                   - |
           ToObject |  2.4807 ns | 0.0305 ns | 0.0285 ns |      0.0038 |           - |           - |                24 B |
          To_String | 28.2210 ns | 0.1678 ns | 0.1488 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 12.0071 ns | 0.0709 ns | 0.0663 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.3103 ns | 0.1472 ns | 0.1377 ns |           - |           - |           - |                   - |
