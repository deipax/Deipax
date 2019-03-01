
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.4004 ns | 0.0085 ns | 0.0075 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9757 ns | 0.0329 ns | 0.0308 ns |           - |           - |           - |                   - |
             ToChar |  0.4149 ns | 0.0047 ns | 0.0044 ns |           - |           - |           - |                   - |
     ToCharNullable |  3.9456 ns | 0.0282 ns | 0.0264 ns |           - |           - |           - |                   - |
            ToSByte |  1.5127 ns | 0.0173 ns | 0.0162 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.5472 ns | 0.0084 ns | 0.0070 ns |           - |           - |           - |                   - |
             ToByte |  1.5057 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.5885 ns | 0.0197 ns | 0.0184 ns |           - |           - |           - |                   - |
            ToShort |  1.4892 ns | 0.0119 ns | 0.0112 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.5783 ns | 0.0262 ns | 0.0246 ns |           - |           - |           - |                   - |
           ToUShort |  0.4093 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
   ToUShortNullable |  3.9065 ns | 0.0214 ns | 0.0200 ns |           - |           - |           - |                   - |
              ToInt |  0.4134 ns | 0.0066 ns | 0.0061 ns |           - |           - |           - |                   - |
      ToIntNullable |  3.9412 ns | 0.0275 ns | 0.0257 ns |           - |           - |           - |                   - |
             ToUInt |  0.4090 ns | 0.0068 ns | 0.0064 ns |           - |           - |           - |                   - |
     ToUIntNullable |  3.9368 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
             ToLong |  0.4152 ns | 0.0062 ns | 0.0055 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.7545 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
            ToULong |  0.4260 ns | 0.0060 ns | 0.0057 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.5569 ns | 0.0147 ns | 0.0138 ns |           - |           - |           - |                   - |
            ToFloat |  0.4088 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.1647 ns | 0.0318 ns | 0.0297 ns |           - |           - |           - |                   - |
           ToDouble |  0.4210 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.9177 ns | 0.0187 ns | 0.0175 ns |           - |           - |           - |                   - |
          ToDecimal |  5.4569 ns | 0.0262 ns | 0.0245 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  1.5477 ns | 0.0150 ns | 0.0140 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1165 ns | 0.0118 ns | 0.0111 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.7995 ns | 0.0764 ns | 0.0715 ns |           - |           - |           - |                   - |
           ToObject |  2.3945 ns | 0.0144 ns | 0.0135 ns |      0.0038 |           - |           - |                24 B |
          To_String |  4.7725 ns | 0.0329 ns | 0.0308 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 11.4344 ns | 0.0542 ns | 0.0481 ns |           - |           - |           - |                   - |
     ToEnumNullable | 15.9076 ns | 0.0726 ns | 0.0679 ns |           - |           - |           - |                   - |
