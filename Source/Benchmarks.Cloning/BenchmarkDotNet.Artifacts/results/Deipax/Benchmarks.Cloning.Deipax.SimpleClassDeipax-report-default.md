
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |           Error |         StdDev |          Median |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |----------------:|----------------:|---------------:|----------------:|---------:|---------:|--------:|----------:|
             SingleInstance |       113.78 ns |       2.3347 ns |       6.810 ns |       111.79 ns |   0.0101 |        - |       - |      64 B |
            DefaultInstance |        34.41 ns |       0.7215 ns |       1.756 ns |        33.91 ns |        - |        - |       - |       0 B |
     ArrayOfDefaultInstance |     9,626.96 ns |     192.1274 ns |     499.365 ns |     9,422.10 ns |  12.6495 |        - |       - |   80024 B |
        ArrayOfDiffInstance |   735,611.19 ns |  14,712.1488 ns |  40,521.530 ns |   723,446.23 ns | 113.2813 |  41.9922 |       - |  720024 B |
        ArrayOfSameInstance |   329,695.98 ns |   6,573.2398 ns |  17,545.308 ns |   330,916.71 ns |  12.2070 |        - |       - |   80088 B |
 ArrayOfObjectsDiffInstance |   992,899.07 ns |  19,849.1063 ns |  48,315.468 ns |   972,870.74 ns | 113.2813 |  42.9688 |       - |  720024 B |
 ArrayOfObjectsSameInstance |   621,933.44 ns |  16,024.7335 ns |  47,249.288 ns |   617,813.06 ns |  11.7188 |        - |       - |   80088 B |
      Array2dOfDiffInstance |   755,999.09 ns |  15,062.5862 ns |  43,459.005 ns |   740,199.52 ns | 114.2578 |  44.9219 |       - |  723224 B |
      Array2dOfSameInstance |    12,050.17 ns |     265.3549 ns |     782.405 ns |    11,950.41 ns |   1.2665 |   0.0305 |       - |    8048 B |
   ArrayRank2OfDiffInstance |     7,381.02 ns |     148.4220 ns |     437.626 ns |     7,283.67 ns |   1.1444 |   0.0153 |       - |    7240 B |
   ArrayRank2OfSameInstance |     4,301.85 ns |      85.5186 ns |     238.392 ns |     4,327.40 ns |   0.1373 |        - |       - |     904 B |
   ArrayRank3OfDiffInstance |   193,108.18 ns |   3,859.8315 ns |  10,886.723 ns |   193,149.92 ns |  11.2305 |   1.7090 |       - |   72168 B |
   ArrayRank3OfSameInstance |   154,011.77 ns |   3,070.9943 ns |   8,860.521 ns |   153,839.63 ns |   1.2207 |        - |       - |    8232 B |
         ListOfDiffInstance |   744,701.21 ns |  14,803.2468 ns |  41,994.347 ns |   728,834.81 ns | 113.2813 |  41.9922 |       - |  720064 B |
         ListOfSameInstance |   329,016.26 ns |   6,670.2778 ns |  17,919.268 ns |   322,548.05 ns |  12.2070 |   1.9531 |       - |   80128 B |
  ListOfObjectsDiffInstance | 1,017,472.12 ns |  20,307.6013 ns |  53,498.345 ns | 1,001,486.40 ns | 113.2813 |  42.9688 |       - |  720064 B |
  ListOfObjectsSameInstance |   615,375.74 ns |  14,098.7314 ns |  41,349.138 ns |   599,392.28 ns |  11.7188 |   1.9531 |       - |   80128 B |
           KeyValuePairSame |       205.20 ns |       4.1811 ns |      12.262 ns |       204.70 ns |   0.0150 |        - |       - |      96 B |
           KeyValuePairDiff |       246.16 ns |       6.5299 ns |      19.151 ns |       245.56 ns |   0.0253 |        - |       - |     160 B |
          TupleSameInstance |       218.23 ns |       4.4621 ns |      13.086 ns |       219.36 ns |   0.0150 |        - |       - |      96 B |
          TupleDiffInstance |       261.25 ns |       6.9739 ns |      20.563 ns |       261.35 ns |   0.0253 |        - |       - |     160 B |
     DictionarySameInstance | 3,132,244.07 ns | 106,665.2399 ns | 314,504.866 ns | 3,115,784.97 ns | 160.1563 | 109.3750 | 54.6875 |  923089 B |
     DictionaryDiffInstance | 5,553,401.94 ns | 140,836.2808 ns | 410,826.041 ns | 5,480,574.78 ns | 263.2813 | 181.7188 | 62.5000 | 1563093 B |
