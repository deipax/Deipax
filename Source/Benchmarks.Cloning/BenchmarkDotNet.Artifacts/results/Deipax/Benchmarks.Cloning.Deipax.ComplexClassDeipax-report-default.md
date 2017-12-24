
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |           Error |         StdDev |          Median |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |----------------:|----------------:|---------------:|----------------:|---------:|---------:|--------:|----------:|
             SingleInstance |       140.63 ns |       2.8568 ns |       8.288 ns |       139.81 ns |   0.0050 |        - |       - |      32 B |
            DefaultInstance |        35.68 ns |       0.7432 ns |       1.837 ns |        35.66 ns |        - |        - |       - |       0 B |
     ArrayOfDefaultInstance |     9,922.38 ns |     247.2293 ns |     725.081 ns |     9,898.07 ns |  12.6495 |        - |       - |   80024 B |
        ArrayOfDiffInstance |   960,047.68 ns |  25,040.2901 ns |  72,246.962 ns |   936,316.59 ns |  62.5000 |  23.4375 |       - |  400024 B |
        ArrayOfSameInstance |   315,997.33 ns |   6,308.9690 ns |  17,586.884 ns |   311,425.41 ns |  12.2070 |        - |       - |   80056 B |
 ArrayOfObjectsDiffInstance | 1,239,019.05 ns |  28,068.7150 ns |  82,320.682 ns | 1,210,172.02 ns |  62.5000 |  23.4375 |       - |  400024 B |
 ArrayOfObjectsSameInstance |   569,767.15 ns |  14,348.5891 ns |  41,855.508 ns |   553,491.61 ns |  11.7188 |        - |       - |   80056 B |
      Array2dOfDiffInstance |   992,499.66 ns |  29,630.2192 ns |  87,365.370 ns |   967,377.82 ns |  63.4766 |  24.4141 |       - |  403224 B |
      Array2dOfSameInstance |    13,953.13 ns |     278.7571 ns |     683.796 ns |    13,777.34 ns |   0.7629 |        - |       - |    4848 B |
   ArrayRank2OfDiffInstance |     9,576.37 ns |     190.2077 ns |     312.517 ns |     9,550.77 ns |   0.6256 |        - |       - |    4040 B |
   ArrayRank2OfSameInstance |     4,229.22 ns |     103.9515 ns |     304.872 ns |     4,180.34 ns |   0.1297 |        - |       - |     872 B |
   ArrayRank3OfDiffInstance |   208,434.88 ns |   4,529.4410 ns |   9,454.630 ns |   208,080.20 ns |   6.1035 |   0.4883 |       - |   40168 B |
   ArrayRank3OfSameInstance |   149,757.85 ns |   3,585.3754 ns |  10,571.560 ns |   149,345.73 ns |   1.2207 |        - |       - |    8200 B |
         ListOfDiffInstance |   913,910.18 ns |  18,638.5614 ns |  42,449.436 ns |   892,654.04 ns |  62.5000 |  23.4375 |       - |  400064 B |
         ListOfSameInstance |   325,762.55 ns |   7,657.0785 ns |  22,456.886 ns |   316,387.54 ns |  12.2070 |   1.9531 |       - |   80096 B |
  ListOfObjectsDiffInstance | 1,335,323.38 ns |  29,252.9251 ns |  86,252.910 ns | 1,330,249.85 ns |  62.5000 |  23.4375 |       - |  400064 B |
  ListOfObjectsSameInstance |   590,028.18 ns |  11,675.7683 ns |  30,962.481 ns |   580,164.42 ns |  11.7188 |   1.9531 |       - |   80096 B |
           KeyValuePairSame |       228.61 ns |       4.5923 ns |      13.323 ns |       226.42 ns |   0.0100 |        - |       - |      64 B |
           KeyValuePairDiff |       291.54 ns |       6.2969 ns |      18.468 ns |       290.17 ns |   0.0148 |        - |       - |      96 B |
          TupleSameInstance |       241.50 ns |       4.8410 ns |      14.198 ns |       238.79 ns |   0.0100 |        - |       - |      64 B |
          TupleDiffInstance |       281.44 ns |       5.7854 ns |      16.968 ns |       280.83 ns |   0.0148 |        - |       - |      96 B |
     DictionarySameInstance | 2,889,626.08 ns |  61,618.9231 ns | 170,745.746 ns | 2,896,824.00 ns | 119.3750 | 109.4531 | 66.7969 |  603149 B |
     DictionaryDiffInstance | 4,455,380.17 ns | 129,609.3109 ns | 382,155.978 ns | 4,466,389.03 ns | 156.2500 | 117.4219 | 62.5000 |  923124 B |
