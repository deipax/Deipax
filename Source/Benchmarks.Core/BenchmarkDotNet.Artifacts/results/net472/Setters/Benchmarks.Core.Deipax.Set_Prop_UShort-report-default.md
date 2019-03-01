
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  1.0868 ns | 0.0229 ns | 0.0214 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.6595 ns | 0.0087 ns | 0.0077 ns |           - |           - |           - |                   - |
             FromChar |  0.6589 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.5430 ns | 0.0132 ns | 0.0123 ns |           - |           - |           - |                   - |
            FromSByte |  1.6046 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.2156 ns | 0.0183 ns | 0.0171 ns |           - |           - |           - |                   - |
             FromByte |  0.6769 ns | 0.0115 ns | 0.0108 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.6589 ns | 0.0079 ns | 0.0070 ns |           - |           - |           - |                   - |
            FromShort |  1.7554 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.2287 ns | 0.0096 ns | 0.0089 ns |           - |           - |           - |                   - |
           FromUShort |  0.6537 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.3292 ns | 0.0164 ns | 0.0153 ns |           - |           - |           - |                   - |
              FromInt |  1.9724 ns | 0.0126 ns | 0.0111 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.4016 ns | 0.0208 ns | 0.0184 ns |           - |           - |           - |                   - |
             FromUInt |  1.9708 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.4132 ns | 0.0164 ns | 0.0153 ns |           - |           - |           - |                   - |
             FromLong |  1.7503 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.6554 ns | 0.0220 ns | 0.0205 ns |           - |           - |           - |                   - |
            FromULong |  1.7575 ns | 0.0136 ns | 0.0120 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.6347 ns | 0.0225 ns | 0.0211 ns |           - |           - |           - |                   - |
            FromFloat |  3.5935 ns | 0.0211 ns | 0.0187 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.9603 ns | 0.0267 ns | 0.0250 ns |           - |           - |           - |                   - |
           FromDouble |  3.4971 ns | 0.0209 ns | 0.0195 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.4881 ns | 0.0334 ns | 0.0313 ns |           - |           - |           - |                   - |
          FromDecimal | 13.0396 ns | 0.0846 ns | 0.0791 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 22.8507 ns | 0.1868 ns | 0.1656 ns |           - |           - |           - |                   - |
         FromDateTime |  0.8445 ns | 0.0119 ns | 0.0112 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3268 ns | 0.0135 ns | 0.0126 ns |           - |           - |           - |                   - |
           FromObject |  2.1228 ns | 0.0213 ns | 0.0199 ns |           - |           - |           - |                   - |
           FromString | 44.5184 ns | 0.2542 ns | 0.2254 ns |           - |           - |           - |                   - |
             FromEnum |  1.7551 ns | 0.0108 ns | 0.0101 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.1893 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
