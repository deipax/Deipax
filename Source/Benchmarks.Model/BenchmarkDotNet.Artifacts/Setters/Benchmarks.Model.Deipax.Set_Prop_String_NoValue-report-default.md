
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |   3.529 ns |  0.9462 ns | 0.0519 ns |   3.499 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 5.0 |   4.033 ns |  2.5120 ns | 0.1377 ns |   4.041 ns |  1.14 |    0.04 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 3.1 |   2.071 ns |  0.3989 ns | 0.0219 ns |   2.062 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |   2.253 ns |  0.8548 ns | 0.0469 ns |   2.267 ns |  1.09 |    0.03 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromChar | .NET Core 3.1 |   4.280 ns |  1.0957 ns | 0.0601 ns |   4.270 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 5.0 |   4.475 ns |  0.7033 ns | 0.0385 ns |   4.495 ns |  1.05 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromCharNullable | .NET Core 3.1 |   2.024 ns |  0.5189 ns | 0.0284 ns |   2.010 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |   2.474 ns |  0.2624 ns | 0.0144 ns |   2.473 ns |  1.22 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromSByte | .NET Core 3.1 |  13.875 ns |  5.8009 ns | 0.3180 ns |  13.744 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |   4.880 ns |  1.2906 ns | 0.0707 ns |   4.905 ns |  0.35 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 3.1 |   2.223 ns |  0.6349 ns | 0.0348 ns |   2.231 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |   2.254 ns |  0.6793 ns | 0.0372 ns |   2.274 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromByte | .NET Core 3.1 |  13.335 ns |  4.2469 ns | 0.2328 ns |  13.415 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromByte | .NET Core 5.0 |   4.426 ns |  0.6398 ns | 0.0351 ns |   4.438 ns |  0.33 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromByteNullable | .NET Core 3.1 |   2.210 ns |  0.7662 ns | 0.0420 ns |   2.208 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |   2.311 ns |  0.5872 ns | 0.0322 ns |   2.308 ns |  1.05 |    0.03 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromShort | .NET Core 3.1 |  13.551 ns |  2.7813 ns | 0.1525 ns |  13.628 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            FromShort | .NET Core 5.0 |   3.934 ns |  0.2251 ns | 0.0123 ns |   3.933 ns |  0.29 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromShortNullable | .NET Core 3.1 |   2.731 ns |  0.6547 ns | 0.0359 ns |   2.744 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |   2.582 ns |  3.1492 ns | 0.1726 ns |   2.540 ns |  0.95 |    0.06 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromUShort | .NET Core 3.1 |  12.964 ns |  3.1862 ns | 0.1746 ns |  13.007 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |   4.210 ns |  1.1076 ns | 0.0607 ns |   4.243 ns |  0.32 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 3.1 |   2.392 ns |  4.3755 ns | 0.2398 ns |   2.290 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |   2.298 ns |  0.8727 ns | 0.0478 ns |   2.276 ns |  0.97 |    0.07 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
              FromInt | .NET Core 3.1 |  13.115 ns |  0.2971 ns | 0.0163 ns |  13.122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              FromInt | .NET Core 5.0 |   4.181 ns |  1.8402 ns | 0.1009 ns |   4.130 ns |  0.32 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
      FromIntNullable | .NET Core 3.1 |   2.647 ns |  1.0814 ns | 0.0593 ns |   2.619 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |   2.259 ns |  1.1022 ns | 0.0604 ns |   2.270 ns |  0.85 |    0.03 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromUInt | .NET Core 3.1 |  12.857 ns |  1.7487 ns | 0.0958 ns |  12.869 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |   3.792 ns |  1.1966 ns | 0.0656 ns |   3.765 ns |  0.29 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 3.1 |   2.597 ns |  0.8847 ns | 0.0485 ns |   2.585 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |   2.329 ns |  1.6691 ns | 0.0915 ns |   2.282 ns |  0.90 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromLong | .NET Core 3.1 |  13.062 ns |  1.6907 ns | 0.0927 ns |  13.092 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromLong | .NET Core 5.0 |   4.682 ns |  0.0909 ns | 0.0050 ns |   4.682 ns |  0.36 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromLongNullable | .NET Core 3.1 |   2.997 ns |  0.4895 ns | 0.0268 ns |   2.985 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |   2.710 ns |  1.4951 ns | 0.0819 ns |   2.707 ns |  0.90 |    0.03 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromULong | .NET Core 3.1 |  12.788 ns |  2.5453 ns | 0.1395 ns |  12.849 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            FromULong | .NET Core 5.0 |   4.585 ns |  0.6751 ns | 0.0370 ns |   4.594 ns |  0.36 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromULongNullable | .NET Core 3.1 |   3.048 ns |  1.0358 ns | 0.0568 ns |   3.016 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |   2.480 ns |  1.2579 ns | 0.0689 ns |   2.451 ns |  0.81 |    0.03 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromFloat | .NET Core 3.1 |  54.340 ns | 29.6908 ns | 1.6275 ns |  54.076 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 5.0 |  39.555 ns |  9.4802 ns | 0.5196 ns |  39.423 ns |  0.73 |    0.03 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 3.1 |   2.501 ns |  0.3850 ns | 0.0211 ns |   2.509 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |   1.959 ns |  0.4921 ns | 0.0270 ns |   1.959 ns |  0.78 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromDouble | .NET Core 3.1 |  52.198 ns |  2.4685 ns | 0.1353 ns |  52.218 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 5.0 |  38.777 ns |  4.5844 ns | 0.2513 ns |  38.878 ns |  0.74 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |   2.855 ns |  0.8625 ns | 0.0473 ns |   2.834 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |   2.424 ns |  0.2555 ns | 0.0140 ns |   2.426 ns |  0.85 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
          FromDecimal | .NET Core 3.1 |  48.844 ns |  4.6523 ns | 0.2550 ns |  48.761 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          FromDecimal | .NET Core 5.0 |  35.189 ns | 14.4749 ns | 0.7934 ns |  34.775 ns |  0.72 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 3.1 |   9.364 ns |  1.5133 ns | 0.0829 ns |   9.374 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |   3.385 ns |  1.3321 ns | 0.0730 ns |   3.410 ns |  0.36 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
         FromDateTime | .NET Core 3.1 | 224.844 ns | 60.3937 ns | 3.3104 ns | 225.282 ns |  1.00 |    0.00 | 0.0100 |     - |     - |      64 B |
         FromDateTime | .NET Core 5.0 | 237.151 ns | 26.7883 ns | 1.4684 ns | 236.949 ns |  1.05 |    0.02 | 0.0100 |     - |     - |      64 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |   3.141 ns |  0.1109 ns | 0.0061 ns |   3.139 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |   2.778 ns |  1.8207 ns | 0.0998 ns |   2.810 ns |  0.88 |    0.03 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromObject | .NET Core 3.1 |   2.724 ns |  1.5525 ns | 0.0851 ns |   2.693 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 5.0 |   2.485 ns |  0.9099 ns | 0.0499 ns |   2.472 ns |  0.91 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromString | .NET Core 3.1 |   1.703 ns |  0.7584 ns | 0.0416 ns |   1.689 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 5.0 |   1.479 ns |  0.5906 ns | 0.0324 ns |   1.482 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromEnum | .NET Core 3.1 |  16.552 ns |  2.2876 ns | 0.1254 ns |  16.575 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  13.406 ns |  1.1390 ns | 0.0624 ns |  13.397 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 3.1 |   2.407 ns |  0.4999 ns | 0.0274 ns |   2.413 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |   2.239 ns |  1.0592 ns | 0.0581 ns |   2.212 ns |  0.93 |    0.03 |      - |     - |     - |         - |
