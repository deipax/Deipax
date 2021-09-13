
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

               Method |     Toolchain |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------------- |-------------- |---------:|----------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
             FromBool | .NET Core 3.1 | 4.663 ns | 2.4164 ns | 0.1325 ns | 4.645 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromBool | .NET Core 5.0 | 4.286 ns | 0.8917 ns | 0.0489 ns | 4.283 ns |  0.92 |    0.02 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromBoolNullable | .NET Core 3.1 | 1.559 ns | 4.5082 ns | 0.2471 ns | 1.439 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromBoolNullable | .NET Core 5.0 | 1.130 ns | 0.3376 ns | 0.0185 ns | 1.121 ns |  0.74 |    0.11 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromChar | .NET Core 3.1 | 4.230 ns | 1.3614 ns | 0.0746 ns | 4.238 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromChar | .NET Core 5.0 | 4.227 ns | 1.3582 ns | 0.0744 ns | 4.191 ns |  1.00 |    0.03 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromCharNullable | .NET Core 3.1 | 1.363 ns | 0.4988 ns | 0.0273 ns | 1.349 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromCharNullable | .NET Core 5.0 | 1.443 ns | 4.0995 ns | 0.2247 ns | 1.326 ns |  1.06 |    0.18 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromSByte | .NET Core 3.1 | 4.547 ns | 8.2085 ns | 0.4499 ns | 4.383 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromSByte | .NET Core 5.0 | 4.119 ns | 1.3961 ns | 0.0765 ns | 4.147 ns |  0.91 |    0.08 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromSByteNullable | .NET Core 3.1 | 1.119 ns | 0.2119 ns | 0.0116 ns | 1.117 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromSByteNullable | .NET Core 5.0 | 1.120 ns | 0.3265 ns | 0.0179 ns | 1.118 ns |  1.00 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromByte | .NET Core 3.1 | 4.153 ns | 3.5194 ns | 0.1929 ns | 4.057 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromByte | .NET Core 5.0 | 4.089 ns | 0.9473 ns | 0.0519 ns | 4.085 ns |  0.99 |    0.06 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromByteNullable | .NET Core 3.1 | 1.131 ns | 0.3162 ns | 0.0173 ns | 1.122 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromByteNullable | .NET Core 5.0 | 1.143 ns | 0.4020 ns | 0.0220 ns | 1.149 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromShort | .NET Core 3.1 | 4.171 ns | 0.7057 ns | 0.0387 ns | 4.185 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromShort | .NET Core 5.0 | 4.713 ns | 2.1953 ns | 0.1203 ns | 4.747 ns |  1.13 |    0.02 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromShortNullable | .NET Core 3.1 | 1.350 ns | 0.2338 ns | 0.0128 ns | 1.346 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromShortNullable | .NET Core 5.0 | 1.328 ns | 0.2579 ns | 0.0141 ns | 1.320 ns |  0.98 |    0.00 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromUShort | .NET Core 3.1 | 4.161 ns | 2.0565 ns | 0.1127 ns | 4.204 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromUShort | .NET Core 5.0 | 4.160 ns | 2.1519 ns | 0.1180 ns | 4.160 ns |  1.00 |    0.04 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
   FromUShortNullable | .NET Core 3.1 | 1.438 ns | 0.6704 ns | 0.0367 ns | 1.431 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromUShortNullable | .NET Core 5.0 | 1.320 ns | 0.0095 ns | 0.0005 ns | 1.320 ns |  0.92 |    0.02 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
              FromInt | .NET Core 3.1 | 4.647 ns | 0.6554 ns | 0.0359 ns | 4.666 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
              FromInt | .NET Core 5.0 | 4.474 ns | 8.7873 ns | 0.4817 ns | 4.198 ns |  0.96 |    0.10 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
      FromIntNullable | .NET Core 3.1 | 1.553 ns | 3.3441 ns | 0.1833 ns | 1.527 ns |  1.00 |    0.00 |      - |     - |     - |         - |
      FromIntNullable | .NET Core 5.0 | 1.651 ns | 0.0838 ns | 0.0046 ns | 1.649 ns |  1.07 |    0.12 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromUInt | .NET Core 3.1 | 4.139 ns | 1.4646 ns | 0.0803 ns | 4.158 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromUInt | .NET Core 5.0 | 4.264 ns | 0.5763 ns | 0.0316 ns | 4.262 ns |  1.03 |    0.02 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromUIntNullable | .NET Core 3.1 | 1.565 ns | 2.9568 ns | 0.1621 ns | 1.658 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromUIntNullable | .NET Core 5.0 | 1.351 ns | 0.0656 ns | 0.0036 ns | 1.350 ns |  0.87 |    0.10 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromLong | .NET Core 3.1 | 4.231 ns | 3.2465 ns | 0.1780 ns | 4.185 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromLong | .NET Core 5.0 | 4.202 ns | 0.2787 ns | 0.0153 ns | 4.198 ns |  0.99 |    0.04 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromLongNullable | .NET Core 3.1 | 1.874 ns | 0.7276 ns | 0.0399 ns | 1.870 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromLongNullable | .NET Core 5.0 | 1.722 ns | 0.6256 ns | 0.0343 ns | 1.705 ns |  0.92 |    0.04 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromULong | .NET Core 3.1 | 4.205 ns | 0.7813 ns | 0.0428 ns | 4.224 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromULong | .NET Core 5.0 | 4.154 ns | 0.9478 ns | 0.0520 ns | 4.167 ns |  0.99 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromULongNullable | .NET Core 3.1 | 1.731 ns | 0.2896 ns | 0.0159 ns | 1.727 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromULongNullable | .NET Core 5.0 | 1.696 ns | 0.2457 ns | 0.0135 ns | 1.703 ns |  0.98 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
            FromFloat | .NET Core 3.1 | 4.287 ns | 0.8693 ns | 0.0476 ns | 4.268 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
            FromFloat | .NET Core 5.0 | 4.684 ns | 7.3265 ns | 0.4016 ns | 4.552 ns |  1.09 |    0.10 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
    FromFloatNullable | .NET Core 3.1 | 1.298 ns | 0.1751 ns | 0.0096 ns | 1.293 ns |  1.00 |    0.00 |      - |     - |     - |         - |
    FromFloatNullable | .NET Core 5.0 | 1.309 ns | 0.1973 ns | 0.0108 ns | 1.310 ns |  1.01 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromDouble | .NET Core 3.1 | 4.525 ns | 5.0549 ns | 0.2771 ns | 4.418 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
           FromDouble | .NET Core 5.0 | 4.322 ns | 0.8357 ns | 0.0458 ns | 4.323 ns |  0.96 |    0.07 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
   FromDoubleNullable | .NET Core 3.1 | 2.137 ns | 0.7017 ns | 0.0385 ns | 2.126 ns |  1.00 |    0.00 |      - |     - |     - |         - |
   FromDoubleNullable | .NET Core 5.0 | 1.574 ns | 0.2017 ns | 0.0111 ns | 1.579 ns |  0.74 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
          FromDecimal | .NET Core 3.1 | 6.247 ns | 1.7477 ns | 0.0958 ns | 6.212 ns |  1.00 |    0.00 | 0.0051 |     - |     - |      32 B |
          FromDecimal | .NET Core 5.0 | 5.448 ns | 1.1069 ns | 0.0607 ns | 5.465 ns |  0.87 |    0.02 | 0.0051 |     - |     - |      32 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
  FromDecimalNullable | .NET Core 3.1 | 1.728 ns | 0.7868 ns | 0.0431 ns | 1.708 ns |  1.00 |    0.00 |      - |     - |     - |         - |
  FromDecimalNullable | .NET Core 5.0 | 1.792 ns | 0.4304 ns | 0.0236 ns | 1.783 ns |  1.04 |    0.03 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
         FromDateTime | .NET Core 3.1 | 4.144 ns | 0.5879 ns | 0.0322 ns | 4.155 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
         FromDateTime | .NET Core 5.0 | 4.227 ns | 0.5734 ns | 0.0314 ns | 4.210 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
 FromDateTimeNullable | .NET Core 3.1 | 1.807 ns | 0.1344 ns | 0.0074 ns | 1.808 ns |  1.00 |    0.00 |      - |     - |     - |         - |
 FromDateTimeNullable | .NET Core 5.0 | 1.574 ns | 0.4679 ns | 0.0256 ns | 1.560 ns |  0.87 |    0.01 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromObject | .NET Core 3.1 | 1.725 ns | 0.7699 ns | 0.0422 ns | 1.719 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromObject | .NET Core 5.0 | 1.883 ns | 0.0983 ns | 0.0054 ns | 1.886 ns |  1.09 |    0.03 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
           FromString | .NET Core 3.1 | 1.871 ns | 0.0724 ns | 0.0040 ns | 1.872 ns |  1.00 |    0.00 |      - |     - |     - |         - |
           FromString | .NET Core 5.0 | 1.736 ns | 0.6084 ns | 0.0333 ns | 1.738 ns |  0.93 |    0.02 |      - |     - |     - |         - |
                      |               |          |           |           |          |       |         |        |       |       |           |
             FromEnum | .NET Core 3.1 | 4.129 ns | 0.1995 ns | 0.0109 ns | 4.131 ns |  1.00 |    0.00 | 0.0038 |     - |     - |      24 B |
             FromEnum | .NET Core 5.0 | 4.200 ns | 0.8578 ns | 0.0470 ns | 4.211 ns |  1.02 |    0.01 | 0.0038 |     - |     - |      24 B |
                      |               |          |           |           |          |       |         |        |       |       |           |
     FromEnumNullable | .NET Core 3.1 | 1.361 ns | 0.0825 ns | 0.0045 ns | 1.362 ns |  1.00 |    0.00 |      - |     - |     - |         - |
     FromEnumNullable | .NET Core 5.0 | 1.354 ns | 0.0642 ns | 0.0035 ns | 1.354 ns |  0.99 |    0.00 |      - |     - |     - |         - |
