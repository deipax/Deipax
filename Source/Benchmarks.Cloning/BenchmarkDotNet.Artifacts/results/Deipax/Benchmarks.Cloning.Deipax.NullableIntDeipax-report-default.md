
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |        StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|--------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |     158.99 ns |     14.3780 ns |     42.394 ns |     136.31 ns |  0.0036 |       - |       - |      24 B |
            DefaultInstance |      30.78 ns |      0.8030 ns |      2.368 ns |      30.67 ns |       - |       - |       - |       0 B |
     ArrayOfDefaultInstance |   8,429.44 ns |    177.8590 ns |    342.674 ns |   8,282.59 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfDiffInstance |   8,231.54 ns |    207.5720 ns |    605.497 ns |   8,295.50 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfSameInstance |   8,769.02 ns |    247.1938 ns |    728.857 ns |   8,723.61 ns | 12.6495 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance | 311,359.49 ns |  6,689.0488 ns | 19,722.811 ns | 306,470.75 ns | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 337,641.57 ns |  7,348.3580 ns | 21,666.799 ns | 339,210.36 ns | 12.2070 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  19,698.63 ns |    402.1718 ns |  1,001.547 ns |  19,563.01 ns | 13.2141 |  2.6245 |       - |   83224 B |
      Array2dOfSameInstance |   4,492.09 ns |     89.8378 ns |    263.479 ns |   4,440.62 ns |  0.2594 |       - |       - |    1648 B |
   ArrayRank2OfDiffInstance |     350.69 ns |      7.8061 ns |     22.894 ns |     349.64 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank2OfSameInstance |     331.70 ns |      7.3532 ns |     21.566 ns |     332.98 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank3OfDiffInstance |   1,372.24 ns |     28.9965 ns |     84.584 ns |   1,360.94 ns |  1.2836 |       - |       - |    8088 B |
   ArrayRank3OfSameInstance |   1,333.33 ns |     28.2825 ns |     81.602 ns |   1,309.06 ns |  1.2836 |       - |       - |    8088 B |
         ListOfDiffInstance |   9,432.71 ns |    264.1037 ns |    774.570 ns |   9,458.73 ns | 12.6495 |  2.1057 |       - |   80064 B |
         ListOfSameInstance |   8,983.18 ns |    257.3847 ns |    754.865 ns |   8,838.42 ns | 12.6495 |  2.1057 |       - |   80064 B |
  ListOfObjectsDiffInstance | 355,110.66 ns |  8,327.7355 ns | 24,160.271 ns | 351,057.50 ns | 12.2070 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 345,400.16 ns |  7,881.1585 ns | 22,485.389 ns | 344,974.19 ns | 12.2070 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      52.41 ns |      1.2793 ns |      3.772 ns |      51.62 ns |  0.0050 |       - |       - |      32 B |
           KeyValuePairDiff |      55.61 ns |      1.1514 ns |      3.152 ns |      55.21 ns |  0.0051 |       - |       - |      32 B |
          TupleSameInstance |     107.63 ns |      6.1409 ns |      6.306 ns |     104.02 ns |  0.0050 |       - |       - |      32 B |
          TupleDiffInstance |     121.04 ns |      3.4739 ns |     10.188 ns |     119.74 ns |  0.0050 |       - |       - |      32 B |
     DictionarySameInstance | 778,847.29 ns | 15,851.6048 ns | 43,125.460 ns | 780,226.49 ns | 76.1719 | 76.1719 | 76.1719 |  283040 B |
     DictionaryDiffInstance | 773,038.49 ns | 20,378.3722 ns | 59,766.238 ns | 775,222.98 ns | 76.1719 | 76.1719 | 76.1719 |  283040 B |
