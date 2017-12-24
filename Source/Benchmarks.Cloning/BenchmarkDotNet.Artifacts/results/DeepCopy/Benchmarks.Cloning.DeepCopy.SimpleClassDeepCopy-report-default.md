
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |        StdDev |          Median |    Gen 0 |   Gen 1 | Allocated |
--------------------------- |----------------:|---------------:|--------------:|----------------:|---------:|--------:|----------:|
             SingleInstance |        56.22 ns |      1.1615 ns |      2.871 ns |        56.13 ns |   0.0101 |       - |      64 B |
            DefaultInstance |        35.44 ns |      0.8098 ns |      2.388 ns |        35.19 ns |        - |       - |       0 B |
     ArrayOfDefaultInstance |    10,305.53 ns |    268.6021 ns |    783.525 ns |    10,178.84 ns |  12.6495 |       - |   80024 B |
        ArrayOfDiffInstance |   735,748.40 ns | 14,725.6007 ns | 41,774.078 ns |   725,138.65 ns | 113.2813 | 41.9922 |  720024 B |
        ArrayOfSameInstance |   234,875.93 ns |  5,007.2941 ns | 14,685.527 ns |   234,178.75 ns |  12.4512 |       - |   80088 B |
 ArrayOfObjectsDiffInstance | 1,174,124.67 ns | 23,163.1917 ns | 43,506.089 ns | 1,152,301.89 ns | 113.2813 | 42.9688 |  720024 B |
 ArrayOfObjectsSameInstance |   295,706.85 ns |  6,156.6323 ns | 18,056.337 ns |   293,107.12 ns |  12.2070 |       - |   80088 B |
      Array2dOfDiffInstance |   782,424.47 ns | 19,213.2004 ns | 56,348.991 ns |   781,713.52 ns | 114.2578 | 44.9219 |  723224 B |
      Array2dOfSameInstance |    10,444.53 ns |    206.6934 ns |    526.101 ns |    10,492.06 ns |   1.2665 |  0.0305 |    8048 B |
   ArrayRank2OfDiffInstance |     7,581.69 ns |    151.1966 ns |    350.421 ns |     7,571.72 ns |   1.1444 |  0.0229 |    7240 B |
   ArrayRank2OfSameInstance |     3,186.11 ns |     73.1410 ns |    215.658 ns |     3,173.10 ns |   0.1411 |       - |     904 B |
   ArrayRank3OfDiffInstance |   213,286.50 ns |  4,218.1484 ns | 10,736.534 ns |   211,322.13 ns |  11.2305 |  1.7090 |   72168 B |
   ArrayRank3OfSameInstance |   103,429.03 ns |  2,428.3195 ns |  7,159.955 ns |   100,760.66 ns |   1.2207 |       - |    8232 B |
         ListOfDiffInstance |   750,011.63 ns | 16,199.9408 ns | 47,765.891 ns |   732,257.84 ns | 113.2813 | 41.9922 |  720064 B |
         ListOfSameInstance |   233,067.35 ns |  4,606.8691 ns |  9,200.415 ns |   228,211.97 ns |  12.2070 |  1.9531 |   80128 B |
  ListOfObjectsDiffInstance | 1,060,830.14 ns | 21,071.4263 ns | 57,682.690 ns | 1,057,341.21 ns | 113.2813 | 41.9922 |  720064 B |
  ListOfObjectsSameInstance |   309,920.85 ns |  6,147.3765 ns | 16,086.613 ns |   308,314.53 ns |  12.2070 |  1.9531 |   80128 B |
           KeyValuePairSame |       222.06 ns |      4.4754 ns |      9.537 ns |       222.09 ns |   0.0253 |       - |     160 B |
           KeyValuePairDiff |       257.54 ns |      5.0206 ns |     13.995 ns |       256.74 ns |   0.0253 |       - |     160 B |
          TupleSameInstance |       251.74 ns |      5.4078 ns |     12.640 ns |       245.01 ns |   0.0253 |       - |     160 B |
          TupleDiffInstance |       252.31 ns |      5.0795 ns |     13.470 ns |       250.87 ns |   0.0253 |       - |     160 B |
     DictionarySameInstance |              NA |             NA |            NA |              NA |      N/A |     N/A |       N/A |
     DictionaryDiffInstance |              NA |             NA |            NA |              NA |      N/A |     N/A |       N/A |

Benchmarks with issues:
  SimpleClassDeepCopy.DictionarySameInstance: DefaultJob
  SimpleClassDeepCopy.DictionaryDiffInstance: DefaultJob
