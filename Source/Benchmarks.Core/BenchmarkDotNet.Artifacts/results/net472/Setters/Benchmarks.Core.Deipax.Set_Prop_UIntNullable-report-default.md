
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8716 ns | 0.0085 ns | 0.0076 ns |           - |           - |           - |                   - |
     FromBoolNullable |  2.0597 ns | 0.0103 ns | 0.0091 ns |           - |           - |           - |                   - |
             FromChar |  0.8727 ns | 0.0170 ns | 0.0159 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.8805 ns | 0.0107 ns | 0.0095 ns |           - |           - |           - |                   - |
            FromSByte |  1.6652 ns | 0.0100 ns | 0.0094 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.5898 ns | 0.0295 ns | 0.0276 ns |           - |           - |           - |                   - |
             FromByte |  0.6711 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.9492 ns | 0.0097 ns | 0.0090 ns |           - |           - |           - |                   - |
            FromShort |  2.0046 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.4874 ns | 0.0195 ns | 0.0182 ns |           - |           - |           - |                   - |
           FromUShort |  0.6693 ns | 0.0103 ns | 0.0096 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.8661 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
              FromInt |  1.6453 ns | 0.0089 ns | 0.0084 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.7110 ns | 0.0178 ns | 0.0157 ns |           - |           - |           - |                   - |
             FromUInt |  0.6800 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
     FromUIntNullable |  0.6751 ns | 0.0102 ns | 0.0095 ns |           - |           - |           - |                   - |
             FromLong |  1.7652 ns | 0.0088 ns | 0.0078 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.8334 ns | 0.0219 ns | 0.0205 ns |           - |           - |           - |                   - |
            FromULong |  1.6505 ns | 0.0117 ns | 0.0104 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.7357 ns | 0.0229 ns | 0.0214 ns |           - |           - |           - |                   - |
            FromFloat |  3.3405 ns | 0.0277 ns | 0.0260 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.5590 ns | 0.0250 ns | 0.0222 ns |           - |           - |           - |                   - |
           FromDouble |  3.1302 ns | 0.0192 ns | 0.0180 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  3.8292 ns | 0.0216 ns | 0.0202 ns |           - |           - |           - |                   - |
          FromDecimal | 12.5665 ns | 0.0457 ns | 0.0406 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 22.7049 ns | 0.1215 ns | 0.1077 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7010 ns | 0.0189 ns | 0.0177 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5431 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
           FromObject | 12.8140 ns | 0.0806 ns | 0.0754 ns |           - |           - |           - |                   - |
           FromString | 44.0095 ns | 0.1917 ns | 0.1793 ns |           - |           - |           - |                   - |
             FromEnum |  1.6637 ns | 0.0150 ns | 0.0133 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.5229 ns | 0.0357 ns | 0.0316 ns |           - |           - |           - |                   - |
