
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |   3.722 ns | 0.0387 ns | 0.0362 ns |           - |           - |           - |                   - |
     FromBoolNullable |   2.327 ns | 0.0260 ns | 0.0243 ns |           - |           - |           - |                   - |
             FromChar |   6.331 ns | 0.0570 ns | 0.0534 ns |      0.0051 |           - |           - |                32 B |
     FromCharNullable |   2.340 ns | 0.0151 ns | 0.0142 ns |           - |           - |           - |                   - |
            FromSByte |  30.913 ns | 0.1489 ns | 0.1393 ns |      0.0051 |           - |           - |                32 B |
    FromSByteNullable |   2.514 ns | 0.0239 ns | 0.0224 ns |           - |           - |           - |                   - |
             FromByte |  30.778 ns | 0.1981 ns | 0.1756 ns |      0.0051 |           - |           - |                32 B |
     FromByteNullable |   2.775 ns | 0.0201 ns | 0.0188 ns |           - |           - |           - |                   - |
            FromShort |  31.064 ns | 0.1534 ns | 0.1435 ns |      0.0051 |           - |           - |                32 B |
    FromShortNullable |   2.457 ns | 0.0119 ns | 0.0106 ns |           - |           - |           - |                   - |
           FromUShort |  30.557 ns | 0.1517 ns | 0.1419 ns |      0.0051 |           - |           - |                32 B |
   FromUShortNullable |   2.723 ns | 0.0234 ns | 0.0208 ns |           - |           - |           - |                   - |
              FromInt |  30.367 ns | 0.2680 ns | 0.2507 ns |      0.0051 |           - |           - |                32 B |
      FromIntNullable |   2.258 ns | 0.0188 ns | 0.0176 ns |           - |           - |           - |                   - |
             FromUInt |  29.319 ns | 0.2882 ns | 0.2696 ns |      0.0051 |           - |           - |                32 B |
     FromUIntNullable |   2.822 ns | 0.0326 ns | 0.0305 ns |           - |           - |           - |                   - |
             FromLong |  31.376 ns | 0.2065 ns | 0.1932 ns |      0.0051 |           - |           - |                32 B |
     FromLongNullable |   2.641 ns | 0.0239 ns | 0.0224 ns |           - |           - |           - |                   - |
            FromULong |  29.609 ns | 0.0772 ns | 0.0645 ns |      0.0051 |           - |           - |                32 B |
    FromULongNullable |   2.849 ns | 0.0268 ns | 0.0250 ns |           - |           - |           - |                   - |
            FromFloat |  89.696 ns | 0.4337 ns | 0.4057 ns |      0.0050 |           - |           - |                32 B |
    FromFloatNullable |   2.496 ns | 0.0249 ns | 0.0233 ns |           - |           - |           - |                   - |
           FromDouble |  97.338 ns | 0.6934 ns | 0.6486 ns |      0.0050 |           - |           - |                32 B |
   FromDoubleNullable |   2.818 ns | 0.0222 ns | 0.0208 ns |           - |           - |           - |                   - |
          FromDecimal |  46.241 ns | 0.1388 ns | 0.1299 ns |      0.0051 |           - |           - |                32 B |
  FromDecimalNullable |   8.728 ns | 0.0654 ns | 0.0612 ns |           - |           - |           - |                   - |
         FromDateTime | 303.438 ns | 1.3089 ns | 1.2243 ns |      0.0300 |           - |           - |               192 B |
 FromDateTimeNullable |   3.018 ns | 0.0186 ns | 0.0174 ns |           - |           - |           - |                   - |
           FromObject |   2.924 ns | 0.0381 ns | 0.0356 ns |           - |           - |           - |                   - |
           FromString |   2.142 ns | 0.0171 ns | 0.0160 ns |           - |           - |           - |                   - |
             FromEnum | 306.860 ns | 1.7910 ns | 1.6753 ns |      0.0162 |           - |           - |               104 B |
     FromEnumNullable |   2.179 ns | 0.0161 ns | 0.0142 ns |           - |           - |           - |                   - |
