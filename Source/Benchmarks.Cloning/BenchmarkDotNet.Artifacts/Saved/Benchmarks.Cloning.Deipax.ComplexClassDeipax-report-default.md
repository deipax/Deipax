
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1256 (1909/November2018Update/19H2)
Intel Xeon W-10855M CPU 2.80GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.400
  [Host]   : .NET Core 5.0.9 (CoreCLR 5.0.921.35908, CoreFX 5.0.921.35908), X64 RyuJIT
  ShortRun : .NET Core 3.1.18 (CoreCLR 4.700.21.35901, CoreFX 4.700.21.36305), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

                     Method |     Toolchain |            Mean |            Error |         StdDev |          Median | Ratio | RatioSD |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |-------------- |----------------:|-----------------:|---------------:|----------------:|------:|--------:|---------:|---------:|--------:|----------:|
             SingleInstance | .NET Core 3.1 |       105.49 ns |        31.402 ns |       1.721 ns |       104.82 ns |  1.00 |    0.00 |   0.0050 |        - |       - |      32 B |
             SingleInstance | .NET Core 5.0 |        87.76 ns |        26.561 ns |       1.456 ns |        88.29 ns |  0.83 |    0.01 |   0.0050 |        - |       - |      32 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
             ObjectInstance | .NET Core 3.1 |       128.37 ns |        17.886 ns |       0.980 ns |       128.34 ns |  1.00 |    0.00 |   0.0050 |        - |       - |      32 B |
             ObjectInstance | .NET Core 5.0 |       111.14 ns |        25.231 ns |       1.383 ns |       111.29 ns |  0.87 |    0.02 |   0.0050 |        - |       - |      32 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
            DefaultInstance | .NET Core 3.1 |        20.10 ns |         5.468 ns |       0.300 ns |        20.04 ns |  1.00 |    0.00 |        - |        - |       - |         - |
            DefaultInstance | .NET Core 5.0 |        19.87 ns |         0.839 ns |       0.046 ns |        19.88 ns |  0.99 |    0.02 |        - |        - |       - |         - |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
     ArrayOfDefaultInstance | .NET Core 3.1 |     9,224.17 ns |       805.735 ns |      44.165 ns |     9,200.02 ns |  1.00 |    0.00 |  12.6495 |        - |       - |   80024 B |
     ArrayOfDefaultInstance | .NET Core 5.0 |     6,890.99 ns |     1,178.138 ns |      64.578 ns |     6,886.44 ns |  0.75 |    0.00 |  12.6572 |        - |       - |   80024 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
        ArrayOfDiffInstance | .NET Core 3.1 |   731,985.90 ns |   169,146.402 ns |   9,271.485 ns |   730,937.30 ns |  1.00 |    0.00 |  63.4766 |  22.4609 |       - |  400024 B |
        ArrayOfDiffInstance | .NET Core 5.0 |   658,199.84 ns |    75,465.184 ns |   4,136.501 ns |   658,394.73 ns |  0.90 |    0.01 |  63.4766 |  22.4609 |       - |  400024 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
        ArrayOfSameInstance | .NET Core 3.1 |   248,063.49 ns |    56,713.728 ns |   3,108.671 ns |   249,303.61 ns |  1.00 |    0.00 |  12.2070 |        - |       - |   80056 B |
        ArrayOfSameInstance | .NET Core 5.0 |   218,695.21 ns |    22,955.022 ns |   1,258.242 ns |   218,440.99 ns |  0.88 |    0.01 |  12.4512 |        - |       - |   80056 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
 ArrayOfObjectsDiffInstance | .NET Core 3.1 |   963,072.20 ns |   168,068.289 ns |   9,212.390 ns |   958,689.55 ns |  1.00 |    0.00 |  63.4766 |  22.4609 |       - |  400024 B |
 ArrayOfObjectsDiffInstance | .NET Core 5.0 |   891,697.56 ns |    89,096.744 ns |   4,883.693 ns |   893,724.02 ns |  0.93 |    0.01 |  63.4766 |  22.4609 |       - |  400024 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
 ArrayOfObjectsSameInstance | .NET Core 3.1 |   429,702.69 ns |    28,793.453 ns |   1,578.266 ns |   429,206.64 ns |  1.00 |    0.00 |  12.2070 |        - |       - |   80056 B |
 ArrayOfObjectsSameInstance | .NET Core 5.0 |   407,645.48 ns |    43,583.153 ns |   2,388.940 ns |   407,902.59 ns |  0.95 |    0.00 |  12.2070 |        - |       - |   80056 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
      Array2dOfDiffInstance | .NET Core 3.1 |   730,932.71 ns |    53,913.164 ns |   2,955.162 ns |   729,842.38 ns |  1.00 |    0.00 |  63.4766 |  27.3438 |       - |  403224 B |
      Array2dOfDiffInstance | .NET Core 5.0 |   717,610.71 ns |    94,262.654 ns |   5,166.854 ns |   717,621.48 ns |  0.98 |    0.00 |  63.4766 |  27.3438 |       - |  403224 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
      Array2dOfSameInstance | .NET Core 3.1 |    10,069.58 ns |     1,339.711 ns |      73.434 ns |    10,033.40 ns |  1.00 |    0.00 |   0.7629 |        - |       - |    4848 B |
      Array2dOfSameInstance | .NET Core 5.0 |     8,874.63 ns |       773.100 ns |      42.376 ns |     8,882.09 ns |  0.88 |    0.01 |   0.7629 |        - |       - |    4848 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
   ArrayRank2OfDiffInstance | .NET Core 3.1 |     7,340.49 ns |       738.072 ns |      40.456 ns |     7,347.98 ns |  1.00 |    0.00 |   0.6409 |   0.0076 |       - |    4040 B |
   ArrayRank2OfDiffInstance | .NET Core 5.0 |     6,668.58 ns |       946.591 ns |      51.886 ns |     6,638.89 ns |  0.91 |    0.01 |   0.6409 |   0.0076 |       - |    4040 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
   ArrayRank2OfSameInstance | .NET Core 3.1 |     2,985.61 ns |       185.458 ns |      10.166 ns |     2,984.36 ns |  1.00 |    0.00 |   0.1373 |        - |       - |     872 B |
   ArrayRank2OfSameInstance | .NET Core 5.0 |     2,840.05 ns |        66.643 ns |       3.653 ns |     2,841.36 ns |  0.95 |    0.00 |   0.1373 |        - |       - |     872 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
   ArrayRank3OfDiffInstance | .NET Core 3.1 |   141,961.35 ns |   127,253.768 ns |   6,975.208 ns |   137,952.91 ns |  1.00 |    0.00 |   6.3477 |   0.7324 |       - |   40168 B |
   ArrayRank3OfDiffInstance | .NET Core 5.0 |   126,295.46 ns |    14,319.599 ns |     784.906 ns |   126,508.67 ns |  0.89 |    0.04 |   6.3477 |   0.7324 |       - |   40168 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
   ArrayRank3OfSameInstance | .NET Core 3.1 |    90,510.70 ns |     7,737.659 ns |     424.127 ns |    90,608.58 ns |  1.00 |    0.00 |   1.2207 |        - |       - |    8200 B |
   ArrayRank3OfSameInstance | .NET Core 5.0 |    85,853.62 ns |   190,267.922 ns |  10,429.227 ns |    80,448.74 ns |  0.95 |    0.11 |   1.2207 |        - |       - |    8200 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
         ListOfDiffInstance | .NET Core 3.1 |   722,256.74 ns |    33,714.302 ns |   1,847.995 ns |   722,397.07 ns |  1.00 |    0.00 |  63.4766 |  22.4609 |       - |  400056 B |
         ListOfDiffInstance | .NET Core 5.0 |   707,133.37 ns |    20,803.684 ns |   1,140.320 ns |   706,934.18 ns |  0.98 |    0.00 |  63.4766 |  22.4609 |       - |  400056 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
         ListOfSameInstance | .NET Core 3.1 |   248,513.09 ns |    85,062.370 ns |   4,662.556 ns |   246,124.61 ns |  1.00 |    0.00 |  12.2070 |   1.9531 |       - |   80088 B |
         ListOfSameInstance | .NET Core 5.0 |   230,388.64 ns |       512.975 ns |      28.118 ns |   230,387.50 ns |  0.93 |    0.02 |  12.4512 |   1.9531 |       - |   80088 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
  ListOfObjectsDiffInstance | .NET Core 3.1 |   958,189.97 ns |   132,876.993 ns |   7,283.436 ns |   956,035.45 ns |  1.00 |    0.00 |  63.4766 |  22.4609 |       - |  400056 B |
  ListOfObjectsDiffInstance | .NET Core 5.0 |   902,536.39 ns |    96,068.535 ns |   5,265.841 ns |   903,357.32 ns |  0.94 |    0.01 |  63.4766 |  22.4609 |       - |  400056 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
  ListOfObjectsSameInstance | .NET Core 3.1 |   465,763.54 ns |   103,649.690 ns |   5,681.389 ns |   462,697.41 ns |  1.00 |    0.00 |  12.2070 |   1.9531 |       - |   80088 B |
  ListOfObjectsSameInstance | .NET Core 5.0 |   415,803.39 ns |    73,349.994 ns |   4,020.561 ns |   416,067.72 ns |  0.89 |    0.01 |  12.2070 |   1.9531 |       - |   80088 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
           KeyValuePairSame | .NET Core 3.1 |       145.38 ns |       143.589 ns |       7.871 ns |       140.94 ns |  1.00 |    0.00 |   0.0050 |        - |       - |      32 B |
           KeyValuePairSame | .NET Core 5.0 |       123.85 ns |        28.242 ns |       1.548 ns |       124.32 ns |  0.85 |    0.04 |   0.0050 |        - |       - |      32 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
           KeyValuePairDiff | .NET Core 3.1 |       178.11 ns |        28.650 ns |       1.570 ns |       177.32 ns |  1.00 |    0.00 |   0.0100 |        - |       - |      64 B |
           KeyValuePairDiff | .NET Core 5.0 |       159.17 ns |        37.233 ns |       2.041 ns |       159.67 ns |  0.89 |    0.01 |   0.0100 |        - |       - |      64 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
          TupleSameInstance | .NET Core 3.1 |       164.49 ns |        22.012 ns |       1.207 ns |       163.84 ns |  1.00 |    0.00 |   0.0100 |        - |       - |      64 B |
          TupleSameInstance | .NET Core 5.0 |       142.67 ns |        12.630 ns |       0.692 ns |       142.46 ns |  0.87 |    0.00 |   0.0100 |        - |       - |      64 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
          TupleDiffInstance | .NET Core 3.1 |       199.37 ns |         9.379 ns |       0.514 ns |       199.37 ns |  1.00 |    0.00 |   0.0153 |        - |       - |      96 B |
          TupleDiffInstance | .NET Core 5.0 |       177.56 ns |        13.957 ns |       0.765 ns |       177.28 ns |  0.89 |    0.00 |   0.0153 |        - |       - |      96 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
     DictionarySameInstance | .NET Core 3.1 | 1,693,264.65 ns |   129,995.512 ns |   7,125.493 ns | 1,691,009.18 ns |  1.00 |    0.00 | 121.0938 | 111.3281 | 64.4531 |  603236 B |
     DictionarySameInstance | .NET Core 5.0 | 1,600,558.85 ns |   189,193.173 ns |  10,370.316 ns | 1,604,658.40 ns |  0.95 |    0.01 | 121.0938 | 111.3281 | 64.4531 |  603171 B |
                            |               |                 |                  |                |                 |       |         |          |          |         |           |
     DictionaryDiffInstance | .NET Core 3.1 | 2,578,906.90 ns | 2,294,398.534 ns | 125,763.726 ns | 2,519,148.05 ns |  1.00 |    0.00 | 167.9688 | 125.0000 | 62.5000 |  923116 B |
     DictionaryDiffInstance | .NET Core 5.0 | 2,345,604.69 ns | 1,359,794.275 ns |  74,534.913 ns | 2,309,200.39 ns |  0.91 |    0.07 | 167.9688 | 125.0000 | 62.5000 |  923093 B |
