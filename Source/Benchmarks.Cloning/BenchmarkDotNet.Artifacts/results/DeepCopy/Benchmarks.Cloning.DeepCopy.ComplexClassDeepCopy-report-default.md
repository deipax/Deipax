
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |          StdDev |          Median |   Gen 0 |   Gen 1 | Allocated |
--------------------------- |----------------:|---------------:|----------------:|----------------:|--------:|--------:|----------:|
             SingleInstance |       143.95 ns |      2.8856 ns |       7.3448 ns |       143.50 ns |  0.0050 |       - |      32 B |
             ObjectInstance |       165.85 ns |      0.8511 ns |       0.6645 ns |       165.85 ns |  0.0050 |       - |      32 B |
            DefaultInstance |        29.20 ns |      0.6142 ns |       1.3088 ns |        28.34 ns |       - |       - |       0 B |
     ArrayOfDefaultInstance |     9,244.64 ns |    189.3133 ns |     558.1944 ns |     9,184.26 ns | 12.6495 |       - |   80024 B |
        ArrayOfDiffInstance | 1,223,434.59 ns | 24,013.0598 ns |  45,687.3420 ns | 1,207,197.79 ns | 62.5000 | 23.4375 |  400024 B |
        ArrayOfSameInstance |   224,136.53 ns |  4,467.1971 ns |   8,390.4790 ns |   224,248.40 ns | 12.4512 |       - |   80056 B |
 ArrayOfObjectsDiffInstance | 1,545,001.91 ns | 30,496.7711 ns |  62,296.8218 ns | 1,547,883.26 ns | 62.5000 | 23.4375 |  400024 B |
 ArrayOfObjectsSameInstance |   271,631.50 ns |  5,339.0095 ns |  11,261.7832 ns |   264,909.53 ns | 12.2070 |       - |   80056 B |
      Array2dOfDiffInstance | 1,227,103.87 ns | 24,362.6860 ns |  39,341.1966 ns | 1,214,541.42 ns | 62.5000 | 23.4375 |  403224 B |
      Array2dOfSameInstance |    15,596.85 ns |    310.9825 ns |     584.1006 ns |    15,366.43 ns |  0.7629 |       - |    4848 B |
   ArrayRank2OfDiffInstance |    12,534.76 ns |    249.6398 ns |     648.8470 ns |    12,372.21 ns |  0.6256 |       - |    4040 B |
   ArrayRank2OfSameInstance |     3,109.59 ns |     62.1946 ns |     179.4455 ns |     3,089.83 ns |  0.1373 |       - |     872 B |
   ArrayRank3OfDiffInstance |   276,667.68 ns |  5,625.1633 ns |  16,497.6303 ns |   274,579.91 ns |  5.8594 |  0.4883 |   40168 B |
   ArrayRank3OfSameInstance |    99,852.44 ns |  1,993.3037 ns |   5,000.8094 ns |    98,062.58 ns |  1.2207 |       - |    8200 B |
         ListOfDiffInstance | 1,241,100.07 ns | 24,794.4021 ns |  58,443.3227 ns | 1,222,625.02 ns | 62.5000 | 23.4375 |  400064 B |
         ListOfSameInstance |   237,742.80 ns |  5,806.8884 ns |  17,121.7415 ns |   238,460.97 ns | 12.4512 |  1.9531 |   80096 B |
  ListOfObjectsDiffInstance | 1,867,447.57 ns | 37,701.7719 ns | 110,572.7705 ns | 1,806,678.70 ns | 62.5000 | 23.4375 |  400064 B |
  ListOfObjectsSameInstance |   273,943.09 ns |  5,445.2414 ns |  11,123.1853 ns |   267,450.56 ns | 12.2070 |  1.9531 |   80096 B |
           KeyValuePairSame |       299.46 ns |      6.0104 ns |      13.9300 ns |       295.87 ns |  0.0100 |       - |      64 B |
           KeyValuePairDiff |       382.92 ns |      8.2269 ns |      24.2571 ns |       381.54 ns |  0.0148 |       - |      96 B |
          TupleSameInstance |       341.17 ns |      6.8792 ns |      19.7377 ns |       341.52 ns |  0.0100 |       - |      64 B |
          TupleDiffInstance |       380.64 ns |      7.5775 ns |      19.1492 ns |       372.94 ns |  0.0148 |       - |      96 B |
     DictionarySameInstance |              NA |             NA |              NA |              NA |     N/A |     N/A |       N/A |
     DictionaryDiffInstance |              NA |             NA |              NA |              NA |     N/A |     N/A |       N/A |

Benchmarks with issues:
  ComplexClassDeepCopy.DictionarySameInstance: DefaultJob
  ComplexClassDeepCopy.DictionaryDiffInstance: DefaultJob
