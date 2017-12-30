
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev |          Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |----------------:|---------------:|---------------:|----------------:|---------:|---------:|---------:|----------:|
             SingleInstance |        44.20 ns |      1.0245 ns |       2.989 ns |        44.15 ns |   0.0051 |        - |        - |      32 B |
             ObjectInstance |        57.34 ns |      1.3187 ns |       3.867 ns |        56.10 ns |        - |        - |        - |       0 B |
            DefaultInstance |        41.64 ns |      0.8622 ns |       2.418 ns |        41.63 ns |   0.0051 |        - |        - |      32 B |
     ArrayOfDefaultInstance |    88,874.54 ns |  1,776.6988 ns |   4,742.369 ns |    89,028.99 ns |  38.5986 |  38.5986 |  38.5986 |  160024 B |
        ArrayOfDiffInstance |    75,378.82 ns |  1,691.9862 ns |   4,988.860 ns |    74,689.01 ns |  35.3571 |  35.3556 |  35.3556 |  160024 B |
        ArrayOfSameInstance |   126,440.28 ns |  4,798.3772 ns |  14,148.123 ns |   130,568.54 ns |  34.8572 |  34.8557 |  34.8557 |  160024 B |
 ArrayOfObjectsDiffInstance |   315,222.80 ns |  6,661.8715 ns |  16,956.590 ns |   304,684.77 ns |  12.2070 |        - |        - |   80024 B |
 ArrayOfObjectsSameInstance |   312,854.57 ns |  6,220.4825 ns |  16,167.861 ns |   307,197.70 ns |  12.2070 |        - |        - |   80024 B |
      Array2dOfDiffInstance |    22,342.17 ns |    509.4357 ns |   1,477.965 ns |    21,981.23 ns |  25.9094 |   7.1106 |        - |  163224 B |
      Array2dOfSameInstance |     4,264.28 ns |    102.0684 ns |     299.349 ns |     4,211.27 ns |   0.3815 |        - |        - |    2448 B |
   ArrayRank2OfDiffInstance |       378.78 ns |      8.8638 ns |      26.135 ns |       380.06 ns |   0.2604 |        - |        - |    1640 B |
   ArrayRank2OfSameInstance |       374.46 ns |      7.4870 ns |      20.495 ns |       372.10 ns |   0.2604 |        - |        - |    1640 B |
   ArrayRank3OfDiffInstance |     1,820.54 ns |     43.3202 ns |     127.731 ns |     1,798.96 ns |   2.5558 |        - |        - |   16088 B |
   ArrayRank3OfSameInstance |     1,864.21 ns |     53.6918 ns |     158.311 ns |     1,834.76 ns |   2.5558 |        - |        - |   16088 B |
         ListOfDiffInstance |    87,419.05 ns |  1,727.3279 ns |   3,286.421 ns |    86,724.16 ns |  39.2920 |  39.2920 |  39.2920 |  160376 B |
         ListOfSameInstance |    86,609.64 ns |  1,727.6546 ns |   4,334.347 ns |    86,442.08 ns |  40.8337 |  40.8337 |  40.8337 |  160390 B |
  ListOfObjectsDiffInstance |   332,414.95 ns |  8,219.2589 ns |  24,105.663 ns |   322,219.99 ns |  12.2070 |   1.9531 |        - |   80064 B |
  ListOfObjectsSameInstance |   329,599.62 ns |  6,526.6223 ns |  18,193.614 ns |   328,343.06 ns |  12.2070 |   1.9531 |        - |   80064 B |
           KeyValuePairSame |        61.13 ns |      1.2546 ns |       3.679 ns |        60.16 ns |   0.0075 |        - |        - |      48 B |
           KeyValuePairDiff |        59.69 ns |      1.2666 ns |       2.672 ns |        59.22 ns |   0.0075 |        - |        - |      48 B |
          TupleSameInstance |       111.28 ns |      2.3239 ns |       6.852 ns |       110.15 ns |   0.0075 |        - |        - |      48 B |
          TupleDiffInstance |       115.59 ns |      3.4853 ns |      10.276 ns |       115.18 ns |   0.0075 |        - |        - |      48 B |
     DictionarySameInstance | 1,613,200.55 ns | 46,603.8207 ns | 136,680.939 ns | 1,626,564.94 ns | 167.7539 | 118.8086 | 111.1133 |  764817 B |
     DictionaryDiffInstance | 1,625,637.65 ns | 48,698.8053 ns | 143,589.526 ns | 1,616,504.89 ns | 167.6172 | 118.9844 | 110.9766 |  764812 B |
