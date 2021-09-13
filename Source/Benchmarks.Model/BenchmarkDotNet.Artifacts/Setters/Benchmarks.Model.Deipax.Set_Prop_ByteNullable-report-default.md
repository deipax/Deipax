
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.8825 ns | 0.4451 ns | 0.0244 ns |  0.8932 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.9723 ns | 0.0858 ns | 0.0047 ns |  0.9734 ns |  1.10 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.2166 ns | 0.9586 ns | 0.0525 ns |  1.2100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.4696 ns | 0.8162 ns | 0.0447 ns |  1.4492 ns |  1.21 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.7694 ns | 0.6317 ns | 0.0346 ns |  0.7759 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7350 ns | 0.7333 ns | 0.0402 ns |  0.7274 ns |  0.96 |    0.09 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.1857 ns | 0.2420 ns | 0.0133 ns |  1.1895 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.3035 ns | 0.1464 ns | 0.0080 ns |  1.3015 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.9339 ns | 0.4868 ns | 0.0267 ns |  0.9491 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.7220 ns | 0.4351 ns | 0.0238 ns |  0.7130 ns |  0.77 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.2008 ns | 0.0836 ns | 0.0046 ns |  1.2007 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.1418 ns | 0.8361 ns | 0.0458 ns |  1.1157 ns |  0.95 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.6472 ns | 0.2574 ns | 0.0141 ns |  0.6502 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7689 ns | 0.3221 ns | 0.0177 ns |  0.7595 ns |  1.19 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  0.8964 ns | 0.0716 ns | 0.0039 ns |  0.8973 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  0.7833 ns | 0.8767 ns | 0.0481 ns |  0.7965 ns |  0.87 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  1.9715 ns | 0.1120 ns | 0.0061 ns |  1.9690 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.9905 ns | 0.4243 ns | 0.0233 ns |  0.9859 ns |  0.50 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  2.4152 ns | 0.3553 ns | 0.0195 ns |  2.4051 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.2659 ns | 0.7293 ns | 0.0400 ns |  1.2492 ns |  0.52 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.8997 ns | 0.7075 ns | 0.0388 ns |  0.8813 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.9971 ns | 0.4933 ns | 0.0270 ns |  0.9895 ns |  1.11 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.1713 ns | 0.1481 ns | 0.0081 ns |  1.1689 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.2920 ns | 0.4973 ns | 0.0273 ns |  1.2838 ns |  1.10 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  1.7707 ns | 0.7758 ns | 0.0425 ns |  1.7478 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.8009 ns | 0.0899 ns | 0.0049 ns |  0.8007 ns |  0.45 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  2.3141 ns | 0.9602 ns | 0.0526 ns |  2.3157 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.2643 ns | 0.0408 ns | 0.0022 ns |  1.2648 ns |  0.55 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.9445 ns | 0.7226 ns | 0.0396 ns |  0.9277 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.9422 ns | 0.4177 ns | 0.0229 ns |  0.9295 ns |  1.00 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.2203 ns | 0.7532 ns | 0.0413 ns |  1.2021 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.2058 ns | 0.5506 ns | 0.0302 ns |  1.1911 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  2.1911 ns | 0.6318 ns | 0.0346 ns |  2.1750 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  2.1309 ns | 0.0625 ns | 0.0034 ns |  2.1316 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.4203 ns | 1.0568 ns | 0.0579 ns |  3.3958 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  3.6361 ns | 0.7015 ns | 0.0385 ns |  3.6469 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  1.9513 ns | 0.0117 ns | 0.0006 ns |  1.9517 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  1.9390 ns | 0.8340 ns | 0.0457 ns |  1.9614 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  3.0732 ns | 0.5670 ns | 0.0311 ns |  3.0561 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  2.9668 ns | 1.1331 ns | 0.0621 ns |  2.9746 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  4.2571 ns | 2.6153 ns | 0.1434 ns |  4.1881 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  3.6299 ns | 0.9388 ns | 0.0515 ns |  3.6194 ns |  0.85 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  4.8545 ns | 1.4344 ns | 0.0786 ns |  4.8360 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  3.8253 ns | 1.7711 ns | 0.0971 ns |  3.7805 ns |  0.79 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  3.9864 ns | 1.1290 ns | 0.0619 ns |  3.9973 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  3.4517 ns | 2.3049 ns | 0.1263 ns |  3.4838 ns |  0.87 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  5.2008 ns | 3.2095 ns | 0.1759 ns |  5.1826 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  4.1381 ns | 0.7703 ns | 0.0422 ns |  4.1377 ns |  0.80 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  7.9037 ns | 0.1317 ns | 0.0072 ns |  7.9071 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  9.0608 ns | 2.6560 ns | 0.1456 ns |  9.1115 ns |  1.15 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 13.7331 ns | 1.4556 ns | 0.0798 ns | 13.7255 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 10.6070 ns | 3.4714 ns | 0.1903 ns | 10.6993 ns |  0.77 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.6797 ns | 0.5832 ns | 0.0320 ns |  0.6630 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7812 ns | 0.1556 ns | 0.0085 ns |  0.7785 ns |  1.15 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.6430 ns | 0.7967 ns | 0.0437 ns |  1.6576 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2377 ns | 0.8575 ns | 0.0470 ns |  1.2208 ns |  0.75 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.6181 ns | 1.5723 ns | 0.0862 ns | 12.6314 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.1674 ns | 1.3882 ns | 0.0761 ns | 11.1402 ns |  0.89 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  9.3628 ns | 1.3040 ns | 0.0715 ns |  9.3311 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  8.4561 ns | 0.0412 ns | 0.0023 ns |  8.4564 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  1.7917 ns | 1.0168 ns | 0.0557 ns |  1.7650 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.9887 ns | 0.5986 ns | 0.0328 ns |  1.0016 ns |  0.55 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  2.9041 ns | 1.9049 ns | 0.1044 ns |  2.8466 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.2824 ns | 0.9363 ns | 0.0513 ns |  1.2762 ns |  0.44 |    0.01 |     - |     - |     - |         - |
