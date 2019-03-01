
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


               Method |      Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------- |----------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             FromBool |  7.159 ns | 0.0592 ns | 0.0554 ns |           - |           - |           - |                   - |
     FromBoolNullable |  7.371 ns | 0.0571 ns | 0.0535 ns |           - |           - |           - |                   - |
             FromChar |  7.064 ns | 0.0679 ns | 0.0635 ns |           - |           - |           - |                   - |
     FromCharNullable | 10.867 ns | 0.0698 ns | 0.0653 ns |           - |           - |           - |                   - |
            FromSByte |  7.174 ns | 0.0504 ns | 0.0471 ns |           - |           - |           - |                   - |
    FromSByteNullable |  7.504 ns | 0.0391 ns | 0.0366 ns |           - |           - |           - |                   - |
             FromByte |  7.219 ns | 0.0306 ns | 0.0287 ns |           - |           - |           - |                   - |
     FromByteNullable |  7.573 ns | 0.0561 ns | 0.0525 ns |           - |           - |           - |                   - |
            FromShort | 10.740 ns | 0.0493 ns | 0.0461 ns |           - |           - |           - |                   - |
    FromShortNullable |  7.122 ns | 0.0430 ns | 0.0402 ns |           - |           - |           - |                   - |
           FromUShort |  7.147 ns | 0.0521 ns | 0.0487 ns |           - |           - |           - |                   - |
   FromUShortNullable |  7.316 ns | 0.0477 ns | 0.0446 ns |           - |           - |           - |                   - |
              FromInt |  7.022 ns | 0.0766 ns | 0.0716 ns |           - |           - |           - |                   - |
      FromIntNullable |  7.351 ns | 0.0730 ns | 0.0683 ns |           - |           - |           - |                   - |
             FromUInt |  7.128 ns | 0.0472 ns | 0.0441 ns |           - |           - |           - |                   - |
     FromUIntNullable |  7.511 ns | 0.0383 ns | 0.0320 ns |           - |           - |           - |                   - |
             FromLong |  7.161 ns | 0.0598 ns | 0.0559 ns |           - |           - |           - |                   - |
     FromLongNullable |  7.609 ns | 0.0492 ns | 0.0460 ns |           - |           - |           - |                   - |
            FromULong |  7.189 ns | 0.0565 ns | 0.0529 ns |           - |           - |           - |                   - |
    FromULongNullable |  7.810 ns | 0.0484 ns | 0.0429 ns |           - |           - |           - |                   - |
            FromFloat |  7.505 ns | 0.0404 ns | 0.0358 ns |           - |           - |           - |                   - |
    FromFloatNullable |  7.599 ns | 0.0753 ns | 0.0704 ns |           - |           - |           - |                   - |
           FromDouble |  7.560 ns | 0.0474 ns | 0.0420 ns |           - |           - |           - |                   - |
   FromDoubleNullable |  7.720 ns | 0.0409 ns | 0.0383 ns |           - |           - |           - |                   - |
          FromDecimal |  8.031 ns | 0.0456 ns | 0.0426 ns |           - |           - |           - |                   - |
  FromDecimalNullable |  7.843 ns | 0.0419 ns | 0.0392 ns |           - |           - |           - |                   - |
         FromDateTime |  4.589 ns | 0.0364 ns | 0.0340 ns |           - |           - |           - |                   - |
 FromDateTimeNullable |  1.376 ns | 0.0245 ns | 0.0229 ns |           - |           - |           - |                   - |
           FromObject |  8.194 ns | 0.0543 ns | 0.0508 ns |           - |           - |           - |                   - |
           FromString |  7.640 ns | 0.0465 ns | 0.0435 ns |           - |           - |           - |                   - |
             FromEnum |  7.390 ns | 0.0282 ns | 0.0250 ns |           - |           - |           - |                   - |
     FromEnumNullable |  7.538 ns | 0.0493 ns | 0.0461 ns |           - |           - |           - |                   - |
