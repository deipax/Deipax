
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |       Error |      StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|------------:|------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      76.14 ns |   0.0528 ns |   0.0440 ns |      0.0037 |           - |           - |                24 B |
             ObjectInstance |      41.21 ns |   0.0163 ns |   0.0152 ns |           - |           - |           - |                   - |
            DefaultInstance |      17.27 ns |   0.0129 ns |   0.0114 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   4,913.19 ns |   8.2982 ns |   7.3561 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfDiffInstance |   4,993.45 ns |   4.4449 ns |   3.7117 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfSameInstance |   4,925.10 ns |   8.2685 ns |   7.7344 ns |     12.6572 |           - |           - |             80024 B |
 ArrayOfObjectsDiffInstance | 255,893.21 ns | 198.6682 ns | 176.1142 ns |     12.2070 |           - |           - |             80024 B |
 ArrayOfObjectsSameInstance | 258,300.46 ns | 344.3873 ns | 322.1401 ns |     12.2070 |           - |           - |             80024 B |
      Array2dOfDiffInstance |  12,435.14 ns |  19.2128 ns |  17.9716 ns |     13.2141 |      2.6245 |           - |             83224 B |
      Array2dOfSameInstance |   3,267.57 ns |   3.2111 ns |   3.0037 ns |      0.2594 |           - |           - |              1648 B |
   ArrayRank2OfDiffInstance |     224.91 ns |   0.1732 ns |   0.1535 ns |      0.1333 |           - |           - |               840 B |
   ArrayRank2OfSameInstance |     221.96 ns |   0.3888 ns |   0.3637 ns |      0.1333 |           - |           - |               840 B |
   ArrayRank3OfDiffInstance |     865.83 ns |   0.9096 ns |   0.8509 ns |      1.2846 |           - |           - |              8088 B |
   ArrayRank3OfSameInstance |     877.49 ns |   1.2799 ns |   1.1972 ns |      1.2846 |           - |           - |              8088 B |
         ListOfDiffInstance |   5,303.29 ns |  30.3080 ns |  28.3501 ns |     12.6572 |      2.1057 |           - |             80064 B |
         ListOfSameInstance |   5,299.87 ns |   6.0016 ns |   5.0116 ns |     12.6572 |      2.1057 |           - |             80064 B |
  ListOfObjectsDiffInstance | 253,971.30 ns | 248.4877 ns | 232.4356 ns |     12.2070 |      1.9531 |           - |             80064 B |
  ListOfObjectsSameInstance | 260,434.09 ns | 313.9348 ns | 278.2950 ns |     12.2070 |      1.9531 |           - |             80064 B |
           KeyValuePairSame |      28.38 ns |   0.0290 ns |   0.0272 ns |           - |           - |           - |                   - |
           KeyValuePairDiff |      33.13 ns |   0.0172 ns |   0.0152 ns |           - |           - |           - |                   - |
          TupleSameInstance |      75.65 ns |   0.0817 ns |   0.0764 ns |      0.0050 |           - |           - |                32 B |
          TupleDiffInstance |      76.27 ns |   0.0491 ns |   0.0459 ns |      0.0050 |           - |           - |                32 B |
     DictionarySameInstance | 546,507.92 ns | 411.1248 ns | 364.4514 ns |     76.1719 |     76.1719 |     76.1719 |            283040 B |
     DictionaryDiffInstance | 536,589.11 ns | 437.9013 ns | 409.6131 ns |     76.1719 |     76.1719 |     76.1719 |            283040 B |
