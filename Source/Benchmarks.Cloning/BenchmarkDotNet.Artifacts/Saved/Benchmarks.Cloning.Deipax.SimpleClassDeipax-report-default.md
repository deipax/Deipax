
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                     Method |     Toolchain |            Mean |            Error |        StdDev |          Median | Ratio | RatioSD |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |-------------- |----------------:|-----------------:|--------------:|----------------:|------:|--------:|---------:|---------:|--------:|----------:|
             SingleInstance | .NET Core 3.1 |        84.85 ns |        52.850 ns |      2.897 ns |        84.24 ns |  1.00 |    0.00 |   0.0101 |        - |       - |      64 B |
             SingleInstance | .NET Core 5.0 |        68.37 ns |        15.836 ns |      0.868 ns |        68.79 ns |  0.81 |    0.03 |   0.0101 |        - |       - |      64 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
             ObjectInstance | .NET Core 3.1 |       107.04 ns |        32.861 ns |      1.801 ns |       107.80 ns |  1.00 |    0.00 |   0.0100 |        - |       - |      64 B |
             ObjectInstance | .NET Core 5.0 |        90.19 ns |        19.111 ns |      1.048 ns |        90.64 ns |  0.84 |    0.01 |   0.0101 |        - |       - |      64 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
            DefaultInstance | .NET Core 3.1 |        19.92 ns |         0.933 ns |      0.051 ns |        19.95 ns |  1.00 |    0.00 |        - |        - |       - |         - |
            DefaultInstance | .NET Core 5.0 |        21.02 ns |         4.772 ns |      0.262 ns |        21.08 ns |  1.06 |    0.01 |        - |        - |       - |         - |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
     ArrayOfDefaultInstance | .NET Core 3.1 |     9,461.56 ns |     1,753.658 ns |     96.124 ns |     9,497.00 ns |  1.00 |    0.00 |  12.6495 |        - |       - |   80024 B |
     ArrayOfDefaultInstance | .NET Core 5.0 |     9,547.59 ns |     2,649.785 ns |    145.244 ns |     9,471.78 ns |  1.01 |    0.03 |  12.6495 |        - |       - |   80024 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
        ArrayOfDiffInstance | .NET Core 3.1 |   721,647.07 ns | 1,082,021.443 ns | 59,309.246 ns |   700,024.02 ns |  1.00 |    0.00 | 114.2578 |  48.8281 |       - |  720024 B |
        ArrayOfDiffInstance | .NET Core 5.0 |   515,237.86 ns |   142,523.296 ns |  7,812.183 ns |   511,643.36 ns |  0.72 |    0.06 | 114.2578 |  48.8281 |       - |  720024 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
        ArrayOfSameInstance | .NET Core 3.1 |   249,499.97 ns |    30,552.434 ns |  1,674.682 ns |   249,126.71 ns |  1.00 |    0.00 |  12.2070 |        - |       - |   80088 B |
        ArrayOfSameInstance | .NET Core 5.0 |   217,323.92 ns |    22,190.059 ns |  1,216.312 ns |   216,983.15 ns |  0.87 |    0.01 |  12.4512 |        - |       - |   80088 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
 ArrayOfObjectsDiffInstance | .NET Core 3.1 |   846,948.54 ns |   179,067.727 ns |  9,815.306 ns |   848,100.20 ns |  1.00 |    0.00 | 114.2578 |  48.8281 |       - |  720024 B |
 ArrayOfObjectsDiffInstance | .NET Core 5.0 |   729,419.89 ns |    20,701.885 ns |  1,134.740 ns |   729,081.05 ns |  0.86 |    0.01 | 114.2578 |  48.8281 |       - |  720024 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
 ArrayOfObjectsSameInstance | .NET Core 3.1 |   469,055.32 ns |    32,323.257 ns |  1,771.747 ns |   468,066.65 ns |  1.00 |    0.00 |  12.2070 |        - |       - |   80088 B |
 ArrayOfObjectsSameInstance | .NET Core 5.0 |   414,798.99 ns |    21,886.958 ns |  1,199.698 ns |   414,956.98 ns |  0.88 |    0.00 |  12.2070 |        - |       - |   80088 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
      Array2dOfDiffInstance | .NET Core 3.1 |   571,728.52 ns |   102,912.975 ns |  5,641.007 ns |   572,635.25 ns |  1.00 |    0.00 | 115.2344 |  43.9453 |       - |  723224 B |
      Array2dOfDiffInstance | .NET Core 5.0 |   538,291.80 ns |   113,719.161 ns |  6,233.331 ns |   536,236.82 ns |  0.94 |    0.02 | 115.2344 |  43.9453 |       - |  723224 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
      Array2dOfSameInstance | .NET Core 3.1 |     8,252.51 ns |        66.918 ns |      3.668 ns |     8,252.82 ns |  1.00 |    0.00 |   1.2817 |   0.0305 |       - |    8048 B |
      Array2dOfSameInstance | .NET Core 5.0 |     7,059.38 ns |       779.734 ns |     42.740 ns |     7,066.37 ns |  0.86 |    0.01 |   1.2817 |   0.0305 |       - |    8048 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank2OfDiffInstance | .NET Core 3.1 |     5,113.41 ns |     1,012.773 ns |     55.513 ns |     5,095.82 ns |  1.00 |    0.00 |   1.1520 |   0.0229 |       - |    7240 B |
   ArrayRank2OfDiffInstance | .NET Core 5.0 |     4,733.58 ns |     1,477.259 ns |     80.974 ns |     4,690.08 ns |  0.93 |    0.01 |   1.1520 |   0.0229 |       - |    7240 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank2OfSameInstance | .NET Core 3.1 |     3,007.16 ns |       224.065 ns |     12.282 ns |     3,009.63 ns |  1.00 |    0.00 |   0.1411 |        - |       - |     904 B |
   ArrayRank2OfSameInstance | .NET Core 5.0 |     2,636.67 ns |       372.895 ns |     20.440 ns |     2,637.50 ns |  0.88 |    0.01 |   0.1411 |        - |       - |     904 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank3OfDiffInstance | .NET Core 3.1 |   121,123.69 ns |    27,890.374 ns |  1,528.765 ns |   121,010.23 ns |  1.00 |    0.00 |  11.4746 |   1.8311 |       - |   72168 B |
   ArrayRank3OfDiffInstance | .NET Core 5.0 |   103,691.43 ns |    15,236.719 ns |    835.176 ns |   103,250.88 ns |  0.86 |    0.02 |  11.4746 |   1.8311 |       - |   72168 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
   ArrayRank3OfSameInstance | .NET Core 3.1 |    92,069.01 ns |    20,521.871 ns |  1,124.873 ns |    91,446.24 ns |  1.00 |    0.00 |   1.2207 |        - |       - |    8232 B |
   ArrayRank3OfSameInstance | .NET Core 5.0 |    81,338.01 ns |     6,364.191 ns |    348.843 ns |    81,344.49 ns |  0.88 |    0.01 |   1.2207 |        - |       - |    8232 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
         ListOfDiffInstance | .NET Core 3.1 |   573,597.01 ns |    60,448.818 ns |  3,313.404 ns |   574,662.11 ns |  1.00 |    0.00 | 114.2578 |  48.8281 |       - |  720056 B |
         ListOfDiffInstance | .NET Core 5.0 |   535,312.57 ns |    88,411.528 ns |  4,846.134 ns |   534,228.61 ns |  0.93 |    0.01 | 114.2578 |  48.8281 |       - |  720057 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
         ListOfSameInstance | .NET Core 3.1 |   256,469.97 ns |    48,994.729 ns |  2,685.566 ns |   255,917.19 ns |  1.00 |    0.00 |  12.2070 |   1.9531 |       - |   80120 B |
         ListOfSameInstance | .NET Core 5.0 |   234,037.71 ns |    13,085.861 ns |    717.280 ns |   233,680.57 ns |  0.91 |    0.01 |  12.4512 |   1.9531 |       - |   80120 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
  ListOfObjectsDiffInstance | .NET Core 3.1 |   797,930.34 ns |    40,881.655 ns |  2,240.861 ns |   798,407.13 ns |  1.00 |    0.00 | 114.2578 |  48.8281 |       - |  720056 B |
  ListOfObjectsDiffInstance | .NET Core 5.0 |   730,541.28 ns |   169,849.010 ns |  9,309.997 ns |   726,744.92 ns |  0.92 |    0.01 | 114.2578 |  48.8281 |       - |  720056 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
  ListOfObjectsSameInstance | .NET Core 3.1 |   460,433.27 ns |    62,906.282 ns |  3,448.106 ns |   458,752.00 ns |  1.00 |    0.00 |  12.2070 |   1.9531 |       - |   80120 B |
  ListOfObjectsSameInstance | .NET Core 5.0 |   408,719.29 ns |    35,511.698 ns |  1,946.516 ns |   408,075.05 ns |  0.89 |    0.01 |  12.2070 |   1.9531 |       - |   80120 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
           KeyValuePairSame | .NET Core 3.1 |       133.15 ns |       131.371 ns |      7.201 ns |       129.16 ns |  1.00 |    0.00 |   0.0100 |        - |       - |      64 B |
           KeyValuePairSame | .NET Core 5.0 |       107.38 ns |        28.050 ns |      1.538 ns |       107.80 ns |  0.81 |    0.04 |   0.0101 |        - |       - |      64 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
           KeyValuePairDiff | .NET Core 3.1 |       139.73 ns |        29.292 ns |      1.606 ns |       139.75 ns |  1.00 |    0.00 |   0.0203 |        - |       - |     128 B |
           KeyValuePairDiff | .NET Core 5.0 |       121.82 ns |        16.894 ns |      0.926 ns |       122.22 ns |  0.87 |    0.01 |   0.0203 |        - |       - |     128 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
          TupleSameInstance | .NET Core 3.1 |       143.55 ns |         5.390 ns |      0.295 ns |       143.67 ns |  1.00 |    0.00 |   0.0153 |        - |       - |      96 B |
          TupleSameInstance | .NET Core 5.0 |       141.45 ns |       238.499 ns |     13.073 ns |       143.09 ns |  0.99 |    0.09 |   0.0153 |        - |       - |      96 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
          TupleDiffInstance | .NET Core 3.1 |       161.67 ns |       139.204 ns |      7.630 ns |       157.37 ns |  1.00 |    0.00 |   0.0253 |        - |       - |     160 B |
          TupleDiffInstance | .NET Core 5.0 |       139.84 ns |         2.732 ns |      0.150 ns |       139.81 ns |  0.87 |    0.04 |   0.0253 |        - |       - |     160 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
     DictionarySameInstance | .NET Core 3.1 | 1,904,150.20 ns |   123,062.862 ns |  6,745.491 ns | 1,907,209.18 ns |  1.00 |    0.00 | 171.8750 | 130.8594 | 64.4531 |  923161 B |
     DictionarySameInstance | .NET Core 5.0 | 1,720,732.49 ns | 1,715,578.052 ns | 94,036.622 ns | 1,672,239.84 ns |  0.90 |    0.05 | 171.8750 | 130.8594 | 64.4531 |  923083 B |
                            |               |                 |                  |               |                 |       |         |          |          |         |           |
     DictionaryDiffInstance | .NET Core 3.1 | 3,047,846.35 ns |   934,785.405 ns | 51,238.742 ns | 3,042,017.19 ns |  1.00 |    0.00 | 257.8125 | 160.1563 | 62.5000 | 1563069 B |
     DictionaryDiffInstance | .NET Core 5.0 | 2,503,809.11 ns |   273,358.463 ns | 14,983.700 ns | 2,511,450.00 ns |  0.82 |    0.01 | 257.8125 | 160.1563 | 66.4063 | 1563049 B |
