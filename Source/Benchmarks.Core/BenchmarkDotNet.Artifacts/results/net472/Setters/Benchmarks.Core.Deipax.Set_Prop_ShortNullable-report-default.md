
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6536 ns | 0.0127 ns | 0.0118 ns |           - |           - |           - |                   - |
     FromBoolNullable |  2.0150 ns | 0.0168 ns | 0.0157 ns |           - |           - |           - |                   - |
             FromChar |  2.3621 ns | 0.0190 ns | 0.0178 ns |           - |           - |           - |                   - |
     FromCharNullable |  2.6099 ns | 0.0393 ns | 0.0367 ns |           - |           - |           - |                   - |
            FromSByte |  0.5490 ns | 0.0102 ns | 0.0096 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.0037 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
             FromByte |  0.5511 ns | 0.0069 ns | 0.0065 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.0040 ns | 0.0172 ns | 0.0161 ns |           - |           - |           - |                   - |
            FromShort |  0.6118 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
    FromShortNullable |  0.5832 ns | 0.0192 ns | 0.0180 ns |           - |           - |           - |                   - |
           FromUShort |  1.7209 ns | 0.0151 ns | 0.0126 ns |           - |           - |           - |                   - |
   FromUShortNullable |  2.6404 ns | 0.0244 ns | 0.0228 ns |           - |           - |           - |                   - |
              FromInt |  1.6509 ns | 0.0124 ns | 0.0116 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.7027 ns | 0.0295 ns | 0.0276 ns |           - |           - |           - |                   - |
             FromUInt |  1.6427 ns | 0.0189 ns | 0.0177 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.6632 ns | 0.0220 ns | 0.0206 ns |           - |           - |           - |                   - |
             FromLong |  1.7540 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.9547 ns | 0.0183 ns | 0.0171 ns |           - |           - |           - |                   - |
            FromULong |  1.6979 ns | 0.0152 ns | 0.0143 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.9956 ns | 0.0262 ns | 0.0245 ns |           - |           - |           - |                   - |
            FromFloat |  3.8356 ns | 0.0236 ns | 0.0221 ns |           - |           - |           - |                   - |
    FromFloatNullable |  4.4786 ns | 0.0294 ns | 0.0275 ns |           - |           - |           - |                   - |
           FromDouble |  3.4370 ns | 0.0297 ns | 0.0278 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.9147 ns | 0.0177 ns | 0.0157 ns |           - |           - |           - |                   - |
          FromDecimal | 13.3100 ns | 0.0311 ns | 0.0260 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 28.3644 ns | 0.1586 ns | 0.1484 ns |           - |           - |           - |                   - |
         FromDateTime |  0.8704 ns | 0.0114 ns | 0.0106 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5658 ns | 0.0225 ns | 0.0210 ns |           - |           - |           - |                   - |
           FromObject | 13.0010 ns | 0.0629 ns | 0.0588 ns |           - |           - |           - |                   - |
           FromString | 43.6819 ns | 0.1858 ns | 0.1738 ns |           - |           - |           - |                   - |
             FromEnum |  1.6889 ns | 0.0159 ns | 0.0149 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.7458 ns | 0.0340 ns | 0.0318 ns |           - |           - |           - |                   - |
