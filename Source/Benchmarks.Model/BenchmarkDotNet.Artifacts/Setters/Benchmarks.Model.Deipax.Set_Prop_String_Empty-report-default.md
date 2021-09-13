
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |   3.699 ns |  0.5353 ns | 0.0293 ns |   3.686 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 5.0 |   3.847 ns |  0.3529 ns | 0.0193 ns |   3.838 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 3.1 |   2.084 ns |  1.6863 ns | 0.0924 ns |   2.129 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |   2.249 ns |  0.5177 ns | 0.0284 ns |   2.234 ns |  1.08 |    0.06 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromChar | .NET Core 3.1 |   4.303 ns |  0.6066 ns | 0.0333 ns |   4.296 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 5.0 |   4.493 ns |  0.5774 ns | 0.0316 ns |   4.495 ns |  1.04 |    0.00 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromCharNullable | .NET Core 3.1 |   1.979 ns |  0.6672 ns | 0.0366 ns |   1.958 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |   2.471 ns |  0.6676 ns | 0.0366 ns |   2.464 ns |  1.25 |    0.03 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromSByte | .NET Core 3.1 |  13.763 ns |  2.6269 ns | 0.1440 ns |  13.806 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |   4.904 ns |  1.2559 ns | 0.0688 ns |   4.908 ns |  0.36 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 3.1 |   2.196 ns |  3.7008 ns | 0.2029 ns |   2.083 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |   2.211 ns |  0.3867 ns | 0.0212 ns |   2.201 ns |  1.01 |    0.08 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromByte | .NET Core 3.1 |  14.111 ns |  0.6546 ns | 0.0359 ns |  14.106 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromByte | .NET Core 5.0 |   4.430 ns |  0.7445 ns | 0.0408 ns |   4.408 ns |  0.31 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromByteNullable | .NET Core 3.1 |   2.101 ns |  2.1261 ns | 0.1165 ns |   2.082 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |   2.398 ns |  1.9728 ns | 0.1081 ns |   2.362 ns |  1.14 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromShort | .NET Core 3.1 |  13.350 ns |  2.1496 ns | 0.1178 ns |  13.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            FromShort | .NET Core 5.0 |   3.895 ns |  1.4697 ns | 0.0806 ns |   3.885 ns |  0.29 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromShortNullable | .NET Core 3.1 |   2.643 ns |  1.1964 ns | 0.0656 ns |   2.639 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |   2.560 ns |  2.3197 ns | 0.1272 ns |   2.550 ns |  0.97 |    0.04 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromUShort | .NET Core 3.1 |  13.905 ns |  5.3112 ns | 0.2911 ns |  14.018 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |   4.276 ns |  1.2328 ns | 0.0676 ns |   4.253 ns |  0.31 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 3.1 |   2.226 ns |  0.3991 ns | 0.0219 ns |   2.229 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |   2.316 ns |  0.4127 ns | 0.0226 ns |   2.311 ns |  1.04 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
              FromInt | .NET Core 3.1 |  13.101 ns |  2.5984 ns | 0.1424 ns |  13.065 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              FromInt | .NET Core 5.0 |   4.346 ns |  2.6699 ns | 0.1463 ns |   4.350 ns |  0.33 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
      FromIntNullable | .NET Core 3.1 |   2.305 ns |  0.3247 ns | 0.0178 ns |   2.303 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |   2.220 ns |  0.5313 ns | 0.0291 ns |   2.226 ns |  0.96 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromUInt | .NET Core 3.1 |  13.434 ns |  2.7768 ns | 0.1522 ns |  13.507 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |   3.794 ns |  0.5770 ns | 0.0316 ns |   3.779 ns |  0.28 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 3.1 |   2.613 ns |  0.3037 ns | 0.0166 ns |   2.610 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |   2.333 ns |  0.5883 ns | 0.0322 ns |   2.350 ns |  0.89 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromLong | .NET Core 3.1 |  13.968 ns |  7.2568 ns | 0.3978 ns |  13.740 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromLong | .NET Core 5.0 |   4.758 ns |  2.0717 ns | 0.1136 ns |   4.723 ns |  0.34 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromLongNullable | .NET Core 3.1 |   2.921 ns |  0.8418 ns | 0.0461 ns |   2.930 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |   2.694 ns |  0.4969 ns | 0.0272 ns |   2.698 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromULong | .NET Core 3.1 |  13.012 ns |  3.0926 ns | 0.1695 ns |  13.012 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            FromULong | .NET Core 5.0 |   4.752 ns |  3.3595 ns | 0.1841 ns |   4.812 ns |  0.37 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromULongNullable | .NET Core 3.1 |   3.040 ns |  0.3144 ns | 0.0172 ns |   3.031 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |   2.439 ns |  0.1500 ns | 0.0082 ns |   2.439 ns |  0.80 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromFloat | .NET Core 3.1 |  52.791 ns |  8.2964 ns | 0.4548 ns |  52.974 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 5.0 |  39.051 ns |  4.2680 ns | 0.2339 ns |  38.979 ns |  0.74 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 3.1 |   2.479 ns |  1.2234 ns | 0.0671 ns |   2.456 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |   2.039 ns |  2.5269 ns | 0.1385 ns |   1.968 ns |  0.82 |    0.07 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromDouble | .NET Core 3.1 |  52.752 ns | 15.5587 ns | 0.8528 ns |  52.490 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 5.0 |  39.314 ns |  2.7417 ns | 0.1503 ns |  39.310 ns |  0.75 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |   2.650 ns |  1.5445 ns | 0.0847 ns |   2.607 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |   2.455 ns |  0.5490 ns | 0.0301 ns |   2.468 ns |  0.93 |    0.03 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
          FromDecimal | .NET Core 3.1 |  48.537 ns |  5.9538 ns | 0.3263 ns |  48.670 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          FromDecimal | .NET Core 5.0 |  34.693 ns | 10.0045 ns | 0.5484 ns |  34.990 ns |  0.71 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 3.1 |   9.125 ns |  3.3949 ns | 0.1861 ns |   9.044 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |   3.390 ns |  0.9653 ns | 0.0529 ns |   3.408 ns |  0.37 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
         FromDateTime | .NET Core 3.1 | 223.029 ns | 65.8808 ns | 3.6112 ns | 223.298 ns |  1.00 |    0.00 | 0.0100 |     - |     - |      64 B |
         FromDateTime | .NET Core 5.0 | 237.918 ns | 17.4464 ns | 0.9563 ns | 237.608 ns |  1.07 |    0.02 | 0.0100 |     - |     - |      64 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |   2.732 ns |  0.5967 ns | 0.0327 ns |   2.725 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |   2.774 ns |  2.1771 ns | 0.1193 ns |   2.836 ns |  1.02 |    0.04 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromObject | .NET Core 3.1 |   2.154 ns |  0.1834 ns | 0.0101 ns |   2.152 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 5.0 |   2.150 ns |  0.8457 ns | 0.0464 ns |   2.133 ns |  1.00 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromString | .NET Core 3.1 |   1.683 ns |  0.8263 ns | 0.0453 ns |   1.663 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 5.0 |   1.452 ns |  1.3231 ns | 0.0725 ns |   1.417 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromEnum | .NET Core 3.1 |  16.760 ns |  4.5212 ns | 0.2478 ns |  16.630 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  13.626 ns |  0.7729 ns | 0.0424 ns |  13.636 ns |  0.81 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 3.1 |   2.375 ns |  0.2005 ns | 0.0110 ns |   2.375 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |   2.221 ns |  0.5142 ns | 0.0282 ns |   2.231 ns |  0.94 |    0.02 |      - |     - |     - |         - |
