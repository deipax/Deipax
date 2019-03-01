
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9880 ns | 0.0057 ns | 0.0054 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.1687 ns | 0.0155 ns | 0.0145 ns |           - |           - |           - |                   - |
             ToChar |  0.9842 ns | 0.0038 ns | 0.0034 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.4065 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
            ToSByte |  1.0021 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.4089 ns | 0.0211 ns | 0.0187 ns |           - |           - |           - |                   - |
             ToByte |  1.1485 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
     ToByteNullable |  1.1927 ns | 0.0179 ns | 0.0167 ns |           - |           - |           - |                   - |
            ToShort |  0.9900 ns | 0.0071 ns | 0.0067 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.4350 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
           ToUShort |  0.9917 ns | 0.0111 ns | 0.0093 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.4202 ns | 0.0215 ns | 0.0201 ns |           - |           - |           - |                   - |
              ToInt |  0.9905 ns | 0.0086 ns | 0.0080 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.4080 ns | 0.0146 ns | 0.0129 ns |           - |           - |           - |                   - |
             ToUInt |  1.1602 ns | 0.0125 ns | 0.0111 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.4390 ns | 0.0267 ns | 0.0223 ns |           - |           - |           - |                   - |
             ToLong |  1.0079 ns | 0.0179 ns | 0.0167 ns |           - |           - |           - |                   - |
     ToLongNullable |  2.3728 ns | 0.0182 ns | 0.0170 ns |           - |           - |           - |                   - |
            ToULong |  1.0019 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.9418 ns | 0.0107 ns | 0.0095 ns |           - |           - |           - |                   - |
            ToFloat |  1.1626 ns | 0.0039 ns | 0.0033 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.6262 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
           ToDouble |  1.1455 ns | 0.0033 ns | 0.0028 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.4083 ns | 0.0120 ns | 0.0093 ns |           - |           - |           - |                   - |
          ToDecimal |  6.0306 ns | 0.0180 ns | 0.0168 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 13.2979 ns | 0.0573 ns | 0.0508 ns |           - |           - |           - |                   - |
         ToDateTime |  1.3959 ns | 0.0117 ns | 0.0104 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.2550 ns | 0.0232 ns | 0.0217 ns |           - |           - |           - |                   - |
           ToObject |  1.3780 ns | 0.0081 ns | 0.0076 ns |           - |           - |           - |                   - |
          To_String |  1.6074 ns | 0.0096 ns | 0.0080 ns |           - |           - |           - |                   - |
             ToEnum |  1.3353 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.6412 ns | 0.0169 ns | 0.0150 ns |           - |           - |           - |                   - |
