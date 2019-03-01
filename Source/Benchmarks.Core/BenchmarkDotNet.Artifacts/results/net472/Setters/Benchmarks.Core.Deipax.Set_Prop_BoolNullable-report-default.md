
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6752 ns | 0.0184 ns | 0.0172 ns |           - |           - |           - |                   - |
     FromBoolNullable |  0.6684 ns | 0.0069 ns | 0.0061 ns |           - |           - |           - |                   - |
             FromChar |  0.6798 ns | 0.0108 ns | 0.0096 ns |           - |           - |           - |                   - |
     FromCharNullable |  0.8709 ns | 0.0145 ns | 0.0135 ns |           - |           - |           - |                   - |
            FromSByte |  0.6840 ns | 0.0084 ns | 0.0078 ns |           - |           - |           - |                   - |
    FromSByteNullable |  2.3634 ns | 0.0141 ns | 0.0132 ns |           - |           - |           - |                   - |
             FromByte |  0.6859 ns | 0.0111 ns | 0.0098 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.2272 ns | 0.0702 ns | 0.0720 ns |           - |           - |           - |                   - |
            FromShort |  1.3927 ns | 0.0399 ns | 0.0373 ns |           - |           - |           - |                   - |
    FromShortNullable |  1.9668 ns | 0.0396 ns | 0.0370 ns |           - |           - |           - |                   - |
           FromUShort |  0.9557 ns | 0.0146 ns | 0.0137 ns |           - |           - |           - |                   - |
   FromUShortNullable |  1.9573 ns | 0.0235 ns | 0.0220 ns |           - |           - |           - |                   - |
              FromInt |  0.6897 ns | 0.0145 ns | 0.0135 ns |           - |           - |           - |                   - |
      FromIntNullable |  1.9455 ns | 0.0144 ns | 0.0135 ns |           - |           - |           - |                   - |
             FromUInt |  0.6408 ns | 0.0165 ns | 0.0154 ns |           - |           - |           - |                   - |
     FromUIntNullable |  1.9703 ns | 0.0148 ns | 0.0138 ns |           - |           - |           - |                   - |
             FromLong |  0.6422 ns | 0.0112 ns | 0.0100 ns |           - |           - |           - |                   - |
     FromLongNullable |  1.9976 ns | 0.0103 ns | 0.0086 ns |           - |           - |           - |                   - |
            FromULong |  0.6590 ns | 0.0126 ns | 0.0118 ns |           - |           - |           - |                   - |
    FromULongNullable |  2.0205 ns | 0.0172 ns | 0.0160 ns |           - |           - |           - |                   - |
            FromFloat |  0.9272 ns | 0.0132 ns | 0.0124 ns |           - |           - |           - |                   - |
    FromFloatNullable |  2.1416 ns | 0.0454 ns | 0.0425 ns |           - |           - |           - |                   - |
           FromDouble |  0.8982 ns | 0.0284 ns | 0.0265 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  2.7001 ns | 0.0432 ns | 0.0383 ns |           - |           - |           - |                   - |
          FromDecimal |  8.0813 ns | 0.0643 ns | 0.0570 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 17.3317 ns | 0.1858 ns | 0.1738 ns |           - |           - |           - |                   - |
         FromDateTime |  0.6501 ns | 0.0137 ns | 0.0128 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.3630 ns | 0.0229 ns | 0.0214 ns |           - |           - |           - |                   - |
           FromObject | 12.7866 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
           FromString |  7.8679 ns | 0.0445 ns | 0.0395 ns |           - |           - |           - |                   - |
             FromEnum |  0.6572 ns | 0.0143 ns | 0.0134 ns |           - |           - |           - |                   - |
     FromEnumNullable |  1.8948 ns | 0.0286 ns | 0.0268 ns |           - |           - |           - |                   - |
