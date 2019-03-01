
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9333 ns | 0.0140 ns | 0.0131 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.9193 ns | 0.0212 ns | 0.0198 ns |           - |           - |           - |                   - |
             ToChar |  0.9432 ns | 0.0137 ns | 0.0122 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1275 ns | 0.0224 ns | 0.0210 ns |           - |           - |           - |                   - |
            ToSByte |  0.9393 ns | 0.0178 ns | 0.0166 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1220 ns | 0.0331 ns | 0.0310 ns |           - |           - |           - |                   - |
             ToByte |  0.9421 ns | 0.0177 ns | 0.0166 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1364 ns | 0.0246 ns | 0.0230 ns |           - |           - |           - |                   - |
            ToShort |  1.0995 ns | 0.0119 ns | 0.0112 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1040 ns | 0.0279 ns | 0.0261 ns |           - |           - |           - |                   - |
           ToUShort |  0.9378 ns | 0.0112 ns | 0.0099 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1105 ns | 0.0240 ns | 0.0225 ns |           - |           - |           - |                   - |
              ToInt |  0.9105 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
      ToIntNullable |  4.1298 ns | 0.0252 ns | 0.0236 ns |           - |           - |           - |                   - |
             ToUInt |  1.1050 ns | 0.0167 ns | 0.0156 ns |           - |           - |           - |                   - |
     ToUIntNullable |  1.0693 ns | 0.0182 ns | 0.0170 ns |           - |           - |           - |                   - |
             ToLong |  0.9515 ns | 0.0087 ns | 0.0077 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.9124 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
            ToULong |  1.1075 ns | 0.0173 ns | 0.0162 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.9099 ns | 0.0115 ns | 0.0102 ns |           - |           - |           - |                   - |
            ToFloat |  1.0998 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3398 ns | 0.0245 ns | 0.0217 ns |           - |           - |           - |                   - |
           ToDouble |  1.1015 ns | 0.0088 ns | 0.0082 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  2.3236 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6460 ns | 0.0174 ns | 0.0155 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.4215 ns | 0.0480 ns | 0.0449 ns |           - |           - |           - |                   - |
         ToDateTime |  1.0571 ns | 0.0139 ns | 0.0124 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  7.7282 ns | 0.0650 ns | 0.0608 ns |           - |           - |           - |                   - |
           ToObject |  0.9327 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
          To_String |  1.2408 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
             ToEnum |  1.2450 ns | 0.0150 ns | 0.0140 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.3365 ns | 0.0234 ns | 0.0219 ns |           - |           - |           - |                   - |
