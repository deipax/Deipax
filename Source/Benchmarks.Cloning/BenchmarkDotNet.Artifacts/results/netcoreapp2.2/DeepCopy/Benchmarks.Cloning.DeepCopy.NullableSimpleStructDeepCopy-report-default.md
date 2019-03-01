
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |     110.96 ns |     0.0843 ns |     0.0788 ns |      0.0050 |           - |           - |                32 B |
             ObjectInstance |      50.04 ns |     0.0256 ns |     0.0239 ns |           - |           - |           - |                   - |
            DefaultInstance |      24.28 ns |     0.0131 ns |     0.0123 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |  37,413.82 ns |   747.2550 ns | 1,308.7568 ns |     46.1426 |     46.1426 |     46.1426 |            240024 B |
        ArrayOfDiffInstance |  37,877.43 ns |   751.4483 ns | 1,335.6986 ns |     45.6543 |     45.6543 |     45.6543 |            240024 B |
        ArrayOfSameInstance |  38,406.77 ns |   616.7493 ns |   576.9076 ns |     43.9453 |     43.9453 |     43.9453 |            240024 B |
 ArrayOfObjectsDiffInstance | 608,193.34 ns | 4,366.7351 ns | 4,084.6467 ns |     11.7188 |           - |           - |             80024 B |
 ArrayOfObjectsSameInstance | 602,727.11 ns |   779.3530 ns |   690.8762 ns |     11.7188 |           - |           - |             80024 B |
      Array2dOfDiffInstance |  27,104.38 ns |    23.7865 ns |    22.2499 ns |     38.6353 |     11.7493 |           - |            243224 B |
      Array2dOfSameInstance |   2,738.47 ns |     5.9623 ns |     5.2854 ns |      0.5150 |           - |           - |              3248 B |
   ArrayRank2OfDiffInstance |     311.64 ns |     0.3734 ns |     0.3493 ns |      0.3877 |           - |           - |              2440 B |
   ArrayRank2OfSameInstance |     306.89 ns |     0.2443 ns |     0.1907 ns |      0.3877 |           - |           - |              2440 B |
   ArrayRank3OfDiffInstance | 264,896.35 ns |   364.7260 ns |   341.1650 ns |     13.6719 |      1.4648 |           - |             88168 B |
   ArrayRank3OfSameInstance | 274,023.82 ns |   465.5205 ns |   435.4482 ns |     13.6719 |      1.4648 |           - |             88168 B |
         ListOfDiffInstance |  41,798.14 ns |   813.9009 ns | 1,114.0768 ns |     43.8843 |     43.8232 |     43.8232 |            240334 B |
         ListOfSameInstance |  38,155.10 ns |   753.3938 ns | 1,433.4100 ns |     44.3115 |     44.2505 |     44.2505 |            240338 B |
  ListOfObjectsDiffInstance | 607,592.14 ns |   581.9657 ns |   544.3711 ns |     11.7188 |      1.9531 |           - |             80064 B |
  ListOfObjectsSameInstance | 607,571.48 ns |   291.2250 ns |   272.4121 ns |     11.7188 |      1.9531 |           - |             80064 B |
           KeyValuePairSame |      37.71 ns |     0.0475 ns |     0.0444 ns |           - |           - |           - |                   - |
           KeyValuePairDiff |      33.81 ns |     0.0239 ns |     0.0223 ns |           - |           - |           - |                   - |
          TupleSameInstance |      93.43 ns |     0.0505 ns |     0.0448 ns |      0.0101 |           - |           - |                64 B |
          TupleDiffInstance |      94.47 ns |     0.5472 ns |     0.4851 ns |      0.0101 |           - |           - |                64 B |
     DictionarySameInstance | 163,026.21 ns | 1,605.9838 ns | 1,502.2382 ns |    154.0527 |    143.3105 |    142.5781 |           1051853 B |
     DictionaryDiffInstance | 171,087.54 ns | 2,682.5732 ns | 2,509.2806 ns |    154.0527 |    143.5547 |    142.5781 |           1051855 B |
