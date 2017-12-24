
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |         Error |        StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|--------------:|--------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |      43.87 ns |     0.9915 ns |      2.829 ns |      43.75 ns |  0.0038 |       - |       - |      24 B |
            DefaultInstance |      44.22 ns |     0.9140 ns |      2.666 ns |      43.97 ns |  0.0038 |       - |       - |      24 B |
     ArrayOfDefaultInstance |   4,106.90 ns |    87.0301 ns |    253.871 ns |   3,924.03 ns |  6.3248 |       - |       - |   40024 B |
        ArrayOfDiffInstance |   4,308.99 ns |   122.1074 ns |    360.036 ns |   4,319.83 ns |  6.3248 |       - |       - |   40024 B |
        ArrayOfSameInstance |   4,420.11 ns |   116.9948 ns |    344.962 ns |   4,396.97 ns |  6.3248 |       - |       - |   40024 B |
 ArrayOfObjectsDiffInstance | 317,139.14 ns | 7,240.4312 ns | 21,348.575 ns | 311,373.68 ns | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 329,612.47 ns | 6,569.5409 ns | 16,602.068 ns | 329,056.07 ns | 12.2070 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  14,892.73 ns |   347.3255 ns |  1,007.654 ns |  14,955.90 ns |  6.8512 |  0.7477 |       - |   43224 B |
      Array2dOfSameInstance |   4,228.56 ns |    97.1185 ns |    148.310 ns |   4,148.20 ns |  0.1907 |       - |       - |    1248 B |
   ArrayRank2OfDiffInstance |     307.30 ns |     6.1423 ns |     17.820 ns |     305.01 ns |  0.0696 |       - |       - |     440 B |
   ArrayRank2OfSameInstance |     312.16 ns |     6.1635 ns |     17.485 ns |     313.19 ns |  0.0696 |       - |       - |     440 B |
   ArrayRank3OfDiffInstance |     843.55 ns |    20.2288 ns |     59.645 ns |     844.99 ns |  0.6485 |       - |       - |    4088 B |
   ArrayRank3OfSameInstance |     811.62 ns |    17.8552 ns |     52.647 ns |     803.56 ns |  0.6485 |       - |       - |    4088 B |
         ListOfDiffInstance |   4,598.82 ns |   102.8689 ns |    303.311 ns |   4,631.14 ns |  6.3629 |  0.6332 |       - |   40064 B |
         ListOfSameInstance |   4,593.80 ns |   100.9781 ns |    297.736 ns |   4,621.30 ns |  6.3629 |  0.6332 |       - |   40064 B |
  ListOfObjectsDiffInstance | 344,044.42 ns | 6,869.9963 ns | 19,931.105 ns | 346,321.55 ns | 12.2070 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 356,687.28 ns | 7,077.8035 ns | 15,083.376 ns | 354,939.45 ns | 12.2070 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      43.31 ns |     0.8994 ns |      2.067 ns |      41.98 ns |  0.0038 |       - |       - |      24 B |
           KeyValuePairDiff |      48.44 ns |     1.0145 ns |      2.760 ns |      48.38 ns |  0.0038 |       - |       - |      24 B |
          TupleSameInstance |     111.70 ns |     2.2600 ns |      4.913 ns |     111.71 ns |  0.0037 |       - |       - |      24 B |
          TupleDiffInstance |     108.39 ns |     2.4280 ns |      7.083 ns |     105.49 ns |  0.0037 |       - |       - |      24 B |
     DictionarySameInstance | 395,230.86 ns | 7,871.9582 ns | 23,210.646 ns | 390,039.96 ns | 49.8047 | 49.8047 | 49.8047 |  202216 B |
     DictionaryDiffInstance | 383,236.90 ns | 7,644.7560 ns | 20,272.808 ns | 369,801.47 ns | 49.8047 | 49.8047 | 49.8047 |  202216 B |
