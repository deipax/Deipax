
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 13.4163 ns | 1.8470 ns | 0.1012 ns | 13.4555 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 12.3294 ns | 0.8701 ns | 0.0477 ns | 12.3428 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  2.0596 ns | 0.7450 ns | 0.0408 ns |  2.0734 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  2.6880 ns | 1.1586 ns | 0.0635 ns |  2.6734 ns |  1.31 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 13.3390 ns | 1.7897 ns | 0.0981 ns | 13.3103 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 12.3419 ns | 1.0178 ns | 0.0558 ns | 12.3455 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  2.0595 ns | 0.5402 ns | 0.0296 ns |  2.0661 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  2.0841 ns | 0.6055 ns | 0.0332 ns |  2.0727 ns |  1.01 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 13.3856 ns | 0.6724 ns | 0.0369 ns | 13.4046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 12.3404 ns | 0.4265 ns | 0.0234 ns | 12.3503 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  2.0830 ns | 1.2415 ns | 0.0681 ns |  2.0551 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  2.1220 ns | 0.9098 ns | 0.0499 ns |  2.1047 ns |  1.02 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 13.4189 ns | 0.0374 ns | 0.0020 ns | 13.4177 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 12.3492 ns | 1.0133 ns | 0.0555 ns | 12.3653 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  2.4225 ns | 5.7122 ns | 0.3131 ns |  2.5763 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  2.1361 ns | 0.4564 ns | 0.0250 ns |  2.1330 ns |  0.89 |    0.13 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 13.4307 ns | 0.6211 ns | 0.0340 ns | 13.4118 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 12.3417 ns | 1.1167 ns | 0.0612 ns | 12.3520 ns |  0.92 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  2.0832 ns | 1.1734 ns | 0.0643 ns |  2.0545 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  2.0869 ns | 0.5834 ns | 0.0320 ns |  2.0695 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 13.4350 ns | 2.1614 ns | 0.1185 ns | 13.4027 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 12.3707 ns | 1.5144 ns | 0.0830 ns | 12.3441 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  2.0424 ns | 0.5616 ns | 0.0308 ns |  2.0299 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  2.1327 ns | 0.6253 ns | 0.0343 ns |  2.1406 ns |  1.04 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 13.0122 ns | 0.2961 ns | 0.0162 ns | 13.0193 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 12.2381 ns | 0.1756 ns | 0.0096 ns | 12.2436 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  2.1219 ns | 1.8845 ns | 0.1033 ns |  2.1124 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  2.0957 ns | 0.6875 ns | 0.0377 ns |  2.0913 ns |  0.99 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 13.1983 ns | 1.0566 ns | 0.0579 ns | 13.2107 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 12.2119 ns | 1.6524 ns | 0.0906 ns | 12.1821 ns |  0.93 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  2.0287 ns | 0.1136 ns | 0.0062 ns |  2.0270 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  2.0729 ns | 0.0532 ns | 0.0029 ns |  2.0738 ns |  1.02 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 13.5739 ns | 0.6237 ns | 0.0342 ns | 13.5844 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 12.8046 ns | 1.1640 ns | 0.0638 ns | 12.8365 ns |  0.94 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  2.1407 ns | 0.8733 ns | 0.0479 ns |  2.1185 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  2.1380 ns | 0.9020 ns | 0.0494 ns |  2.1245 ns |  1.00 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 13.8889 ns | 4.6882 ns | 0.2570 ns | 13.8266 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 12.7980 ns | 0.1476 ns | 0.0081 ns | 12.7939 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  2.2466 ns | 0.2899 ns | 0.0159 ns |  2.2414 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  2.1262 ns | 0.4323 ns | 0.0237 ns |  2.1378 ns |  0.95 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 15.6657 ns | 0.9171 ns | 0.0503 ns | 15.6869 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 15.0617 ns | 0.8031 ns | 0.0440 ns | 15.0512 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  2.0167 ns | 0.0409 ns | 0.0022 ns |  2.0175 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  2.0386 ns | 0.1376 ns | 0.0075 ns |  2.0385 ns |  1.01 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 15.6969 ns | 0.5760 ns | 0.0316 ns | 15.6807 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 14.8080 ns | 0.8110 ns | 0.0445 ns | 14.8232 ns |  0.94 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  2.1494 ns | 2.1223 ns | 0.1163 ns |  2.0945 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  2.1019 ns | 1.5075 ns | 0.0826 ns |  2.0561 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 23.5778 ns | 4.3061 ns | 0.2360 ns | 23.4575 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 21.1468 ns | 2.8916 ns | 0.1585 ns | 21.1042 ns |  0.90 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 |  8.7609 ns | 1.0474 ns | 0.0574 ns |  8.7851 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 |  3.0411 ns | 0.4231 ns | 0.0232 ns |  3.0464 ns |  0.35 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  7.3134 ns | 0.6821 ns | 0.0374 ns |  7.3237 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  3.2510 ns | 0.1775 ns | 0.0097 ns |  3.2481 ns |  0.44 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  2.8224 ns | 0.8690 ns | 0.0476 ns |  2.8261 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  2.3112 ns | 0.1265 ns | 0.0069 ns |  2.3107 ns |  0.82 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  3.1828 ns | 0.1987 ns | 0.0109 ns |  3.1890 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.7252 ns | 0.0390 ns | 0.0021 ns |  2.7261 ns |  0.86 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  1.7812 ns | 0.8313 ns | 0.0456 ns |  1.7779 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  1.8033 ns | 0.0620 ns | 0.0034 ns |  1.8014 ns |  1.01 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  0.9203 ns | 0.4250 ns | 0.0233 ns |  0.9124 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.7233 ns | 0.0514 ns | 0.0028 ns |  0.7217 ns |  0.79 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  0.6498 ns | 0.1662 ns | 0.0091 ns |  0.6447 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  0.9227 ns | 0.0556 ns | 0.0031 ns |  0.9238 ns |  1.42 |    0.02 |     - |     - |     - |         - |
