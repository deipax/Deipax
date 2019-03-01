
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |        Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |------------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |   0.9522 ns | 0.0274 ns | 0.0256 ns |           - |           - |           - |                   - |
     ToBoolNullable |   4.5437 ns | 0.0239 ns | 0.0224 ns |           - |           - |           - |                   - |
             ToChar |   1.9643 ns | 0.0212 ns | 0.0198 ns |           - |           - |           - |                   - |
     ToCharNullable |   5.0005 ns | 0.0267 ns | 0.0250 ns |           - |           - |           - |                   - |
            ToSByte |   2.0088 ns | 0.0734 ns | 0.0687 ns |           - |           - |           - |                   - |
    ToSByteNullable |   4.9573 ns | 0.0354 ns | 0.0331 ns |           - |           - |           - |                   - |
             ToByte |   1.9633 ns | 0.0209 ns | 0.0196 ns |           - |           - |           - |                   - |
     ToByteNullable |   4.9957 ns | 0.0270 ns | 0.0253 ns |           - |           - |           - |                   - |
            ToShort |   1.9320 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
    ToShortNullable |   5.0072 ns | 0.0377 ns | 0.0353 ns |           - |           - |           - |                   - |
           ToUShort |   2.1761 ns | 0.0200 ns | 0.0187 ns |           - |           - |           - |                   - |
   ToUShortNullable |   4.8601 ns | 0.0341 ns | 0.0319 ns |           - |           - |           - |                   - |
              ToInt |   1.0816 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
      ToIntNullable |   4.1331 ns | 0.0231 ns | 0.0216 ns |           - |           - |           - |                   - |
             ToUInt |   1.9421 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
     ToUIntNullable |   4.8155 ns | 0.0276 ns | 0.0244 ns |           - |           - |           - |                   - |
             ToLong |   1.0955 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
     ToLongNullable |   1.9733 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
            ToULong |   1.7288 ns | 0.0297 ns | 0.0278 ns |           - |           - |           - |                   - |
    ToULongNullable |   2.7123 ns | 0.0330 ns | 0.0308 ns |           - |           - |           - |                   - |
            ToFloat |   1.0770 ns | 0.0112 ns | 0.0099 ns |           - |           - |           - |                   - |
    ToFloatNullable |   4.7653 ns | 0.0237 ns | 0.0198 ns |           - |           - |           - |                   - |
           ToDouble |   0.9969 ns | 0.0519 ns | 0.0823 ns |           - |           - |           - |                   - |
   ToDoubleNullable |   2.3916 ns | 0.0192 ns | 0.0179 ns |           - |           - |           - |                   - |
          ToDecimal |   6.0958 ns | 0.0277 ns | 0.0259 ns |           - |           - |           - |                   - |
  ToDecimalNullable |  17.1965 ns | 0.0956 ns | 0.0798 ns |           - |           - |           - |                   - |
         ToDateTime |   0.9414 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |   8.0942 ns | 0.0550 ns | 0.0515 ns |           - |           - |           - |                   - |
           ToObject |   3.4738 ns | 0.0275 ns | 0.0257 ns |      0.0038 |           - |           - |                24 B |
          To_String | 268.9365 ns | 1.9169 ns | 1.7931 ns |      0.0114 |           - |           - |                72 B |
             ToEnum |   1.8923 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
     ToEnumNullable |   0.8991 ns | 0.0150 ns | 0.0141 ns |           - |           - |           - |                   - |
