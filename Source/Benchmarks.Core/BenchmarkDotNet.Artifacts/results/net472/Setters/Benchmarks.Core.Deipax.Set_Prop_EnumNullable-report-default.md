
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool | 19.1937 ns | 0.0109 ns | 0.0102 ns |           - |           - |           - |                   - |
     FromBoolNullable | 20.2869 ns | 0.1685 ns | 0.1576 ns |           - |           - |           - |                   - |
             FromChar | 19.2342 ns | 0.2065 ns | 0.1932 ns |           - |           - |           - |                   - |
     FromCharNullable | 20.1433 ns | 0.1636 ns | 0.1530 ns |           - |           - |           - |                   - |
            FromSByte | 19.3107 ns | 0.2018 ns | 0.1888 ns |           - |           - |           - |                   - |
    FromSByteNullable | 20.3246 ns | 0.2092 ns | 0.1957 ns |           - |           - |           - |                   - |
             FromByte | 19.3864 ns | 0.1743 ns | 0.1630 ns |           - |           - |           - |                   - |
     FromByteNullable | 20.4131 ns | 0.2339 ns | 0.2188 ns |           - |           - |           - |                   - |
            FromShort | 19.4004 ns | 0.1552 ns | 0.1452 ns |           - |           - |           - |                   - |
    FromShortNullable | 20.1418 ns | 0.1644 ns | 0.1457 ns |           - |           - |           - |                   - |
           FromUShort | 19.2295 ns | 0.1766 ns | 0.1652 ns |           - |           - |           - |                   - |
   FromUShortNullable | 20.0859 ns | 0.0475 ns | 0.0422 ns |           - |           - |           - |                   - |
              FromInt | 19.0775 ns | 0.0516 ns | 0.0458 ns |           - |           - |           - |                   - |
      FromIntNullable | 20.1047 ns | 0.0347 ns | 0.0325 ns |           - |           - |           - |                   - |
             FromUInt | 19.8408 ns | 0.1513 ns | 0.1341 ns |           - |           - |           - |                   - |
     FromUIntNullable | 20.5949 ns | 0.2692 ns | 0.2387 ns |           - |           - |           - |                   - |
             FromLong | 18.8542 ns | 0.0980 ns | 0.0869 ns |           - |           - |           - |                   - |
     FromLongNullable | 20.3581 ns | 0.1390 ns | 0.1300 ns |           - |           - |           - |                   - |
            FromULong | 18.7363 ns | 0.0805 ns | 0.0713 ns |           - |           - |           - |                   - |
    FromULongNullable | 20.3973 ns | 0.0906 ns | 0.0848 ns |           - |           - |           - |                   - |
            FromFloat | 21.1528 ns | 0.1153 ns | 0.1079 ns |           - |           - |           - |                   - |
    FromFloatNullable | 21.2114 ns | 0.0573 ns | 0.0479 ns |           - |           - |           - |                   - |
           FromDouble | 20.8575 ns | 0.0905 ns | 0.0846 ns |           - |           - |           - |                   - |
   FromDoubleNullable | 21.8253 ns | 0.0887 ns | 0.0830 ns |           - |           - |           - |                   - |
          FromDecimal | 28.7740 ns | 0.1829 ns | 0.1711 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 32.6130 ns | 0.1484 ns | 0.1388 ns |           - |           - |           - |                   - |
         FromDateTime | 13.5237 ns | 0.0596 ns | 0.0529 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  8.3999 ns | 0.0588 ns | 0.0550 ns |           - |           - |           - |                   - |
           FromObject | 13.1831 ns | 0.0447 ns | 0.0418 ns |           - |           - |           - |                   - |
           FromString | 29.0118 ns | 0.0908 ns | 0.0849 ns |           - |           - |           - |                   - |
             FromEnum |  0.4061 ns | 0.0117 ns | 0.0110 ns |           - |           - |           - |                   - |
     FromEnumNullable |  0.6123 ns | 0.0136 ns | 0.0127 ns |           - |           - |           - |                   - |
