
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      38.13 ns |     0.1756 ns |     0.1642 ns |      0.0038 |           - |           - |                24 B |
             ObjectInstance |      47.78 ns |     0.1724 ns |     0.1613 ns |           - |           - |           - |                   - |
            DefaultInstance |      34.45 ns |     0.2055 ns |     0.1716 ns |      0.0038 |           - |           - |                24 B |
     ArrayOfDefaultInstance |   2,549.61 ns |    13.2917 ns |    12.4330 ns |      6.3286 |           - |           - |             40048 B |
        ArrayOfDiffInstance |   2,649.94 ns |     7.0631 ns |     5.8980 ns |      6.3286 |           - |           - |             40048 B |
        ArrayOfSameInstance |   2,678.48 ns |    30.8371 ns |    27.3363 ns |      6.3286 |           - |           - |             40048 B |
 ArrayOfObjectsDiffInstance | 250,615.17 ns |   703.4353 ns |   657.9938 ns |     12.2070 |           - |           - |             80048 B |
 ArrayOfObjectsSameInstance | 247,338.45 ns | 1,180.1569 ns | 1,046.1783 ns |     12.2070 |           - |           - |             80048 B |
      Array2dOfDiffInstance |  13,797.73 ns |    34.2217 ns |    28.5767 ns |      6.8665 |      0.7477 |           - |             43226 B |
      Array2dOfSameInstance |   6,138.80 ns |    44.4927 ns |    41.6185 ns |      0.1907 |           - |           - |              1248 B |
   ArrayRank2OfDiffInstance |     422.30 ns |     1.7308 ns |     1.5343 ns |      0.0696 |           - |           - |               440 B |
   ArrayRank2OfSameInstance |     408.27 ns |     7.9184 ns |     8.8012 ns |      0.0696 |           - |           - |               440 B |
   ArrayRank3OfDiffInstance |     877.23 ns |     6.4164 ns |     6.0019 ns |      0.6495 |           - |           - |              4088 B |
   ArrayRank3OfSameInstance |     869.95 ns |    10.5662 ns |     9.3666 ns |      0.6495 |           - |           - |              4088 B |
         ListOfDiffInstance |   2,556.11 ns |    13.5274 ns |    11.9917 ns |      6.3667 |      0.6332 |           - |             40100 B |
         ListOfSameInstance |   2,615.08 ns |    22.7809 ns |    21.3092 ns |      6.3667 |      0.6332 |           - |             40100 B |
  ListOfObjectsDiffInstance | 254,474.46 ns | 1,728.4445 ns | 1,616.7880 ns |     12.2070 |      1.9531 |           - |             80152 B |
  ListOfObjectsSameInstance | 256,470.65 ns | 1,705.8374 ns | 1,512.1804 ns |     12.2070 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |      29.37 ns |     0.1709 ns |     0.1598 ns |      0.0038 |           - |           - |                24 B |
           KeyValuePairDiff |      28.76 ns |     0.1765 ns |     0.1651 ns |      0.0038 |           - |           - |                24 B |
          TupleSameInstance |      96.31 ns |     0.4041 ns |     0.3780 ns |      0.0037 |           - |           - |                24 B |
          TupleDiffInstance |      90.97 ns |     0.3075 ns |     0.2877 ns |      0.0037 |           - |           - |                24 B |
     DictionarySameInstance | 298,840.89 ns | 1,668.3455 ns | 1,560.5714 ns |     49.8047 |     49.8047 |     49.8047 |            202548 B |
     DictionaryDiffInstance | 296,233.87 ns |   673.9707 ns |   562.7961 ns |     49.8047 |     49.8047 |     49.8047 |            202548 B |
