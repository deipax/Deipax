
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |-----------:|----------:|----------:|-----------:|------:|--------:|------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 |  0.9872 ns | 0.4695 ns | 0.0257 ns |  0.9753 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromBool | .NET Core 5.0 |  1.1877 ns | 0.2504 ns | 0.0137 ns |  1.1881 ns |  1.20 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromBoolNullable | .NET Core 3.1 |  1.0870 ns | 0.9620 ns | 0.0527 ns |  1.0684 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 |  1.2358 ns | 0.4404 ns | 0.0241 ns |  1.2417 ns |  1.14 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromChar | .NET Core 3.1 |  0.5133 ns | 0.2872 ns | 0.0157 ns |  0.5043 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromChar | .NET Core 5.0 |  0.7461 ns | 0.3275 ns | 0.0179 ns |  0.7521 ns |  1.45 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromCharNullable | .NET Core 3.1 |  1.0118 ns | 0.6588 ns | 0.0361 ns |  0.9913 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 |  1.0111 ns | 1.0725 ns | 0.0588 ns |  0.9794 ns |  1.00 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromSByte | .NET Core 3.1 |  0.5491 ns | 0.3829 ns | 0.0210 ns |  0.5561 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromSByte | .NET Core 5.0 |  0.7530 ns | 0.1002 ns | 0.0055 ns |  0.7534 ns |  1.37 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromSByteNullable | .NET Core 3.1 |  1.0008 ns | 0.1501 ns | 0.0082 ns |  0.9976 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 |  1.1402 ns | 1.9205 ns | 0.1053 ns |  1.1129 ns |  1.14 |    0.11 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromByte | .NET Core 3.1 |  0.5049 ns | 0.1447 ns | 0.0079 ns |  0.5044 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromByte | .NET Core 5.0 |  0.7907 ns | 0.8281 ns | 0.0454 ns |  0.7715 ns |  1.57 |    0.11 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromByteNullable | .NET Core 3.1 |  1.2272 ns | 0.6298 ns | 0.0345 ns |  1.2078 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 |  1.2046 ns | 0.1954 ns | 0.0107 ns |  1.2010 ns |  0.98 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromShort | .NET Core 3.1 |  0.7540 ns | 0.4162 ns | 0.0228 ns |  0.7435 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromShort | .NET Core 5.0 |  0.7280 ns | 0.2769 ns | 0.0152 ns |  0.7203 ns |  0.97 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromShortNullable | .NET Core 3.1 |  1.2441 ns | 0.5896 ns | 0.0323 ns |  1.2297 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 |  1.2427 ns | 0.0625 ns | 0.0034 ns |  1.2445 ns |  1.00 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromUShort | .NET Core 3.1 |  0.7299 ns | 0.2758 ns | 0.0151 ns |  0.7313 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromUShort | .NET Core 5.0 |  0.7143 ns | 0.0922 ns | 0.0051 ns |  0.7160 ns |  0.98 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromUShortNullable | .NET Core 3.1 |  1.0364 ns | 1.4974 ns | 0.0821 ns |  1.0100 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 |  1.0004 ns | 0.2284 ns | 0.0125 ns |  0.9982 ns |  0.97 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
              FromInt | .NET Core 3.1 |  2.1219 ns | 0.1764 ns | 0.0097 ns |  2.1236 ns |  1.00 |    0.00 |     - |     - |     - |         - |
              FromInt | .NET Core 5.0 |  0.7166 ns | 0.1540 ns | 0.0084 ns |  0.7165 ns |  0.34 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
      FromIntNullable | .NET Core 3.1 |  2.3001 ns | 0.5710 ns | 0.0313 ns |  2.2943 ns |  1.00 |    0.00 |     - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 |  1.2278 ns | 0.4779 ns | 0.0262 ns |  1.2177 ns |  0.53 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromUInt | .NET Core 3.1 |  0.5556 ns | 0.5245 ns | 0.0288 ns |  0.5399 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromUInt | .NET Core 5.0 |  0.7495 ns | 0.9270 ns | 0.0508 ns |  0.7420 ns |  1.35 |    0.15 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromUIntNullable | .NET Core 3.1 |  1.0507 ns | 0.8507 ns | 0.0466 ns |  1.0360 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 |  1.2315 ns | 0.3713 ns | 0.0204 ns |  1.2329 ns |  1.17 |    0.03 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromLong | .NET Core 3.1 |  1.7419 ns | 1.8041 ns | 0.0989 ns |  1.7980 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromLong | .NET Core 5.0 |  1.6595 ns | 0.1811 ns | 0.0099 ns |  1.6574 ns |  0.96 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromLongNullable | .NET Core 3.1 |  3.0205 ns | 1.0933 ns | 0.0599 ns |  3.0542 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 |  3.1487 ns | 0.6125 ns | 0.0336 ns |  3.1659 ns |  1.04 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromULong | .NET Core 3.1 |  1.5099 ns | 0.6242 ns | 0.0342 ns |  1.4949 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromULong | .NET Core 5.0 |  1.8460 ns | 1.2340 ns | 0.0676 ns |  1.8078 ns |  1.22 |    0.07 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromULongNullable | .NET Core 3.1 |  3.0310 ns | 1.1356 ns | 0.0622 ns |  3.0227 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 |  2.7814 ns | 1.0502 ns | 0.0576 ns |  2.8080 ns |  0.92 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
            FromFloat | .NET Core 3.1 |  4.4920 ns | 1.1544 ns | 0.0633 ns |  4.4597 ns |  1.00 |    0.00 |     - |     - |     - |         - |
            FromFloat | .NET Core 5.0 |  3.6782 ns | 1.1279 ns | 0.0618 ns |  3.7116 ns |  0.82 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
    FromFloatNullable | .NET Core 3.1 |  4.6551 ns | 3.5945 ns | 0.1970 ns |  4.7324 ns |  1.00 |    0.00 |     - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 |  3.4944 ns | 1.7396 ns | 0.0954 ns |  3.5075 ns |  0.75 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromDouble | .NET Core 3.1 |  4.3058 ns | 0.8454 ns | 0.0463 ns |  4.3244 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromDouble | .NET Core 5.0 |  2.9769 ns | 0.5792 ns | 0.0318 ns |  2.9892 ns |  0.69 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
   FromDoubleNullable | .NET Core 3.1 |  5.5389 ns | 0.8342 ns | 0.0457 ns |  5.5620 ns |  1.00 |    0.00 |     - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 |  3.8205 ns | 0.3436 ns | 0.0188 ns |  3.8156 ns |  0.69 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
          FromDecimal | .NET Core 3.1 |  6.9408 ns | 2.4198 ns | 0.1326 ns |  6.8723 ns |  1.00 |    0.00 |     - |     - |     - |         - |
          FromDecimal | .NET Core 5.0 |  9.1078 ns | 4.5167 ns | 0.2476 ns |  9.0124 ns |  1.31 |    0.05 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 12.9532 ns | 1.2629 ns | 0.0692 ns | 12.9183 ns |  1.00 |    0.00 |     - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 10.0533 ns | 2.1399 ns | 0.1173 ns | 10.1029 ns |  0.78 |    0.01 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
         FromDateTime | .NET Core 3.1 |  0.5177 ns | 0.3502 ns | 0.0192 ns |  0.5076 ns |  1.00 |    0.00 |     - |     - |     - |         - |
         FromDateTime | .NET Core 5.0 |  0.9167 ns | 0.0374 ns | 0.0020 ns |  0.9158 ns |  1.77 |    0.06 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 |  1.4872 ns | 1.3727 ns | 0.0752 ns |  1.4893 ns |  1.00 |    0.00 |     - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 |  1.2242 ns | 0.3857 ns | 0.0211 ns |  1.2209 ns |  0.82 |    0.04 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromObject | .NET Core 3.1 |  2.1729 ns | 0.1212 ns | 0.0066 ns |  2.1749 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromObject | .NET Core 5.0 |  2.0526 ns | 0.8175 ns | 0.0448 ns |  2.0404 ns |  0.94 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
           FromString | .NET Core 3.1 |  9.2383 ns | 1.1753 ns | 0.0644 ns |  9.2463 ns |  1.00 |    0.00 |     - |     - |     - |         - |
           FromString | .NET Core 5.0 |  8.4597 ns | 1.5258 ns | 0.0836 ns |  8.4427 ns |  0.92 |    0.02 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
             FromEnum | .NET Core 3.1 |  1.6085 ns | 0.9515 ns | 0.0522 ns |  1.5832 ns |  1.00 |    0.00 |     - |     - |     - |         - |
             FromEnum | .NET Core 5.0 |  0.6739 ns | 0.3266 ns | 0.0179 ns |  0.6684 ns |  0.42 |    0.00 |     - |     - |     - |         - |
                      |               |            |           |           |            |       |         |       |       |       |           |
     FromEnumNullable | .NET Core 3.1 |  1.9761 ns | 1.3746 ns | 0.0753 ns |  1.9849 ns |  1.00 |    0.00 |     - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 |  0.9655 ns | 0.6490 ns | 0.0356 ns |  0.9495 ns |  0.49 |    0.04 |     - |     - |     - |         - |
