
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |----------:|----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 0.9608 ns | 0.6746 ns | 0.0370 ns | 0.9450 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 | 0.7115 ns | 0.1791 ns | 0.0098 ns | 0.7106 ns |  0.74 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 0.9942 ns | 0.2941 ns | 0.0161 ns | 0.9960 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 0.9583 ns | 0.6223 ns | 0.0341 ns | 0.9482 ns |  0.96 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 | 0.9580 ns | 0.2654 ns | 0.0145 ns | 0.9577 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 | 0.9299 ns | 0.1598 ns | 0.0088 ns | 0.9301 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.1186 ns | 0.4274 ns | 0.0234 ns | 1.1254 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.1109 ns | 0.1567 ns | 0.0086 ns | 1.1106 ns |  0.99 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 | 0.9190 ns | 0.2132 ns | 0.0117 ns | 0.9167 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 | 0.9406 ns | 0.4500 ns | 0.0247 ns | 0.9291 ns |  1.02 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 1.1706 ns | 0.5244 ns | 0.0287 ns | 1.1778 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 0.9626 ns | 0.5421 ns | 0.0297 ns | 0.9605 ns |  0.82 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 | 0.6752 ns | 0.4067 ns | 0.0223 ns | 0.6623 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 | 0.6915 ns | 0.0843 ns | 0.0046 ns | 0.6939 ns |  1.02 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.0007 ns | 0.1061 ns | 0.0058 ns | 1.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 0.9647 ns | 0.0256 ns | 0.0014 ns | 0.9640 ns |  0.96 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 | 0.6047 ns | 0.4017 ns | 0.0220 ns | 0.6117 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 | 0.7394 ns | 0.4860 ns | 0.0266 ns | 0.7276 ns |  1.22 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.1238 ns | 0.0796 ns | 0.0044 ns | 1.1249 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.2333 ns | 0.4650 ns | 0.0255 ns | 1.2245 ns |  1.10 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 | 0.5874 ns | 0.3468 ns | 0.0190 ns | 0.5786 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 | 0.5327 ns | 0.0405 ns | 0.0022 ns | 0.5322 ns |  0.91 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.1261 ns | 0.1975 ns | 0.0108 ns | 1.1199 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.2375 ns | 0.4337 ns | 0.0238 ns | 1.2404 ns |  1.10 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 | 0.6843 ns | 0.3796 ns | 0.0208 ns | 0.6809 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 | 0.7137 ns | 0.0317 ns | 0.0017 ns | 0.7128 ns |  1.04 |    0.03 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.1201 ns | 0.4417 ns | 0.0242 ns | 1.1092 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.1141 ns | 0.4607 ns | 0.0253 ns | 1.1073 ns |  1.00 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 | 0.6803 ns | 0.0964 ns | 0.0053 ns | 0.6819 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 | 0.6599 ns | 0.1972 ns | 0.0108 ns | 0.6550 ns |  0.97 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.1750 ns | 0.5385 ns | 0.0295 ns | 1.1851 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.1455 ns | 0.6495 ns | 0.0356 ns | 1.1536 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 | 0.7187 ns | 0.2898 ns | 0.0159 ns | 0.7145 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 | 0.6402 ns | 0.3178 ns | 0.0174 ns | 0.6394 ns |  0.89 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 | 1.2692 ns | 0.5460 ns | 0.0299 ns | 1.2772 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.2309 ns | 0.6044 ns | 0.0331 ns | 1.2170 ns |  0.97 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 | 0.7996 ns | 0.6451 ns | 0.0354 ns | 0.8150 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 | 0.7123 ns | 0.2365 ns | 0.0130 ns | 0.7049 ns |  0.89 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.5986 ns | 0.3789 ns | 0.0208 ns | 1.5920 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.8691 ns | 1.0392 ns | 0.0570 ns | 1.8595 ns |  1.17 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 | 3.2911 ns | 0.3126 ns | 0.0171 ns | 3.2928 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 | 2.1915 ns | 0.4436 ns | 0.0243 ns | 2.1969 ns |  0.67 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 2.2304 ns | 3.1406 ns | 0.1721 ns | 2.2478 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.7446 ns | 0.1381 ns | 0.0076 ns | 1.7446 ns |  0.79 |    0.06 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 | 2.3142 ns | 0.3945 ns | 0.0216 ns | 2.3087 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 | 2.0628 ns | 0.5706 ns | 0.0313 ns | 2.0573 ns |  0.89 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 2.1098 ns | 1.5800 ns | 0.0866 ns | 2.0650 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 2.0325 ns | 0.7741 ns | 0.0424 ns | 2.0165 ns |  0.96 |    0.05 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 | 6.5074 ns | 1.7923 ns | 0.0982 ns | 6.5081 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 | 8.1325 ns | 0.1829 ns | 0.0100 ns | 8.1285 ns |  1.25 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 3.0261 ns | 5.6774 ns | 0.3112 ns | 3.2014 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 2.4601 ns | 0.7473 ns | 0.0410 ns | 2.4823 ns |  0.82 |    0.08 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 | 0.7534 ns | 0.1664 ns | 0.0091 ns | 0.7495 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 | 0.7099 ns | 1.0926 ns | 0.0599 ns | 0.6880 ns |  0.94 |    0.09 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.6129 ns | 0.3160 ns | 0.0173 ns | 1.6119 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.2163 ns | 0.2402 ns | 0.0132 ns | 1.2173 ns |  0.75 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 | 3.7323 ns | 0.7545 ns | 0.0414 ns | 3.7540 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 2.7439 ns | 0.4959 ns | 0.0272 ns | 2.7419 ns |  0.74 |    0.01 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
           FromString | .NET Core 3.1 | 1.9457 ns | 0.5031 ns | 0.0276 ns | 1.9301 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.7852 ns | 0.5374 ns | 0.0295 ns | 1.7716 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 | 0.7087 ns | 0.4739 ns | 0.0260 ns | 0.7104 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 | 0.6691 ns | 0.1310 ns | 0.0072 ns | 0.6719 ns |  0.95 |    0.04 |     - |     - |     - |         - |
                      |               |           |           |           |           |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.1475 ns | 0.1889 ns | 0.0104 ns | 1.1522 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.1471 ns | 0.1615 ns | 0.0089 ns | 1.1502 ns |  1.00 |    0.01 |     - |     - |     - |         - |
