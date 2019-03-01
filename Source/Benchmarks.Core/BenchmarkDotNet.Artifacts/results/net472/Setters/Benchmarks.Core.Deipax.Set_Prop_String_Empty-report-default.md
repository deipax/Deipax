
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |   3.757 ns | 0.0447 ns | 0.0396 ns |           - |           - |           - |                   - |
     FromBoolNullable |   2.334 ns | 0.0246 ns | 0.0230 ns |           - |           - |           - |                   - |
             FromChar |   6.327 ns | 0.0538 ns | 0.0503 ns |      0.0051 |           - |           - |                32 B |
     FromCharNullable |   2.350 ns | 0.0160 ns | 0.0150 ns |           - |           - |           - |                   - |
            FromSByte |  30.831 ns | 0.1858 ns | 0.1647 ns |      0.0051 |           - |           - |                32 B |
    FromSByteNullable |   2.513 ns | 0.0255 ns | 0.0239 ns |           - |           - |           - |                   - |
             FromByte |  30.968 ns | 0.1889 ns | 0.1767 ns |      0.0051 |           - |           - |                32 B |
     FromByteNullable |   2.748 ns | 0.0185 ns | 0.0174 ns |           - |           - |           - |                   - |
            FromShort |  31.438 ns | 0.2566 ns | 0.2400 ns |      0.0051 |           - |           - |                32 B |
    FromShortNullable |   2.404 ns | 0.0317 ns | 0.0297 ns |           - |           - |           - |                   - |
           FromUShort |  30.414 ns | 0.2327 ns | 0.2177 ns |      0.0051 |           - |           - |                32 B |
   FromUShortNullable |   2.720 ns | 0.0344 ns | 0.0322 ns |           - |           - |           - |                   - |
              FromInt |  30.612 ns | 0.1825 ns | 0.1707 ns |      0.0051 |           - |           - |                32 B |
      FromIntNullable |   2.252 ns | 0.0169 ns | 0.0150 ns |           - |           - |           - |                   - |
             FromUInt |  28.917 ns | 0.2639 ns | 0.2468 ns |      0.0051 |           - |           - |                32 B |
     FromUIntNullable |   2.835 ns | 0.0274 ns | 0.0256 ns |           - |           - |           - |                   - |
             FromLong |  31.427 ns | 0.1960 ns | 0.1834 ns |      0.0051 |           - |           - |                32 B |
     FromLongNullable |   2.654 ns | 0.0218 ns | 0.0204 ns |           - |           - |           - |                   - |
            FromULong |  29.912 ns | 0.2056 ns | 0.1924 ns |      0.0051 |           - |           - |                32 B |
    FromULongNullable |   2.681 ns | 0.0224 ns | 0.0209 ns |           - |           - |           - |                   - |
            FromFloat |  89.783 ns | 0.6242 ns | 0.5839 ns |      0.0050 |           - |           - |                32 B |
    FromFloatNullable |   2.524 ns | 0.0345 ns | 0.0323 ns |           - |           - |           - |                   - |
           FromDouble |  96.766 ns | 0.3924 ns | 0.3670 ns |      0.0050 |           - |           - |                32 B |
   FromDoubleNullable |   3.107 ns | 0.0271 ns | 0.0240 ns |           - |           - |           - |                   - |
          FromDecimal |  47.018 ns | 0.2399 ns | 0.2244 ns |      0.0051 |           - |           - |                32 B |
  FromDecimalNullable |   8.710 ns | 0.0521 ns | 0.0462 ns |           - |           - |           - |                   - |
         FromDateTime | 302.105 ns | 2.6860 ns | 2.5125 ns |      0.0300 |           - |           - |               192 B |
 FromDateTimeNullable |   3.046 ns | 0.0543 ns | 0.0481 ns |           - |           - |           - |                   - |
           FromObject |   2.812 ns | 0.0258 ns | 0.0241 ns |           - |           - |           - |                   - |
           FromString |   2.141 ns | 0.0146 ns | 0.0137 ns |           - |           - |           - |                   - |
             FromEnum | 306.869 ns | 1.5463 ns | 1.4464 ns |      0.0162 |           - |           - |               104 B |
     FromEnumNullable |   2.175 ns | 0.0262 ns | 0.0245 ns |           - |           - |           - |                   - |
