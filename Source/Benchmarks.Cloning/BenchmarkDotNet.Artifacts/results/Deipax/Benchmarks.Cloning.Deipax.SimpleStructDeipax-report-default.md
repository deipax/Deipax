
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev |          Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |----------------:|---------------:|---------------:|----------------:|---------:|---------:|---------:|----------:|
             SingleInstance |        43.14 ns |      1.0434 ns |       3.077 ns |        42.75 ns |   0.0051 |        - |        - |      32 B |
            DefaultInstance |        45.99 ns |      0.9599 ns |       2.769 ns |        45.94 ns |   0.0051 |        - |        - |      32 B |
     ArrayOfDefaultInstance |   107,986.83 ns |  3,257.1650 ns |   9,552.701 ns |   107,443.96 ns |  35.6946 |  35.6897 |  35.6897 |  160024 B |
        ArrayOfDiffInstance |   120,793.31 ns |  4,486.8047 ns |  13,229.445 ns |   122,354.84 ns |  38.5867 |  38.5867 |  38.5867 |  160024 B |
        ArrayOfSameInstance |   128,813.65 ns |  4,268.5076 ns |  12,518.794 ns |   127,166.18 ns |  40.6177 |  40.6177 |  40.6177 |  160024 B |
 ArrayOfObjectsDiffInstance |   326,449.81 ns |  6,798.4975 ns |  20,045.523 ns |   328,593.77 ns |  12.2070 |        - |        - |   80024 B |
 ArrayOfObjectsSameInstance |   319,272.09 ns |  7,478.6272 ns |  21,933.519 ns |   315,364.51 ns |  12.2070 |        - |        - |   80024 B |
      Array2dOfDiffInstance |    24,810.76 ns |    551.9449 ns |   1,618.759 ns |    24,514.66 ns |  25.9094 |   7.1106 |        - |  163224 B |
      Array2dOfSameInstance |     4,796.92 ns |    108.1947 ns |     313.892 ns |     4,803.37 ns |   0.3815 |        - |        - |    2448 B |
   ArrayRank2OfDiffInstance |       397.19 ns |      9.2924 ns |      27.399 ns |       388.93 ns |   0.2604 |        - |        - |    1640 B |
   ArrayRank2OfSameInstance |       429.38 ns |     10.8007 ns |      31.846 ns |       426.08 ns |   0.2604 |        - |        - |    1640 B |
   ArrayRank3OfDiffInstance |     2,048.03 ns |     45.9988 ns |     133.451 ns |     2,023.82 ns |   2.5558 |        - |        - |   16088 B |
   ArrayRank3OfSameInstance |     1,928.63 ns |     30.8974 ns |      24.123 ns |     1,919.40 ns |   2.5558 |        - |        - |   16088 B |
         ListOfDiffInstance |    88,513.39 ns |  1,763.6582 ns |   4,615.186 ns |    88,677.59 ns |  37.9053 |  37.9053 |  37.9053 |  160363 B |
         ListOfSameInstance |   118,198.63 ns |  4,556.1560 ns |  13,362.417 ns |   118,898.19 ns |  35.6195 |  35.6148 |  35.6148 |  160337 B |
  ListOfObjectsDiffInstance |   383,599.89 ns |  7,606.0724 ns |  21,577.162 ns |   375,782.81 ns |  12.2070 |   1.9531 |        - |   80064 B |
  ListOfObjectsSameInstance |   341,586.59 ns |  7,451.8518 ns |  21,737.402 ns |   337,880.75 ns |  12.2070 |   1.9531 |        - |   80064 B |
           KeyValuePairSame |        67.57 ns |      1.6117 ns |       4.727 ns |        67.34 ns |   0.0075 |        - |        - |      48 B |
           KeyValuePairDiff |        64.01 ns |      1.7936 ns |       5.288 ns |        63.59 ns |   0.0075 |        - |        - |      48 B |
          TupleSameInstance |       126.68 ns |      3.4648 ns |      10.216 ns |       126.02 ns |   0.0075 |        - |        - |      48 B |
          TupleDiffInstance |       122.20 ns |      3.2567 ns |       9.551 ns |       122.26 ns |   0.0074 |        - |        - |      48 B |
     DictionarySameInstance | 1,620,164.00 ns | 45,449.8235 ns | 134,009.830 ns | 1,637,966.55 ns | 167.6367 | 122.5195 | 110.9961 |  764780 B |
     DictionaryDiffInstance | 1,442,146.08 ns | 39,261.1790 ns | 115,146.242 ns | 1,431,669.90 ns | 167.7539 | 122.2656 | 111.1133 |  764767 B |
