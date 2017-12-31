
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev |          Median |    Gen 0 |    Gen 1 | Allocated |
--------------------------- |----------------:|---------------:|---------------:|----------------:|---------:|---------:|----------:|
             SingleInstance |       155.48 ns |      3.1108 ns |       8.357 ns |       155.02 ns |   0.0253 |        - |     160 B |
             ObjectInstance |       180.30 ns |      3.6385 ns |       7.097 ns |       176.35 ns |   0.0253 |        - |     160 B |
            DefaultInstance |        36.06 ns |      0.7531 ns |       2.136 ns |        35.91 ns |        - |        - |       0 B |
     ArrayOfDefaultInstance |     9,023.72 ns |    180.3956 ns |     468.872 ns |     8,847.86 ns |  12.6495 |        - |   80024 B |
        ArrayOfDiffInstance | 1,701,233.13 ns | 39,620.4690 ns | 116,821.847 ns | 1,682,612.93 ns | 265.6250 | 130.8594 | 1680024 B |
        ArrayOfSameInstance |   212,826.04 ns |  1,506.8871 ns |   1,176.478 ns |   212,386.04 ns |  12.4512 |        - |   80184 B |
 ArrayOfObjectsDiffInstance | 1,962,067.96 ns | 46,569.4170 ns | 136,580.039 ns | 1,935,191.78 ns | 265.6250 | 130.8594 | 1680024 B |
 ArrayOfObjectsSameInstance |   281,530.60 ns |  5,565.8824 ns |  13,442.232 ns |   282,302.83 ns |  12.2070 |        - |   80184 B |
      Array2dOfDiffInstance | 1,771,611.26 ns | 46,207.0878 ns | 136,242.641 ns | 1,764,006.19 ns | 265.6250 | 125.0000 | 1683224 B |
      Array2dOfSameInstance |    17,417.22 ns |    431.7547 ns |   1,266.262 ns |    17,344.11 ns |   2.7771 |   0.1221 |   17648 B |
   ArrayRank2OfDiffInstance |    13,533.92 ns |    307.8596 ns |     907.731 ns |    13,285.09 ns |   2.6703 |   0.1221 |   16840 B |
   ArrayRank2OfSameInstance |     3,041.43 ns |     62.5494 ns |     143.718 ns |     2,975.21 ns |   0.1564 |        - |    1000 B |
   ArrayRank3OfDiffInstance |   291,473.75 ns |  6,071.3480 ns |  17,901.507 ns |   284,940.83 ns |  26.3672 |   7.3242 |  168168 B |
   ArrayRank3OfSameInstance |   103,522.78 ns |  2,068.0233 ns |   5,661.180 ns |   102,136.10 ns |   1.2207 |        - |    8328 B |
         ListOfDiffInstance | 1,741,942.95 ns | 34,660.9905 ns |  91,916.030 ns | 1,739,927.26 ns | 265.6250 | 130.8594 | 1680064 B |
         ListOfSameInstance |   225,273.20 ns |  4,674.5199 ns |  13,107.855 ns |   223,915.41 ns |  12.4512 |   1.9531 |   80224 B |
  ListOfObjectsDiffInstance | 2,171,734.57 ns | 48,244.4372 ns | 141,492.583 ns | 2,169,911.79 ns | 265.6250 | 128.9063 | 1680064 B |
  ListOfObjectsSameInstance |   282,898.67 ns |  5,959.4083 ns |  17,571.450 ns |   276,267.25 ns |  12.2070 |   1.9531 |   80224 B |
           KeyValuePairSame |       330.15 ns |      6.5854 ns |      18.466 ns |       331.68 ns |   0.0300 |        - |     192 B |
           KeyValuePairDiff |       381.53 ns |      7.6113 ns |      14.664 ns |       381.94 ns |   0.0558 |        - |     352 B |
          TupleSameInstance |       342.28 ns |      7.5342 ns |      22.096 ns |       340.52 ns |   0.0300 |        - |     192 B |
          TupleDiffInstance |       395.30 ns |      7.8495 ns |      17.394 ns |       390.40 ns |   0.0558 |        - |     352 B |
     DictionarySameInstance |              NA |             NA |             NA |              NA |      N/A |      N/A |       N/A |
     DictionaryDiffInstance |              NA |             NA |             NA |              NA |      N/A |      N/A |       N/A |

Benchmarks with issues:
  DoubleSimpleClassDeepCopy.DictionarySameInstance: DefaultJob
  DoubleSimpleClassDeepCopy.DictionaryDiffInstance: DefaultJob
