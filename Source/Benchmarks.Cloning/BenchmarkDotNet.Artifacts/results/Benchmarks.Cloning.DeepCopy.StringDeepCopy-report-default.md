
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |         StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|---------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |      38.37 ns |      1.0880 ns |      3.1391 ns |      37.84 ns |       - |       - |       - |       0 B |
            DefaultInstance |      28.93 ns |      0.4580 ns |      0.3576 ns |      28.82 ns |       - |       - |       - |       0 B |
     ArrayOfDefaultInstance |   9,216.10 ns |    288.1926 ns |    845.2191 ns |   9,024.84 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfDiffInstance |   9,352.54 ns |    305.7896 ns |    901.6277 ns |   9,274.86 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfSameInstance |   9,855.49 ns |    329.3387 ns |    971.0627 ns |   9,871.44 ns | 12.6495 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance | 865,310.96 ns | 17,185.7202 ns | 41,832.4182 ns | 869,534.94 ns | 11.7188 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 288,698.93 ns |  6,044.6276 ns | 17,822.7207 ns | 289,104.73 ns | 12.2070 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  22,769.34 ns |    491.7743 ns |  1,450.0077 ns |  22,613.67 ns | 13.2141 |  2.5940 |       - |   83224 B |
      Array2dOfSameInstance |   4,403.49 ns |    108.0496 ns |    318.5867 ns |   4,391.70 ns |  0.2594 |       - |       - |    1648 B |
   ArrayRank2OfDiffInstance |     358.95 ns |      7.1907 ns |     20.5156 ns |     356.41 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank2OfSameInstance |     362.86 ns |      8.0350 ns |     23.6913 ns |     360.50 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank3OfDiffInstance | 197,682.56 ns |  3,947.6328 ns |  8,665.1497 ns | 196,341.03 ns |  1.2207 |       - |       - |    8168 B |
   ArrayRank3OfSameInstance | 103,962.33 ns |  2,229.5768 ns |  6,538.9629 ns | 103,063.27 ns |  1.2207 |       - |       - |    8168 B |
         ListOfDiffInstance |   9,349.47 ns |    213.1826 ns |    621.8637 ns |   8,913.45 ns | 12.6495 |  2.1057 |       - |   80064 B |
         ListOfSameInstance |  10,158.88 ns |    275.5827 ns |    808.2364 ns |  10,183.43 ns | 12.6495 |  2.1057 |       - |   80064 B |
  ListOfObjectsDiffInstance | 893,786.18 ns | 17,689.6790 ns | 51,320.9663 ns | 892,256.73 ns | 11.7188 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 285,406.28 ns |  7,224.3850 ns | 21,073.8700 ns | 275,393.00 ns | 12.2070 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      73.39 ns |      2.2607 ns |      6.6657 ns |      72.73 ns |  0.0050 |       - |       - |      32 B |
           KeyValuePairDiff |      71.33 ns |      1.6453 ns |      4.8254 ns |      69.00 ns |  0.0050 |       - |       - |      32 B |
          TupleSameInstance |     130.54 ns |      3.1163 ns |      9.0904 ns |     129.82 ns |  0.0050 |       - |       - |      32 B |
          TupleDiffInstance |     124.39 ns |      2.5290 ns |      6.7066 ns |     120.40 ns |  0.0050 |       - |       - |      32 B |
     DictionarySameInstance | 192,265.06 ns |  4,649.1892 ns | 13,708.2392 ns | 190,899.30 ns | 76.9043 | 76.9043 | 76.9043 |  283064 B |
     DictionaryDiffInstance | 177,355.66 ns |  3,542.2140 ns |  7,471.7316 ns | 176,018.85 ns | 76.9043 | 76.9043 | 76.9043 |  283064 B |
