
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |        StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|--------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |      40.84 ns |      0.8132 ns |      1.527 ns |      40.70 ns |       - |       - |       - |       0 B |
            DefaultInstance |      33.52 ns |      0.7142 ns |      1.979 ns |      33.67 ns |       - |       - |       - |       0 B |
     ArrayOfDefaultInstance |   8,475.53 ns |    167.9678 ns |    408.857 ns |   8,246.67 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfDiffInstance |   9,303.78 ns |    244.7800 ns |    717.897 ns |   9,207.41 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfSameInstance |   8,584.30 ns |    177.2633 ns |    505.742 ns |   8,257.42 ns | 12.6495 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance | 310,218.16 ns |  6,124.1257 ns | 14,193.592 ns | 306,612.53 ns | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 313,252.91 ns |  6,245.8152 ns | 18,120.242 ns | 310,214.15 ns | 12.2070 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  18,612.59 ns |    426.4576 ns |  1,257.420 ns |  18,075.32 ns | 13.2141 |  2.6245 |       - |   83224 B |
      Array2dOfSameInstance |   4,669.72 ns |     96.9875 ns |    285.970 ns |   4,675.42 ns |  0.2594 |       - |       - |    1648 B |
   ArrayRank2OfDiffInstance |     322.49 ns |      5.2985 ns |      4.137 ns |     321.14 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank2OfSameInstance |     358.60 ns |      7.1555 ns |     19.345 ns |     358.39 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank3OfDiffInstance |   1,291.99 ns |     25.7107 ns |     51.937 ns |   1,265.01 ns |  1.2836 |       - |       - |    8088 B |
   ArrayRank3OfSameInstance |   1,398.09 ns |     34.4948 ns |    101.709 ns |   1,404.94 ns |  1.2836 |       - |       - |    8088 B |
         ListOfDiffInstance |   8,799.54 ns |     17.9297 ns |     15.894 ns |   8,798.86 ns | 12.6495 |  2.1057 |       - |   80064 B |
         ListOfSameInstance |   9,963.90 ns |    283.8663 ns |    836.986 ns |   9,904.47 ns | 12.6495 |  2.1057 |       - |   80064 B |
  ListOfObjectsDiffInstance | 398,296.40 ns |  8,358.8538 ns | 24,646.269 ns | 399,438.06 ns | 12.2070 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 342,148.54 ns |  8,129.6492 ns | 23,842.854 ns | 341,269.59 ns | 12.2070 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      72.00 ns |      1.7897 ns |      5.277 ns |      71.46 ns |  0.0050 |       - |       - |      32 B |
           KeyValuePairDiff |      75.76 ns |      1.8520 ns |      5.432 ns |      74.99 ns |  0.0050 |       - |       - |      32 B |
          TupleSameInstance |     113.89 ns |      2.4858 ns |      7.291 ns |     112.30 ns |  0.0050 |       - |       - |      32 B |
          TupleDiffInstance |     118.54 ns |      3.3538 ns |      9.889 ns |     117.93 ns |  0.0050 |       - |       - |      32 B |
     DictionarySameInstance | 611,763.43 ns | 13,835.4761 ns | 40,358.733 ns | 603,416.46 ns | 76.1719 | 76.1719 | 76.1719 |  283040 B |
     DictionaryDiffInstance | 629,536.27 ns | 18,103.0107 ns | 53,377.136 ns | 618,736.52 ns | 76.1719 | 76.1719 | 76.1719 |  283040 B |
