
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev |          Median |    Gen 0 |   Gen 1 | Allocated |
--------------------------- |----------------:|---------------:|---------------:|----------------:|---------:|--------:|----------:|
             SingleInstance |        49.85 ns |      1.0301 ns |      1.3751 ns |        49.21 ns |   0.0101 |       - |      64 B |
             ObjectInstance |        74.02 ns |      0.2475 ns |      0.1933 ns |        73.96 ns |   0.0101 |       - |      64 B |
            DefaultInstance |        29.65 ns |      0.6184 ns |      0.5482 ns |        29.41 ns |        - |       - |       0 B |
     ArrayOfDefaultInstance |     8,661.06 ns |     61.0044 ns |     47.6282 ns |     8,641.75 ns |  12.6495 |       - |   80024 B |
        ArrayOfDiffInstance |   775,384.79 ns | 15,329.0756 ns | 38,174.7176 ns |   771,341.79 ns | 113.2813 | 41.9922 |  720024 B |
        ArrayOfSameInstance |   235,548.71 ns |  4,678.1425 ns | 11,298.2400 ns |   234,482.32 ns |  12.4512 |       - |   80088 B |
 ArrayOfObjectsDiffInstance | 1,037,229.35 ns | 23,232.8325 ns | 68,137.8759 ns | 1,035,100.21 ns | 113.2813 | 41.9922 |  720024 B |
 ArrayOfObjectsSameInstance |   275,612.37 ns |  1,437.6093 ns |  1,200.4688 ns |   275,198.17 ns |  12.2070 |       - |   80088 B |
      Array2dOfDiffInstance |   703,771.87 ns |  1,391.5465 ns |  1,162.0042 ns |   703,875.60 ns | 114.2578 | 44.9219 |  723224 B |
      Array2dOfSameInstance |     9,798.88 ns |    126.6695 ns |     98.8952 ns |     9,764.14 ns |   1.2665 |  0.0305 |    8048 B |
   ArrayRank2OfDiffInstance |     6,619.97 ns |    166.0306 ns |    147.1818 ns |     6,614.17 ns |   1.1444 |  0.0229 |    7240 B |
   ArrayRank2OfSameInstance |     2,844.66 ns |      8.2992 ns |      6.4795 ns |     2,843.66 ns |   0.1411 |       - |     904 B |
   ArrayRank3OfDiffInstance |   204,277.96 ns |  4,065.6975 ns |  6,680.0575 ns |   201,379.52 ns |  11.2305 |  1.7090 |   72168 B |
   ArrayRank3OfSameInstance |    99,755.00 ns |    300.2785 ns |    250.7461 ns |    99,740.58 ns |   1.2207 |       - |    8232 B |
         ListOfDiffInstance |   723,305.83 ns | 14,391.4005 ns | 37,659.7869 ns |   699,178.92 ns | 113.2813 | 41.9922 |  720064 B |
         ListOfSameInstance |   235,123.16 ns |  4,674.3069 ns | 11,812.5699 ns |   234,457.45 ns |  12.4512 |  1.9531 |   80128 B |
  ListOfObjectsDiffInstance | 1,100,297.31 ns | 25,784.0406 ns | 75,620.1276 ns | 1,106,728.37 ns | 113.2813 | 41.9922 |  720064 B |
  ListOfObjectsSameInstance |   314,381.70 ns |  6,246.8294 ns | 17,619.2931 ns |   312,188.21 ns |  12.2070 |  1.9531 |   80128 B |
           KeyValuePairSame |       229.21 ns |      4.6025 ns |     11.1155 ns |       228.79 ns |   0.0253 |       - |     160 B |
           KeyValuePairDiff |       225.36 ns |      4.5307 ns |     12.1713 ns |       225.07 ns |   0.0253 |       - |     160 B |
          TupleSameInstance |       246.81 ns |      5.1736 ns |      9.5897 ns |       241.85 ns |   0.0253 |       - |     160 B |
          TupleDiffInstance |       240.66 ns |      4.8094 ns |     10.0391 ns |       237.56 ns |   0.0253 |       - |     160 B |
     DictionarySameInstance |              NA |             NA |             NA |              NA |      N/A |     N/A |       N/A |
     DictionaryDiffInstance |              NA |             NA |             NA |              NA |      N/A |     N/A |       N/A |

Benchmarks with issues:
  SimpleClassDeepCopy.DictionarySameInstance: DefaultJob
  SimpleClassDeepCopy.DictionaryDiffInstance: DefaultJob
