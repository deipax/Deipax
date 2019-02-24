
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      98.48 ns |     0.0561 ns |     0.0497 ns |      0.0037 |           - |           - |                24 B |
             ObjectInstance |      50.90 ns |     0.0639 ns |     0.0566 ns |           - |           - |           - |                   - |
            DefaultInstance |      16.85 ns |     0.0142 ns |     0.0132 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   4,824.60 ns |    25.8700 ns |    22.9331 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfDiffInstance |   4,724.63 ns |     4.8917 ns |     4.5757 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfSameInstance |   4,971.41 ns |     8.7519 ns |     8.1866 ns |     12.6572 |           - |           - |             80024 B |
 ArrayOfObjectsDiffInstance | 609,105.15 ns | 1,055.6767 ns |   987.4806 ns |     11.7188 |           - |           - |             80024 B |
 ArrayOfObjectsSameInstance | 609,671.42 ns |   433.1044 ns |   405.1261 ns |     11.7188 |           - |           - |             80024 B |
      Array2dOfDiffInstance |  14,672.35 ns |    12.3568 ns |    10.3184 ns |     13.2141 |      2.5024 |           - |             83224 B |
      Array2dOfSameInstance |   2,638.53 ns |     5.6698 ns |     5.3036 ns |      0.2594 |           - |           - |              1648 B |
   ArrayRank2OfDiffInstance |     220.22 ns |     0.2048 ns |     0.1816 ns |      0.1333 |           - |           - |               840 B |
   ArrayRank2OfSameInstance |     223.43 ns |     0.1478 ns |     0.1383 ns |      0.1333 |           - |           - |               840 B |
   ArrayRank3OfDiffInstance | 250,046.44 ns |   144.4589 ns |   135.1269 ns |      8.7891 |           - |           - |             56168 B |
   ArrayRank3OfSameInstance | 249,985.90 ns |   267.8811 ns |   250.5761 ns |      8.7891 |           - |           - |             56168 B |
         ListOfDiffInstance |   5,352.19 ns |     6.5741 ns |     6.1494 ns |     12.6572 |      2.1057 |           - |             80064 B |
         ListOfSameInstance |   5,189.12 ns |     5.0088 ns |     4.1826 ns |     12.6572 |      2.1057 |           - |             80064 B |
  ListOfObjectsDiffInstance | 619,806.89 ns |   239.5395 ns |   224.0654 ns |     11.7188 |      1.9531 |           - |             80064 B |
  ListOfObjectsSameInstance | 627,050.19 ns | 1,463.2203 ns | 1,368.6972 ns |     11.7188 |      1.9531 |           - |             80064 B |
           KeyValuePairSame |      28.52 ns |     0.0450 ns |     0.0421 ns |           - |           - |           - |                   - |
           KeyValuePairDiff |      31.18 ns |     0.0253 ns |     0.0237 ns |           - |           - |           - |                   - |
          TupleSameInstance |      82.60 ns |     0.0538 ns |     0.0504 ns |      0.0050 |           - |           - |                32 B |
          TupleDiffInstance |      87.93 ns |     0.0598 ns |     0.0559 ns |      0.0050 |           - |           - |                32 B |
     DictionarySameInstance |  56,374.91 ns | 1,081.9005 ns | 1,202.5295 ns |     94.4824 |     84.4727 |     83.1299 |            491282 B |
     DictionaryDiffInstance |  58,346.65 ns |   531.8117 ns |   497.4570 ns |     95.9473 |     85.5103 |     84.5947 |            491274 B |
