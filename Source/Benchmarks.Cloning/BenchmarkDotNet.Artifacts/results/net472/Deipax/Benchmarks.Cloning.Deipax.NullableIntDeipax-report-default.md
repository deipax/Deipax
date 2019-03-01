
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      89.24 ns |     0.7071 ns |     0.6614 ns |      0.0037 |           - |           - |                24 B |
             ObjectInstance |      43.66 ns |     0.2989 ns |     0.2796 ns |           - |           - |           - |                   - |
            DefaultInstance |      22.19 ns |     0.1071 ns |     0.1002 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   4,893.44 ns |    26.0177 ns |    24.3369 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfDiffInstance |   4,881.38 ns |    20.1975 ns |    17.9045 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfSameInstance |   4,865.17 ns |    27.5899 ns |    25.8076 ns |     12.6572 |           - |           - |             80048 B |
 ArrayOfObjectsDiffInstance | 246,822.00 ns | 2,526.0274 ns | 2,362.8476 ns |     12.2070 |           - |           - |             80048 B |
 ArrayOfObjectsSameInstance | 246,687.76 ns | 1,371.0351 ns | 1,282.4671 ns |     12.2070 |           - |           - |             80048 B |
      Array2dOfDiffInstance |  21,832.26 ns |   108.9035 ns |   101.8684 ns |     13.2141 |      2.5024 |           - |             83228 B |
      Array2dOfSameInstance |  11,222.58 ns |    32.7385 ns |    29.0219 ns |      0.2594 |           - |           - |              1648 B |
   ArrayRank2OfDiffInstance |     409.63 ns |     2.0934 ns |     1.9582 ns |      0.1330 |           - |           - |               840 B |
   ArrayRank2OfSameInstance |     413.64 ns |     2.5017 ns |     2.3401 ns |      0.1330 |           - |           - |               840 B |
   ArrayRank3OfDiffInstance |   1,204.00 ns |     5.7999 ns |     5.4252 ns |      1.2836 |           - |           - |              8097 B |
   ArrayRank3OfSameInstance |   1,191.19 ns |     4.6993 ns |     4.1658 ns |      1.2836 |           - |           - |              8097 B |
         ListOfDiffInstance |   5,244.26 ns |    22.8876 ns |    21.4091 ns |     12.6572 |      2.1057 |           - |             80152 B |
         ListOfSameInstance |   5,162.72 ns |    21.5117 ns |    17.9632 ns |     12.6572 |      2.1057 |           - |             80152 B |
  ListOfObjectsDiffInstance | 278,372.11 ns | 2,061.1026 ns | 1,927.9567 ns |     12.2070 |      1.9531 |           - |             80152 B |
  ListOfObjectsSameInstance | 276,877.57 ns | 2,057.9003 ns | 1,824.2750 ns |     12.2070 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |      32.93 ns |     0.1760 ns |     0.1646 ns |      0.0051 |           - |           - |                32 B |
           KeyValuePairDiff |      33.07 ns |     0.2329 ns |     0.2179 ns |      0.0051 |           - |           - |                32 B |
          TupleSameInstance |      87.31 ns |     0.4695 ns |     0.4392 ns |      0.0050 |           - |           - |                32 B |
          TupleDiffInstance |      86.26 ns |     0.3841 ns |     0.3593 ns |      0.0050 |           - |           - |                32 B |
     DictionarySameInstance | 459,827.73 ns | 2,857.5879 ns | 2,672.9895 ns |     75.6836 |     69.3359 |     69.3359 |            283824 B |
     DictionaryDiffInstance | 456,234.93 ns | 2,930.1182 ns | 2,740.8344 ns |     76.1719 |     69.8242 |     69.8242 |            283828 B |
