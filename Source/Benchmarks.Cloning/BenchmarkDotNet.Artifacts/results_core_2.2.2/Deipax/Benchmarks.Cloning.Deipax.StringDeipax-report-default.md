
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      29.77 ns |     0.0192 ns |     0.0161 ns |           - |           - |           - |                   - |
             ObjectInstance |      49.82 ns |     0.0780 ns |     0.0729 ns |           - |           - |           - |                   - |
            DefaultInstance |      23.81 ns |     0.0122 ns |     0.0108 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   5,092.27 ns |    20.8258 ns |    18.4616 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfDiffInstance |   5,376.07 ns |    17.1598 ns |    16.0513 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfSameInstance |   5,291.71 ns |    44.2302 ns |    39.2089 ns |     12.6572 |           - |           - |             80024 B |
 ArrayOfObjectsDiffInstance | 255,708.21 ns |   673.5023 ns |   629.9944 ns |     12.2070 |           - |           - |             80024 B |
 ArrayOfObjectsSameInstance | 258,275.51 ns |   936.7141 ns |   876.2029 ns |     12.2070 |           - |           - |             80024 B |
      Array2dOfDiffInstance |  13,193.40 ns |    41.9266 ns |    35.0106 ns |     13.2141 |      2.6245 |           - |             83224 B |
      Array2dOfSameInstance |   3,176.19 ns |     4.7826 ns |     4.4736 ns |      0.2594 |           - |           - |              1648 B |
   ArrayRank2OfDiffInstance |     235.41 ns |     0.3164 ns |     0.2959 ns |      0.1333 |           - |           - |               840 B |
   ArrayRank2OfSameInstance |     235.09 ns |     0.2456 ns |     0.2177 ns |      0.1333 |           - |           - |               840 B |
   ArrayRank3OfDiffInstance |     944.87 ns |     3.5946 ns |     3.3624 ns |      1.2836 |           - |           - |              8088 B |
   ArrayRank3OfSameInstance |     949.33 ns |     3.3322 ns |     2.9539 ns |      1.2836 |           - |           - |              8088 B |
         ListOfDiffInstance |   5,955.53 ns |    30.0690 ns |    28.1266 ns |     12.6572 |      2.1057 |           - |             80064 B |
         ListOfSameInstance |   5,764.22 ns |     5.6889 ns |     5.3214 ns |     12.6572 |      2.1057 |           - |             80064 B |
  ListOfObjectsDiffInstance | 258,264.63 ns |   281.4038 ns |   249.4572 ns |     12.2070 |      1.9531 |           - |             80064 B |
  ListOfObjectsSameInstance | 256,344.32 ns |   242.6738 ns |   202.6436 ns |     12.2070 |      1.9531 |           - |             80064 B |
           KeyValuePairSame |      42.11 ns |     0.0518 ns |     0.0459 ns |           - |           - |           - |                   - |
           KeyValuePairDiff |      41.20 ns |     0.0596 ns |     0.0529 ns |           - |           - |           - |                   - |
          TupleSameInstance |      77.20 ns |     0.0790 ns |     0.0739 ns |      0.0050 |           - |           - |                32 B |
          TupleDiffInstance |      77.44 ns |     0.0648 ns |     0.0606 ns |      0.0050 |           - |           - |                32 B |
     DictionarySameInstance | 468,624.05 ns |   507.2530 ns |   449.6666 ns |     76.6602 |     76.6602 |     76.6602 |            283040 B |
     DictionaryDiffInstance | 473,810.52 ns | 2,592.0359 ns | 2,164.4673 ns |     76.6602 |     76.6602 |     76.6602 |            283040 B |
