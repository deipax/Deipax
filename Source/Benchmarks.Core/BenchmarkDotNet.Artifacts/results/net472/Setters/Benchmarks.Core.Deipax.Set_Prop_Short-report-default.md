
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.8409 ns | 0.0163 ns | 0.0153 ns |           - |           - |           - |                   - |
     FromBoolNullable |  1.5120 ns | 0.0137 ns | 0.0129 ns |           - |           - |           - |                   - |
             FromChar |  1.5772 ns | 0.0145 ns | 0.0136 ns |           - |           - |           - |                   - |
     FromCharNullable |  2.1916 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
            FromSByte |  0.4033 ns | 0.0069 ns | 0.0064 ns |           - |           - |           - |                   - |
    FromSByteNullable |  1.6431 ns | 0.0181 ns | 0.0169 ns |           - |           - |           - |                   - |
             FromByte |  0.4024 ns | 0.0057 ns | 0.0053 ns |           - |           - |           - |                   - |
     FromByteNullable |  1.6294 ns | 0.0113 ns | 0.0100 ns |           - |           - |           - |                   - |
            FromShort |  0.4054 ns | 0.0063 ns | 0.0059 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.3812 ns | 0.0557 ns | 0.0684 ns |           - |           - |           - |                   - |
           FromUShort |  1.7620 ns | 0.0598 ns | 0.0664 ns |           - |           - |           - |                   - |
   FromUShortNullable |  2.1479 ns | 0.0153 ns | 0.0128 ns |           - |           - |           - |                   - |
              FromInt |  1.5285 ns | 0.0088 ns | 0.0074 ns |           - |           - |           - |                   - |
      FromIntNullable |  2.1623 ns | 0.0129 ns | 0.0121 ns |           - |           - |           - |                   - |
             FromUInt |  1.5192 ns | 0.0108 ns | 0.0096 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.0390 ns | 0.0242 ns | 0.0227 ns |           - |           - |           - |                   - |
             FromLong |  1.5309 ns | 0.0118 ns | 0.0110 ns |           - |           - |           - |                   - |
     FromLongNullable |  2.8386 ns | 0.0237 ns | 0.0221 ns |           - |           - |           - |                   - |
            FromULong |  1.4701 ns | 0.0100 ns | 0.0089 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.6037 ns | 0.0208 ns | 0.0194 ns |           - |           - |           - |                   - |
            FromFloat |  3.6394 ns | 0.0425 ns | 0.0398 ns |           - |           - |           - |                   - |
    FromFloatNullable |  3.9343 ns | 0.0349 ns | 0.0327 ns |           - |           - |           - |                   - |
           FromDouble |  3.2058 ns | 0.0235 ns | 0.0220 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  4.4809 ns | 0.0264 ns | 0.0220 ns |           - |           - |           - |                   - |
          FromDecimal | 13.1061 ns | 0.0617 ns | 0.0547 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 23.0945 ns | 0.1354 ns | 0.1266 ns |           - |           - |           - |                   - |
         FromDateTime |  0.4235 ns | 0.0090 ns | 0.0084 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3393 ns | 0.0078 ns | 0.0073 ns |           - |           - |           - |                   - |
           FromObject |  2.1021 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
           FromString | 43.9453 ns | 0.1436 ns | 0.1343 ns |           - |           - |           - |                   - |
             FromEnum |  1.5645 ns | 0.0148 ns | 0.0139 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.0249 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
