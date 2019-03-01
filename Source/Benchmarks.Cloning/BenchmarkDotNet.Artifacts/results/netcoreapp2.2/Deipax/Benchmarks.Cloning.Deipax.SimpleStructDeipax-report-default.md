
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      31.39 ns |     0.0728 ns |     0.0681 ns |           - |           - |           - |                   - |
             ObjectInstance |      47.97 ns |     0.0296 ns |     0.0247 ns |           - |           - |           - |                   - |
            DefaultInstance |      34.56 ns |     0.0283 ns |     0.0265 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |  20,214.47 ns |   161.3633 ns |   150.9393 ns |     35.9192 |     35.9192 |     35.9192 |            160024 B |
        ArrayOfDiffInstance |  19,520.03 ns |   109.9435 ns |    97.4621 ns |     36.0107 |     36.0107 |     36.0107 |            160024 B |
        ArrayOfSameInstance |  21,679.45 ns |   328.6747 ns |   291.3615 ns |     35.8276 |     35.8276 |     35.8276 |            160024 B |
 ArrayOfObjectsDiffInstance | 254,298.97 ns |   158.9003 ns |   140.8610 ns |     12.2070 |           - |           - |             80024 B |
 ArrayOfObjectsSameInstance | 255,107.54 ns |   255.4584 ns |   238.9559 ns |     12.2070 |           - |           - |             80024 B |
      Array2dOfDiffInstance |  17,926.82 ns |    43.5284 ns |    40.7165 ns |     25.9399 |      6.5002 |           - |            163224 B |
      Array2dOfSameInstance |   3,194.69 ns |     3.6368 ns |     3.0369 ns |      0.3853 |           - |           - |              2448 B |
   ArrayRank2OfDiffInstance |     258.89 ns |     0.2019 ns |     0.1790 ns |      0.2604 |           - |           - |              1640 B |
   ArrayRank2OfSameInstance |     257.95 ns |     0.2804 ns |     0.2623 ns |      0.2604 |           - |           - |              1640 B |
   ArrayRank3OfDiffInstance |   1,349.62 ns |     1.8781 ns |     1.7568 ns |      2.5558 |           - |           - |             16088 B |
   ArrayRank3OfSameInstance |   1,329.44 ns |     1.5459 ns |     1.4461 ns |      2.5558 |           - |           - |             16088 B |
         ListOfDiffInstance |  21,988.93 ns |   427.1867 ns |   474.8169 ns |     36.7737 |     36.7432 |     36.7432 |            160354 B |
         ListOfSameInstance |  20,197.15 ns |   149.6891 ns |   140.0193 ns |     36.7126 |     36.6516 |     36.6516 |            160353 B |
  ListOfObjectsDiffInstance | 263,648.99 ns |   354.9372 ns |   332.0085 ns |     12.2070 |      1.9531 |           - |             80064 B |
  ListOfObjectsSameInstance | 278,202.61 ns |   225.6293 ns |   211.0538 ns |     12.2070 |      1.9531 |           - |             80064 B |
           KeyValuePairSame |      50.17 ns |     0.0568 ns |     0.0503 ns |           - |           - |           - |                   - |
           KeyValuePairDiff |      44.09 ns |     0.0357 ns |     0.0298 ns |           - |           - |           - |                   - |
          TupleSameInstance |      76.58 ns |     0.1271 ns |     0.1189 ns |      0.0075 |           - |           - |                48 B |
          TupleDiffInstance |      77.32 ns |     0.0762 ns |     0.0712 ns |      0.0075 |           - |           - |                48 B |
     DictionarySameInstance | 660,778.31 ns | 2,217.9291 ns | 1,966.1364 ns |    168.9453 |    120.1172 |    112.3047 |            764797 B |
     DictionaryDiffInstance | 656,606.34 ns | 1,618.2564 ns | 1,513.7180 ns |    168.9453 |    120.1172 |    112.3047 |            764772 B |
