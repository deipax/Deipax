
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 0.9264 ns | 0.6900 ns | 0.0378 ns | 0.9423 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.7311 ns | 0.1030 ns | 0.0056 ns | 0.7318 ns |  0.79 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.1809 ns | 0.8901 ns | 0.0488 ns | 1.1563 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.2065 ns | 0.5395 ns | 0.0296 ns | 1.2023 ns |  1.02 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.8074 ns | 1.5103 ns | 0.0828 ns | 0.8275 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.6428 ns | 0.5072 ns | 0.0278 ns | 0.6406 ns |  0.80 |    0.12 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.2112 ns | 1.3436 ns | 0.0736 ns | 1.1831 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.1069 ns | 0.0460 ns | 0.0025 ns | 1.1059 ns |  0.92 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.9193 ns | 0.4956 ns | 0.0272 ns | 0.9291 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.7536 ns | 1.7558 ns | 0.0962 ns | 0.7877 ns |  0.82 |    0.13 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 0.9895 ns | 0.2229 ns | 0.0122 ns | 0.9826 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.0355 ns | 1.1539 ns | 0.0633 ns | 1.0245 ns |  1.05 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.6603 ns | 0.4013 ns | 0.0220 ns | 0.6522 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.5554 ns | 0.3937 ns | 0.0216 ns | 0.5477 ns |  0.84 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 0.8929 ns | 0.2052 ns | 0.0112 ns | 0.8866 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 0.5861 ns | 0.5641 ns | 0.0309 ns | 0.5714 ns |  0.66 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 1.9814 ns | 0.4849 ns | 0.0266 ns | 1.9894 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.7439 ns | 0.4772 ns | 0.0262 ns | 0.7360 ns |  0.38 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.7236 ns | 0.7380 ns | 0.0405 ns | 1.7221 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.1818 ns | 0.4119 ns | 0.0226 ns | 1.1726 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.8758 ns | 0.1832 ns | 0.0100 ns | 0.8806 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.7398 ns | 0.1549 ns | 0.0085 ns | 0.7415 ns |  0.84 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.1866 ns | 0.7100 ns | 0.0389 ns | 1.1723 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.2837 ns | 0.7438 ns | 0.0408 ns | 1.2793 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 1.7514 ns | 0.3232 ns | 0.0177 ns | 1.7510 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.9629 ns | 2.9605 ns | 0.1623 ns | 1.0447 ns |  0.55 |    0.09 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.7035 ns | 0.4940 ns | 0.0271 ns | 1.6912 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.1083 ns | 0.1636 ns | 0.0090 ns | 1.1099 ns |  0.65 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.9777 ns | 0.1916 ns | 0.0105 ns | 0.9722 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.9826 ns | 0.5008 ns | 0.0275 ns | 0.9745 ns |  1.01 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.1539 ns | 0.4290 ns | 0.0235 ns | 1.1469 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.2419 ns | 0.1140 ns | 0.0062 ns | 1.2388 ns |  1.08 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 2.1810 ns | 0.6555 ns | 0.0359 ns | 2.1622 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 2.0195 ns | 1.9246 ns | 0.1055 ns | 1.9848 ns |  0.93 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 1.9189 ns | 1.0045 ns | 0.0551 ns | 1.8966 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.8270 ns | 0.5604 ns | 0.0307 ns | 1.8403 ns |  0.95 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 1.9950 ns | 1.1472 ns | 0.0629 ns | 1.9589 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 1.7601 ns | 0.8376 ns | 0.0459 ns | 1.7589 ns |  0.88 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.9829 ns | 0.8501 ns | 0.0466 ns | 1.9871 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.7867 ns | 0.1987 ns | 0.0109 ns | 1.7930 ns |  0.90 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 4.0742 ns | 0.2736 ns | 0.0150 ns | 4.0734 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 3.9069 ns | 5.0191 ns | 0.2751 ns | 3.7796 ns |  0.96 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 1.7709 ns | 0.2236 ns | 0.0123 ns | 1.7652 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.8065 ns | 0.0790 ns | 0.0043 ns | 1.8049 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 4.2427 ns | 0.1940 ns | 0.0106 ns | 4.2461 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 3.2601 ns | 1.2918 ns | 0.0708 ns | 3.2812 ns |  0.77 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 2.1619 ns | 1.7744 ns | 0.0973 ns | 2.2005 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 1.9992 ns | 0.3268 ns | 0.0179 ns | 1.9962 ns |  0.93 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 7.1346 ns | 0.6933 ns | 0.0380 ns | 7.1254 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 9.0614 ns | 2.2551 ns | 0.1236 ns | 9.1249 ns |  1.27 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 2.6399 ns | 0.2233 ns | 0.0122 ns | 2.6370 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.3593 ns | 0.6899 ns | 0.0378 ns | 2.3593 ns |  0.89 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.7579 ns | 0.1488 ns | 0.0082 ns | 0.7616 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.7671 ns | 0.2390 ns | 0.0131 ns | 0.7633 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.7133 ns | 2.1467 ns | 0.1177 ns | 1.7574 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.1899 ns | 0.2730 ns | 0.0150 ns | 1.1874 ns |  0.70 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 2.8040 ns | 1.2241 ns | 0.0671 ns | 2.8320 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.8864 ns | 3.9902 ns | 0.2187 ns | 2.9509 ns |  1.03 |    0.08 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.9552 ns | 0.9464 ns | 0.0519 ns | 1.9340 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 2.0596 ns | 6.0866 ns | 0.3336 ns | 1.8966 ns |  1.05 |    0.18 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 1.9628 ns | 0.3923 ns | 0.0215 ns | 1.9730 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.9947 ns | 0.5575 ns | 0.0306 ns | 0.9828 ns |  0.51 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.7370 ns | 0.8086 ns | 0.0443 ns | 1.7529 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.2447 ns | 0.0398 ns | 0.0022 ns | 1.2452 ns |  0.72 |    0.02 |     - |     - |     - |         - |
