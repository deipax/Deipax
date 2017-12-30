
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |        StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|--------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |      42.16 ns |      0.9599 ns |      2.723 ns |      42.11 ns |  0.0038 |       - |       - |      24 B |
             ObjectInstance |      72.38 ns |      2.0206 ns |      5.958 ns |      70.67 ns |       - |       - |       - |       0 B |
            DefaultInstance |      39.44 ns |      0.8319 ns |      2.427 ns |      39.20 ns |  0.0038 |       - |       - |      24 B |
     ArrayOfDefaultInstance |   3,892.46 ns |     88.1439 ns |    254.315 ns |   3,865.69 ns |  6.3248 |       - |       - |   40024 B |
        ArrayOfDiffInstance |   4,181.22 ns |     94.7134 ns |    277.778 ns |   4,171.61 ns |  6.3248 |       - |       - |   40024 B |
        ArrayOfSameInstance |   3,972.62 ns |    110.6078 ns |    326.130 ns |   3,925.09 ns |  6.3248 |       - |       - |   40024 B |
 ArrayOfObjectsDiffInstance | 787,225.22 ns | 15,732.1830 ns | 22,562.627 ns | 774,512.25 ns | 11.7188 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 805,914.97 ns | 15,895.0340 ns | 35,222.297 ns | 791,181.49 ns | 11.7188 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  15,854.56 ns |    312.2585 ns |    476.852 ns |  15,636.01 ns |  6.8359 |  0.7324 |       - |   43224 B |
      Array2dOfSameInstance |   3,638.02 ns |     29.0828 ns |     22.706 ns |   3,632.79 ns |  0.1945 |       - |       - |    1248 B |
   ArrayRank2OfDiffInstance |     295.31 ns |      6.1622 ns |     15.573 ns |     298.07 ns |  0.0696 |       - |       - |     440 B |
   ArrayRank2OfSameInstance |     278.62 ns |      6.5835 ns |      9.650 ns |     273.76 ns |  0.0696 |       - |       - |     440 B |
   ArrayRank3OfDiffInstance | 318,183.42 ns |  6,311.5480 ns | 11,054.167 ns | 310,995.39 ns |  7.8125 |  0.4883 |       - |   52168 B |
   ArrayRank3OfSameInstance | 330,907.19 ns |  6,573.6979 ns | 17,546.530 ns | 328,902.38 ns |  7.8125 |  0.4883 |       - |   52168 B |
         ListOfDiffInstance |   4,532.76 ns |    129.3635 ns |    379.401 ns |   4,557.97 ns |  6.3629 |  0.6332 |       - |   40064 B |
         ListOfSameInstance |   4,225.88 ns |    141.0135 ns |    415.782 ns |   4,107.80 ns |  6.3629 |  0.6332 |       - |   40064 B |
  ListOfObjectsDiffInstance | 844,619.05 ns | 18,518.4893 ns | 54,019.303 ns | 844,544.87 ns | 11.7188 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 821,737.75 ns | 16,299.3556 ns | 47,803.188 ns | 810,320.96 ns | 11.7188 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      41.00 ns |      0.9381 ns |      2.766 ns |      40.76 ns |  0.0038 |       - |       - |      24 B |
           KeyValuePairDiff |      38.71 ns |      0.8633 ns |      2.546 ns |      38.43 ns |  0.0038 |       - |       - |      24 B |
          TupleSameInstance |     124.18 ns |      3.1314 ns |      9.085 ns |     123.92 ns |  0.0036 |       - |       - |      24 B |
          TupleDiffInstance |     114.00 ns |      3.0471 ns |      8.889 ns |     113.09 ns |  0.0036 |       - |       - |      24 B |
     DictionarySameInstance | 162,903.29 ns |  4,211.2507 ns | 12,416.968 ns | 163,446.20 ns | 83.2520 | 83.2520 | 83.2520 |  350560 B |
     DictionaryDiffInstance | 158,232.86 ns |  3,730.7423 ns | 10,941.621 ns | 155,680.38 ns | 83.2520 | 83.2520 | 83.2520 |  350560 B |
