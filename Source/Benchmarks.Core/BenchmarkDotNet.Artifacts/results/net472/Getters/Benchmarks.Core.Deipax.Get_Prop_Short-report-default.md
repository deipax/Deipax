
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.7119 ns | 0.0050 ns | 0.0045 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.1750 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
             ToChar |  1.6361 ns | 0.0051 ns | 0.0042 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.8758 ns | 0.0287 ns | 0.0269 ns |           - |           - |           - |                   - |
            ToSByte |  1.8464 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.8611 ns | 0.0112 ns | 0.0094 ns |           - |           - |           - |                   - |
             ToByte |  1.8479 ns | 0.0219 ns | 0.0194 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.8653 ns | 0.0166 ns | 0.0147 ns |           - |           - |           - |                   - |
            ToShort |  0.7128 ns | 0.0045 ns | 0.0042 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1758 ns | 0.0172 ns | 0.0153 ns |           - |           - |           - |                   - |
           ToUShort |  1.6556 ns | 0.0086 ns | 0.0072 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.8684 ns | 0.0166 ns | 0.0147 ns |           - |           - |           - |                   - |
              ToInt |  0.6928 ns | 0.0054 ns | 0.0050 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1716 ns | 0.0104 ns | 0.0097 ns |           - |           - |           - |                   - |
             ToUInt |  1.8429 ns | 0.0045 ns | 0.0042 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.6494 ns | 0.0164 ns | 0.0154 ns |           - |           - |           - |                   - |
             ToLong |  0.7177 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.7387 ns | 0.0032 ns | 0.0029 ns |           - |           - |           - |                   - |
            ToULong |  1.9124 ns | 0.0444 ns | 0.0416 ns |           - |           - |           - |                   - |
    ToULongNullable |  3.0432 ns | 0.0172 ns | 0.0152 ns |           - |           - |           - |                   - |
            ToFloat |  0.6733 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.2106 ns | 0.0401 ns | 0.0375 ns |           - |           - |           - |                   - |
           ToDouble |  0.6766 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.7169 ns | 0.0167 ns | 0.0156 ns |           - |           - |           - |                   - |
          ToDecimal |  5.5166 ns | 0.0298 ns | 0.0278 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.6774 ns | 0.0688 ns | 0.0644 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1267 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 11.7016 ns | 0.0586 ns | 0.0548 ns |           - |           - |           - |                   - |
           ToObject |  2.6534 ns | 0.0200 ns | 0.0187 ns |      0.0038 |           - |           - |                24 B |
          To_String | 30.4952 ns | 0.1498 ns | 0.1328 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 11.6309 ns | 0.0741 ns | 0.0693 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.2216 ns | 0.0737 ns | 0.0689 ns |           - |           - |           - |                   - |
