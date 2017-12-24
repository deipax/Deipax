
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |        StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|--------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |     170.93 ns |      3.4824 ns |     10.158 ns |     170.39 ns |  0.0036 |       - |       - |      24 B |
            DefaultInstance |      29.63 ns |      0.6292 ns |      1.613 ns |      29.59 ns |       - |       - |       - |       0 B |
     ArrayOfDefaultInstance |   9,123.94 ns |    270.2784 ns |    796.922 ns |   9,090.84 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfDiffInstance |   8,563.83 ns |    235.1652 ns |    689.699 ns |   8,557.97 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfSameInstance |   8,521.87 ns |    213.7957 ns |    630.382 ns |   8,531.99 ns | 12.6495 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance |            NA |             NA |            NA |            NA |     N/A |     N/A |     N/A |       N/A |
 ArrayOfObjectsSameInstance | 834,327.28 ns | 16,536.7489 ns | 44,139.930 ns | 836,685.23 ns | 11.7188 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  23,112.07 ns |    481.0250 ns |  1,418.313 ns |  23,096.30 ns | 13.2141 |  2.5940 |       - |   83224 B |
      Array2dOfSameInstance |   3,869.15 ns |     88.2119 ns |    152.161 ns |   3,783.88 ns |  0.2594 |       - |       - |    1648 B |
   ArrayRank2OfDiffInstance |     330.78 ns |      7.2243 ns |     21.301 ns |     325.02 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank2OfSameInstance |     323.25 ns |      6.8012 ns |     16.683 ns |     315.11 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank3OfDiffInstance | 364,394.77 ns |  9,161.9065 ns |  9,803.136 ns | 361,220.66 ns |  8.7891 |       - |       - |   56168 B |
   ArrayRank3OfSameInstance | 379,527.98 ns |  7,551.9095 ns | 21,300.295 ns | 371,580.95 ns |  8.7891 |       - |       - |   56168 B |
         ListOfDiffInstance |   9,254.55 ns |    219.5443 ns |    643.886 ns |   9,303.39 ns | 12.6495 |  2.1057 |       - |   80064 B |
         ListOfSameInstance |   7,975.91 ns |     72.5500 ns |     56.642 ns |   7,952.98 ns | 12.6495 |  2.1057 |       - |   80064 B |
  ListOfObjectsDiffInstance | 831,843.88 ns | 16,618.4235 ns | 44,644.315 ns | 828,661.44 ns | 11.7188 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 863,183.29 ns | 17,238.0716 ns | 41,631.880 ns | 865,915.53 ns | 11.7188 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      47.52 ns |      0.9918 ns |      2.909 ns |      47.24 ns |  0.0051 |       - |       - |      32 B |
           KeyValuePairDiff |      47.71 ns |      0.9884 ns |      2.914 ns |      47.38 ns |  0.0051 |       - |       - |      32 B |
          TupleSameInstance |     137.55 ns |      2.8361 ns |      8.362 ns |     137.55 ns |  0.0050 |       - |       - |      32 B |
          TupleDiffInstance |     143.14 ns |      2.9088 ns |      8.531 ns |     142.47 ns |  0.0050 |       - |       - |      32 B |
     DictionarySameInstance | 126,170.79 ns |  2,658.3581 ns |  7,796.504 ns | 124,073.15 ns | 76.9043 | 76.9043 | 76.9043 |  283040 B |
     DictionaryDiffInstance | 135,515.02 ns |  3,375.7346 ns |  9,953.430 ns | 135,011.86 ns | 76.9043 | 76.9043 | 76.9043 |  283040 B |

Benchmarks with issues:
  NullableIntDeepCopy.ArrayOfObjectsDiffInstance: DefaultJob
