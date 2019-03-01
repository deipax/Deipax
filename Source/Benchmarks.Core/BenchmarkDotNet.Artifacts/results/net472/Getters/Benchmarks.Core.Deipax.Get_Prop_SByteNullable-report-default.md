
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  1.0268 ns | 0.0016 ns | 0.0015 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.6675 ns | 0.0019 ns | 0.0017 ns |           - |           - |           - |                   - |
             ToChar |  2.0791 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.3798 ns | 0.0592 ns | 0.0554 ns |           - |           - |           - |                   - |
            ToSByte |  1.8634 ns | 0.0017 ns | 0.0016 ns |           - |           - |           - |                   - |
    ToSByteNullable |  0.9494 ns | 0.0075 ns | 0.0066 ns |           - |           - |           - |                   - |
             ToByte |  2.0706 ns | 0.0065 ns | 0.0061 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.3589 ns | 0.0612 ns | 0.0511 ns |           - |           - |           - |                   - |
            ToShort |  0.8756 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.6914 ns | 0.0207 ns | 0.0184 ns |           - |           - |           - |                   - |
           ToUShort |  1.8001 ns | 0.0113 ns | 0.0095 ns |           - |           - |           - |                   - |
   ToUShortNullable |  5.3301 ns | 0.0133 ns | 0.0104 ns |           - |           - |           - |                   - |
              ToInt |  0.9700 ns | 0.0046 ns | 0.0039 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.3962 ns | 0.0058 ns | 0.0052 ns |           - |           - |           - |                   - |
             ToUInt |  1.9594 ns | 0.0055 ns | 0.0052 ns |           - |           - |           - |                   - |
     ToUIntNullable |  5.1322 ns | 0.0291 ns | 0.0272 ns |           - |           - |           - |                   - |
             ToLong |  0.9912 ns | 0.0058 ns | 0.0045 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.2200 ns | 0.0639 ns | 0.0566 ns |           - |           - |           - |                   - |
            ToULong |  1.8076 ns | 0.0085 ns | 0.0076 ns |           - |           - |           - |                   - |
    ToULongNullable |  3.4886 ns | 0.0181 ns | 0.0151 ns |           - |           - |           - |                   - |
            ToFloat |  1.1353 ns | 0.0072 ns | 0.0067 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.8649 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
           ToDouble |  1.1374 ns | 0.0091 ns | 0.0081 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.5657 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
          ToDecimal |  6.2680 ns | 0.0159 ns | 0.0132 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 18.6025 ns | 0.0458 ns | 0.0406 ns |           - |           - |           - |                   - |
         ToDateTime |  1.0049 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.3976 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
           ToObject |  3.7905 ns | 0.0206 ns | 0.0193 ns |      0.0038 |           - |           - |                24 B |
          To_String | 33.8148 ns | 0.1110 ns | 0.0984 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 14.9999 ns | 0.0282 ns | 0.0250 ns |           - |           - |           - |                   - |
     ToEnumNullable | 19.5899 ns | 0.0485 ns | 0.0454 ns |           - |           - |           - |                   - |
