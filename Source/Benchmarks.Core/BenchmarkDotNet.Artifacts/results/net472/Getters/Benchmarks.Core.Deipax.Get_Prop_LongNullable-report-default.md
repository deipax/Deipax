
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9236 ns | 0.0200 ns | 0.0187 ns |           - |           - |           - |                   - |
     ToBoolNullable |  4.5997 ns | 0.0346 ns | 0.0324 ns |           - |           - |           - |                   - |
             ToChar |  2.2017 ns | 0.0106 ns | 0.0094 ns |           - |           - |           - |                   - |
     ToCharNullable |  5.0280 ns | 0.0344 ns | 0.0322 ns |           - |           - |           - |                   - |
            ToSByte |  1.7085 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
    ToSByteNullable |  5.0159 ns | 0.0250 ns | 0.0234 ns |           - |           - |           - |                   - |
             ToByte |  1.9426 ns | 0.0210 ns | 0.0197 ns |           - |           - |           - |                   - |
     ToByteNullable |  5.0439 ns | 0.0275 ns | 0.0244 ns |           - |           - |           - |                   - |
            ToShort |  2.1440 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
    ToShortNullable |  5.0162 ns | 0.0214 ns | 0.0190 ns |           - |           - |           - |                   - |
           ToUShort |  1.9485 ns | 0.0149 ns | 0.0140 ns |           - |           - |           - |                   - |
   ToUShortNullable |  5.0055 ns | 0.0377 ns | 0.0352 ns |           - |           - |           - |                   - |
              ToInt |  2.1494 ns | 0.0135 ns | 0.0120 ns |           - |           - |           - |                   - |
      ToIntNullable |  5.0147 ns | 0.0253 ns | 0.0236 ns |           - |           - |           - |                   - |
             ToUInt |  1.9413 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
     ToUIntNullable |  5.0238 ns | 0.0223 ns | 0.0209 ns |           - |           - |           - |                   - |
             ToLong |  1.8814 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.5425 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
            ToULong |  1.9352 ns | 0.0119 ns | 0.0111 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.8468 ns | 0.0327 ns | 0.0306 ns |           - |           - |           - |                   - |
            ToFloat |  1.0723 ns | 0.0114 ns | 0.0106 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.5990 ns | 0.0220 ns | 0.0184 ns |           - |           - |           - |                   - |
           ToDouble |  0.9092 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.4168 ns | 0.0130 ns | 0.0115 ns |           - |           - |           - |                   - |
          ToDecimal |  6.3113 ns | 0.0282 ns | 0.0264 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.6669 ns | 0.1100 ns | 0.1029 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1195 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
 ToDateTimeNullable | 16.3533 ns | 0.0998 ns | 0.0934 ns |           - |           - |           - |                   - |
           ToObject |  3.4655 ns | 0.0281 ns | 0.0263 ns |      0.0038 |           - |           - |                24 B |
          To_String | 31.4929 ns | 0.1524 ns | 0.1426 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 15.4246 ns | 0.1359 ns | 0.1271 ns |           - |           - |           - |                   - |
     ToEnumNullable | 18.7583 ns | 0.0750 ns | 0.0665 ns |           - |           - |           - |                   - |
