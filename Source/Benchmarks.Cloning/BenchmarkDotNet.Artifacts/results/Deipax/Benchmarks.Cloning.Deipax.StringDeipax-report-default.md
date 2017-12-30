
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |         StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|---------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |      44.76 ns |      0.9206 ns |      2.1152 ns |      44.68 ns |       - |       - |       - |       0 B |
             ObjectInstance |      56.40 ns |      1.1626 ns |      3.2792 ns |      55.39 ns |       - |       - |       - |       0 B |
            DefaultInstance |      33.01 ns |      0.7166 ns |      2.0905 ns |      33.02 ns |       - |       - |       - |       0 B |
     ArrayOfDefaultInstance |   8,017.58 ns |    159.2596 ns |    238.3723 ns |   7,865.29 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfDiffInstance |   8,895.89 ns |    295.0061 ns |    869.8322 ns |   8,844.68 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfSameInstance |   8,810.71 ns |    279.1235 ns |    823.0020 ns |   8,735.07 ns | 12.6495 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance | 306,850.67 ns |  8,144.3524 ns | 12,917.8059 ns | 301,868.53 ns | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 299,566.60 ns |  5,679.5172 ns |  5,312.6234 ns | 296,285.68 ns | 12.2070 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  17,390.99 ns |    347.8452 ns |    928.4693 ns |  17,164.56 ns | 13.2141 |  2.6245 |       - |   83224 B |
      Array2dOfSameInstance |   4,014.41 ns |     98.3764 ns |     82.1487 ns |   3,992.58 ns |  0.2594 |       - |       - |    1648 B |
   ArrayRank2OfDiffInstance |     329.47 ns |      6.7744 ns |     19.9746 ns |     328.25 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank2OfSameInstance |     331.59 ns |      6.6519 ns |     16.3173 ns |     328.81 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank3OfDiffInstance |   1,203.75 ns |     33.8512 ns |     99.8109 ns |   1,184.41 ns |  1.2836 |       - |       - |    8088 B |
   ArrayRank3OfSameInstance |   1,126.85 ns |     36.8998 ns |     32.7107 ns |   1,111.02 ns |  1.2836 |       - |       - |    8088 B |
         ListOfDiffInstance |   8,411.54 ns |    102.5256 ns |     80.0453 ns |   8,394.71 ns | 12.6495 |  2.1057 |       - |   80064 B |
         ListOfSameInstance |   8,478.01 ns |    192.5796 ns |    214.0517 ns |   8,403.11 ns | 12.6495 |  2.1057 |       - |   80064 B |
  ListOfObjectsDiffInstance | 309,662.11 ns |  6,191.5654 ns | 15,871.3492 ns | 305,423.48 ns | 12.2070 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 327,691.29 ns |  6,620.6608 ns | 18,781.7128 ns | 326,385.87 ns | 12.2070 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      69.64 ns |      1.4727 ns |      4.3422 ns |      69.57 ns |  0.0050 |       - |       - |      32 B |
           KeyValuePairDiff |      63.56 ns |      0.8587 ns |      0.7171 ns |      63.42 ns |  0.0050 |       - |       - |      32 B |
          TupleSameInstance |     107.39 ns |      2.1758 ns |      4.2438 ns |     107.51 ns |  0.0050 |       - |       - |      32 B |
          TupleDiffInstance |     106.81 ns |      2.1628 ns |      5.7730 ns |     105.43 ns |  0.0050 |       - |       - |      32 B |
     DictionarySameInstance | 575,483.90 ns | 11,200.9278 ns | 18,403.4455 ns | 564,094.28 ns | 76.1719 | 76.1719 | 76.1719 |  283040 B |
     DictionaryDiffInstance | 649,664.35 ns | 13,764.1306 ns | 39,712.6638 ns | 649,415.49 ns | 76.1719 | 76.1719 | 76.1719 |  283040 B |
