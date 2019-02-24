
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |       Error |      StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|------------:|------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      24.43 ns |   0.0186 ns |   0.0174 ns |           - |           - |           - |                   - |
             ObjectInstance |      43.90 ns |   0.0348 ns |   0.0325 ns |           - |           - |           - |                   - |
            DefaultInstance |      24.37 ns |   0.0146 ns |   0.0137 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   2,479.11 ns |   3.6361 ns |   3.4012 ns |      6.3286 |           - |           - |             40024 B |
        ArrayOfDiffInstance |   2,577.37 ns |  14.9494 ns |  13.9837 ns |      6.3286 |           - |           - |             40024 B |
        ArrayOfSameInstance |   2,603.77 ns |  28.0610 ns |  24.8754 ns |      6.3286 |           - |           - |             40024 B |
 ArrayOfObjectsDiffInstance | 257,084.94 ns | 262.4447 ns | 232.6504 ns |     12.2070 |           - |           - |             80024 B |
 ArrayOfObjectsSameInstance | 269,536.47 ns | 323.7108 ns | 270.3132 ns |     12.2070 |           - |           - |             80024 B |
      Array2dOfDiffInstance |   9,848.68 ns |  20.0065 ns |  18.7141 ns |      6.8665 |      0.7477 |           - |             43224 B |
      Array2dOfSameInstance |   3,253.39 ns |   8.1533 ns |   7.6266 ns |      0.1945 |           - |           - |              1248 B |
   ArrayRank2OfDiffInstance |     196.34 ns |   0.2696 ns |   0.2522 ns |      0.0699 |           - |           - |               440 B |
   ArrayRank2OfSameInstance |     198.94 ns |   0.2072 ns |   0.1938 ns |      0.0699 |           - |           - |               440 B |
   ArrayRank3OfDiffInstance |     549.99 ns |   2.4023 ns |   2.2471 ns |      0.6495 |           - |           - |              4088 B |
   ArrayRank3OfSameInstance |     553.31 ns |   0.8277 ns |   0.7743 ns |      0.6495 |           - |           - |              4088 B |
         ListOfDiffInstance |   2,685.50 ns |  10.9673 ns |   9.7222 ns |      6.3667 |      0.6332 |           - |             40064 B |
         ListOfSameInstance |   2,718.12 ns |   7.2562 ns |   6.7874 ns |      6.3667 |      0.6332 |           - |             40064 B |
  ListOfObjectsDiffInstance | 256,793.28 ns | 374.1614 ns | 349.9908 ns |     12.2070 |      1.9531 |           - |             80064 B |
  ListOfObjectsSameInstance | 256,355.89 ns | 230.7743 ns | 192.7070 ns |     12.2070 |      1.9531 |           - |             80064 B |
           KeyValuePairSame |      26.34 ns |   0.1022 ns |   0.0956 ns |           - |           - |           - |                   - |
           KeyValuePairDiff |      24.53 ns |   0.0180 ns |   0.0160 ns |           - |           - |           - |                   - |
          TupleSameInstance |      69.68 ns |   0.0773 ns |   0.0685 ns |      0.0037 |           - |           - |                24 B |
          TupleDiffInstance |      80.66 ns |   0.0680 ns |   0.0567 ns |      0.0037 |           - |           - |                24 B |
     DictionarySameInstance | 314,406.06 ns | 268.0601 ns | 209.2837 ns |     49.8047 |     49.8047 |     49.8047 |            202216 B |
     DictionaryDiffInstance | 316,500.12 ns | 621.9595 ns | 519.3644 ns |     49.8047 |     49.8047 |     49.8047 |            202216 B |
