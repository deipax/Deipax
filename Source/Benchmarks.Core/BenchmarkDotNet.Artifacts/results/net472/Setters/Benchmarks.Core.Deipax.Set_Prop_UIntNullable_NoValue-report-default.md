
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6303 ns | 0.0125 ns | 0.0117 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.9454 ns | 0.0125 ns | 0.0111 ns |           - |           - |           - |                   - |
             FromChar |  0.6323 ns | 0.0108 ns | 0.0091 ns |           - |           - |           - |                   - |
     FromCharNullable |  1.7880 ns | 0.0098 ns | 0.0081 ns |           - |           - |           - |                   - |
            FromSByte |  1.6520 ns | 0.0186 ns | 0.0174 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.9117 ns | 0.0121 ns | 0.0113 ns |           - |           - |           - |                   - |
             FromByte |  0.5650 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.9118 ns | 0.0112 ns | 0.0105 ns |           - |           - |           - |                   - |
            FromShort |  1.7435 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.8139 ns | 0.0265 ns | 0.0248 ns |           - |           - |           - |                   - |
           FromUShort |  0.5995 ns | 0.0128 ns | 0.0120 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.8761 ns | 0.0225 ns | 0.0210 ns |           - |           - |           - |                   - |
              FromInt |  1.6242 ns | 0.0107 ns | 0.0100 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.8726 ns | 0.0122 ns | 0.0114 ns |           - |           - |           - |                   - |
             FromUInt |  0.6935 ns | 0.0075 ns | 0.0070 ns |           - |           - |           - |                   - |
     FromUIntNullable |  0.6852 ns | 0.0114 ns | 0.0107 ns |           - |           - |           - |                   - |
             FromLong |  1.7552 ns | 0.0124 ns | 0.0110 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.0026 ns | 0.0127 ns | 0.0119 ns |           - |           - |           - |                   - |
            FromULong |  1.6535 ns | 0.0105 ns | 0.0098 ns |           - |           - |           - |                   - |
    FromULongNullable |  1.9005 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
            FromFloat |  3.3196 ns | 0.0331 ns | 0.0310 ns |           - |           - |           - |                   - |
    FromFloatNullable |  1.8998 ns | 0.0382 ns | 0.0319 ns |           - |           - |           - |                   - |
           FromDouble |  2.5327 ns | 0.0219 ns | 0.0194 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  1.9951 ns | 0.0123 ns | 0.0115 ns |           - |           - |           - |                   - |
          FromDecimal | 12.5632 ns | 0.0760 ns | 0.0674 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  8.5355 ns | 0.0528 ns | 0.0494 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6733 ns | 0.0133 ns | 0.0125 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.5720 ns | 0.0146 ns | 0.0136 ns |           - |           - |           - |                   - |
           FromObject |  2.7024 ns | 0.0149 ns | 0.0140 ns |           - |           - |           - |                   - |
           FromString |  1.7564 ns | 0.0098 ns | 0.0091 ns |           - |           - |           - |                   - |
             FromEnum |  1.6661 ns | 0.0157 ns | 0.0147 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.8731 ns | 0.0109 ns | 0.0097 ns |           - |           - |           - |                   - |
