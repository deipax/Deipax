
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev |     Median | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|-----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9200 ns | 0.0155 ns | 0.0145 ns |  0.9168 ns |           - |           - |           - |                   - |
     ToBoolNullable |  1.1135 ns | 0.0143 ns | 0.0134 ns |  1.1124 ns |           - |           - |           - |                   - |
             ToChar |  0.6832 ns | 0.0142 ns | 0.0133 ns |  0.6859 ns |           - |           - |           - |                   - |
     ToCharNullable |  3.9685 ns | 0.0602 ns | 0.0534 ns |  3.9570 ns |           - |           - |           - |                   - |
            ToSByte |  1.0952 ns | 0.0108 ns | 0.0101 ns |  1.0936 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1422 ns | 0.0193 ns | 0.0181 ns |  4.1335 ns |           - |           - |           - |                   - |
             ToByte |  0.9421 ns | 0.0090 ns | 0.0084 ns |  0.9439 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1597 ns | 0.0307 ns | 0.0287 ns |  4.1526 ns |           - |           - |           - |                   - |
            ToShort |  1.1080 ns | 0.0113 ns | 0.0105 ns |  1.1049 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1665 ns | 0.0175 ns | 0.0155 ns |  4.1634 ns |           - |           - |           - |                   - |
           ToUShort |  0.9448 ns | 0.0144 ns | 0.0135 ns |  0.9420 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1438 ns | 0.0234 ns | 0.0219 ns |  4.1420 ns |           - |           - |           - |                   - |
              ToInt |  1.1855 ns | 0.0488 ns | 0.1151 ns |  1.1198 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1672 ns | 0.0259 ns | 0.0242 ns |  4.1630 ns |           - |           - |           - |                   - |
             ToUInt |  0.9474 ns | 0.0122 ns | 0.0114 ns |  0.9461 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1639 ns | 0.0241 ns | 0.0226 ns |  4.1657 ns |           - |           - |           - |                   - |
             ToLong |  1.1166 ns | 0.0104 ns | 0.0097 ns |  1.1126 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.2764 ns | 0.0154 ns | 0.0144 ns |  2.2725 ns |           - |           - |           - |                   - |
            ToULong |  0.9512 ns | 0.0142 ns | 0.0126 ns |  0.9515 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.1109 ns | 0.0136 ns | 0.0127 ns |  2.1089 ns |           - |           - |           - |                   - |
            ToFloat |  1.3120 ns | 0.0137 ns | 0.0128 ns |  1.3106 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3870 ns | 0.0331 ns | 0.0310 ns |  4.3770 ns |           - |           - |           - |                   - |
           ToDouble |  0.9830 ns | 0.0120 ns | 0.0113 ns |  0.9818 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.2529 ns | 0.0099 ns | 0.0088 ns |  2.2508 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6767 ns | 0.0217 ns | 0.0193 ns |  5.6807 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.5485 ns | 0.0454 ns | 0.0379 ns | 12.5509 ns |           - |           - |           - |                   - |
         ToDateTime |  1.3190 ns | 0.0159 ns | 0.0149 ns |  1.3174 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.9414 ns | 0.0639 ns | 0.0597 ns |  7.9407 ns |           - |           - |           - |                   - |
           ToObject |  1.3074 ns | 0.0141 ns | 0.0132 ns |  1.3062 ns |           - |           - |           - |                   - |
          To_String |  1.3004 ns | 0.0137 ns | 0.0128 ns |  1.2993 ns |           - |           - |           - |                   - |
             ToEnum |  1.2270 ns | 0.0081 ns | 0.0076 ns |  1.2256 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.3677 ns | 0.0204 ns | 0.0181 ns |  4.3654 ns |           - |           - |           - |                   - |
