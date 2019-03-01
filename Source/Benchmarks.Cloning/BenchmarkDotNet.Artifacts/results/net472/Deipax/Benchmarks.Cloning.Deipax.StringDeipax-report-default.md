
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      35.07 ns |     0.2182 ns |     0.1822 ns |           - |           - |           - |                   - |
             ObjectInstance |      50.04 ns |     0.2919 ns |     0.2731 ns |           - |           - |           - |                   - |
            DefaultInstance |      23.33 ns |     0.1315 ns |     0.1165 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   5,893.31 ns |    75.8747 ns |    67.2609 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfDiffInstance |   5,934.73 ns |    15.7623 ns |    13.1623 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfSameInstance |   5,993.23 ns |    62.9350 ns |    58.8695 ns |     12.6572 |           - |           - |             80048 B |
 ArrayOfObjectsDiffInstance | 236,535.37 ns | 1,396.4069 ns | 1,306.1999 ns |     12.4512 |           - |           - |             80048 B |
 ArrayOfObjectsSameInstance | 236,036.61 ns | 1,084.6096 ns | 1,014.5445 ns |     12.4512 |           - |           - |             80048 B |
      Array2dOfDiffInstance |  17,322.13 ns |   101.4305 ns |    94.8782 ns |     13.2141 |      2.6245 |           - |             83228 B |
      Array2dOfSameInstance |   5,896.19 ns |    35.9974 ns |    33.6720 ns |      0.2594 |           - |           - |              1648 B |
   ArrayRank2OfDiffInstance |     373.27 ns |     4.3733 ns |     3.8768 ns |      0.1330 |           - |           - |               840 B |
   ArrayRank2OfSameInstance |     375.52 ns |     2.5063 ns |     2.3444 ns |      0.1330 |           - |           - |               840 B |
   ArrayRank3OfDiffInstance |   1,375.15 ns |     7.9684 ns |     7.0638 ns |      1.2836 |           - |           - |              8097 B |
   ArrayRank3OfSameInstance |   1,388.92 ns |     7.5335 ns |     7.0469 ns |      1.2836 |           - |           - |              8097 B |
         ListOfDiffInstance |   6,496.53 ns |    24.7594 ns |    23.1600 ns |     12.6572 |      2.1057 |           - |             80152 B |
         ListOfSameInstance |   6,422.13 ns |    22.1116 ns |    19.6013 ns |     12.6572 |      2.1057 |           - |             80152 B |
  ListOfObjectsDiffInstance | 265,067.09 ns | 1,407.8926 ns | 1,316.9436 ns |     12.2070 |      1.9531 |           - |             80152 B |
  ListOfObjectsSameInstance | 267,486.79 ns | 1,382.8975 ns | 1,293.5631 ns |     12.2070 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |      57.28 ns |     0.3044 ns |     0.2847 ns |      0.0050 |           - |           - |                32 B |
           KeyValuePairDiff |      60.70 ns |     0.3926 ns |     0.3480 ns |      0.0050 |           - |           - |                32 B |
          TupleSameInstance |      94.04 ns |     0.5149 ns |     0.4817 ns |      0.0050 |           - |           - |                32 B |
          TupleDiffInstance |      97.67 ns |     0.4758 ns |     0.4218 ns |      0.0050 |           - |           - |                32 B |
     DictionarySameInstance | 368,092.15 ns | 2,179.4976 ns | 1,932.0679 ns |     68.8477 |     62.5000 |     62.5000 |            284246 B |
     DictionaryDiffInstance | 373,406.76 ns | 3,515.8917 ns | 3,288.7672 ns |     68.8477 |     62.5000 |     62.5000 |            284246 B |
