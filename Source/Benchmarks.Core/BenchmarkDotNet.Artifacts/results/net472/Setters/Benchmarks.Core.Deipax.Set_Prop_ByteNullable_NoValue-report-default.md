
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6263 ns | 0.0165 ns | 0.0154 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.8972 ns | 0.0092 ns | 0.0086 ns |           - |           - |           - |                   - |
             FromChar |  1.7134 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.7781 ns | 0.0090 ns | 0.0080 ns |           - |           - |           - |                   - |
            FromSByte |  1.7100 ns | 0.0089 ns | 0.0083 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9066 ns | 0.0130 ns | 0.0115 ns |           - |           - |           - |                   - |
             FromByte |  0.5472 ns | 0.0085 ns | 0.0080 ns |           - |           - |           - |                   - |
     FromByteNullable |  0.5316 ns | 0.0071 ns | 0.0063 ns |           - |           - |           - |                   - |
            FromShort |  1.7741 ns | 0.0110 ns | 0.0103 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.7806 ns | 0.0172 ns | 0.0160 ns |           - |           - |           - |                   - |
           FromUShort |  1.8415 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.8459 ns | 0.0199 ns | 0.0186 ns |           - |           - |           - |                   - |
              FromInt |  1.6175 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.9062 ns | 0.0142 ns | 0.0133 ns |           - |           - |           - |                   - |
             FromUInt |  1.6612 ns | 0.0166 ns | 0.0156 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.8587 ns | 0.0102 ns | 0.0079 ns |           - |           - |           - |                   - |
             FromLong |  1.6183 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.2240 ns | 0.0246 ns | 0.0230 ns |           - |           - |           - |                   - |
            FromULong |  1.6538 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.0172 ns | 0.0178 ns | 0.0167 ns |           - |           - |           - |                   - |
            FromFloat |  3.6732 ns | 0.0201 ns | 0.0179 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.9546 ns | 0.0099 ns | 0.0083 ns |           - |           - |           - |                   - |
           FromDouble |  3.3216 ns | 0.0315 ns | 0.0294 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  2.1181 ns | 0.0147 ns | 0.0137 ns |           - |           - |           - |                   - |
          FromDecimal | 13.0447 ns | 0.0484 ns | 0.0452 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.4932 ns | 0.0527 ns | 0.0493 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6636 ns | 0.0112 ns | 0.0104 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5669 ns | 0.0220 ns | 0.0206 ns |           - |           - |           - |                   - |
           FromObject |  2.6737 ns | 0.0211 ns | 0.0198 ns |           - |           - |           - |                   - |
           FromString |  1.7167 ns | 0.0190 ns | 0.0178 ns |           - |           - |           - |                   - |
             FromEnum |  1.6184 ns | 0.0139 ns | 0.0130 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.9758 ns | 0.0174 ns | 0.0163 ns |           - |           - |           - |                   - |
