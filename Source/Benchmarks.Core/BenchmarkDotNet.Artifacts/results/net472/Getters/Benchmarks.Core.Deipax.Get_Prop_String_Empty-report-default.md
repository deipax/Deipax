
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9242 ns | 0.0202 ns | 0.0189 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.1411 ns | 0.0242 ns | 0.0226 ns |           - |           - |           - |                   - |
             ToChar |  1.3040 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1601 ns | 0.0322 ns | 0.0301 ns |           - |           - |           - |                   - |
            ToSByte |  1.1105 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.5962 ns | 0.0313 ns | 0.0293 ns |           - |           - |           - |                   - |
             ToByte |  1.1187 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.5708 ns | 0.0244 ns | 0.0228 ns |           - |           - |           - |                   - |
            ToShort |  1.1205 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.6253 ns | 0.0368 ns | 0.0344 ns |           - |           - |           - |                   - |
           ToUShort |  1.1161 ns | 0.0070 ns | 0.0062 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.5919 ns | 0.0280 ns | 0.0262 ns |           - |           - |           - |                   - |
              ToInt |  1.0795 ns | 0.0117 ns | 0.0104 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.5798 ns | 0.0330 ns | 0.0293 ns |           - |           - |           - |                   - |
             ToUInt |  1.0823 ns | 0.0151 ns | 0.0141 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.5667 ns | 0.0207 ns | 0.0193 ns |           - |           - |           - |                   - |
             ToLong |  1.0875 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.9150 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
            ToULong |  1.0884 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.2149 ns | 0.0219 ns | 0.0205 ns |           - |           - |           - |                   - |
            ToFloat |  1.0990 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.7797 ns | 0.0227 ns | 0.0202 ns |           - |           - |           - |                   - |
           ToDouble |  1.0968 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.1999 ns | 0.0106 ns | 0.0099 ns |           - |           - |           - |                   - |
          ToDecimal |  5.9318 ns | 0.0318 ns | 0.0297 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.3826 ns | 0.0564 ns | 0.0528 ns |           - |           - |           - |                   - |
         ToDateTime |  1.3902 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.5780 ns | 0.0595 ns | 0.0556 ns |           - |           - |           - |                   - |
           ToObject |  1.8492 ns | 0.0178 ns | 0.0167 ns |           - |           - |           - |                   - |
          To_String |  0.4095 ns | 0.0053 ns | 0.0049 ns |           - |           - |           - |                   - |
             ToEnum |  1.0863 ns | 0.0131 ns | 0.0122 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.5775 ns | 0.0226 ns | 0.0212 ns |           - |           - |           - |                   - |
