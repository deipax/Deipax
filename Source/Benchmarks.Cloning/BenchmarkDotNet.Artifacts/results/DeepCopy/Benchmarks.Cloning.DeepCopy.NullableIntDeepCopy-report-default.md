
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |        StdDev |        Median |    Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|--------------:|--------------:|---------:|--------:|--------:|----------:|
             SingleInstance |     161.50 ns |      3.2748 ns |      9.656 ns |     162.36 ns |   0.0036 |       - |       - |      24 B |
             ObjectInstance |      72.45 ns |      1.4835 ns |      3.348 ns |      70.43 ns |        - |       - |       - |       0 B |
            DefaultInstance |      27.38 ns |      0.5801 ns |      1.001 ns |      27.36 ns |        - |       - |       - |       0 B |
     ArrayOfDefaultInstance |   7,054.78 ns |    139.5438 ns |    291.280 ns |   6,877.57 ns |  12.6495 |       - |       - |   80024 B |
        ArrayOfDiffInstance |   6,813.12 ns |     19.2319 ns |     15.015 ns |   6,807.96 ns |  12.6495 |       - |       - |   80024 B |
        ArrayOfSameInstance |   7,117.74 ns |    148.7576 ns |    431.573 ns |   6,849.28 ns |  12.6495 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance | 795,653.61 ns | 15,498.7190 ns | 15,916.042 ns | 787,311.06 ns |  11.7188 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 785,606.00 ns | 16,700.3580 ns | 29,684.869 ns | 770,928.96 ns |  11.7188 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  18,256.99 ns |    417.9677 ns |    447.221 ns |  18,085.06 ns |  13.2141 |  2.6245 |       - |   83224 B |
      Array2dOfSameInstance |   4,001.14 ns |     86.1432 ns |    253.995 ns |   3,990.85 ns |   0.2594 |       - |       - |    1648 B |
   ArrayRank2OfDiffInstance |     320.13 ns |      6.4060 ns |     16.763 ns |     320.89 ns |   0.1330 |       - |       - |     840 B |
   ArrayRank2OfSameInstance |     310.21 ns |      6.4484 ns |     19.013 ns |     310.74 ns |   0.1330 |       - |       - |     840 B |
   ArrayRank3OfDiffInstance | 358,539.68 ns |  7,072.5572 ns |  5,905.905 ns | 356,017.82 ns |   8.7891 |       - |       - |   56168 B |
   ArrayRank3OfSameInstance | 357,388.67 ns |  2,619.3692 ns |  2,045.031 ns | 356,850.61 ns |   8.7891 |       - |       - |   56168 B |
         ListOfDiffInstance |   7,298.82 ns |     47.0527 ns |     36.736 ns |   7,294.21 ns |  12.6495 |  2.1057 |       - |   80064 B |
         ListOfSameInstance |   7,285.59 ns |      5.6237 ns |      3.720 ns |   7,285.19 ns |  12.6495 |  2.1057 |       - |   80064 B |
  ListOfObjectsDiffInstance | 808,106.78 ns | 16,063.3038 ns | 27,276.709 ns | 792,475.48 ns |  11.7188 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 807,591.65 ns | 18,616.2404 ns | 27,863.912 ns | 791,544.32 ns |  11.7188 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      41.29 ns |      0.9764 ns |      1.270 ns |      40.59 ns |   0.0051 |       - |       - |      32 B |
           KeyValuePairDiff |      40.82 ns |      0.8512 ns |      2.415 ns |      39.51 ns |   0.0051 |       - |       - |      32 B |
          TupleSameInstance |     131.81 ns |      2.6606 ns |      7.193 ns |     128.32 ns |   0.0050 |       - |       - |      32 B |
          TupleDiffInstance |     132.76 ns |      2.9214 ns |      8.568 ns |     128.33 ns |   0.0050 |       - |       - |      32 B |
     DictionarySameInstance | 210,299.03 ns |  4,195.2211 ns |  3,275.352 ns | 209,249.83 ns | 107.6709 | 97.1094 | 96.4404 |  491330 B |
     DictionaryDiffInstance | 180,633.40 ns |  3,245.0453 ns |  2,709.760 ns | 180,337.20 ns | 109.9121 | 99.2529 | 98.6816 |  491294 B |
