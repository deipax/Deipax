
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev |          Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |----------------:|---------------:|---------------:|----------------:|---------:|---------:|---------:|----------:|
             SingleInstance |       155.58 ns |      3.3550 ns |       5.787 ns |       155.63 ns |   0.0050 |        - |        - |      32 B |
             ObjectInstance |        57.42 ns |      1.3817 ns |       4.031 ns |        55.72 ns |        - |        - |        - |       0 B |
            DefaultInstance |        41.56 ns |      0.8599 ns |       2.425 ns |        41.37 ns |        - |        - |        - |       0 B |
     ArrayOfDefaultInstance |   195,402.47 ns |  7,056.7048 ns |  20,696.094 ns |   194,317.69 ns |  57.0313 |  57.0313 |  57.0313 |  240024 B |
        ArrayOfDiffInstance |   137,811.52 ns |  2,749.9167 ns |   7,527.853 ns |   137,811.92 ns |  50.2956 |  50.2956 |  50.2956 |  240024 B |
        ArrayOfSameInstance |   192,469.04 ns |  7,838.3567 ns |  22,864.854 ns |   195,009.01 ns |  49.8551 |  49.8551 |  49.8551 |  240024 B |
 ArrayOfObjectsDiffInstance |   330,133.31 ns |  6,570.0973 ns |  17,874.434 ns |   329,991.93 ns |  12.2070 |        - |        - |   80024 B |
 ArrayOfObjectsSameInstance |   305,973.92 ns |  7,097.1103 ns |  20,814.596 ns |   300,215.22 ns |  12.2070 |        - |        - |   80024 B |
      Array2dOfDiffInstance |    32,676.63 ns |    998.5988 ns |   2,928.717 ns |    32,787.66 ns |  38.6353 |  11.7493 |        - |  243224 B |
      Array2dOfSameInstance |     4,494.06 ns |    103.6301 ns |     305.556 ns |     4,458.57 ns |   0.5112 |        - |        - |    3248 B |
   ArrayRank2OfDiffInstance |       409.39 ns |      8.9174 ns |      26.293 ns |       407.62 ns |   0.3872 |        - |        - |    2440 B |
   ArrayRank2OfSameInstance |       418.58 ns |     10.3524 ns |      30.362 ns |       414.84 ns |   0.3872 |        - |        - |    2440 B |
   ArrayRank3OfDiffInstance |     2,878.11 ns |     71.5590 ns |     208.741 ns |     2,833.55 ns |   3.8147 |        - |        - |   24088 B |
   ArrayRank3OfSameInstance |     2,817.73 ns |     71.4735 ns |     209.619 ns |     2,741.13 ns |   3.8147 |        - |        - |   24088 B |
         ListOfDiffInstance |   142,208.35 ns |  3,349.5950 ns |   9,876.356 ns |   142,834.54 ns |  58.3398 |  58.3398 |  58.3398 |  240524 B |
         ListOfSameInstance |   138,046.19 ns |  2,717.2870 ns |   5,489.054 ns |   137,899.44 ns |  54.7201 |  54.7201 |  54.7201 |  240502 B |
  ListOfObjectsDiffInstance |   324,408.36 ns |  7,552.0157 ns |  22,148.755 ns |   321,378.07 ns |  12.2070 |   1.9531 |        - |   80064 B |
  ListOfObjectsSameInstance |   347,119.05 ns |  8,298.1579 ns |  24,467.306 ns |   344,668.84 ns |  12.2070 |   1.9531 |        - |   80064 B |
           KeyValuePairSame |        71.73 ns |      1.9591 ns |       5.715 ns |        71.36 ns |   0.0101 |        - |        - |      64 B |
           KeyValuePairDiff |        59.79 ns |      1.2299 ns |       3.489 ns |        59.24 ns |   0.0101 |        - |        - |      64 B |
          TupleSameInstance |       139.57 ns |      2.8372 ns |       8.321 ns |       138.56 ns |   0.0100 |        - |        - |      64 B |
          TupleDiffInstance |       113.22 ns |      2.3003 ns |       5.377 ns |       113.86 ns |   0.0100 |        - |        - |      64 B |
     DictionarySameInstance | 1,849,127.88 ns | 50,516.3500 ns | 148,155.710 ns | 1,856,861.05 ns | 195.2930 | 155.9570 | 138.6523 |  926470 B |
     DictionaryDiffInstance | 1,852,572.97 ns | 56,994.1325 ns | 168,048.486 ns | 1,840,247.97 ns | 195.3320 | 155.9570 | 138.6914 |  926475 B |
