
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.9887 ns | 0.2042 ns | 0.0112 ns |  0.9926 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.9527 ns | 0.6248 ns | 0.0342 ns |  0.9549 ns |  0.96 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.4839 ns | 0.5221 ns | 0.0286 ns |  1.4870 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.4499 ns | 0.4885 ns | 0.0268 ns |  1.4392 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.9507 ns | 0.2734 ns | 0.0150 ns |  0.9594 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7453 ns | 1.5668 ns | 0.0859 ns |  0.6989 ns |  0.78 |    0.08 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.2370 ns | 0.0578 ns | 0.0032 ns |  1.2386 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.1856 ns | 0.0924 ns | 0.0051 ns |  1.1854 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.9540 ns | 0.4023 ns | 0.0221 ns |  0.9581 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.7149 ns | 0.3077 ns | 0.0169 ns |  0.7145 ns |  0.75 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.0669 ns | 0.5742 ns | 0.0315 ns |  1.0757 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.0853 ns | 0.5875 ns | 0.0322 ns |  1.0852 ns |  1.02 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.7192 ns | 0.1268 ns | 0.0070 ns |  0.7178 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.6506 ns | 0.0190 ns | 0.0010 ns |  0.6511 ns |  0.90 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.0398 ns | 0.1811 ns | 0.0099 ns |  1.0412 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.0405 ns | 0.1691 ns | 0.0093 ns |  1.0365 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.7677 ns | 0.2145 ns | 0.0118 ns |  0.7682 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.6491 ns | 0.5241 ns | 0.0287 ns |  0.6564 ns |  0.85 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.2571 ns | 0.2742 ns | 0.0150 ns |  1.2576 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.2668 ns | 1.0078 ns | 0.0552 ns |  1.2553 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.8422 ns | 1.0059 ns | 0.0551 ns |  0.8550 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.6317 ns | 0.0844 ns | 0.0046 ns |  0.6296 ns |  0.75 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.2771 ns | 0.4302 ns | 0.0236 ns |  1.2798 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.3447 ns | 4.5580 ns | 0.2498 ns |  1.2144 ns |  1.05 |    0.19 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.7656 ns | 0.0872 ns | 0.0048 ns |  0.7671 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.7341 ns | 0.2446 ns | 0.0134 ns |  0.7305 ns |  0.96 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.1430 ns | 0.0671 ns | 0.0037 ns |  1.1424 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.2092 ns | 0.1542 ns | 0.0085 ns |  1.2106 ns |  1.06 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.6947 ns | 0.2919 ns | 0.0160 ns |  0.6898 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.7233 ns | 0.2720 ns | 0.0149 ns |  0.7227 ns |  1.04 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.1475 ns | 0.2344 ns | 0.0128 ns |  1.1443 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.1845 ns | 0.5838 ns | 0.0320 ns |  1.1946 ns |  1.03 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  0.7465 ns | 0.3154 ns | 0.0173 ns |  0.7463 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  1.1502 ns | 7.2687 ns | 0.3984 ns |  1.3606 ns |  1.53 |    0.51 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  1.2194 ns | 0.1359 ns | 0.0074 ns |  1.2195 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.2588 ns | 0.2393 ns | 0.0131 ns |  1.2541 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.8493 ns | 0.5182 ns | 0.0284 ns |  0.8608 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.7593 ns | 0.1182 ns | 0.0065 ns |  0.7560 ns |  0.89 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.8448 ns | 0.7982 ns | 0.0438 ns |  1.8196 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.7904 ns | 1.0794 ns | 0.0592 ns |  1.7979 ns |  0.97 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  2.1682 ns | 0.4585 ns | 0.0251 ns |  2.1659 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  2.1793 ns | 1.1121 ns | 0.0610 ns |  2.1451 ns |  1.01 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  2.6810 ns | 0.4291 ns | 0.0235 ns |  2.6875 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  2.7906 ns | 0.2479 ns | 0.0136 ns |  2.7877 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  2.1133 ns | 0.6528 ns | 0.0358 ns |  2.1252 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  2.1480 ns | 1.2228 ns | 0.0670 ns |  2.1681 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  3.1314 ns | 0.8331 ns | 0.0457 ns |  3.1052 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  3.4099 ns | 0.2883 ns | 0.0158 ns |  3.4150 ns |  1.09 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  6.1833 ns | 0.3873 ns | 0.0212 ns |  6.1869 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  8.4325 ns | 1.6846 ns | 0.0923 ns |  8.3987 ns |  1.36 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 13.3749 ns | 0.9198 ns | 0.0504 ns | 13.3539 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  9.8916 ns | 1.6137 ns | 0.0885 ns |  9.9353 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.9011 ns | 0.2417 ns | 0.0133 ns |  0.8954 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7138 ns | 0.0741 ns | 0.0041 ns |  0.7126 ns |  0.79 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.6983 ns | 1.8160 ns | 0.0995 ns |  1.7515 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2363 ns | 0.0677 ns | 0.0037 ns |  1.2379 ns |  0.73 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.8558 ns | 3.7107 ns | 0.2034 ns | 12.8545 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 12.1457 ns | 4.8276 ns | 0.2646 ns | 12.2341 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 11.0437 ns | 1.3161 ns | 0.0721 ns | 11.0407 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  9.6426 ns | 2.3005 ns | 0.1261 ns |  9.5734 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.7527 ns | 1.6074 ns | 0.0881 ns |  0.7128 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.7274 ns | 0.2186 ns | 0.0120 ns |  0.7234 ns |  0.98 |    0.12 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.1831 ns | 0.0785 ns | 0.0043 ns |  1.1829 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.1993 ns | 0.7725 ns | 0.0423 ns |  1.1895 ns |  1.01 |    0.03 |     - |     - |     - |         - |
