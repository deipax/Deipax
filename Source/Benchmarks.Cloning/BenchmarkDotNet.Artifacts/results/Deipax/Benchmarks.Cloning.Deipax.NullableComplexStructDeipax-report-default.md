
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |             Mean |          Error |         StdDev |           Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |-----------------:|---------------:|---------------:|-----------------:|---------:|---------:|---------:|----------:|
             SingleInstance |        384.23 ns |      16.137 ns |      47.326 ns |        376.93 ns |   0.0100 |        - |        - |      64 B |
            DefaultInstance |         59.98 ns |       1.283 ns |       3.147 ns |         59.89 ns |        - |        - |        - |       0 B |
     ArrayOfDefaultInstance |     59,199.36 ns |   3,407.883 ns |   9,994.732 ns |     57,953.56 ns |   5.8539 |   5.8539 |   5.8539 |  240024 B |
        ArrayOfDiffInstance |  3,994,938.00 ns |  91,822.254 ns | 270,739.987 ns |  3,999,535.45 ns | 138.3594 |  93.7500 |  46.8750 |  880114 B |
        ArrayOfSameInstance |  2,602,454.10 ns |  67,312.208 ns | 198,471.564 ns |  2,595,740.56 ns | 103.7109 |  56.8359 |  56.8359 |  560220 B |
 ArrayOfObjectsDiffInstance |  1,553,050.71 ns |  30,965.499 ns |  79,931.841 ns |  1,559,733.04 ns | 113.2813 |  42.9688 |        - |  720024 B |
 ArrayOfObjectsSameInstance |    789,446.32 ns |  19,685.845 ns |  58,044.158 ns |    776,857.05 ns |  62.5000 |  23.4375 |        - |  400056 B |
      Array2dOfDiffInstance |  2,741,248.58 ns |  76,152.686 ns | 224,537.914 ns |  2,725,289.63 ns | 136.7188 |  54.6875 |        - |  883224 B |
      Array2dOfSameInstance |     31,408.63 ns |     721.159 ns |   2,126.353 ns |     31,238.27 ns |   1.4954 |   0.0305 |        - |    9648 B |
   ArrayRank2OfDiffInstance |     26,031.92 ns |     542.306 ns |   1,590.491 ns |     25,656.75 ns |   1.3733 |        - |        - |    8840 B |
   ArrayRank2OfSameInstance |     20,359.99 ns |     404.833 ns |   1,187.304 ns |     20,310.27 ns |   0.8850 |        - |        - |    5672 B |
   ArrayRank3OfDiffInstance |    343,539.20 ns |   6,850.967 ns |  18,404.679 ns |    340,556.31 ns |  18.5547 |   2.4414 |        - |  120168 B |
   ArrayRank3OfSameInstance |    279,979.39 ns |   5,608.848 ns |  16,272.286 ns |    279,667.34 ns |  13.6719 |   0.9766 |        - |   88200 B |
         ListOfDiffInstance |  4,684,623.12 ns | 129,206.663 ns | 378,940.775 ns |  4,681,430.57 ns | 138.3594 |  93.8281 |  46.8750 |  880161 B |
         ListOfSameInstance |  2,354,443.59 ns |  63,947.168 ns | 187,545.974 ns |  2,327,410.05 ns | 104.6875 |  57.8125 |  57.8125 |  560270 B |
  ListOfObjectsDiffInstance |  1,430,960.01 ns |  28,253.317 ns |  45,623.841 ns |  1,409,106.01 ns | 113.2813 |  42.9688 |        - |  720064 B |
  ListOfObjectsSameInstance |    795,928.41 ns |  15,889.516 ns |  45,075.913 ns |    791,086.86 ns |  62.5000 |  23.4375 |        - |  400096 B |
           KeyValuePairSame |        588.63 ns |      14.722 ns |      43.177 ns |        579.66 ns |   0.0248 |        - |        - |     160 B |
           KeyValuePairDiff |        639.50 ns |      14.993 ns |      44.208 ns |        645.79 ns |   0.0296 |        - |        - |     192 B |
          TupleSameInstance |        558.67 ns |      14.558 ns |      13.617 ns |        552.93 ns |   0.0248 |        - |        - |     160 B |
          TupleDiffInstance |        635.64 ns |      15.125 ns |      44.119 ns |        629.82 ns |   0.0296 |        - |        - |     192 B |
     DictionarySameInstance |  9,797,488.38 ns | 246,606.101 ns | 723,253.004 ns |  9,895,419.27 ns | 312.5000 | 234.3750 | 109.3750 | 1886622 B |
     DictionaryDiffInstance | 11,607,634.89 ns | 276,422.403 ns | 810,699.056 ns | 11,568,739.01 ns | 343.9063 | 218.7500 | 109.3750 | 2206537 B |
