
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |         Error |         StdDev |          Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |----------------:|--------------:|---------------:|----------------:|---------:|---------:|---------:|----------:|
             SingleInstance |       193.83 ns |      5.545 ns |      15.910 ns |       193.37 ns |   0.0050 |        - |        - |      32 B |
            DefaultInstance |        44.85 ns |      1.670 ns |       4.872 ns |        43.89 ns |        - |        - |        - |       0 B |
     ArrayOfDefaultInstance |   139,052.63 ns |  2,767.797 ns |   7,941.329 ns |   139,245.59 ns |  54.8267 |  54.8267 |  54.8267 |  240024 B |
        ArrayOfDiffInstance |   168,653.97 ns |  6,019.760 ns |  17,749.398 ns |   168,120.91 ns |  57.9053 |  57.9053 |  57.9053 |  240024 B |
        ArrayOfSameInstance |   159,555.54 ns |  7,036.042 ns |  20,635.493 ns |   157,814.82 ns |  53.3593 |  53.3429 |  53.3429 |  240024 B |
 ArrayOfObjectsDiffInstance |   300,767.53 ns |  2,325.215 ns |   2,061.242 ns |   299,968.98 ns |  12.2070 |        - |        - |   80024 B |
 ArrayOfObjectsSameInstance |   324,163.75 ns |  7,034.159 ns |  20,740.376 ns |   317,689.69 ns |  12.2070 |        - |        - |   80024 B |
      Array2dOfDiffInstance |    36,687.05 ns |  1,083.084 ns |   3,193.498 ns |    36,350.60 ns |  38.6353 |  11.7188 |        - |  243224 B |
      Array2dOfSameInstance |     4,752.67 ns |    104.725 ns |     303.827 ns |     4,717.81 ns |   0.5112 |        - |        - |    3248 B |
   ArrayRank2OfDiffInstance |       465.50 ns |      9.921 ns |      28.305 ns |       461.54 ns |   0.3872 |        - |        - |    2440 B |
   ArrayRank2OfSameInstance |       461.09 ns |      9.660 ns |      23.877 ns |       449.14 ns |   0.3872 |        - |        - |    2440 B |
   ArrayRank3OfDiffInstance |     3,378.93 ns |     88.405 ns |     259.276 ns |     3,320.73 ns |   3.8147 |        - |        - |   24088 B |
   ArrayRank3OfSameInstance |     3,527.45 ns |    130.660 ns |     385.253 ns |     3,407.95 ns |   3.8147 |        - |        - |   24088 B |
         ListOfDiffInstance |   149,220.64 ns |  6,178.789 ns |  18,218.297 ns |   146,621.65 ns |  54.0302 |  54.0067 |  54.0067 |  240456 B |
         ListOfSameInstance |   112,287.99 ns |  2,236.021 ns |   4,765.144 ns |   111,832.52 ns |  58.6890 |  58.6865 |  58.6865 |  240525 B |
  ListOfObjectsDiffInstance |   319,487.74 ns | 12,013.424 ns |  11,798.787 ns |   314,315.96 ns |  12.2070 |   1.9531 |        - |   80064 B |
  ListOfObjectsSameInstance |   322,730.55 ns |  6,376.102 ns |  12,284.584 ns |   316,799.16 ns |  12.2070 |   1.9531 |        - |   80064 B |
           KeyValuePairSame |        79.21 ns |      2.426 ns |       7.078 ns |        79.41 ns |   0.0101 |        - |        - |      64 B |
           KeyValuePairDiff |        77.32 ns |      2.904 ns |       8.562 ns |        76.94 ns |   0.0101 |        - |        - |      64 B |
          TupleSameInstance |       144.19 ns |      4.668 ns |      13.765 ns |       143.08 ns |   0.0100 |        - |        - |      64 B |
          TupleDiffInstance |       130.82 ns |      3.480 ns |      10.260 ns |       128.63 ns |   0.0100 |        - |        - |      64 B |
     DictionarySameInstance | 1,752,277.63 ns | 56,030.640 ns | 165,207.607 ns | 1,738,970.03 ns | 197.2266 | 156.8750 | 140.5859 |  926502 B |
     DictionaryDiffInstance | 1,363,302.01 ns | 29,716.320 ns |  85,261.692 ns | 1,360,070.33 ns | 191.4844 | 152.4219 | 136.7969 |  926504 B |
