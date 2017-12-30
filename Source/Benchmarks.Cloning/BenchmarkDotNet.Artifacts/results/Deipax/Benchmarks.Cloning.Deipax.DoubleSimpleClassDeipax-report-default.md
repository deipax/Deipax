
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |           Error |          StdDev |          Median |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |----------------:|----------------:|----------------:|----------------:|---------:|---------:|--------:|----------:|
             SingleInstance |       202.25 ns |       4.0538 ns |      11.5000 ns |       200.17 ns |   0.0150 |        - |       - |      96 B |
             ObjectInstance |       231.90 ns |       4.6349 ns |      10.7420 ns |       230.36 ns |   0.0148 |        - |       - |      96 B |
            DefaultInstance |        30.40 ns |       0.5983 ns |       0.4996 ns |        30.16 ns |        - |        - |       - |       0 B |
     ArrayOfDefaultInstance |     9,166.76 ns |     193.3162 ns |     566.9629 ns |     9,081.48 ns |  12.6495 |        - |       - |   80024 B |
        ArrayOfDiffInstance | 1,883,781.28 ns |  41,477.6285 ns | 122,297.7236 ns | 1,889,339.99 ns | 164.0625 |  62.5000 |       - | 1040024 B |
        ArrayOfSameInstance |   318,404.41 ns |   6,489.2260 ns |  19,133.6293 ns |   317,849.64 ns |  12.2070 |        - |       - |   80120 B |
 ArrayOfObjectsDiffInstance | 2,212,278.18 ns |  64,162.4453 ns | 188,177.3452 ns | 2,213,199.02 ns | 164.0625 |  62.5000 |       - | 1040024 B |
 ArrayOfObjectsSameInstance |   572,735.59 ns |  13,944.8985 ns |  41,116.8478 ns |   563,649.72 ns |  11.7188 |        - |       - |   80120 B |
      Array2dOfDiffInstance | 1,761,161.21 ns |  34,746.7052 ns |  62,655.4768 ns | 1,730,663.93 ns | 164.0625 |  74.2188 |       - | 1043224 B |
      Array2dOfSameInstance |    19,957.48 ns |     426.1225 ns |   1,249.7436 ns |    19,786.62 ns |   1.7700 |   0.0610 |       - |   11248 B |
   ArrayRank2OfDiffInstance |    21,232.35 ns |     423.8618 ns |   1,086.5197 ns |    21,295.04 ns |   1.6479 |   0.0458 |       - |   10440 B |
   ArrayRank2OfSameInstance |     3,954.19 ns |      86.5050 ns |     249.5868 ns |     3,808.02 ns |   0.1450 |        - |       - |     936 B |
   ArrayRank3OfDiffInstance |   276,350.96 ns |   5,509.7241 ns |  15,719.5528 ns |   272,250.04 ns |  16.1133 |   2.9297 |       - |  104168 B |
   ArrayRank3OfSameInstance |   151,147.42 ns |   3,539.0530 ns |  10,379.4298 ns |   151,535.35 ns |   1.2207 |        - |       - |    8264 B |
         ListOfDiffInstance | 1,820,905.32 ns |  43,065.8939 ns | 126,980.7599 ns | 1,800,791.82 ns | 164.0625 |  58.5938 |       - | 1040064 B |
         ListOfSameInstance |   315,697.95 ns |   4,357.0714 ns |   3,638.3516 ns |   314,472.93 ns |  12.2070 |   1.9531 |       - |   80160 B |
  ListOfObjectsDiffInstance | 2,766,460.51 ns |  54,987.0023 ns | 143,891.4010 ns | 2,762,060.48 ns | 164.0625 |  62.5000 |       - | 1040064 B |
  ListOfObjectsSameInstance |   616,081.64 ns |  16,203.5838 ns |  47,776.6326 ns |   613,351.04 ns |  11.7188 |   1.9531 |       - |   80160 B |
           KeyValuePairSame |       291.59 ns |       6.0015 ns |      17.6013 ns |       292.68 ns |   0.0200 |        - |       - |     128 B |
           KeyValuePairDiff |       434.75 ns |       8.7060 ns |      24.1242 ns |       432.28 ns |   0.0353 |        - |       - |     224 B |
          TupleSameInstance |       283.78 ns |       5.6785 ns |      12.2235 ns |       276.46 ns |   0.0200 |        - |       - |     128 B |
          TupleDiffInstance |       406.93 ns |       9.0134 ns |      26.4346 ns |       397.33 ns |   0.0353 |        - |       - |     224 B |
     DictionarySameInstance | 4,913,849.07 ns | 126,445.2930 ns | 372,826.7992 ns | 4,872,411.49 ns | 197.1875 | 116.5625 | 48.0469 | 1243097 B |
     DictionaryDiffInstance | 9,187,880.37 ns | 254,169.2573 ns | 749,423.7899 ns | 9,014,450.11 ns | 343.7500 | 171.8750 | 46.8750 | 2203075 B |
