
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      91.08 ns |     0.1336 ns |     0.1250 ns |      0.0050 |           - |           - |                32 B |
             ObjectInstance |      41.99 ns |     0.0998 ns |     0.0885 ns |           - |           - |           - |                   - |
            DefaultInstance |      24.66 ns |     0.1093 ns |     0.0969 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |  36,056.27 ns |   707.4281 ns | 1,036.9390 ns |     45.8374 |     45.8374 |     45.8374 |            240024 B |
        ArrayOfDiffInstance |  39,267.00 ns |   816.9124 ns |   764.1404 ns |     46.5088 |     46.5088 |     46.5088 |            240024 B |
        ArrayOfSameInstance |  37,078.30 ns |   740.1641 ns |   852.3741 ns |     44.5557 |     44.5557 |     44.5557 |            240024 B |
 ArrayOfObjectsDiffInstance | 255,100.39 ns |   205.6608 ns |   182.3130 ns |     12.2070 |           - |           - |             80024 B |
 ArrayOfObjectsSameInstance | 255,371.17 ns |   246.4267 ns |   230.5077 ns |     12.2070 |           - |           - |             80024 B |
      Array2dOfDiffInstance |  25,024.52 ns |    64.2617 ns |    56.9663 ns |     38.6353 |     11.7493 |           - |            243224 B |
      Array2dOfSameInstance |   3,292.26 ns |     6.4954 ns |     6.0758 ns |      0.5150 |           - |           - |              3248 B |
   ArrayRank2OfDiffInstance |     311.72 ns |     0.4871 ns |     0.4556 ns |      0.3877 |           - |           - |              2440 B |
   ArrayRank2OfSameInstance |     308.38 ns |     1.1247 ns |     1.0520 ns |      0.3877 |           - |           - |              2440 B |
   ArrayRank3OfDiffInstance |   2,017.60 ns |     2.9832 ns |     2.6446 ns |      3.8147 |           - |           - |             24088 B |
   ArrayRank3OfSameInstance |   2,091.62 ns |     2.5316 ns |     2.2442 ns |      3.8147 |           - |           - |             24088 B |
         ListOfDiffInstance |  37,373.11 ns |   734.0064 ns | 1,164.2120 ns |     45.9595 |     45.8984 |     45.8984 |            240430 B |
         ListOfSameInstance |  36,989.51 ns |   730.6152 ns | 1,390.0714 ns |     46.3257 |     46.2646 |     46.2646 |            240433 B |
  ListOfObjectsDiffInstance | 265,893.36 ns |   290.0482 ns |   271.3113 ns |     12.2070 |      1.9531 |           - |             80064 B |
  ListOfObjectsSameInstance | 276,901.87 ns |   261.7997 ns |   244.8876 ns |     12.2070 |      1.9531 |           - |             80064 B |
           KeyValuePairSame |      34.06 ns |     0.0279 ns |     0.0261 ns |           - |           - |           - |                   - |
           KeyValuePairDiff |      35.54 ns |     0.0236 ns |     0.0221 ns |           - |           - |           - |                   - |
          TupleSameInstance |      77.68 ns |     0.0808 ns |     0.0756 ns |      0.0101 |           - |           - |                64 B |
          TupleDiffInstance |      77.47 ns |     0.0930 ns |     0.0870 ns |      0.0101 |           - |           - |                64 B |
     DictionarySameInstance | 712,415.66 ns | 6,393.5666 ns | 5,980.5461 ns |    197.2656 |    159.1797 |    140.6250 |            926487 B |
     DictionaryDiffInstance | 728,734.11 ns | 3,272.2450 ns | 3,060.8600 ns |    197.2656 |    159.1797 |    140.6250 |            926441 B |
