
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |            Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       137.07 ns |      0.5256 ns |      0.4916 ns |      0.0050 |           - |           - |                32 B |
             ObjectInstance |       181.29 ns |      1.3148 ns |      1.2299 ns |      0.0050 |           - |           - |                32 B |
            DefaultInstance |        24.73 ns |      0.0954 ns |      0.0892 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |     7,099.56 ns |     28.2819 ns |     26.4549 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfDiffInstance |   953,538.96 ns |  4,248.1737 ns |  3,547.4174 ns |     63.4766 |     23.4375 |           - |            400031 B |
        ArrayOfSameInstance |   292,145.04 ns |  1,596.4552 ns |  1,493.3252 ns |     12.2070 |           - |           - |             80152 B |
 ArrayOfObjectsDiffInstance | 1,487,153.31 ns |  9,252.1762 ns |  8,654.4914 ns |     62.5000 |     23.4375 |           - |            400034 B |
 ArrayOfObjectsSameInstance |   579,561.80 ns |  5,689.4187 ns |  5,321.8858 ns |     11.7188 |           - |           - |             80152 B |
      Array2dOfDiffInstance |   965,429.44 ns |  6,450.6385 ns |  6,033.9313 ns |     62.5000 |     23.4375 |           - |            403237 B |
      Array2dOfSameInstance |    17,003.67 ns |    113.1787 ns |    105.8674 ns |      0.7629 |           - |           - |              4848 B |
   ArrayRank2OfDiffInstance |     9,506.87 ns |     57.0491 ns |     53.3637 ns |      0.6409 |           - |           - |              4040 B |
   ArrayRank2OfSameInstance |     4,690.66 ns |     22.6669 ns |     18.9279 ns |      0.1373 |           - |           - |               872 B |
   ArrayRank3OfDiffInstance |   181,877.03 ns |  1,109.6456 ns |  1,037.9632 ns |      6.3477 |      0.4883 |           - |             40169 B |
   ArrayRank3OfSameInstance |   120,597.83 ns |    700.1935 ns |    654.9615 ns |      1.2207 |           - |           - |              8203 B |
         ListOfDiffInstance |   970,414.17 ns |  5,420.7396 ns |  5,070.5632 ns |     63.4766 |     23.4375 |           - |            400071 B |
         ListOfSameInstance |   312,188.76 ns |  1,737.8341 ns |  1,625.5711 ns |     12.2070 |      1.9531 |           - |             80152 B |
  ListOfObjectsDiffInstance | 1,240,153.32 ns |  5,373.5035 ns |  4,763.4709 ns |     62.5000 |     23.4375 |           - |            400076 B |
  ListOfObjectsSameInstance |   697,701.00 ns |  4,964.2144 ns |  4,400.6468 ns |     11.7188 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |       237.09 ns |      1.3127 ns |      1.2279 ns |      0.0100 |           - |           - |                64 B |
           KeyValuePairDiff |       258.27 ns |      2.7075 ns |      2.5326 ns |      0.0148 |           - |           - |                96 B |
          TupleSameInstance |       283.10 ns |      1.5581 ns |      1.4575 ns |      0.0100 |           - |           - |                64 B |
          TupleDiffInstance |       274.68 ns |      0.8818 ns |      0.6884 ns |      0.0148 |           - |           - |                96 B |
     DictionarySameInstance | 1,963,962.29 ns | 13,932.9280 ns | 13,032.8695 ns |    121.0938 |    113.2813 |     66.4063 |            603385 B |
     DictionaryDiffInstance | 2,943,248.33 ns | 21,506.6271 ns | 20,117.3123 ns |    167.9688 |    125.0000 |     62.5000 |            923349 B |
