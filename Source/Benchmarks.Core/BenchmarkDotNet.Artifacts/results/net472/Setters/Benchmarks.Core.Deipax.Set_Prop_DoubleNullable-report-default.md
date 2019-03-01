
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8481 ns | 0.0099 ns | 0.0093 ns |           - |           - |           - |                   - |
     FromBoolNullable |  2.0246 ns | 0.0239 ns | 0.0224 ns |           - |           - |           - |                   - |
             FromChar |  0.5985 ns | 0.0070 ns | 0.0066 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.1946 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
            FromSByte |  0.5784 ns | 0.0094 ns | 0.0088 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9892 ns | 0.0116 ns | 0.0108 ns |           - |           - |           - |                   - |
             FromByte |  0.6655 ns | 0.0077 ns | 0.0072 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.6761 ns | 0.0146 ns | 0.0137 ns |           - |           - |           - |                   - |
            FromShort |  1.4001 ns | 0.0113 ns | 0.0106 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.8594 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
           FromUShort |  0.6941 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
   FromUShortNullable |  2.4000 ns | 0.0108 ns | 0.0090 ns |           - |           - |           - |                   - |
              FromInt |  0.5890 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.8940 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
             FromUInt |  0.8919 ns | 0.0180 ns | 0.0168 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9341 ns | 0.0300 ns | 0.0266 ns |           - |           - |           - |                   - |
             FromLong |  0.6815 ns | 0.0130 ns | 0.0122 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.2344 ns | 0.0249 ns | 0.0233 ns |           - |           - |           - |                   - |
            FromULong |  0.8719 ns | 0.0111 ns | 0.0104 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.6279 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
            FromFloat |  0.8908 ns | 0.0101 ns | 0.0095 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.8841 ns | 0.0095 ns | 0.0080 ns |           - |           - |           - |                   - |
           FromDouble |  0.6969 ns | 0.0135 ns | 0.0127 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.1196 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
          FromDecimal |  7.9171 ns | 0.0459 ns | 0.0430 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 21.6282 ns | 0.1210 ns | 0.1132 ns |           - |           - |           - |                   - |
         FromDateTime |  0.8711 ns | 0.0064 ns | 0.0054 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5606 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
           FromObject | 13.1135 ns | 0.1144 ns | 0.1070 ns |           - |           - |           - |                   - |
           FromString | 59.1178 ns | 0.3190 ns | 0.2828 ns |           - |           - |           - |                   - |
             FromEnum |  0.6839 ns | 0.0078 ns | 0.0069 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.9247 ns | 0.0133 ns | 0.0124 ns |           - |           - |           - |                   - |
