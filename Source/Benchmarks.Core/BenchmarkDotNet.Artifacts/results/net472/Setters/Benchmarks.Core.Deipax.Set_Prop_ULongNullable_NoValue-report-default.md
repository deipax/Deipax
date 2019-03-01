
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6213 ns | 0.0131 ns | 0.0122 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9114 ns | 0.0161 ns | 0.0143 ns |           - |           - |           - |                   - |
             FromChar |  0.6105 ns | 0.0133 ns | 0.0118 ns |           - |           - |           - |                   - |
     FromCharNullable |  2.4206 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
            FromSByte |  1.7100 ns | 0.0213 ns | 0.0199 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9110 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
             FromByte |  0.6282 ns | 0.0091 ns | 0.0085 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.9347 ns | 0.0230 ns | 0.0215 ns |           - |           - |           - |                   - |
            FromShort |  1.7098 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7888 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
           FromUShort |  0.6086 ns | 0.0114 ns | 0.0106 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.8636 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
              FromInt |  1.6466 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.8519 ns | 0.0113 ns | 0.0100 ns |           - |           - |           - |                   - |
             FromUInt |  0.5732 ns | 0.0104 ns | 0.0098 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.8610 ns | 0.0142 ns | 0.0132 ns |           - |           - |           - |                   - |
             FromLong |  1.6326 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.0032 ns | 0.0154 ns | 0.0144 ns |           - |           - |           - |                   - |
            FromULong |  1.5275 ns | 0.0129 ns | 0.0120 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.3273 ns | 0.0153 ns | 0.0143 ns |           - |           - |           - |                   - |
            FromFloat |  3.2419 ns | 0.0246 ns | 0.0230 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.8419 ns | 0.0094 ns | 0.0083 ns |           - |           - |           - |                   - |
           FromDouble |  3.2786 ns | 0.0285 ns | 0.0266 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.9904 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
          FromDecimal | 12.6671 ns | 0.0436 ns | 0.0364 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.5965 ns | 0.0577 ns | 0.0539 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6860 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5718 ns | 0.0172 ns | 0.0161 ns |           - |           - |           - |                   - |
           FromObject |  2.9174 ns | 0.0284 ns | 0.0266 ns |           - |           - |           - |                   - |
           FromString |  1.7224 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
             FromEnum |  1.6571 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.8666 ns | 0.0175 ns | 0.0155 ns |           - |           - |           - |                   - |
