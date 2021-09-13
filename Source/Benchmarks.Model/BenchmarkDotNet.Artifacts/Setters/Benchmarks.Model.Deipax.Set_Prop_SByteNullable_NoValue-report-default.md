
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 0.9728 ns | 1.2066 ns | 0.0661 ns | 0.9939 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.7733 ns | 0.2947 ns | 0.0162 ns | 0.7798 ns |  0.80 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.1162 ns | 0.0902 ns | 0.0049 ns | 1.1176 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.2482 ns | 0.1709 ns | 0.0094 ns | 1.2464 ns |  1.12 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.9463 ns | 0.1588 ns | 0.0087 ns | 0.9513 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.6385 ns | 0.0710 ns | 0.0039 ns | 0.6367 ns |  0.67 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.1622 ns | 0.0953 ns | 0.0052 ns | 1.1626 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.1777 ns | 0.4270 ns | 0.0234 ns | 1.1682 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.8118 ns | 0.9021 ns | 0.0494 ns | 0.7893 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.5922 ns | 0.2623 ns | 0.0144 ns | 0.5928 ns |  0.73 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 0.7986 ns | 0.0562 ns | 0.0031 ns | 0.7990 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 0.6443 ns | 0.2032 ns | 0.0111 ns | 0.6487 ns |  0.81 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.8056 ns | 0.2390 ns | 0.0131 ns | 0.8036 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.7988 ns | 0.0724 ns | 0.0040 ns | 0.7966 ns |  0.99 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.0393 ns | 0.2691 ns | 0.0148 ns | 1.0399 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.1309 ns | 1.6468 ns | 0.0903 ns | 1.0940 ns |  1.09 |    0.10 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 2.0232 ns | 1.8215 ns | 0.0998 ns | 1.9754 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 1.7669 ns | 0.3593 ns | 0.0197 ns | 1.7736 ns |  0.87 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.7773 ns | 0.1304 ns | 0.0071 ns | 1.7800 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.8287 ns | 2.4492 ns | 0.1342 ns | 1.7520 ns |  1.03 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.7249 ns | 0.1332 ns | 0.0073 ns | 0.7214 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.7447 ns | 0.3210 ns | 0.0176 ns | 0.7357 ns |  1.03 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.2918 ns | 0.5124 ns | 0.0281 ns | 1.2827 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.1757 ns | 0.3420 ns | 0.0187 ns | 1.1855 ns |  0.91 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 1.8075 ns | 0.5751 ns | 0.0315 ns | 1.7913 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 1.8476 ns | 0.2003 ns | 0.0110 ns | 1.8429 ns |  1.02 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.7678 ns | 0.1415 ns | 0.0078 ns | 1.7713 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.8657 ns | 1.9455 ns | 0.1066 ns | 1.8174 ns |  1.06 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.9854 ns | 0.2399 ns | 0.0131 ns | 0.9809 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.8233 ns | 0.4132 ns | 0.0226 ns | 0.8311 ns |  0.84 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.4097 ns | 4.5440 ns | 0.2491 ns | 1.3097 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.1944 ns | 0.3443 ns | 0.0189 ns | 1.1846 ns |  0.86 |    0.14 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 2.0129 ns | 0.3737 ns | 0.0205 ns | 2.0145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 1.8415 ns | 0.0623 ns | 0.0034 ns | 1.8420 ns |  0.91 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 2.0367 ns | 0.5063 ns | 0.0277 ns | 2.0517 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 2.1219 ns | 5.1937 ns | 0.2847 ns | 1.9940 ns |  1.04 |    0.13 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 0.9762 ns | 0.2439 ns | 0.0134 ns | 0.9772 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 0.8158 ns | 0.1369 ns | 0.0075 ns | 0.8141 ns |  0.84 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 2.0084 ns | 3.4743 ns | 0.1904 ns | 1.9046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.7555 ns | 0.4786 ns | 0.0262 ns | 1.7681 ns |  0.88 |    0.07 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 4.4671 ns | 0.3011 ns | 0.0165 ns | 4.4621 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 4.0990 ns | 0.5488 ns | 0.0301 ns | 4.0897 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 1.8503 ns | 2.1950 ns | 0.1203 ns | 1.7835 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 2.0037 ns | 4.1150 ns | 0.2256 ns | 1.8945 ns |  1.09 |    0.17 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 3.9500 ns | 0.2672 ns | 0.0146 ns | 3.9449 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 4.6058 ns | 0.2201 ns | 0.0121 ns | 4.6061 ns |  1.17 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 2.2291 ns | 2.5385 ns | 0.1391 ns | 2.1734 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 2.0804 ns | 0.5120 ns | 0.0281 ns | 2.0837 ns |  0.94 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 7.9184 ns | 9.8864 ns | 0.5419 ns | 7.6155 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 9.3026 ns | 0.5051 ns | 0.0277 ns | 9.3098 ns |  1.18 |    0.08 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 2.7324 ns | 0.1647 ns | 0.0090 ns | 2.7318 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.3665 ns | 0.4961 ns | 0.0272 ns | 2.3754 ns |  0.87 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.7973 ns | 0.2344 ns | 0.0129 ns | 0.7986 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.9949 ns | 0.2406 ns | 0.0132 ns | 0.9918 ns |  1.25 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.6396 ns | 0.3839 ns | 0.0210 ns | 1.6340 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.2556 ns | 1.5377 ns | 0.0843 ns | 1.2071 ns |  0.77 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 2.7478 ns | 0.3067 ns | 0.0168 ns | 2.7494 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.8105 ns | 1.1500 ns | 0.0630 ns | 2.8457 ns |  1.02 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.9715 ns | 0.3701 ns | 0.0203 ns | 1.9723 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.9206 ns | 0.6634 ns | 0.0364 ns | 1.9243 ns |  0.97 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 2.1113 ns | 2.6897 ns | 0.1474 ns | 2.0449 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 1.8336 ns | 0.2252 ns | 0.0123 ns | 1.8346 ns |  0.87 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 2.3313 ns | 0.2196 ns | 0.0120 ns | 2.3258 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.7838 ns | 0.0900 ns | 0.0049 ns | 1.7815 ns |  0.77 |    0.01 |     - |     - |     - |         - |
