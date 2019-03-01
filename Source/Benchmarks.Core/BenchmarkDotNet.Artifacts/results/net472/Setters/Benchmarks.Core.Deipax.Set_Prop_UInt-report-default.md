
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.1129 ns | 0.0146 ns | 0.0136 ns |           - |           - |           - |                   - |
     FromBoolNullable |  2.0371 ns | 0.0660 ns | 0.1027 ns |           - |           - |           - |                   - |
             FromChar |  0.6671 ns | 0.0152 ns | 0.0142 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.5404 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
            FromSByte |  1.5604 ns | 0.0169 ns | 0.0158 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.0192 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
             FromByte |  0.6681 ns | 0.0095 ns | 0.0089 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.6445 ns | 0.0183 ns | 0.0171 ns |           - |           - |           - |                   - |
            FromShort |  1.7613 ns | 0.0212 ns | 0.0199 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.2520 ns | 0.0192 ns | 0.0180 ns |           - |           - |           - |                   - |
           FromUShort |  0.8123 ns | 0.0418 ns | 0.0845 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.5525 ns | 0.0151 ns | 0.0141 ns |           - |           - |           - |                   - |
              FromInt |  1.5560 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.1812 ns | 0.0082 ns | 0.0072 ns |           - |           - |           - |                   - |
             FromUInt |  0.6270 ns | 0.0136 ns | 0.0128 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.3051 ns | 0.0151 ns | 0.0134 ns |           - |           - |           - |                   - |
             FromLong |  1.5056 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.4600 ns | 0.0227 ns | 0.0213 ns |           - |           - |           - |                   - |
            FromULong |  1.5102 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.9166 ns | 0.0224 ns | 0.0198 ns |           - |           - |           - |                   - |
            FromFloat |  3.3090 ns | 0.0305 ns | 0.0285 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.2336 ns | 0.0175 ns | 0.0164 ns |           - |           - |           - |                   - |
           FromDouble |  2.3773 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.5045 ns | 0.0228 ns | 0.0213 ns |           - |           - |           - |                   - |
          FromDecimal | 12.3123 ns | 0.0675 ns | 0.0632 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 22.5306 ns | 0.1187 ns | 0.1110 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6240 ns | 0.0089 ns | 0.0078 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3253 ns | 0.0146 ns | 0.0129 ns |           - |           - |           - |                   - |
           FromObject |  2.0936 ns | 0.0137 ns | 0.0121 ns |           - |           - |           - |                   - |
           FromString | 43.8058 ns | 0.1725 ns | 0.1347 ns |           - |           - |           - |                   - |
             FromEnum |  1.5031 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.7360 ns | 0.0209 ns | 0.0195 ns |           - |           - |           - |                   - |
