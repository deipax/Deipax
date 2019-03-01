
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |   3.472 ns | 0.0350 ns | 0.0327 ns |           - |           - |           - |                   - |
     FromBoolNullable |   1.931 ns | 0.0134 ns | 0.0125 ns |           - |           - |           - |                   - |
             FromChar |   6.553 ns | 0.0521 ns | 0.0487 ns |      0.0051 |           - |           - |                32 B |
     FromCharNullable |   6.927 ns | 0.0567 ns | 0.0531 ns |      0.0051 |           - |           - |                32 B |
            FromSByte |  31.209 ns | 0.1396 ns | 0.1238 ns |      0.0051 |           - |           - |                32 B |
    FromSByteNullable |  32.583 ns | 0.1857 ns | 0.1551 ns |      0.0051 |           - |           - |                32 B |
             FromByte |  37.242 ns | 0.1565 ns | 0.1387 ns |      0.0051 |           - |           - |                32 B |
     FromByteNullable |  32.775 ns | 0.1851 ns | 0.1731 ns |      0.0051 |           - |           - |                32 B |
            FromShort |  31.873 ns | 0.2014 ns | 0.1884 ns |      0.0051 |           - |           - |                32 B |
    FromShortNullable |  38.607 ns | 0.1799 ns | 0.1682 ns |      0.0051 |           - |           - |                32 B |
           FromUShort |  31.155 ns | 0.2576 ns | 0.2410 ns |      0.0051 |           - |           - |                32 B |
   FromUShortNullable |  31.916 ns | 0.1711 ns | 0.1517 ns |      0.0051 |           - |           - |                32 B |
              FromInt |  31.012 ns | 0.1402 ns | 0.1312 ns |      0.0051 |           - |           - |                32 B |
      FromIntNullable |  32.305 ns | 0.2183 ns | 0.2042 ns |      0.0051 |           - |           - |                32 B |
             FromUInt |  36.291 ns | 0.1729 ns | 0.1532 ns |      0.0051 |           - |           - |                32 B |
     FromUIntNullable |  38.153 ns | 0.1978 ns | 0.1850 ns |      0.0051 |           - |           - |                32 B |
             FromLong |  31.748 ns | 0.1900 ns | 0.1777 ns |      0.0051 |           - |           - |                32 B |
     FromLongNullable |  33.514 ns | 0.1583 ns | 0.1481 ns |      0.0051 |           - |           - |                32 B |
            FromULong |  30.021 ns | 0.2100 ns | 0.1965 ns |      0.0051 |           - |           - |                32 B |
    FromULongNullable |  32.401 ns | 0.2998 ns | 0.2804 ns |      0.0051 |           - |           - |                32 B |
            FromFloat | 264.236 ns | 2.0623 ns | 1.9291 ns |      0.0048 |           - |           - |                32 B |
    FromFloatNullable | 263.191 ns | 1.5339 ns | 1.4348 ns |      0.0048 |           - |           - |                32 B |
           FromDouble | 286.146 ns | 1.8824 ns | 1.7608 ns |      0.0048 |           - |           - |                32 B |
   FromDoubleNullable | 281.925 ns | 1.8790 ns | 1.7576 ns |      0.0048 |           - |           - |                32 B |
          FromDecimal |  49.850 ns | 0.2271 ns | 0.2014 ns |      0.0051 |           - |           - |                32 B |
  FromDecimalNullable |  62.980 ns | 0.2810 ns | 0.2629 ns |      0.0051 |           - |           - |                32 B |
         FromDateTime | 307.476 ns | 2.5489 ns | 2.3842 ns |      0.0300 |           - |           - |               192 B |
 FromDateTimeNullable |   3.043 ns | 0.0175 ns | 0.0146 ns |           - |           - |           - |                   - |
           FromObject |   2.689 ns | 0.0243 ns | 0.0227 ns |           - |           - |           - |                   - |
           FromString |   1.938 ns | 0.0168 ns | 0.0157 ns |           - |           - |           - |                   - |
             FromEnum | 271.695 ns | 2.1220 ns | 1.9849 ns |      0.0114 |           - |           - |                72 B |
     FromEnumNullable | 271.821 ns | 2.1694 ns | 1.9231 ns |      0.0114 |           - |           - |                72 B |
