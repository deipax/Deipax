
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                     Method |     Toolchain |          Mean |          Error |       StdDev |        Median | Ratio | RatioSD |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |-------------- |--------------:|---------------:|-------------:|--------------:|------:|--------:|--------:|--------:|--------:|----------:|
             SingleInstance | .NET Core 3.1 |      30.25 ns |       0.502 ns |     0.028 ns |      30.24 ns |  1.00 |    0.00 |       - |       - |       - |         - |
             SingleInstance | .NET Core 5.0 |      26.03 ns |      12.191 ns |     0.668 ns |      26.02 ns |  0.86 |    0.02 |       - |       - |       - |         - |
                            |               |               |                |              |               |       |         |         |         |         |           |
             ObjectInstance | .NET Core 3.1 |      51.45 ns |      27.709 ns |     1.519 ns |      51.81 ns |  1.00 |    0.00 |       - |       - |       - |         - |
             ObjectInstance | .NET Core 5.0 |      44.68 ns |      60.471 ns |     3.315 ns |      43.25 ns |  0.87 |    0.06 |       - |       - |       - |         - |
                            |               |               |                |              |               |       |         |         |         |         |           |
            DefaultInstance | .NET Core 3.1 |      21.07 ns |       2.743 ns |     0.150 ns |      21.04 ns |  1.00 |    0.00 |       - |       - |       - |         - |
            DefaultInstance | .NET Core 5.0 |      23.22 ns |       9.014 ns |     0.494 ns |      23.12 ns |  1.10 |    0.02 |       - |       - |       - |         - |
                            |               |               |                |              |               |       |         |         |         |         |           |
     ArrayOfDefaultInstance | .NET Core 3.1 |   4,795.08 ns |   1,052.933 ns |    57.715 ns |   4,808.53 ns |  1.00 |    0.00 | 12.6572 |       - |       - |   80024 B |
     ArrayOfDefaultInstance | .NET Core 5.0 |   4,719.66 ns |     682.022 ns |    37.384 ns |   4,723.85 ns |  0.98 |    0.02 | 12.6572 |       - |       - |   80024 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
        ArrayOfDiffInstance | .NET Core 3.1 |   4,781.41 ns |   1,732.635 ns |    94.972 ns |   4,832.93 ns |  1.00 |    0.00 | 12.6572 |       - |       - |   80024 B |
        ArrayOfDiffInstance | .NET Core 5.0 |   4,585.45 ns |   1,345.410 ns |    73.746 ns |   4,548.09 ns |  0.96 |    0.02 | 12.6572 |       - |       - |   80024 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
        ArrayOfSameInstance | .NET Core 3.1 |   4,772.72 ns |   1,669.117 ns |    91.490 ns |   4,747.16 ns |  1.00 |    0.00 | 12.6572 |       - |       - |   80024 B |
        ArrayOfSameInstance | .NET Core 5.0 |   4,567.62 ns |   1,241.289 ns |    68.039 ns |   4,597.71 ns |  0.96 |    0.02 | 12.6572 |       - |       - |   80024 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
 ArrayOfObjectsDiffInstance | .NET Core 3.1 | 280,362.96 ns |  29,693.671 ns | 1,627.610 ns | 280,582.62 ns |  1.00 |    0.00 | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance | .NET Core 5.0 | 230,551.86 ns |  42,989.022 ns | 2,356.373 ns | 229,675.85 ns |  0.82 |    0.01 | 12.4512 |       - |       - |   80024 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
 ArrayOfObjectsSameInstance | .NET Core 3.1 | 267,912.96 ns |  39,107.110 ns | 2,143.593 ns | 268,305.57 ns |  1.00 |    0.00 | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | .NET Core 5.0 | 234,610.58 ns |  33,628.800 ns | 1,843.308 ns | 234,794.34 ns |  0.88 |    0.01 | 12.2070 |       - |       - |   80024 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
      Array2dOfDiffInstance | .NET Core 3.1 |  12,308.12 ns |   1,165.210 ns |    63.869 ns |  12,293.66 ns |  1.00 |    0.00 | 13.2599 |  2.4872 |       - |   83224 B |
      Array2dOfDiffInstance | .NET Core 5.0 |  10,215.90 ns |   2,014.350 ns |   110.413 ns |  10,184.35 ns |  0.83 |    0.01 | 13.2599 |  2.4872 |       - |   83224 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
      Array2dOfSameInstance | .NET Core 3.1 |   3,368.14 ns |   1,919.811 ns |   105.231 ns |   3,339.06 ns |  1.00 |    0.00 |  0.2594 |       - |       - |    1648 B |
      Array2dOfSameInstance | .NET Core 5.0 |   2,601.85 ns |     683.835 ns |    37.483 ns |   2,594.31 ns |  0.77 |    0.03 |  0.2594 |       - |       - |    1648 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
   ArrayRank2OfDiffInstance | .NET Core 3.1 |     231.27 ns |      83.268 ns |     4.564 ns |     228.95 ns |  1.00 |    0.00 |  0.1338 |       - |       - |     840 B |
   ArrayRank2OfDiffInstance | .NET Core 5.0 |     192.21 ns |      24.356 ns |     1.335 ns |     191.56 ns |  0.83 |    0.01 |  0.1338 |       - |       - |     840 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
   ArrayRank2OfSameInstance | .NET Core 3.1 |     230.85 ns |      59.883 ns |     3.282 ns |     229.98 ns |  1.00 |    0.00 |  0.1338 |       - |       - |     840 B |
   ArrayRank2OfSameInstance | .NET Core 5.0 |     190.14 ns |       4.132 ns |     0.227 ns |     190.10 ns |  0.82 |    0.01 |  0.1338 |       - |       - |     840 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
   ArrayRank3OfDiffInstance | .NET Core 3.1 |     757.40 ns |      10.120 ns |     0.555 ns |     757.60 ns |  1.00 |    0.00 |  1.2884 |       - |       - |    8088 B |
   ArrayRank3OfDiffInstance | .NET Core 5.0 |     783.75 ns |     223.915 ns |    12.274 ns |     788.85 ns |  1.03 |    0.02 |  1.2884 |       - |       - |    8088 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
   ArrayRank3OfSameInstance | .NET Core 3.1 |     781.01 ns |     105.536 ns |     5.785 ns |     781.27 ns |  1.00 |    0.00 |  1.2884 |       - |       - |    8088 B |
   ArrayRank3OfSameInstance | .NET Core 5.0 |     698.37 ns |     102.145 ns |     5.599 ns |     696.83 ns |  0.89 |    0.01 |  1.2884 |       - |       - |    8088 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
         ListOfDiffInstance | .NET Core 3.1 |   5,374.23 ns |   1,150.448 ns |    63.060 ns |   5,384.03 ns |  1.00 |    0.00 | 12.6572 |  2.1057 |       - |   80056 B |
         ListOfDiffInstance | .NET Core 5.0 |   5,112.74 ns |     921.106 ns |    50.489 ns |   5,094.94 ns |  0.95 |    0.01 | 12.6572 |  2.1057 |       - |   80056 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
         ListOfSameInstance | .NET Core 3.1 |   5,415.77 ns |      66.646 ns |     3.653 ns |   5,414.01 ns |  1.00 |    0.00 | 12.6572 |  2.1057 |       - |   80056 B |
         ListOfSameInstance | .NET Core 5.0 |   5,088.29 ns |     933.038 ns |    51.143 ns |   5,115.68 ns |  0.94 |    0.01 | 12.6572 |  2.1057 |       - |   80056 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
  ListOfObjectsDiffInstance | .NET Core 3.1 | 272,920.18 ns |  10,914.145 ns |   598.241 ns | 273,264.31 ns |  1.00 |    0.00 | 12.2070 |  1.9531 |       - |   80056 B |
  ListOfObjectsDiffInstance | .NET Core 5.0 | 251,087.98 ns |  87,780.098 ns | 4,811.523 ns | 248,469.75 ns |  0.92 |    0.02 | 12.4512 |  1.9531 |       - |   80056 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
  ListOfObjectsSameInstance | .NET Core 3.1 | 270,567.50 ns |  20,459.381 ns | 1,121.448 ns | 270,183.01 ns |  1.00 |    0.00 | 12.2070 |  1.9531 |       - |   80056 B |
  ListOfObjectsSameInstance | .NET Core 5.0 | 244,013.41 ns |  88,277.468 ns | 4,838.786 ns | 244,906.40 ns |  0.90 |    0.02 | 12.2070 |  1.9531 |       - |   80056 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
           KeyValuePairSame | .NET Core 3.1 |      35.89 ns |       7.853 ns |     0.430 ns |      35.89 ns |  1.00 |    0.00 |       - |       - |       - |         - |
           KeyValuePairSame | .NET Core 5.0 |      33.36 ns |      57.411 ns |     3.147 ns |      32.21 ns |  0.93 |    0.09 |       - |       - |       - |         - |
                            |               |               |                |              |               |       |         |         |         |         |           |
           KeyValuePairDiff | .NET Core 3.1 |      31.38 ns |       2.401 ns |     0.132 ns |      31.40 ns |  1.00 |    0.00 |       - |       - |       - |         - |
           KeyValuePairDiff | .NET Core 5.0 |      30.15 ns |       4.324 ns |     0.237 ns |      30.24 ns |  0.96 |    0.01 |       - |       - |       - |         - |
                            |               |               |                |              |               |       |         |         |         |         |           |
          TupleSameInstance | .NET Core 3.1 |      78.92 ns |     101.128 ns |     5.543 ns |      76.98 ns |  1.00 |    0.00 |  0.0050 |       - |       - |      32 B |
          TupleSameInstance | .NET Core 5.0 |      68.58 ns |      10.740 ns |     0.589 ns |      68.92 ns |  0.87 |    0.06 |  0.0050 |       - |       - |      32 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
          TupleDiffInstance | .NET Core 3.1 |      77.22 ns |       5.282 ns |     0.290 ns |      77.27 ns |  1.00 |    0.00 |  0.0050 |       - |       - |      32 B |
          TupleDiffInstance | .NET Core 5.0 |      70.05 ns |       6.971 ns |     0.382 ns |      70.00 ns |  0.91 |    0.00 |  0.0050 |       - |       - |      32 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
     DictionarySameInstance | .NET Core 3.1 | 461,192.43 ns |  95,159.028 ns | 5,215.987 ns | 462,263.57 ns |  1.00 |    0.00 | 76.6602 | 76.6602 | 76.6602 |  283032 B |
     DictionarySameInstance | .NET Core 5.0 | 428,543.02 ns |  34,085.261 ns | 1,868.328 ns | 429,148.97 ns |  0.93 |    0.01 | 76.6602 | 76.6602 | 76.6602 |  283040 B |
                            |               |               |                |              |               |       |         |         |         |         |           |
     DictionaryDiffInstance | .NET Core 3.1 | 466,475.08 ns | 158,046.181 ns | 8,663.044 ns | 469,006.45 ns |  1.00 |    0.00 | 76.6602 | 76.6602 | 76.6602 |  283032 B |
     DictionaryDiffInstance | .NET Core 5.0 | 435,376.14 ns |  46,172.183 ns | 2,530.853 ns | 435,679.15 ns |  0.93 |    0.01 | 76.6602 | 76.6602 | 76.6602 |  283040 B |
