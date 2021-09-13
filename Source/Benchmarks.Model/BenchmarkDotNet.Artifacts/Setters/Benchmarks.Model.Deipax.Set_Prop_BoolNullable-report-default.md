
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.7364 ns | 0.0707 ns | 0.0039 ns |  0.7342 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  0.9693 ns | 0.2409 ns | 0.0132 ns |  0.9626 ns |  1.32 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  0.7889 ns | 0.0542 ns | 0.0030 ns |  0.7881 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  0.5841 ns | 0.0684 ns | 0.0038 ns |  0.5833 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.7443 ns | 0.2155 ns | 0.0118 ns |  0.7474 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.6020 ns | 0.1357 ns | 0.0074 ns |  0.5999 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  0.7744 ns | 0.1614 ns | 0.0088 ns |  0.7695 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  0.7579 ns | 0.4784 ns | 0.0262 ns |  0.7487 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.6837 ns | 0.2860 ns | 0.0157 ns |  0.6780 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.9899 ns | 0.0857 ns | 0.0047 ns |  0.9888 ns |  1.45 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.3154 ns | 0.3381 ns | 0.0185 ns |  1.3091 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.1334 ns | 0.0660 ns | 0.0036 ns |  1.1325 ns |  0.86 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.7256 ns | 0.2224 ns | 0.0122 ns |  0.7250 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.6609 ns | 0.1020 ns | 0.0056 ns |  0.6610 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.2713 ns | 0.7045 ns | 0.0386 ns |  1.2631 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.0943 ns | 0.5502 ns | 0.0302 ns |  1.0872 ns |  0.86 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.9706 ns | 0.3397 ns | 0.0186 ns |  0.9773 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.7305 ns | 0.2989 ns | 0.0164 ns |  0.7397 ns |  0.75 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.1932 ns | 0.2167 ns | 0.0119 ns |  1.1871 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.2288 ns | 0.3321 ns | 0.0182 ns |  1.2233 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.9371 ns | 0.1699 ns | 0.0093 ns |  0.9331 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.5599 ns | 0.2453 ns | 0.0134 ns |  0.5618 ns |  0.60 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.2754 ns | 0.5686 ns | 0.0312 ns |  1.2734 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.2865 ns | 0.1167 ns | 0.0064 ns |  1.2869 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  0.9821 ns | 0.4427 ns | 0.0243 ns |  0.9717 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  1.1751 ns | 6.9862 ns | 0.3829 ns |  1.3936 ns |  1.19 |    0.38 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  1.2769 ns | 0.2638 ns | 0.0145 ns |  1.2739 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.2832 ns | 0.3004 ns | 0.0165 ns |  1.2827 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.6941 ns | 0.0520 ns | 0.0028 ns |  0.6942 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  1.0058 ns | 0.3249 ns | 0.0178 ns |  1.0127 ns |  1.45 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.1951 ns | 0.5373 ns | 0.0295 ns |  1.1798 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.2954 ns | 0.2966 ns | 0.0163 ns |  1.2895 ns |  1.08 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  0.7584 ns | 0.4225 ns | 0.0232 ns |  0.7616 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  0.7692 ns | 0.3453 ns | 0.0189 ns |  0.7624 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  1.7943 ns | 0.1447 ns | 0.0079 ns |  1.7981 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  1.8398 ns | 0.3294 ns | 0.0181 ns |  1.8444 ns |  1.03 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  0.9145 ns | 3.7248 ns | 0.2042 ns |  0.9049 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  0.7292 ns | 0.0437 ns | 0.0024 ns |  0.7290 ns |  0.83 |    0.19 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  1.8239 ns | 0.4025 ns | 0.0221 ns |  1.8258 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  1.7797 ns | 0.5848 ns | 0.0321 ns |  1.7624 ns |  0.98 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  0.8837 ns | 0.2531 ns | 0.0139 ns |  0.8770 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  1.0488 ns | 0.3837 ns | 0.0210 ns |  1.0553 ns |  1.19 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  1.3497 ns | 0.6414 ns | 0.0352 ns |  1.3306 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  1.5296 ns | 0.9059 ns | 0.0497 ns |  1.5110 ns |  1.13 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  0.9878 ns | 2.4037 ns | 0.1318 ns |  0.9683 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  0.8589 ns | 0.1508 ns | 0.0083 ns |  0.8574 ns |  0.88 |    0.12 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  1.7946 ns | 0.0932 ns | 0.0051 ns |  1.7922 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  1.9892 ns | 1.2726 ns | 0.0698 ns |  1.9811 ns |  1.11 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  5.2507 ns | 1.1867 ns | 0.0650 ns |  5.2840 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  8.2257 ns | 3.4769 ns | 0.1906 ns |  8.1462 ns |  1.57 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 11.5198 ns | 0.3606 ns | 0.0198 ns | 11.5122 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  9.0831 ns | 1.2576 ns | 0.0689 ns |  9.0779 ns |  0.79 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.6430 ns | 0.1473 ns | 0.0081 ns |  0.6439 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.7793 ns | 0.0676 ns | 0.0037 ns |  0.7783 ns |  1.21 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.5490 ns | 0.1361 ns | 0.0075 ns |  1.5514 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2472 ns | 0.1699 ns | 0.0093 ns |  1.2523 ns |  0.81 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 12.0023 ns | 1.1936 ns | 0.0654 ns | 12.0029 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 11.1744 ns | 0.3194 ns | 0.0175 ns | 11.1675 ns |  0.93 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 14.0841 ns | 1.0771 ns | 0.0590 ns | 14.0999 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 14.0960 ns | 3.5850 ns | 0.1965 ns | 13.9952 ns |  1.00 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.8175 ns | 0.9840 ns | 0.0539 ns |  0.8042 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.7708 ns | 0.2184 ns | 0.0120 ns |  0.7717 ns |  0.95 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.2058 ns | 0.3166 ns | 0.0174 ns |  1.2133 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  1.2919 ns | 0.6301 ns | 0.0345 ns |  1.2779 ns |  1.07 |    0.03 |     - |     - |     - |         - |
