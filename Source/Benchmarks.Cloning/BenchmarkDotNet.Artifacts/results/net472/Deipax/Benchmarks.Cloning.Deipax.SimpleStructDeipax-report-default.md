
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      31.63 ns |     0.2251 ns |     0.2106 ns |      0.0051 |           - |           - |                32 B |
             ObjectInstance |      47.77 ns |     0.3073 ns |     0.2875 ns |           - |           - |           - |                   - |
            DefaultInstance |      31.00 ns |     0.2203 ns |     0.2060 ns |      0.0051 |           - |           - |                32 B |
     ArrayOfDefaultInstance |  17,318.94 ns |   320.4868 ns |   299.7836 ns |     28.5645 |     28.5645 |     28.5645 |            160024 B |
        ArrayOfDiffInstance |  17,238.49 ns |   334.4575 ns |   371.7487 ns |     28.4119 |     28.4119 |     28.4119 |            160024 B |
        ArrayOfSameInstance |  17,462.19 ns |   263.1044 ns |   246.1080 ns |     28.1372 |     28.1372 |     28.1372 |            160024 B |
 ArrayOfObjectsDiffInstance | 238,451.34 ns |   934.2044 ns |   873.8554 ns |     12.4512 |           - |           - |             80048 B |
 ArrayOfObjectsSameInstance | 239,055.42 ns | 1,142.4596 ns | 1,068.6574 ns |     12.4512 |           - |           - |             80048 B |
      Array2dOfDiffInstance |  23,527.66 ns |    57.3483 ns |    53.6436 ns |     25.9399 |      7.1106 |           - |            163245 B |
      Array2dOfSameInstance |   8,477.75 ns |    25.5685 ns |    21.3509 ns |      0.3815 |           - |           - |              2448 B |
   ArrayRank2OfDiffInstance |     434.35 ns |     2.2681 ns |     2.1215 ns |      0.2604 |           - |           - |              1640 B |
   ArrayRank2OfSameInstance |     418.18 ns |     3.3544 ns |     3.1377 ns |      0.2604 |           - |           - |              1640 B |
   ArrayRank3OfDiffInstance |   1,552.34 ns |     8.8965 ns |     8.3218 ns |      2.5558 |           - |           - |             16093 B |
   ArrayRank3OfSameInstance |   1,545.01 ns |    13.2608 ns |    12.4042 ns |      2.5558 |           - |           - |             16093 B |
         ListOfDiffInstance |  17,160.08 ns |   310.8778 ns |   290.7953 ns |     28.8391 |     28.8086 |     28.8086 |            160319 B |
         ListOfSameInstance |  17,036.46 ns |   220.2145 ns |   205.9888 ns |     28.3508 |     28.3203 |     28.3203 |            160313 B |
  ListOfObjectsDiffInstance | 257,331.10 ns | 1,989.0643 ns | 1,860.5720 ns |     12.2070 |      1.9531 |           - |             80152 B |
  ListOfObjectsSameInstance | 288,314.34 ns | 2,843.5394 ns | 2,659.8485 ns |     12.2070 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |      47.90 ns |     0.3548 ns |     0.3319 ns |      0.0076 |           - |           - |                48 B |
           KeyValuePairDiff |      53.82 ns |     0.2155 ns |     0.2016 ns |      0.0076 |           - |           - |                48 B |
          TupleSameInstance |      94.10 ns |     0.3586 ns |     0.3355 ns |      0.0075 |           - |           - |                48 B |
          TupleDiffInstance |      91.42 ns |     0.5625 ns |     0.5262 ns |      0.0075 |           - |           - |                48 B |
     DictionarySameInstance | 770,160.76 ns | 6,613.0805 ns | 6,185.8796 ns |    168.9453 |    120.1172 |    112.3047 |            765133 B |
     DictionaryDiffInstance | 760,037.02 ns | 4,702.9607 ns | 4,399.1524 ns |    168.9453 |    120.1172 |    112.3047 |            765180 B |
