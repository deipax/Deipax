
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                     Method |     Toolchain |          Mean |          Error |        StdDev |        Median | Ratio | RatioSD |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |-------------- |--------------:|---------------:|--------------:|--------------:|------:|--------:|---------:|---------:|---------:|----------:|
             SingleInstance | .NET Core 3.1 |      78.41 ns |      10.138 ns |      0.556 ns |      78.45 ns |  1.00 |    0.00 |   0.0050 |        - |        - |      32 B |
             SingleInstance | .NET Core 5.0 |      73.69 ns |       8.917 ns |      0.489 ns |      73.62 ns |  0.94 |    0.01 |   0.0050 |        - |        - |      32 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
             ObjectInstance | .NET Core 3.1 |      46.39 ns |       5.790 ns |      0.317 ns |      46.56 ns |  1.00 |    0.00 |        - |        - |        - |         - |
             ObjectInstance | .NET Core 5.0 |      44.76 ns |      51.867 ns |      2.843 ns |      43.37 ns |  0.96 |    0.06 |        - |        - |        - |         - |
                            |               |               |                |               |               |       |         |          |          |          |           |
            DefaultInstance | .NET Core 3.1 |      20.17 ns |       3.522 ns |      0.193 ns |      20.14 ns |  1.00 |    0.00 |        - |        - |        - |         - |
            DefaultInstance | .NET Core 5.0 |      18.40 ns |       6.705 ns |      0.368 ns |      18.23 ns |  0.91 |    0.01 |        - |        - |        - |         - |
                            |               |               |                |               |               |       |         |          |          |          |           |
     ArrayOfDefaultInstance | .NET Core 3.1 |  26,696.88 ns |  29,687.071 ns |  1,627.249 ns |  27,297.71 ns |  1.00 |    0.00 |  32.6538 |  32.6538 |  32.6538 |  240015 B |
     ArrayOfDefaultInstance | .NET Core 5.0 |  62,079.27 ns |  17,090.926 ns |    936.811 ns |  61,869.30 ns |  2.33 |    0.18 |  22.5830 |  22.5830 |  22.5830 |  240025 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
        ArrayOfDiffInstance | .NET Core 3.1 |  25,745.06 ns |   6,157.346 ns |    337.505 ns |  25,937.41 ns |  1.00 |    0.00 |  32.3792 |  32.3792 |  32.3792 |  240015 B |
        ArrayOfDiffInstance | .NET Core 5.0 |  63,511.12 ns |  18,648.825 ns |  1,022.205 ns |  63,119.84 ns |  2.47 |    0.07 |  21.2402 |  21.2402 |  21.2402 |  240021 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
        ArrayOfSameInstance | .NET Core 3.1 |  25,335.71 ns |   1,898.758 ns |    104.077 ns |  25,354.76 ns |  1.00 |    0.00 |  32.7759 |  32.7759 |  32.7759 |  240015 B |
        ArrayOfSameInstance | .NET Core 5.0 |  65,400.51 ns |  29,981.587 ns |  1,643.392 ns |  65,935.61 ns |  2.58 |    0.07 |  22.7051 |  22.7051 |  22.7051 |  240021 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
 ArrayOfObjectsDiffInstance | .NET Core 3.1 | 269,127.75 ns |  18,712.612 ns |  1,025.701 ns | 268,674.12 ns |  1.00 |    0.00 |  12.2070 |        - |        - |   80024 B |
 ArrayOfObjectsDiffInstance | .NET Core 5.0 | 255,275.14 ns | 379,412.867 ns | 20,796.900 ns | 244,083.59 ns |  0.95 |    0.08 |  12.4512 |        - |        - |   80024 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
 ArrayOfObjectsSameInstance | .NET Core 3.1 | 270,236.49 ns |  13,724.051 ns |    752.262 ns | 270,348.58 ns |  1.00 |    0.00 |  12.2070 |        - |        - |   80024 B |
 ArrayOfObjectsSameInstance | .NET Core 5.0 | 235,704.04 ns |  19,357.320 ns |  1,061.040 ns | 235,430.18 ns |  0.87 |    0.01 |  12.4512 |        - |        - |   80024 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
      Array2dOfDiffInstance | .NET Core 3.1 |  23,178.20 ns |   3,491.766 ns |    191.395 ns |  23,186.09 ns |  1.00 |    0.00 |  38.7573 |  12.9089 |        - |  243224 B |
      Array2dOfDiffInstance | .NET Core 5.0 |  19,330.58 ns |   5,492.573 ns |    301.066 ns |  19,326.30 ns |  0.83 |    0.02 |  38.7573 |  12.9089 |        - |  243224 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
      Array2dOfSameInstance | .NET Core 3.1 |   3,359.80 ns |     285.402 ns |     15.644 ns |   3,351.10 ns |  1.00 |    0.00 |   0.5150 |        - |        - |    3248 B |
      Array2dOfSameInstance | .NET Core 5.0 |   2,649.43 ns |     462.652 ns |     25.360 ns |   2,654.17 ns |  0.79 |    0.01 |   0.5150 |        - |        - |    3248 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
   ArrayRank2OfDiffInstance | .NET Core 3.1 |     290.33 ns |      79.836 ns |      4.376 ns |     292.32 ns |  1.00 |    0.00 |   0.3886 |        - |        - |    2440 B |
   ArrayRank2OfDiffInstance | .NET Core 5.0 |     248.37 ns |      30.692 ns |      1.682 ns |     248.90 ns |  0.86 |    0.02 |   0.3886 |        - |        - |    2440 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
   ArrayRank2OfSameInstance | .NET Core 3.1 |     286.98 ns |      74.313 ns |      4.073 ns |     288.40 ns |  1.00 |    0.00 |   0.3886 |        - |        - |    2440 B |
   ArrayRank2OfSameInstance | .NET Core 5.0 |     252.87 ns |      58.718 ns |      3.219 ns |     254.38 ns |  0.88 |    0.02 |   0.3886 |        - |        - |    2440 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
   ArrayRank3OfDiffInstance | .NET Core 3.1 |   1,706.27 ns |     503.323 ns |     27.589 ns |   1,700.67 ns |  1.00 |    0.00 |   3.8300 |        - |        - |   24088 B |
   ArrayRank3OfDiffInstance | .NET Core 5.0 |   1,485.24 ns |     451.102 ns |     24.726 ns |   1,479.98 ns |  0.87 |    0.01 |   3.8300 |        - |        - |   24088 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
   ArrayRank3OfSameInstance | .NET Core 3.1 |   1,661.68 ns |     313.917 ns |     17.207 ns |   1,665.11 ns |  1.00 |    0.00 |   3.8300 |        - |        - |   24088 B |
   ArrayRank3OfSameInstance | .NET Core 5.0 |   1,512.24 ns |     454.521 ns |     24.914 ns |   1,506.88 ns |  0.91 |    0.01 |   3.8300 |        - |        - |   24088 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
         ListOfDiffInstance | .NET Core 3.1 |  25,665.39 ns |   2,645.801 ns |    145.025 ns |  25,649.65 ns |  1.00 |    0.00 |  33.3862 |  33.3557 |  33.3557 |  240295 B |
         ListOfDiffInstance | .NET Core 5.0 |  60,704.74 ns |  60,244.547 ns |  3,302.207 ns |  60,221.71 ns |  2.37 |    0.14 |  22.0947 |  22.0947 |  22.0947 |  240214 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
         ListOfSameInstance | .NET Core 3.1 |  27,880.98 ns |  35,321.869 ns |  1,936.111 ns |  28,668.88 ns |  1.00 |    0.00 |  33.0505 |  33.0200 |  33.0200 |  240291 B |
         ListOfSameInstance | .NET Core 5.0 |  61,147.20 ns |   8,868.132 ns |    486.092 ns |  61,347.83 ns |  2.20 |    0.17 |  20.9351 |  20.9351 |  20.9351 |  240208 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
  ListOfObjectsDiffInstance | .NET Core 3.1 | 290,176.01 ns |  30,832.364 ns |  1,690.026 ns | 290,566.70 ns |  1.00 |    0.00 |  12.2070 |   1.9531 |        - |   80056 B |
  ListOfObjectsDiffInstance | .NET Core 5.0 | 240,376.50 ns |  26,008.254 ns |  1,425.600 ns | 239,704.79 ns |  0.83 |    0.01 |  12.2070 |   1.9531 |        - |   80056 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
  ListOfObjectsSameInstance | .NET Core 3.1 | 297,600.05 ns |  99,916.085 ns |  5,476.738 ns | 295,002.98 ns |  1.00 |    0.00 |  12.2070 |   1.9531 |        - |   80056 B |
  ListOfObjectsSameInstance | .NET Core 5.0 | 238,670.37 ns |  16,299.077 ns |    893.407 ns | 238,822.95 ns |  0.80 |    0.01 |  12.4512 |   1.9531 |        - |   80056 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
           KeyValuePairSame | .NET Core 3.1 |      30.92 ns |      11.793 ns |      0.646 ns |      30.56 ns |  1.00 |    0.00 |        - |        - |        - |         - |
           KeyValuePairSame | .NET Core 5.0 |      27.91 ns |      39.210 ns |      2.149 ns |      28.13 ns |  0.90 |    0.09 |        - |        - |        - |         - |
                            |               |               |                |               |               |       |         |          |          |          |           |
           KeyValuePairDiff | .NET Core 3.1 |      30.96 ns |       3.877 ns |      0.212 ns |      31.01 ns |  1.00 |    0.00 |        - |        - |        - |         - |
           KeyValuePairDiff | .NET Core 5.0 |      25.67 ns |       4.154 ns |      0.228 ns |      25.72 ns |  0.83 |    0.00 |        - |        - |        - |         - |
                            |               |               |                |               |               |       |         |          |          |          |           |
          TupleSameInstance | .NET Core 3.1 |      73.80 ns |       2.835 ns |      0.155 ns |      73.79 ns |  1.00 |    0.00 |   0.0101 |        - |        - |      64 B |
          TupleSameInstance | .NET Core 5.0 |      62.75 ns |      23.347 ns |      1.280 ns |      62.01 ns |  0.85 |    0.02 |   0.0101 |        - |        - |      64 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
          TupleDiffInstance | .NET Core 3.1 |      78.24 ns |      11.649 ns |      0.639 ns |      78.29 ns |  1.00 |    0.00 |   0.0101 |        - |        - |      64 B |
          TupleDiffInstance | .NET Core 5.0 |      61.27 ns |      16.386 ns |      0.898 ns |      60.90 ns |  0.78 |    0.02 |   0.0101 |        - |        - |      64 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
     DictionarySameInstance | .NET Core 3.1 | 751,815.53 ns | 254,539.493 ns | 13,952.169 ns | 744,768.65 ns |  1.00 |    0.00 | 196.2891 | 156.2500 | 139.6484 |  926474 B |
     DictionarySameInstance | .NET Core 5.0 | 652,756.05 ns | 887,102.845 ns | 48,625.100 ns | 626,697.95 ns |  0.87 |    0.07 | 194.3359 | 156.2500 | 137.6953 |  926437 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
     DictionaryDiffInstance | .NET Core 3.1 | 739,028.16 ns | 107,465.719 ns |  5,890.559 ns | 742,312.79 ns |  1.00 |    0.00 | 196.2891 | 158.2031 | 139.6484 |  926424 B |
     DictionaryDiffInstance | .NET Core 5.0 | 622,374.66 ns | 220,481.035 ns | 12,085.309 ns | 620,234.81 ns |  0.84 |    0.01 | 194.3359 | 155.2734 | 137.6953 |  926450 B |
