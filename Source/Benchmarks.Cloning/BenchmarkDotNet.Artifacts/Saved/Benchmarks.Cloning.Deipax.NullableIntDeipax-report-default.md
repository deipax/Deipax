
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                     Method |     Toolchain |          Mean |          Error |        StdDev |        Median | Ratio | RatioSD |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |-------------- |--------------:|---------------:|--------------:|--------------:|------:|--------:|--------:|--------:|--------:|----------:|
             SingleInstance | .NET Core 3.1 |      68.96 ns |      57.737 ns |      3.165 ns |      69.61 ns |  1.00 |    0.00 |  0.0038 |       - |       - |      24 B |
             SingleInstance | .NET Core 5.0 |      67.57 ns |      15.743 ns |      0.863 ns |      67.28 ns |  0.98 |    0.04 |  0.0038 |       - |       - |      24 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
             ObjectInstance | .NET Core 3.1 |      41.67 ns |      14.229 ns |      0.780 ns |      41.55 ns |  1.00 |    0.00 |       - |       - |       - |         - |
             ObjectInstance | .NET Core 5.0 |      37.95 ns |       7.513 ns |      0.412 ns |      38.18 ns |  0.91 |    0.02 |       - |       - |       - |         - |
                            |               |               |                |               |               |       |         |         |         |         |           |
            DefaultInstance | .NET Core 3.1 |      17.51 ns |       3.382 ns |      0.185 ns |      17.55 ns |  1.00 |    0.00 |       - |       - |       - |         - |
            DefaultInstance | .NET Core 5.0 |      16.65 ns |       7.778 ns |      0.426 ns |      16.89 ns |  0.95 |    0.03 |       - |       - |       - |         - |
                            |               |               |                |               |               |       |         |         |         |         |           |
     ArrayOfDefaultInstance | .NET Core 3.1 |   4,337.65 ns |     643.555 ns |     35.275 ns |   4,352.16 ns |  1.00 |    0.00 | 12.6572 |       - |       - |   80024 B |
     ArrayOfDefaultInstance | .NET Core 5.0 |   4,290.97 ns |     542.497 ns |     29.736 ns |   4,301.21 ns |  0.99 |    0.00 | 12.6572 |       - |       - |   80024 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
        ArrayOfDiffInstance | .NET Core 3.1 |   4,335.97 ns |     307.322 ns |     16.845 ns |   4,336.70 ns |  1.00 |    0.00 | 12.6572 |       - |       - |   80024 B |
        ArrayOfDiffInstance | .NET Core 5.0 |   4,348.26 ns |   1,947.894 ns |    106.771 ns |   4,292.51 ns |  1.00 |    0.03 | 12.6572 |       - |       - |   80024 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
        ArrayOfSameInstance | .NET Core 3.1 |   4,327.96 ns |     249.575 ns |     13.680 ns |   4,334.07 ns |  1.00 |    0.00 | 12.6572 |       - |       - |   80024 B |
        ArrayOfSameInstance | .NET Core 5.0 |   4,336.08 ns |     325.284 ns |     17.830 ns |   4,331.22 ns |  1.00 |    0.00 | 12.6572 |       - |       - |   80024 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
 ArrayOfObjectsDiffInstance | .NET Core 3.1 | 290,260.68 ns |  29,898.381 ns |  1,638.831 ns | 289,853.86 ns |  1.00 |    0.00 | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance | .NET Core 5.0 | 239,174.02 ns |  16,286.480 ns |    892.717 ns | 238,814.67 ns |  0.82 |    0.01 | 12.4512 |       - |       - |   80024 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
 ArrayOfObjectsSameInstance | .NET Core 3.1 | 300,778.58 ns |  62,135.350 ns |  3,405.848 ns | 300,718.02 ns |  1.00 |    0.00 | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | .NET Core 5.0 | 237,884.03 ns |  24,150.637 ns |  1,323.778 ns | 237,377.59 ns |  0.79 |    0.01 | 12.4512 |       - |       - |   80024 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
      Array2dOfDiffInstance | .NET Core 3.1 |  11,713.47 ns |     333.476 ns |     18.279 ns |  11,705.36 ns |  1.00 |    0.00 | 13.2599 |  2.4872 |       - |   83224 B |
      Array2dOfDiffInstance | .NET Core 5.0 |   9,321.35 ns |   7,283.255 ns |    399.220 ns |   9,108.41 ns |  0.80 |    0.03 | 13.2599 |  2.4872 |       - |   83224 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
      Array2dOfSameInstance | .NET Core 3.1 |   3,213.80 ns |     207.440 ns |     11.370 ns |   3,215.23 ns |  1.00 |    0.00 |  0.2594 |       - |       - |    1648 B |
      Array2dOfSameInstance | .NET Core 5.0 |   2,674.43 ns |      72.903 ns |      3.996 ns |   2,672.81 ns |  0.83 |    0.00 |  0.2594 |       - |       - |    1648 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
   ArrayRank2OfDiffInstance | .NET Core 3.1 |     216.43 ns |      41.349 ns |      2.267 ns |     217.65 ns |  1.00 |    0.00 |  0.1338 |       - |       - |     840 B |
   ArrayRank2OfDiffInstance | .NET Core 5.0 |     181.82 ns |      22.839 ns |      1.252 ns |     181.27 ns |  0.84 |    0.01 |  0.1338 |       - |       - |     840 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
   ArrayRank2OfSameInstance | .NET Core 3.1 |     218.98 ns |      93.559 ns |      5.128 ns |     218.19 ns |  1.00 |    0.00 |  0.1338 |       - |       - |     840 B |
   ArrayRank2OfSameInstance | .NET Core 5.0 |     202.49 ns |     412.017 ns |     22.584 ns |     189.65 ns |  0.93 |    0.12 |  0.1338 |       - |       - |     840 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
   ArrayRank3OfDiffInstance | .NET Core 3.1 |     684.25 ns |     105.531 ns |      5.785 ns |     683.55 ns |  1.00 |    0.00 |  1.2884 |       - |       - |    8088 B |
   ArrayRank3OfDiffInstance | .NET Core 5.0 |     704.21 ns |     544.523 ns |     29.847 ns |     690.35 ns |  1.03 |    0.04 |  1.2884 |       - |       - |    8088 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
   ArrayRank3OfSameInstance | .NET Core 3.1 |     706.45 ns |     108.370 ns |      5.940 ns |     707.73 ns |  1.00 |    0.00 |  1.2884 |       - |       - |    8088 B |
   ArrayRank3OfSameInstance | .NET Core 5.0 |     717.39 ns |     360.994 ns |     19.787 ns |     713.09 ns |  1.02 |    0.03 |  1.2884 |       - |       - |    8088 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
         ListOfDiffInstance | .NET Core 3.1 |   5,089.00 ns |   3,228.117 ns |    176.944 ns |   5,035.67 ns |  1.00 |    0.00 | 12.6572 |  2.1057 |       - |   80056 B |
         ListOfDiffInstance | .NET Core 5.0 |   5,390.67 ns |   9,954.735 ns |    545.653 ns |   5,431.50 ns |  1.06 |    0.14 | 12.6572 |  2.1057 |       - |   80056 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
         ListOfSameInstance | .NET Core 3.1 |   4,887.60 ns |     686.749 ns |     37.643 ns |   4,867.05 ns |  1.00 |    0.00 | 12.6572 |  2.1057 |       - |   80056 B |
         ListOfSameInstance | .NET Core 5.0 |   4,643.58 ns |   1,476.694 ns |     80.943 ns |   4,614.98 ns |  0.95 |    0.02 | 12.6572 |  2.1057 |       - |   80056 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
  ListOfObjectsDiffInstance | .NET Core 3.1 | 284,140.15 ns |  33,706.608 ns |  1,847.573 ns | 284,869.87 ns |  1.00 |    0.00 | 12.2070 |  1.9531 |       - |   80056 B |
  ListOfObjectsDiffInstance | .NET Core 5.0 | 242,683.76 ns |  48,413.499 ns |  2,653.707 ns | 243,471.68 ns |  0.85 |    0.01 | 12.4512 |  1.9531 |       - |   80056 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
  ListOfObjectsSameInstance | .NET Core 3.1 | 291,413.74 ns |  34,445.030 ns |  1,888.048 ns | 290,742.87 ns |  1.00 |    0.00 | 12.2070 |  1.9531 |       - |   80056 B |
  ListOfObjectsSameInstance | .NET Core 5.0 | 244,254.85 ns |  48,191.378 ns |  2,641.532 ns | 244,141.94 ns |  0.84 |    0.01 | 12.2070 |  1.9531 |       - |   80056 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
           KeyValuePairSame | .NET Core 3.1 |      24.90 ns |       1.488 ns |      0.082 ns |      24.91 ns |  1.00 |    0.00 |       - |       - |       - |         - |
           KeyValuePairSame | .NET Core 5.0 |      22.62 ns |       2.555 ns |      0.140 ns |      22.70 ns |  0.91 |    0.00 |       - |       - |       - |         - |
                            |               |               |                |               |               |       |         |         |         |         |           |
           KeyValuePairDiff | .NET Core 3.1 |      24.69 ns |       6.231 ns |      0.342 ns |      24.51 ns |  1.00 |    0.00 |       - |       - |       - |         - |
           KeyValuePairDiff | .NET Core 5.0 |      23.41 ns |       2.371 ns |      0.130 ns |      23.42 ns |  0.95 |    0.01 |       - |       - |       - |         - |
                            |               |               |                |               |               |       |         |         |         |         |           |
          TupleSameInstance | .NET Core 3.1 |      70.16 ns |       4.845 ns |      0.266 ns |      70.10 ns |  1.00 |    0.00 |  0.0050 |       - |       - |      32 B |
          TupleSameInstance | .NET Core 5.0 |      61.54 ns |       8.425 ns |      0.462 ns |      61.68 ns |  0.88 |    0.00 |  0.0050 |       - |       - |      32 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
          TupleDiffInstance | .NET Core 3.1 |      72.51 ns |       5.938 ns |      0.326 ns |      72.40 ns |  1.00 |    0.00 |  0.0050 |       - |       - |      32 B |
          TupleDiffInstance | .NET Core 5.0 |      74.71 ns |      21.388 ns |      1.172 ns |      74.56 ns |  1.03 |    0.02 |  0.0050 |       - |       - |      32 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
     DictionarySameInstance | .NET Core 3.1 | 542,414.00 ns |  59,649.575 ns |  3,269.595 ns | 540,542.19 ns |  1.00 |    0.00 | 76.1719 | 76.1719 | 76.1719 |  283032 B |
     DictionarySameInstance | .NET Core 5.0 | 472,634.41 ns |  43,023.130 ns |  2,358.243 ns | 473,546.97 ns |  0.87 |    0.01 | 76.1719 | 76.1719 | 76.1719 |  283040 B |
                            |               |               |                |               |               |       |         |         |         |         |           |
     DictionaryDiffInstance | .NET Core 3.1 | 557,015.49 ns | 185,462.550 ns | 10,165.828 ns | 561,652.05 ns |  1.00 |    0.00 | 76.1719 | 76.1719 | 76.1719 |  283032 B |
     DictionaryDiffInstance | .NET Core 5.0 | 492,689.84 ns | 703,051.112 ns | 38,536.604 ns | 471,278.86 ns |  0.89 |    0.09 | 76.6602 | 76.6602 | 76.6602 |  283040 B |
