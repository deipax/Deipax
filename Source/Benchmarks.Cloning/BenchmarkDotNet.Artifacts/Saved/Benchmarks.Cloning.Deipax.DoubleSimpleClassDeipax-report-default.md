
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                     Method |     Toolchain |            Mean |            Error |        StdDev |          Median | Ratio | RatioSD |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |-------------- |----------------:|-----------------:|--------------:|----------------:|------:|--------:|---------:|---------:|--------:|----------:|
             SingleInstance | .NET Core 3.1 |       156.06 ns |        71.835 ns |      3.938 ns |       154.67 ns |  1.00 |    0.00 |   0.0153 |        - |       - |      96 B |
             SingleInstance | .NET Core 5.0 |       130.63 ns |        25.094 ns |      1.375 ns |       130.10 ns |  0.84 |    0.03 |   0.0153 |        - |       - |      96 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
             ObjectInstance | .NET Core 3.1 |       167.51 ns |        13.849 ns |      0.759 ns |       167.68 ns |  1.00 |    0.00 |   0.0153 |        - |       - |      96 B |
             ObjectInstance | .NET Core 5.0 |       161.42 ns |       239.798 ns |     13.144 ns |       154.66 ns |  0.96 |    0.08 |   0.0153 |        - |       - |      96 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
            DefaultInstance | .NET Core 3.1 |        20.04 ns |         1.282 ns |      0.070 ns |        20.07 ns |  1.00 |    0.00 |        - |        - |       - |         - |
            DefaultInstance | .NET Core 5.0 |        19.79 ns |         1.313 ns |      0.072 ns |        19.83 ns |  0.99 |    0.01 |        - |        - |       - |         - |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
     ArrayOfDefaultInstance | .NET Core 3.1 |     7,096.83 ns |     2,214.997 ns |    121.411 ns |     7,059.20 ns |  1.00 |    0.00 |  12.6572 |        - |       - |   80024 B |
     ArrayOfDefaultInstance | .NET Core 5.0 |     7,222.79 ns |     1,305.761 ns |     71.573 ns |     7,219.38 ns |  1.02 |    0.03 |  12.6572 |        - |       - |   80024 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
        ArrayOfDiffInstance | .NET Core 3.1 | 1,442,409.83 ns |   126,905.370 ns |  6,956.112 ns | 1,442,945.51 ns |  1.00 |    0.00 | 164.0625 |  70.3125 |       - | 1040024 B |
        ArrayOfDiffInstance | .NET Core 5.0 | 1,264,440.95 ns |   146,338.420 ns |  8,021.303 ns | 1,265,553.91 ns |  0.88 |    0.00 | 164.0625 |  68.3594 |       - | 1040030 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
        ArrayOfSameInstance | .NET Core 3.1 |   249,560.89 ns |    24,000.926 ns |  1,315.572 ns |   249,023.10 ns |  1.00 |    0.00 |  12.2070 |        - |       - |   80120 B |
        ArrayOfSameInstance | .NET Core 5.0 |   227,233.46 ns |    41,205.543 ns |  2,258.615 ns |   226,650.24 ns |  0.91 |    0.01 |  12.4512 |        - |       - |   80120 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
 ArrayOfObjectsDiffInstance | .NET Core 3.1 | 1,677,579.10 ns |   155,516.232 ns |  8,524.369 ns | 1,679,867.38 ns |  1.00 |    0.00 | 164.0625 |  70.3125 |       - | 1040024 B |
 ArrayOfObjectsDiffInstance | .NET Core 5.0 | 1,517,035.61 ns |   143,905.421 ns |  7,887.942 ns | 1,513,095.31 ns |  0.90 |    0.01 | 164.0625 |  68.3594 |       - | 1040026 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
 ArrayOfObjectsSameInstance | .NET Core 3.1 |   462,286.65 ns |    37,133.356 ns |  2,035.405 ns |   463,011.08 ns |  1.00 |    0.00 |  12.2070 |        - |       - |   80120 B |
 ArrayOfObjectsSameInstance | .NET Core 5.0 |   393,923.89 ns |    35,823.022 ns |  1,963.581 ns |   394,395.26 ns |  0.85 |    0.00 |  12.2070 |        - |       - |   80120 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
      Array2dOfDiffInstance | .NET Core 3.1 | 1,485,370.57 ns |   194,187.668 ns | 10,644.081 ns | 1,481,672.27 ns |  1.00 |    0.00 | 166.0156 |  74.2188 |       - | 1043224 B |
      Array2dOfDiffInstance | .NET Core 5.0 | 1,252,894.53 ns |    56,644.278 ns |  3,104.864 ns | 1,254,491.60 ns |  0.84 |    0.00 | 166.0156 |  74.2188 |       - | 1043224 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
      Array2dOfSameInstance | .NET Core 3.1 |    15,979.99 ns |    18,207.210 ns |    997.999 ns |    16,047.85 ns |  1.00 |    0.00 |   1.7853 |   0.0610 |       - |   11248 B |
      Array2dOfSameInstance | .NET Core 5.0 |    12,918.05 ns |     1,092.379 ns |     59.877 ns |    12,949.66 ns |  0.81 |    0.05 |   1.7853 |   0.0610 |       - |   11248 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank2OfDiffInstance | .NET Core 3.1 |    12,011.12 ns |       626.474 ns |     34.339 ns |    12,026.25 ns |  1.00 |    0.00 |   1.6632 |   0.0610 |       - |   10440 B |
   ArrayRank2OfDiffInstance | .NET Core 5.0 |    10,685.56 ns |     2,163.455 ns |    118.586 ns |    10,691.15 ns |  0.89 |    0.01 |   1.6632 |   0.0458 |       - |   10440 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank2OfSameInstance | .NET Core 3.1 |     3,195.76 ns |       475.991 ns |     26.091 ns |     3,182.60 ns |  1.00 |    0.00 |   0.1488 |        - |       - |     936 B |
   ArrayRank2OfSameInstance | .NET Core 5.0 |     2,764.42 ns |       437.813 ns |     23.998 ns |     2,761.07 ns |  0.87 |    0.00 |   0.1488 |        - |       - |     936 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank3OfDiffInstance | .NET Core 3.1 |   192,775.53 ns |    51,083.478 ns |  2,800.058 ns |   191,999.12 ns |  1.00 |    0.00 |  16.6016 |   3.6621 |       - |  104168 B |
   ArrayRank3OfDiffInstance | .NET Core 5.0 |   167,819.82 ns |    18,424.785 ns |  1,009.925 ns |   168,201.10 ns |  0.87 |    0.01 |  16.6016 |   3.6621 |       - |  104168 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank3OfSameInstance | .NET Core 3.1 |    90,467.15 ns |    15,662.837 ns |    858.533 ns |    90,079.30 ns |  1.00 |    0.00 |   1.2207 |        - |       - |    8264 B |
   ArrayRank3OfSameInstance | .NET Core 5.0 |    81,814.95 ns |    36,273.135 ns |  1,988.253 ns |    80,909.16 ns |  0.90 |    0.01 |   1.2207 |        - |       - |    8264 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
         ListOfDiffInstance | .NET Core 3.1 | 1,400,153.91 ns |   212,651.198 ns | 11,656.130 ns | 1,406,318.55 ns |  1.00 |    0.00 | 164.0625 |  68.3594 |       - | 1040056 B |
         ListOfDiffInstance | .NET Core 5.0 | 1,267,018.16 ns |   158,053.709 ns |  8,663.457 ns | 1,266,007.62 ns |  0.90 |    0.01 | 164.0625 |  68.3594 |       - | 1040056 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
         ListOfSameInstance | .NET Core 3.1 |   253,454.18 ns |    27,070.490 ns |  1,483.825 ns |   253,908.59 ns |  1.00 |    0.00 |  12.2070 |   1.9531 |       - |   80152 B |
         ListOfSameInstance | .NET Core 5.0 |   215,079.03 ns |     5,468.751 ns |    299.761 ns |   215,199.12 ns |  0.85 |    0.00 |  12.4512 |   1.9531 |       - |   80152 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
  ListOfObjectsDiffInstance | .NET Core 3.1 | 1,663,512.17 ns |   141,532.889 ns |  7,757.895 ns | 1,660,853.71 ns |  1.00 |    0.00 | 164.0625 |  68.3594 |       - | 1040056 B |
  ListOfObjectsDiffInstance | .NET Core 5.0 | 1,500,509.57 ns |   183,099.969 ns | 10,036.327 ns | 1,494,823.44 ns |  0.90 |    0.01 | 164.0625 |  68.3594 |       - | 1040062 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
  ListOfObjectsSameInstance | .NET Core 3.1 |   451,189.97 ns |    96,537.858 ns |  5,291.566 ns |   449,875.93 ns |  1.00 |    0.00 |  12.2070 |   1.9531 |       - |   80152 B |
  ListOfObjectsSameInstance | .NET Core 5.0 |   414,395.36 ns |    80,702.821 ns |  4,423.594 ns |   414,941.70 ns |  0.92 |    0.02 |  12.2070 |   1.9531 |       - |   80152 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
           KeyValuePairSame | .NET Core 3.1 |       194.69 ns |        33.166 ns |      1.818 ns |       194.35 ns |  1.00 |    0.00 |   0.0153 |        - |       - |      96 B |
           KeyValuePairSame | .NET Core 5.0 |       175.34 ns |        29.522 ns |      1.618 ns |       175.09 ns |  0.90 |    0.01 |   0.0153 |        - |       - |      96 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
           KeyValuePairDiff | .NET Core 3.1 |       275.14 ns |        14.072 ns |      0.771 ns |       274.84 ns |  1.00 |    0.00 |   0.0305 |        - |       - |     192 B |
           KeyValuePairDiff | .NET Core 5.0 |       244.55 ns |        29.045 ns |      1.592 ns |       244.70 ns |  0.89 |    0.01 |   0.0305 |        - |       - |     192 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
          TupleSameInstance | .NET Core 3.1 |       205.26 ns |        23.654 ns |      1.297 ns |       205.65 ns |  1.00 |    0.00 |   0.0203 |        - |       - |     128 B |
          TupleSameInstance | .NET Core 5.0 |       192.10 ns |         8.093 ns |      0.444 ns |       192.27 ns |  0.94 |    0.01 |   0.0203 |        - |       - |     128 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
          TupleDiffInstance | .NET Core 3.1 |       293.22 ns |        17.757 ns |      0.973 ns |       293.15 ns |  1.00 |    0.00 |   0.0353 |        - |       - |     224 B |
          TupleDiffInstance | .NET Core 5.0 |       256.27 ns |        24.982 ns |      1.369 ns |       256.85 ns |  0.87 |    0.00 |   0.0353 |        - |       - |     224 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
     DictionarySameInstance | .NET Core 3.1 | 3,414,325.91 ns |   170,686.683 ns |  9,355.913 ns | 3,411,205.08 ns |  1.00 |    0.00 | 210.9375 | 140.6250 | 62.5000 | 1243092 B |
     DictionarySameInstance | .NET Core 5.0 | 2,908,148.70 ns | 1,340,899.363 ns | 73,499.219 ns | 2,930,369.14 ns |  0.85 |    0.02 | 203.1250 | 125.0000 | 54.6875 | 1243124 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
     DictionaryDiffInstance | .NET Core 3.1 | 6,143,789.06 ns |   468,997.142 ns | 25,707.316 ns | 6,141,633.59 ns |  1.00 |    0.00 | 359.3750 | 171.8750 | 62.5000 | 2203125 B |
     DictionaryDiffInstance | .NET Core 5.0 | 5,104,437.76 ns |   536,508.651 ns | 29,407.850 ns | 5,104,832.81 ns |  0.83 |    0.00 | 351.5625 | 171.8750 | 62.5000 | 2203040 B |
