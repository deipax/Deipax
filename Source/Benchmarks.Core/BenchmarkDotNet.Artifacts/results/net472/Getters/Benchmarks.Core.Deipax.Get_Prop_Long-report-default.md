
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.8980 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9406 ns | 0.0357 ns | 0.0334 ns |           - |           - |           - |                   - |
             ToChar |  1.5419 ns | 0.0072 ns | 0.0064 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.5874 ns | 0.0280 ns | 0.0262 ns |           - |           - |           - |                   - |
            ToSByte |  1.5278 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.5783 ns | 0.0284 ns | 0.0266 ns |           - |           - |           - |                   - |
             ToByte |  1.5312 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.5891 ns | 0.0168 ns | 0.0157 ns |           - |           - |           - |                   - |
            ToShort |  1.7609 ns | 0.0161 ns | 0.0151 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.5806 ns | 0.0308 ns | 0.0288 ns |           - |           - |           - |                   - |
           ToUShort |  1.5444 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.5658 ns | 0.0244 ns | 0.0228 ns |           - |           - |           - |                   - |
              ToInt |  1.7452 ns | 0.0159 ns | 0.0149 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.3709 ns | 0.0245 ns | 0.0217 ns |           - |           - |           - |                   - |
             ToUInt |  1.5225 ns | 0.0076 ns | 0.0071 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.5977 ns | 0.0313 ns | 0.0292 ns |           - |           - |           - |                   - |
             ToLong |  0.6760 ns | 0.0177 ns | 0.0166 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.5866 ns | 0.0096 ns | 0.0090 ns |           - |           - |           - |                   - |
            ToULong |  1.5523 ns | 0.0150 ns | 0.0141 ns |           - |           - |           - |                   - |
    ToULongNullable |  2.6192 ns | 0.0255 ns | 0.0238 ns |           - |           - |           - |                   - |
            ToFloat |  0.6678 ns | 0.0138 ns | 0.0129 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.1437 ns | 0.0265 ns | 0.0248 ns |           - |           - |           - |                   - |
           ToDouble |  0.6812 ns | 0.0216 ns | 0.0202 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.9067 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6644 ns | 0.0267 ns | 0.0249 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 17.2341 ns | 0.1255 ns | 0.1174 ns |           - |           - |           - |                   - |
         ToDateTime |  1.1081 ns | 0.0116 ns | 0.0103 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.4226 ns | 0.0510 ns | 0.0477 ns |           - |           - |           - |                   - |
           ToObject |  2.6387 ns | 0.0284 ns | 0.0266 ns |      0.0038 |           - |           - |                24 B |
          To_String | 30.7156 ns | 0.3011 ns | 0.2816 ns |      0.0051 |           - |           - |                32 B |
             ToEnum | 11.8811 ns | 0.0526 ns | 0.0492 ns |           - |           - |           - |                   - |
     ToEnumNullable | 16.4112 ns | 0.1106 ns | 0.1034 ns |           - |           - |           - |                   - |
