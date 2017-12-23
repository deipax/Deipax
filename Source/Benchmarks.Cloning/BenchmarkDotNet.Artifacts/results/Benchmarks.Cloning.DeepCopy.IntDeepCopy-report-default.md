
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |        StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|--------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |      44.89 ns |      0.9592 ns |      2.798 ns |      45.00 ns |  0.0038 |       - |       - |      24 B |
            DefaultInstance |      39.09 ns |      1.0560 ns |      3.064 ns |      38.58 ns |  0.0038 |       - |       - |      24 B |
     ArrayOfDefaultInstance |   4,401.67 ns |    134.2279 ns |    395.774 ns |   4,378.13 ns |  6.3248 |       - |       - |   40024 B |
        ArrayOfDiffInstance |            NA |             NA |            NA |            NA |  6.3248 |       - |       - |   40024 B |
        ArrayOfSameInstance |   4,214.68 ns |    108.9222 ns |    321.160 ns |   4,128.59 ns |  6.3248 |       - |       - |   40024 B |
 ArrayOfObjectsDiffInstance | 836,851.77 ns | 17,208.0656 ns | 50,738.370 ns | 839,445.25 ns | 11.7188 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 808,342.86 ns | 16,964.4120 ns | 49,753.684 ns | 808,531.44 ns | 11.7188 |       - |       - |   80024 B |
      Array2dOfDiffInstance |            NA |             NA |            NA |            NA |  6.8359 |  0.7629 |       - |   43224 B |
      Array2dOfSameInstance |   4,003.24 ns |    106.1714 ns |    309.707 ns |   3,993.46 ns |  0.1907 |       - |       - |    1248 B |
   ArrayRank2OfDiffInstance |     332.24 ns |      6.9390 ns |     20.021 ns |     335.07 ns |  0.0696 |       - |       - |     440 B |
   ArrayRank2OfSameInstance |     313.06 ns |      8.8303 ns |     25.898 ns |     306.30 ns |  0.0696 |       - |       - |     440 B |
   ArrayRank3OfDiffInstance | 353,549.81 ns |  9,181.6702 ns | 26,928.249 ns | 352,471.95 ns |  7.8125 |  0.4883 |       - |   52168 B |
   ArrayRank3OfSameInstance | 344,113.65 ns |  8,259.4305 ns | 24,353.117 ns | 338,517.32 ns |  7.8125 |  0.4883 |       - |   52168 B |
         ListOfDiffInstance |   4,575.16 ns |    137.6351 ns |    405.820 ns |   4,489.08 ns |  6.3629 |  0.6332 |       - |   40064 B |
         ListOfSameInstance |   4,579.26 ns |    131.7938 ns |    388.597 ns |   4,508.35 ns |  6.3629 |  0.6332 |       - |   40064 B |
  ListOfObjectsDiffInstance | 869,471.39 ns | 17,650.9490 ns | 48,910.697 ns | 861,791.62 ns | 11.7188 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 809,940.61 ns | 18,317.2647 ns | 52,849.497 ns | 811,305.47 ns | 11.7188 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      42.77 ns |      0.9127 ns |      2.677 ns |      42.28 ns |  0.0038 |       - |       - |      24 B |
           KeyValuePairDiff |      40.16 ns |      0.8119 ns |      2.330 ns |      39.93 ns |  0.0038 |       - |       - |      24 B |
          TupleSameInstance |     125.47 ns |      2.8048 ns |      8.093 ns |     125.28 ns |  0.0036 |       - |       - |      24 B |
          TupleDiffInstance |     128.55 ns |      2.9105 ns |      8.536 ns |     128.35 ns |  0.0036 |       - |       - |      24 B |
     DictionarySameInstance |  97,944.70 ns |  2,343.7526 ns |  6,873.821 ns |  97,171.92 ns | 49.9268 | 49.9268 | 49.9268 |  202240 B |
     DictionaryDiffInstance |  96,257.13 ns |  2,201.2704 ns |  6,490.496 ns |  96,283.21 ns | 49.9268 | 49.9268 | 49.9268 |  202240 B |

Benchmarks with issues:
  IntDeepCopy.ArrayOfDiffInstance: DefaultJob
  IntDeepCopy.Array2dOfDiffInstance: DefaultJob
