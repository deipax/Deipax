
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |      Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|-----------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |   3.556 ns |  1.1472 ns | 0.0629 ns |   3.537 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromBool | .NET Core 5.0 |   3.433 ns |  0.6789 ns | 0.0372 ns |   3.418 ns |  0.97 |    0.03 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 3.1 |   2.052 ns |  0.0686 ns | 0.0038 ns |   2.052 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |   2.077 ns |  0.2449 ns | 0.0134 ns |   2.077 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromChar | .NET Core 3.1 |   4.644 ns |  4.6675 ns | 0.2558 ns |   4.720 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 5.0 |   4.299 ns |  0.4336 ns | 0.0238 ns |   4.300 ns |  0.93 |    0.06 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromCharNullable | .NET Core 3.1 |   5.126 ns |  1.3342 ns | 0.0731 ns |   5.150 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
     FromCharNullable | .NET Core 5.0 |   5.250 ns |  1.1715 ns | 0.0642 ns |   5.255 ns |  1.02 |    0.03 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromSByte | .NET Core 3.1 |  13.997 ns |  0.3978 ns | 0.0218 ns |  13.990 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |   4.848 ns |  0.5489 ns | 0.0301 ns |   4.832 ns |  0.35 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  14.617 ns |  2.2796 ns | 0.1250 ns |  14.598 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |   4.507 ns |  0.2406 ns | 0.0132 ns |   4.513 ns |  0.31 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromByte | .NET Core 3.1 |  13.508 ns |  3.4302 ns | 0.1880 ns |  13.402 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromByte | .NET Core 5.0 |   4.388 ns |  0.1578 ns | 0.0086 ns |   4.386 ns |  0.32 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromByteNullable | .NET Core 3.1 |  13.873 ns |  5.0976 ns | 0.2794 ns |  13.745 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |   4.808 ns |  0.7828 ns | 0.0429 ns |   4.797 ns |  0.35 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromShort | .NET Core 3.1 |  13.630 ns |  1.9410 ns | 0.1064 ns |  13.631 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            FromShort | .NET Core 5.0 |   3.978 ns |  0.6738 ns | 0.0369 ns |   3.979 ns |  0.29 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromShortNullable | .NET Core 3.1 |  14.271 ns |  9.8683 ns | 0.5409 ns |  13.980 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |   5.165 ns |  1.6138 ns | 0.0885 ns |   5.165 ns |  0.36 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromUShort | .NET Core 3.1 |  13.024 ns |  0.8961 ns | 0.0491 ns |  13.033 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |   4.220 ns |  1.0014 ns | 0.0549 ns |   4.215 ns |  0.32 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  14.090 ns |  7.5091 ns | 0.4116 ns |  13.890 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |   4.014 ns |  2.3718 ns | 0.1300 ns |   3.960 ns |  0.29 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
              FromInt | .NET Core 3.1 |  13.141 ns |  4.9095 ns | 0.2691 ns |  13.128 ns |  1.00 |    0.00 |      - |     - |     - |         - |
              FromInt | .NET Core 5.0 |   4.231 ns |  2.0421 ns | 0.1119 ns |   4.213 ns |  0.32 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
      FromIntNullable | .NET Core 3.1 |  13.218 ns |  1.1710 ns | 0.0642 ns |  13.223 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |   4.293 ns |  1.2386 ns | 0.0679 ns |   4.263 ns |  0.32 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromUInt | .NET Core 3.1 |  12.860 ns |  5.9428 ns | 0.3257 ns |  12.773 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |   3.831 ns |  0.8688 ns | 0.0476 ns |   3.821 ns |  0.30 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  13.296 ns |  4.2852 ns | 0.2349 ns |  13.302 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |   4.239 ns |  0.8660 ns | 0.0475 ns |   4.214 ns |  0.32 |    0.00 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromLong | .NET Core 3.1 |  13.281 ns |  0.9617 ns | 0.0527 ns |  13.251 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromLong | .NET Core 5.0 |   4.396 ns |  1.5407 ns | 0.0844 ns |   4.377 ns |  0.33 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromLongNullable | .NET Core 3.1 |  14.640 ns |  1.8333 ns | 0.1005 ns |  14.589 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |   6.399 ns |  1.7651 ns | 0.0968 ns |   6.428 ns |  0.44 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromULong | .NET Core 3.1 |  13.103 ns |  0.0893 ns | 0.0049 ns |  13.102 ns |  1.00 |    0.00 |      - |     - |     - |         - |
            FromULong | .NET Core 5.0 |   4.817 ns |  1.2643 ns | 0.0693 ns |   4.795 ns |  0.37 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromULongNullable | .NET Core 3.1 |  14.824 ns |  5.5823 ns | 0.3060 ns |  14.658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |   5.435 ns |  0.5500 ns | 0.0301 ns |   5.451 ns |  0.37 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
            FromFloat | .NET Core 3.1 | 114.623 ns | 35.5860 ns | 1.9506 ns | 113.644 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 5.0 |  87.534 ns | 21.4271 ns | 1.1745 ns |  87.560 ns |  0.76 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 115.520 ns | 27.4903 ns | 1.5068 ns | 115.530 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
    FromFloatNullable | .NET Core 5.0 |  88.330 ns |  9.6667 ns | 0.5299 ns |  88.393 ns |  0.76 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromDouble | .NET Core 3.1 | 115.259 ns |  4.7221 ns | 0.2588 ns | 115.407 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 5.0 |  90.182 ns | 36.6225 ns | 2.0074 ns |  90.032 ns |  0.78 |    0.02 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 116.135 ns | 43.5502 ns | 2.3871 ns | 115.391 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
   FromDoubleNullable | .NET Core 5.0 |  90.052 ns | 26.3741 ns | 1.4457 ns |  90.390 ns |  0.78 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
          FromDecimal | .NET Core 3.1 |  52.297 ns |  4.0449 ns | 0.2217 ns |  52.312 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
          FromDecimal | .NET Core 5.0 |  38.957 ns | 21.6453 ns | 1.1865 ns |  39.307 ns |  0.74 |    0.02 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 3.1 |  51.977 ns | 21.5494 ns | 1.1812 ns |  51.333 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
  FromDecimalNullable | .NET Core 5.0 |  38.912 ns |  1.1481 ns | 0.0629 ns |  38.880 ns |  0.75 |    0.02 | 0.0038 |     - |     - |      24 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
         FromDateTime | .NET Core 3.1 | 220.137 ns | 11.7264 ns | 0.6428 ns | 220.137 ns |  1.00 |    0.00 | 0.0100 |     - |     - |      64 B |
         FromDateTime | .NET Core 5.0 | 212.859 ns | 18.1776 ns | 0.9964 ns | 212.442 ns |  0.97 |    0.01 | 0.0100 |     - |     - |      64 B |
                      |               |            |            |           |            |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |   3.199 ns |  0.3375 ns | 0.0185 ns |   3.191 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |   2.747 ns |  1.2232 ns | 0.0670 ns |   2.712 ns |  0.86 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromObject | .NET Core 3.1 |   2.545 ns |  0.8345 ns | 0.0457 ns |   2.564 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 5.0 |   2.190 ns |  0.1900 ns | 0.0104 ns |   2.188 ns |  0.86 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
           FromString | .NET Core 3.1 |   1.454 ns |  0.3594 ns | 0.0197 ns |   1.461 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 5.0 |   1.486 ns |  0.0369 ns | 0.0020 ns |   1.487 ns |  1.02 |    0.01 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
             FromEnum | .NET Core 3.1 |  22.687 ns |  5.5034 ns | 0.3017 ns |  22.546 ns |  1.00 |    0.00 |      - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  19.107 ns |  2.8887 ns | 0.1583 ns |  19.037 ns |  0.84 |    0.02 |      - |     - |     - |         - |
                      |               |            |            |           |            |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  23.253 ns |  3.7617 ns | 0.2062 ns |  23.318 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  19.372 ns |  1.1719 ns | 0.0642 ns |  19.380 ns |  0.83 |    0.01 |      - |     - |     - |         - |
