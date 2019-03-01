
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |     116.97 ns |     0.6012 ns |     0.5624 ns |      0.0036 |           - |           - |                24 B |
             ObjectInstance |      47.89 ns |     0.1434 ns |     0.1271 ns |           - |           - |           - |                   - |
            DefaultInstance |      20.01 ns |     0.1141 ns |     0.1067 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   4,974.15 ns |    33.2442 ns |    31.0967 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfDiffInstance |   4,846.11 ns |    32.0507 ns |    29.9803 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfSameInstance |   4,759.31 ns |    33.2394 ns |    31.0922 ns |     12.6572 |           - |           - |             80048 B |
 ArrayOfObjectsDiffInstance | 552,723.92 ns | 3,829.0703 ns | 3,581.7147 ns |     11.7188 |           - |           - |             80048 B |
 ArrayOfObjectsSameInstance | 550,846.54 ns | 4,213.7057 ns | 3,941.5030 ns |     11.7188 |           - |           - |             80048 B |
      Array2dOfDiffInstance |  23,749.77 ns |   164.8641 ns |   154.2139 ns |     13.2141 |      2.6245 |           - |             83228 B |
      Array2dOfSameInstance |   3,502.47 ns |    15.1583 ns |    14.1791 ns |      0.2594 |           - |           - |              1648 B |
   ArrayRank2OfDiffInstance |     415.25 ns |     4.3901 ns |     4.1065 ns |      0.1330 |           - |           - |               840 B |
   ArrayRank2OfSameInstance |     424.97 ns |     5.8846 ns |     5.5044 ns |      0.1330 |           - |           - |               840 B |
   ArrayRank3OfDiffInstance | 272,745.04 ns | 2,354.7194 ns | 2,202.6060 ns |      8.7891 |           - |           - |             56172 B |
   ArrayRank3OfSameInstance | 272,623.89 ns | 1,483.9163 ns | 1,315.4531 ns |      8.7891 |           - |           - |             56172 B |
         ListOfDiffInstance |   5,227.06 ns |    24.9929 ns |    23.3784 ns |     12.6572 |      2.1057 |           - |             80152 B |
         ListOfSameInstance |   5,459.57 ns |   106.7629 ns |   109.6377 ns |     12.6572 |      2.1057 |           - |             80152 B |
  ListOfObjectsDiffInstance | 561,798.67 ns | 3,884.7406 ns | 3,633.7888 ns |     11.7188 |      1.9531 |           - |             80152 B |
  ListOfObjectsSameInstance | 562,891.85 ns | 2,496.2041 ns | 2,334.9508 ns |     11.7188 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |      34.64 ns |     0.1758 ns |     0.1644 ns |      0.0051 |           - |           - |                32 B |
           KeyValuePairDiff |      34.42 ns |     0.2079 ns |     0.1945 ns |      0.0051 |           - |           - |                32 B |
          TupleSameInstance |     117.88 ns |     0.5393 ns |     0.4781 ns |      0.0050 |           - |           - |                32 B |
          TupleDiffInstance |     113.68 ns |     0.4691 ns |     0.4388 ns |      0.0050 |           - |           - |                32 B |
     DictionarySameInstance |  52,092.29 ns |   466.6591 ns |   436.5132 ns |     81.4819 |     71.6553 |     70.1294 |            492697 B |
     DictionaryDiffInstance |  52,155.88 ns |   737.6237 ns |   653.8842 ns |     82.0313 |     72.3267 |     70.6787 |            492706 B |
