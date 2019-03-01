
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      30.38 ns |     0.1433 ns |     0.1340 ns |      0.0051 |           - |           - |                32 B |
             ObjectInstance |      49.06 ns |     0.2473 ns |     0.2313 ns |           - |           - |           - |                   - |
            DefaultInstance |      31.14 ns |     0.1821 ns |     0.1703 ns |      0.0051 |           - |           - |                32 B |
     ArrayOfDefaultInstance |  16,971.29 ns |   262.5665 ns |   232.7584 ns |     28.5645 |     28.5645 |     28.5645 |            160024 B |
        ArrayOfDiffInstance |  16,803.90 ns |   254.6063 ns |   238.1589 ns |     28.6865 |     28.6865 |     28.6865 |            160024 B |
        ArrayOfSameInstance |  17,254.05 ns |   334.5887 ns |   328.6108 ns |     29.3884 |     29.3884 |     29.3884 |            160024 B |
 ArrayOfObjectsDiffInstance | 564,139.34 ns | 2,517.9121 ns | 2,355.2566 ns |     11.7188 |           - |           - |             80048 B |
 ArrayOfObjectsSameInstance | 557,729.07 ns | 3,642.1039 ns | 3,406.8263 ns |     11.7188 |           - |           - |             80048 B |
      Array2dOfDiffInstance |  24,499.05 ns |    75.8385 ns |    70.9394 ns |     25.9399 |      6.5002 |           - |            163245 B |
      Array2dOfSameInstance |   3,444.36 ns |    18.0826 ns |    16.0297 ns |      0.3853 |           - |           - |              2448 B |
   ArrayRank2OfDiffInstance |     424.29 ns |     3.9227 ns |     3.6693 ns |      0.2604 |           - |           - |              1640 B |
   ArrayRank2OfSameInstance |     402.41 ns |     3.9851 ns |     3.7277 ns |      0.2604 |           - |           - |              1640 B |
   ArrayRank3OfDiffInstance | 260,497.69 ns | 1,628.5487 ns | 1,523.3454 ns |     12.6953 |      1.4648 |           - |             80171 B |
   ArrayRank3OfSameInstance | 260,305.58 ns | 1,898.6233 ns | 1,775.9734 ns |     12.6953 |      1.4648 |           - |             80171 B |
         ListOfDiffInstance |  17,591.26 ns |   340.0072 ns |   391.5528 ns |     28.2288 |     28.1982 |     28.1982 |            160299 B |
         ListOfSameInstance |  16,913.56 ns |   232.6948 ns |   206.2779 ns |     28.6865 |     28.6560 |     28.6560 |            160307 B |
  ListOfObjectsDiffInstance | 551,565.30 ns | 3,497.7754 ns | 3,271.8213 ns |     11.7188 |      1.9531 |           - |             80152 B |
  ListOfObjectsSameInstance | 553,261.48 ns | 2,934.6005 ns | 2,745.0272 ns |     11.7188 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |      36.02 ns |     0.1613 ns |     0.1430 ns |      0.0076 |           - |           - |                48 B |
           KeyValuePairDiff |      37.78 ns |     0.1583 ns |     0.1480 ns |      0.0076 |           - |           - |                48 B |
          TupleSameInstance |     108.89 ns |     0.5101 ns |     0.4771 ns |      0.0075 |           - |           - |                48 B |
          TupleDiffInstance |     102.29 ns |     0.5545 ns |     0.5187 ns |      0.0075 |           - |           - |                48 B |
     DictionarySameInstance |  85,399.31 ns | 1,635.1724 ns | 1,749.6162 ns |    105.8350 |     95.4590 |     94.3604 |            773512 B |
     DictionaryDiffInstance |  87,223.86 ns | 1,679.0569 ns | 1,866.2673 ns |    106.5674 |     96.0693 |     95.0928 |            773489 B |
