
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |             Mean |          Error |         StdDev |           Median |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |-----------------:|---------------:|---------------:|-----------------:|---------:|---------:|--------:|----------:|
             SingleInstance |        306.17 ns |       6.357 ns |      15.949 ns |        304.73 ns |   0.0100 |        - |       - |      64 B |
             ObjectInstance |        193.28 ns |       3.985 ns |      10.499 ns |        191.32 ns |   0.0100 |        - |       - |      64 B |
            DefaultInstance |         60.21 ns |       1.429 ns |       4.147 ns |         60.04 ns |        - |        - |       - |       0 B |
     ArrayOfDefaultInstance |     53,736.74 ns |   2,233.869 ns |   6,551.551 ns |     54,765.80 ns |   4.3768 |   4.3768 |  4.3768 |  240024 B |
        ArrayOfDiffInstance |  5,175,216.74 ns | 113,876.621 ns | 328,560.090 ns |  5,179,321.18 ns | 132.8125 |  86.7188 | 39.8438 |  880071 B |
        ArrayOfSameInstance |  2,327,225.59 ns |  67,500.257 ns | 199,026.031 ns |  2,311,286.14 ns |  97.8125 |  50.9375 | 50.9375 |  560223 B |
 ArrayOfObjectsDiffInstance |  1,450,526.63 ns |  35,430.753 ns | 104,468.376 ns |  1,436,149.10 ns | 113.2813 |  42.9688 |       - |  720024 B |
 ArrayOfObjectsSameInstance |    757,879.82 ns |  19,046.377 ns |  56,158.672 ns |    742,607.00 ns |  62.5000 |  23.4375 |       - |  400056 B |
      Array2dOfDiffInstance |  2,372,136.56 ns |  72,153.631 ns |  63,962.308 ns |  2,345,588.78 ns | 136.7188 |  54.6875 |       - |  883224 B |
      Array2dOfSameInstance |     30,485.43 ns |     607.886 ns |   1,408.868 ns |     30,395.83 ns |   1.4954 |   0.0305 |       - |    9648 B |
   ArrayRank2OfDiffInstance |     23,973.16 ns |     477.664 ns |     953.947 ns |     23,733.09 ns |   1.3733 |        - |       - |    8840 B |
   ArrayRank2OfSameInstance |     18,419.70 ns |     447.979 ns |   1,313.846 ns |     18,361.51 ns |   0.8850 |        - |       - |    5672 B |
   ArrayRank3OfDiffInstance |    356,065.48 ns |   8,071.291 ns |  23,544.334 ns |    354,819.92 ns |  18.5547 |   2.4414 |       - |  120168 B |
   ArrayRank3OfSameInstance |    306,195.99 ns |   6,105.591 ns |  17,518.084 ns |    305,147.12 ns |  13.6719 |   0.9766 |       - |   88200 B |
         ListOfDiffInstance |  4,354,834.31 ns | 126,482.473 ns | 370,951.199 ns |  4,348,993.60 ns | 149.4531 | 102.7734 | 51.7969 |  880116 B |
         ListOfSameInstance |  2,293,420.80 ns |  62,597.093 ns | 183,586.437 ns |  2,268,968.39 ns |  97.9297 |  51.0547 | 51.0547 |  560263 B |
  ListOfObjectsDiffInstance |  1,440,312.33 ns |  33,679.000 ns |  99,303.291 ns |  1,399,330.49 ns | 113.2813 |  42.9688 |       - |  720064 B |
  ListOfObjectsSameInstance |    756,494.78 ns |  15,115.950 ns |  42,881.434 ns |    746,796.73 ns |  62.5000 |  23.4375 |       - |  400096 B |
           KeyValuePairSame |        568.94 ns |      11.775 ns |      34.718 ns |        571.48 ns |   0.0248 |        - |       - |     160 B |
           KeyValuePairDiff |        663.97 ns |      14.315 ns |      41.984 ns |        659.80 ns |   0.0296 |        - |       - |     192 B |
          TupleSameInstance |        582.07 ns |      13.629 ns |      40.184 ns |        581.61 ns |   0.0248 |        - |       - |     160 B |
          TupleDiffInstance |        641.27 ns |      15.024 ns |      44.299 ns |        636.54 ns |   0.0296 |        - |       - |     192 B |
     DictionarySameInstance | 10,332,486.82 ns | 225,580.758 ns | 665,129.955 ns | 10,264,848.26 ns | 296.8750 | 203.1250 | 93.7500 | 1886632 B |
     DictionaryDiffInstance | 13,472,981.61 ns | 334,227.883 ns | 980,232.523 ns | 13,300,532.99 ns | 323.3045 | 198.3045 | 88.9295 | 2206559 B |
