
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |            Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       106.88 ns |      1.0125 ns |      0.9471 ns |      0.0101 |           - |           - |                64 B |
             ObjectInstance |       148.05 ns |      1.4288 ns |      1.3365 ns |      0.0100 |           - |           - |                64 B |
            DefaultInstance |        22.72 ns |      0.0877 ns |      0.0777 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |     7,089.41 ns |     37.6963 ns |     35.2611 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfDiffInstance |   870,291.91 ns |  4,482.1937 ns |  4,192.6468 ns |    114.2578 |     56.6406 |           - |            720034 B |
        ArrayOfSameInstance |   307,741.90 ns |  2,108.4009 ns |  1,972.1995 ns |     12.2070 |           - |           - |             80152 B |
 ArrayOfObjectsDiffInstance |   938,307.97 ns |  4,720.5823 ns |  4,415.6356 ns |    114.2578 |     56.6406 |           - |            720031 B |
 ArrayOfObjectsSameInstance |   796,190.57 ns |  4,041.7130 ns |  3,780.6208 ns |     11.7188 |           - |           - |             80152 B |
      Array2dOfDiffInstance |   694,703.25 ns |  3,500.4451 ns |  3,274.3186 ns |    114.2578 |     44.9219 |           - |            723233 B |
      Array2dOfSameInstance |    14,102.90 ns |    111.4717 ns |     98.8167 ns |      1.2665 |      0.0305 |           - |              8048 B |
   ArrayRank2OfDiffInstance |     6,622.11 ns |     36.2881 ns |     32.1685 ns |      1.1444 |      0.0229 |           - |              7240 B |
   ArrayRank2OfSameInstance |     3,722.58 ns |     25.2015 ns |     23.5735 ns |      0.1411 |           - |           - |               904 B |
   ArrayRank3OfDiffInstance |   149,502.37 ns |    795.6598 ns |    744.2607 ns |     11.2305 |      1.7090 |           - |             72169 B |
   ArrayRank3OfSameInstance |   129,421.63 ns |    874.4177 ns |    817.9309 ns |      1.2207 |           - |           - |              8236 B |
         ListOfDiffInstance |   686,123.92 ns |  3,668.7444 ns |  3,431.7458 ns |    114.2578 |     56.6406 |           - |            720069 B |
         ListOfSameInstance |   318,522.54 ns |  2,633.0101 ns |  2,462.9193 ns |     12.2070 |      1.9531 |           - |             80152 B |
  ListOfObjectsDiffInstance |   954,780.00 ns |  6,631.5921 ns |  5,537.6798 ns |    114.2578 |     56.6406 |           - |            720073 B |
  ListOfObjectsSameInstance |   556,001.63 ns |  4,254.6330 ns |  3,979.7864 ns |     11.7188 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |       177.88 ns |      0.9862 ns |      0.9225 ns |      0.0150 |           - |           - |                96 B |
           KeyValuePairDiff |       209.67 ns |      0.8682 ns |      0.8121 ns |      0.0253 |           - |           - |               160 B |
          TupleSameInstance |       193.51 ns |      1.0610 ns |      0.9925 ns |      0.0150 |           - |           - |                96 B |
          TupleDiffInstance |       218.10 ns |      2.2115 ns |      2.0686 ns |      0.0253 |           - |           - |               160 B |
     DictionarySameInstance | 2,098,179.13 ns |  6,302.5252 ns |  4,920.5971 ns |    167.9688 |    128.9063 |     62.5000 |            923361 B |
     DictionaryDiffInstance | 3,361,245.49 ns | 39,457.7894 ns | 36,908.8406 ns |    265.6250 |    183.5938 |     62.5000 |           1563349 B |
