
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   0.6694 ns | 0.0154 ns | 0.0137 ns |           - |           - |           - |                   - |
     ToBoolNullable |  10.6406 ns | 0.0559 ns | 0.0495 ns |           - |           - |           - |                   - |
             ToChar |   0.8836 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
     ToCharNullable |  10.6880 ns | 0.0691 ns | 0.0647 ns |           - |           - |           - |                   - |
            ToSByte |   0.6801 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
    ToSByteNullable |  10.6421 ns | 0.0686 ns | 0.0642 ns |           - |           - |           - |                   - |
             ToByte |   0.8831 ns | 0.0135 ns | 0.0127 ns |           - |           - |           - |                   - |
     ToByteNullable |  10.6483 ns | 0.0621 ns | 0.0551 ns |           - |           - |           - |                   - |
            ToShort |   0.6793 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
    ToShortNullable |  10.6412 ns | 0.0428 ns | 0.0400 ns |           - |           - |           - |                   - |
           ToUShort |   0.8927 ns | 0.0196 ns | 0.0183 ns |           - |           - |           - |                   - |
   ToUShortNullable |  10.6829 ns | 0.0953 ns | 0.0796 ns |           - |           - |           - |                   - |
              ToInt |   0.6731 ns | 0.0117 ns | 0.0110 ns |           - |           - |           - |                   - |
      ToIntNullable |  11.9595 ns | 0.0489 ns | 0.0457 ns |           - |           - |           - |                   - |
             ToUInt |   0.8845 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
     ToUIntNullable |  11.9998 ns | 0.0722 ns | 0.0676 ns |           - |           - |           - |                   - |
             ToLong |   0.6738 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
     ToLongNullable |   1.5313 ns | 0.0149 ns | 0.0139 ns |           - |           - |           - |                   - |
            ToULong |   0.6782 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
    ToULongNullable |   1.5284 ns | 0.0121 ns | 0.0114 ns |           - |           - |           - |                   - |
            ToFloat |   0.8939 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
    ToFloatNullable |  11.9661 ns | 0.0744 ns | 0.0696 ns |           - |           - |           - |                   - |
           ToDouble |   0.6719 ns | 0.0091 ns | 0.0086 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   1.5299 ns | 0.0131 ns | 0.0122 ns |           - |           - |           - |                   - |
          ToDecimal |  10.6340 ns | 0.0454 ns | 0.0402 ns |           - |           - |           - |                   - |
  ToDecimalNullable |   1.6765 ns | 0.0145 ns | 0.0129 ns |           - |           - |           - |                   - |
         ToDateTime |   1.7889 ns | 0.0134 ns | 0.0125 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   1.4687 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
           ToObject |   3.4935 ns | 0.0334 ns | 0.0312 ns |      0.0038 |           - |           - |                24 B |
          To_String | 301.2932 ns | 0.9988 ns | 0.8854 ns |      0.0300 |           - |           - |               192 B |
             ToEnum |  14.0730 ns | 0.0772 ns | 0.0685 ns |           - |           - |           - |                   - |
     ToEnumNullable |  19.4722 ns | 0.0996 ns | 0.0931 ns |           - |           - |           - |                   - |
