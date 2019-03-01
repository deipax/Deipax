
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |       Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |-----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  0.6002 ns | 0.0163 ns | 0.0144 ns |           - |           - |           - |                   - |
     FromBoolNullable |  2.0402 ns | 0.0489 ns | 0.0457 ns |           - |           - |           - |                   - |
             FromChar |  1.8276 ns | 0.0424 ns | 0.0354 ns |           - |           - |           - |                   - |
     FromCharNullable |  2.7311 ns | 0.0442 ns | 0.0414 ns |           - |           - |           - |                   - |
            FromSByte |  0.5396 ns | 0.0122 ns | 0.0108 ns |           - |           - |           - |                   - |
    FromSByteNullable |  0.5093 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
             FromByte |  1.6475 ns | 0.0228 ns | 0.0214 ns |           - |           - |           - |                   - |
     FromByteNullable |  2.8707 ns | 0.0266 ns | 0.0249 ns |           - |           - |           - |                   - |
            FromShort |  1.7818 ns | 0.0134 ns | 0.0118 ns |           - |           - |           - |                   - |
    FromShortNullable |  2.9153 ns | 0.0631 ns | 0.0559 ns |           - |           - |           - |                   - |
           FromUShort |  1.7991 ns | 0.0073 ns | 0.0065 ns |           - |           - |           - |                   - |
   FromUShortNullable |  2.7410 ns | 0.0087 ns | 0.0082 ns |           - |           - |           - |                   - |
              FromInt |  1.6947 ns | 0.0131 ns | 0.0123 ns |           - |           - |           - |                   - |
      FromIntNullable |  3.1266 ns | 0.0130 ns | 0.0108 ns |           - |           - |           - |                   - |
             FromUInt |  1.7005 ns | 0.0134 ns | 0.0125 ns |           - |           - |           - |                   - |
     FromUIntNullable |  2.8789 ns | 0.0195 ns | 0.0182 ns |           - |           - |           - |                   - |
             FromLong |  1.7372 ns | 0.0081 ns | 0.0072 ns |           - |           - |           - |                   - |
     FromLongNullable |  3.1876 ns | 0.0479 ns | 0.0448 ns |           - |           - |           - |                   - |
            FromULong |  1.7903 ns | 0.0280 ns | 0.0262 ns |           - |           - |           - |                   - |
    FromULongNullable |  3.1937 ns | 0.0206 ns | 0.0182 ns |           - |           - |           - |                   - |
            FromFloat |  3.9517 ns | 0.0178 ns | 0.0149 ns |           - |           - |           - |                   - |
    FromFloatNullable |  4.6464 ns | 0.0101 ns | 0.0085 ns |           - |           - |           - |                   - |
           FromDouble |  3.7491 ns | 0.0396 ns | 0.0370 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  5.2167 ns | 0.0327 ns | 0.0290 ns |           - |           - |           - |                   - |
          FromDecimal | 14.0648 ns | 0.0534 ns | 0.0500 ns |           - |           - |           - |                   - |
  FromDecimalNullable | 24.8785 ns | 0.0366 ns | 0.0324 ns |           - |           - |           - |                   - |
         FromDateTime |  0.7133 ns | 0.0027 ns | 0.0025 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.6667 ns | 0.0319 ns | 0.0298 ns |           - |           - |           - |                   - |
           FromObject | 13.1338 ns | 0.2784 ns | 0.2979 ns |           - |           - |           - |                   - |
           FromString | 46.1939 ns | 0.6896 ns | 0.6450 ns |           - |           - |           - |                   - |
             FromEnum |  1.6616 ns | 0.0185 ns | 0.0173 ns |           - |           - |           - |                   - |
     FromEnumNullable |  2.7146 ns | 0.0204 ns | 0.0191 ns |           - |           - |           - |                   - |
