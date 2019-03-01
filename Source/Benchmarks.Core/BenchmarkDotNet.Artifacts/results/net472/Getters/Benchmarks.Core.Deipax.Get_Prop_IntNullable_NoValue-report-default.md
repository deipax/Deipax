
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


             Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             ToBool |  0.9590 ns | 0.0160 ns | 0.0149 ns |           - |           - |           - |                   - |
     ToBoolNullable |  3.8877 ns | 0.0210 ns | 0.0197 ns |           - |           - |           - |                   - |
             ToChar |  0.9460 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
     ToCharNullable |  4.1287 ns | 0.0266 ns | 0.0249 ns |           - |           - |           - |                   - |
            ToSByte |  0.9384 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
    ToSByteNullable |  4.1261 ns | 0.0376 ns | 0.0352 ns |           - |           - |           - |                   - |
             ToByte |  0.9469 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
     ToByteNullable |  4.1155 ns | 0.0282 ns | 0.0264 ns |           - |           - |           - |                   - |
            ToShort |  1.1096 ns | 0.0161 ns | 0.0151 ns |           - |           - |           - |                   - |
    ToShortNullable |  4.1289 ns | 0.0233 ns | 0.0206 ns |           - |           - |           - |                   - |
           ToUShort |  0.9439 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
   ToUShortNullable |  4.1326 ns | 0.0285 ns | 0.0266 ns |           - |           - |           - |                   - |
              ToInt |  1.1041 ns | 0.0151 ns | 0.0141 ns |           - |           - |           - |                   - |
      ToIntNullable |  1.0721 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
             ToUInt |  1.1141 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
     ToUIntNullable |  4.1177 ns | 0.0285 ns | 0.0266 ns |           - |           - |           - |                   - |
             ToLong |  0.9451 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
     ToLongNullable |  1.9402 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
            ToULong |  0.9219 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
    ToULongNullable |  1.9187 ns | 0.0126 ns | 0.0112 ns |           - |           - |           - |                   - |
            ToFloat |  1.1104 ns | 0.0100 ns | 0.0093 ns |           - |           - |           - |                   - |
    ToFloatNullable |  4.3371 ns | 0.0295 ns | 0.0276 ns |           - |           - |           - |                   - |
           ToDouble |  1.1322 ns | 0.0195 ns | 0.0183 ns |           - |           - |           - |                   - |
   ToDoubleNullable |  1.9666 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
          ToDecimal |  5.6670 ns | 0.0398 ns | 0.0372 ns |           - |           - |           - |                   - |
  ToDecimalNullable | 12.4985 ns | 0.0791 ns | 0.0740 ns |           - |           - |           - |                   - |
         ToDateTime |  1.0677 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
 ToDateTimeNullable |  8.0783 ns | 0.0635 ns | 0.0594 ns |           - |           - |           - |                   - |
           ToObject |  0.9339 ns | 0.0120 ns | 0.0112 ns |           - |           - |           - |                   - |
          To_String |  1.3198 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
             ToEnum |  1.2325 ns | 0.0101 ns | 0.0094 ns |           - |           - |           - |                   - |
     ToEnumNullable |  4.3306 ns | 0.0294 ns | 0.0275 ns |           - |           - |           - |                   - |
