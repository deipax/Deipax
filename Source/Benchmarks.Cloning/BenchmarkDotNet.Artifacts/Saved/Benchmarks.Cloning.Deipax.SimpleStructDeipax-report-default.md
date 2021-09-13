
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                     Method |     Toolchain |          Mean |          Error |        StdDev |        Median | Ratio | RatioSD |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |-------------- |--------------:|---------------:|--------------:|--------------:|------:|--------:|---------:|---------:|---------:|----------:|
             SingleInstance | .NET Core 3.1 |      22.71 ns |       5.314 ns |      0.291 ns |      22.62 ns |  1.00 |    0.00 |        - |        - |        - |         - |
             SingleInstance | .NET Core 5.0 |      21.95 ns |       4.132 ns |      0.226 ns |      21.89 ns |  0.97 |    0.01 |        - |        - |        - |         - |
                            |               |               |                |               |               |       |         |          |          |          |           |
             ObjectInstance | .NET Core 3.1 |      42.15 ns |       1.807 ns |      0.099 ns |      42.09 ns |  1.00 |    0.00 |        - |        - |        - |         - |
             ObjectInstance | .NET Core 5.0 |      41.11 ns |       2.623 ns |      0.144 ns |      41.10 ns |  0.98 |    0.00 |        - |        - |        - |         - |
                            |               |               |                |               |               |       |         |          |          |          |           |
            DefaultInstance | .NET Core 3.1 |      21.54 ns |       3.243 ns |      0.178 ns |      21.49 ns |  1.00 |    0.00 |        - |        - |        - |         - |
            DefaultInstance | .NET Core 5.0 |      21.93 ns |       0.471 ns |      0.026 ns |      21.94 ns |  1.02 |    0.01 |        - |        - |        - |         - |
                            |               |               |                |               |               |       |         |          |          |          |           |
     ArrayOfDefaultInstance | .NET Core 3.1 |  17,272.57 ns |   3,165.798 ns |    173.528 ns |  17,173.58 ns |  1.00 |    0.00 |  24.6277 |  24.6277 |  24.6277 |  160014 B |
     ArrayOfDefaultInstance | .NET Core 5.0 |  36,369.20 ns |   9,572.505 ns |    524.701 ns |  36,395.83 ns |  2.11 |    0.02 |  17.2729 |  17.2729 |  17.2729 |  160023 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
        ArrayOfDiffInstance | .NET Core 3.1 |  19,146.52 ns |  30,664.756 ns |  1,680.839 ns |  19,154.99 ns |  1.00 |    0.00 |  24.5361 |  24.5361 |  24.5361 |  160014 B |
        ArrayOfDiffInstance | .NET Core 5.0 |  36,344.64 ns |  17,591.467 ns |    964.248 ns |  35,882.59 ns |  1.91 |    0.17 |  17.3340 |  17.3340 |  17.3340 |  160020 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
        ArrayOfSameInstance | .NET Core 3.1 |  17,185.11 ns |   2,612.022 ns |    143.174 ns |  17,193.01 ns |  1.00 |    0.00 |  24.6887 |  24.6887 |  24.6887 |  160014 B |
        ArrayOfSameInstance | .NET Core 5.0 |  37,164.36 ns |  11,674.494 ns |    639.918 ns |  37,332.10 ns |  2.16 |    0.02 |  15.9912 |  15.9912 |  15.9912 |  160020 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
 ArrayOfObjectsDiffInstance | .NET Core 3.1 | 300,247.02 ns | 312,220.208 ns | 17,113.843 ns | 301,883.25 ns |  1.00 |    0.00 |  12.2070 |        - |        - |   80024 B |
 ArrayOfObjectsDiffInstance | .NET Core 5.0 | 244,750.26 ns |  70,263.256 ns |  3,851.366 ns | 243,342.87 ns |  0.82 |    0.05 |  12.4512 |        - |        - |   80024 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
 ArrayOfObjectsSameInstance | .NET Core 3.1 | 287,156.22 ns |  60,976.115 ns |  3,342.307 ns | 287,450.24 ns |  1.00 |    0.00 |  12.2070 |        - |        - |   80024 B |
 ArrayOfObjectsSameInstance | .NET Core 5.0 | 251,098.54 ns |  14,738.245 ns |    807.853 ns | 250,811.13 ns |  0.87 |    0.01 |  12.2070 |        - |        - |   80024 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
      Array2dOfDiffInstance | .NET Core 3.1 |  16,687.39 ns |   3,284.970 ns |    180.060 ns |  16,610.07 ns |  1.00 |    0.00 |  26.0010 |   7.2021 |        - |  163224 B |
      Array2dOfDiffInstance | .NET Core 5.0 |  15,106.97 ns |   2,714.094 ns |    148.769 ns |  15,042.65 ns |  0.91 |    0.00 |  26.0010 |   7.2021 |        - |  163224 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
      Array2dOfSameInstance | .NET Core 3.1 |   3,460.99 ns |     702.779 ns |     38.522 ns |   3,447.00 ns |  1.00 |    0.00 |   0.3891 |        - |        - |    2448 B |
      Array2dOfSameInstance | .NET Core 5.0 |   2,973.73 ns |   2,046.143 ns |    112.156 ns |   2,957.97 ns |  0.86 |    0.03 |   0.3891 |        - |        - |    2448 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
   ArrayRank2OfDiffInstance | .NET Core 3.1 |     247.95 ns |      25.758 ns |      1.412 ns |     247.39 ns |  1.00 |    0.00 |   0.2613 |        - |        - |    1640 B |
   ArrayRank2OfDiffInstance | .NET Core 5.0 |     220.51 ns |      35.158 ns |      1.927 ns |     219.62 ns |  0.89 |    0.01 |   0.2613 |        - |        - |    1640 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
   ArrayRank2OfSameInstance | .NET Core 3.1 |     252.05 ns |      19.607 ns |      1.075 ns |     252.12 ns |  1.00 |    0.00 |   0.2613 |        - |        - |    1640 B |
   ArrayRank2OfSameInstance | .NET Core 5.0 |     221.98 ns |     108.690 ns |      5.958 ns |     221.01 ns |  0.88 |    0.02 |   0.2613 |        - |        - |    1640 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
   ArrayRank3OfDiffInstance | .NET Core 3.1 |   1,182.49 ns |     783.960 ns |     42.972 ns |   1,169.24 ns |  1.00 |    0.00 |   2.5558 |        - |        - |   16088 B |
   ArrayRank3OfDiffInstance | .NET Core 5.0 |   1,093.24 ns |      64.784 ns |      3.551 ns |   1,095.14 ns |  0.93 |    0.03 |   2.5558 |        - |        - |   16088 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
   ArrayRank3OfSameInstance | .NET Core 3.1 |   1,167.69 ns |      52.938 ns |      2.902 ns |   1,168.57 ns |  1.00 |    0.00 |   2.5558 |        - |        - |   16088 B |
   ArrayRank3OfSameInstance | .NET Core 5.0 |   1,079.77 ns |     162.055 ns |      8.883 ns |   1,075.09 ns |  0.92 |    0.01 |   2.5558 |        - |        - |   16088 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
         ListOfDiffInstance | .NET Core 3.1 |  16,965.08 ns |   2,447.076 ns |    134.132 ns |  16,940.48 ns |  1.00 |    0.00 |  26.4893 |  26.4587 |  26.4587 |  160245 B |
         ListOfDiffInstance | .NET Core 5.0 |  36,513.18 ns |   8,065.579 ns |    442.102 ns |  36,380.35 ns |  2.15 |    0.01 |  17.1509 |  17.1509 |  17.1509 |  160175 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
         ListOfSameInstance | .NET Core 3.1 |  17,807.44 ns |   4,918.287 ns |    269.588 ns |  17,656.32 ns |  1.00 |    0.00 |  25.1160 |  25.0854 |  25.0854 |  160232 B |
         ListOfSameInstance | .NET Core 5.0 |  36,451.72 ns |  17,563.862 ns |    962.735 ns |  36,258.97 ns |  2.05 |    0.03 |  17.5781 |  17.5781 |  17.5781 |  160183 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
  ListOfObjectsDiffInstance | .NET Core 3.1 | 306,435.66 ns | 237,382.731 ns | 13,011.748 ns | 306,322.12 ns |  1.00 |    0.00 |  12.2070 |   1.9531 |        - |   80056 B |
  ListOfObjectsDiffInstance | .NET Core 5.0 | 244,161.91 ns |   5,042.952 ns |    276.421 ns | 244,316.94 ns |  0.80 |    0.03 |  12.2070 |   1.9531 |        - |   80056 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
  ListOfObjectsSameInstance | .NET Core 3.1 | 288,860.64 ns | 168,498.453 ns |  9,235.969 ns | 284,137.01 ns |  1.00 |    0.00 |  12.2070 |   1.9531 |        - |   80056 B |
  ListOfObjectsSameInstance | .NET Core 5.0 | 245,953.07 ns | 189,875.363 ns | 10,407.709 ns | 240,719.34 ns |  0.85 |    0.01 |  12.4512 |   1.9531 |        - |   80056 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
           KeyValuePairSame | .NET Core 3.1 |      26.04 ns |       1.690 ns |      0.093 ns |      26.00 ns |  1.00 |    0.00 |        - |        - |        - |         - |
           KeyValuePairSame | .NET Core 5.0 |      24.96 ns |      21.310 ns |      1.168 ns |      25.51 ns |  0.96 |    0.04 |        - |        - |        - |         - |
                            |               |               |                |               |               |       |         |          |          |          |           |
           KeyValuePairDiff | .NET Core 3.1 |      25.15 ns |       3.592 ns |      0.197 ns |      25.21 ns |  1.00 |    0.00 |        - |        - |        - |         - |
           KeyValuePairDiff | .NET Core 5.0 |      24.76 ns |       2.227 ns |      0.122 ns |      24.81 ns |  0.98 |    0.00 |        - |        - |        - |         - |
                            |               |               |                |               |               |       |         |          |          |          |           |
          TupleSameInstance | .NET Core 3.1 |      72.18 ns |       2.601 ns |      0.143 ns |      72.18 ns |  1.00 |    0.00 |   0.0076 |        - |        - |      48 B |
          TupleSameInstance | .NET Core 5.0 |      65.25 ns |       3.749 ns |      0.205 ns |      65.29 ns |  0.90 |    0.00 |   0.0076 |        - |        - |      48 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
          TupleDiffInstance | .NET Core 3.1 |      75.86 ns |      57.917 ns |      3.175 ns |      75.12 ns |  1.00 |    0.00 |   0.0076 |        - |        - |      48 B |
          TupleDiffInstance | .NET Core 5.0 |      61.48 ns |      14.892 ns |      0.816 ns |      61.70 ns |  0.81 |    0.03 |   0.0076 |        - |        - |      48 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
     DictionarySameInstance | .NET Core 3.1 | 659,742.97 ns |  50,224.903 ns |  2,752.996 ns | 661,105.47 ns |  1.00 |    0.00 | 164.0625 | 124.0234 | 107.4219 |  764793 B |
     DictionarySameInstance | .NET Core 5.0 | 593,363.83 ns |  92,372.444 ns |  5,063.245 ns | 596,069.82 ns |  0.90 |    0.01 | 161.1328 | 120.1172 | 104.4922 |  764794 B |
                            |               |               |                |               |               |       |         |          |          |          |           |
     DictionaryDiffInstance | .NET Core 3.1 | 691,356.28 ns | 217,631.698 ns | 11,929.128 ns | 689,665.92 ns |  1.00 |    0.00 | 164.0625 | 120.1172 | 107.4219 |  764798 B |
     DictionaryDiffInstance | .NET Core 5.0 | 595,517.48 ns |  50,547.660 ns |  2,770.688 ns | 595,265.92 ns |  0.86 |    0.01 | 160.1563 | 119.1406 | 103.5156 |  764812 B |
