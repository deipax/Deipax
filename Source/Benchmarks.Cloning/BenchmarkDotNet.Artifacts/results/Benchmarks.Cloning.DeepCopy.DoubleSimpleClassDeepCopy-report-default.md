
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |          StdDev |          Median |    Gen 0 |    Gen 1 | Allocated |
--------------------------- |----------------:|---------------:|----------------:|----------------:|---------:|---------:|----------:|
             SingleInstance |       151.64 ns |      3.0347 ns |       7.2710 ns |       151.59 ns |   0.0253 |        - |     160 B |
            DefaultInstance |        30.80 ns |      0.6367 ns |       0.8052 ns |        30.46 ns |        - |        - |       0 B |
     ArrayOfDefaultInstance |    11,302.54 ns |    219.1636 ns |     607.3014 ns |    11,205.72 ns |  12.6495 |        - |   80024 B |
        ArrayOfDiffInstance | 1,635,090.73 ns | 32,576.9617 ns |  89,178.9069 ns | 1,618,566.65 ns | 265.6250 | 130.8594 | 1680024 B |
        ArrayOfSameInstance |   234,372.50 ns |  4,683.2215 ns |  12,419.2390 ns |   232,259.69 ns |  12.4512 |        - |   80184 B |
 ArrayOfObjectsDiffInstance | 1,935,875.67 ns | 39,320.7034 ns | 104,954.9171 ns | 1,896,266.18 ns | 265.6250 | 130.8594 | 1680024 B |
 ArrayOfObjectsSameInstance |   266,885.66 ns |    889.7271 ns |     832.2512 ns |   266,694.23 ns |  12.2070 |        - |   80184 B |
      Array2dOfDiffInstance | 1,756,314.23 ns | 36,035.8254 ns |  91,722.6813 ns | 1,749,289.91 ns | 265.6250 | 126.9531 | 1683224 B |
      Array2dOfSameInstance |    16,371.22 ns |    248.9618 ns |     220.6981 ns |    16,325.31 ns |   2.7771 |   0.1221 |   17648 B |
   ArrayRank2OfDiffInstance |    13,821.05 ns |    299.3423 ns |     873.1955 ns |    13,536.53 ns |   2.6703 |   0.1221 |   16840 B |
   ArrayRank2OfSameInstance |     3,281.54 ns |     64.7396 ns |     132.2458 ns |     3,291.01 ns |   0.1564 |        - |    1000 B |
   ArrayRank3OfDiffInstance |   291,045.08 ns |  5,812.4756 ns |  15,107.3969 ns |   282,997.22 ns |  26.3672 |   6.8359 |  168168 B |
   ArrayRank3OfSameInstance |   107,369.07 ns |  2,126.0953 ns |   4,711.2803 ns |   107,601.81 ns |   1.2207 |        - |    8328 B |
         ListOfDiffInstance | 1,753,164.07 ns | 41,463.8133 ns | 122,256.9891 ns | 1,733,300.82 ns | 265.6250 | 130.8594 | 1680064 B |
         ListOfSameInstance |   232,003.20 ns |  4,639.2432 ns |  11,380.1426 ns |   232,178.37 ns |  12.4512 |   1.9531 |   80224 B |
  ListOfObjectsDiffInstance | 2,135,514.96 ns | 52,500.3549 ns | 154,798.4809 ns | 2,123,035.89 ns | 265.6250 | 128.9063 | 1680064 B |
  ListOfObjectsSameInstance |   282,724.76 ns |  5,641.8450 ns |  14,360.2970 ns |   277,426.66 ns |  12.2070 |   1.9531 |   80224 B |
           KeyValuePairSame |       336.06 ns |      7.3354 ns |      21.6287 ns |       337.38 ns |   0.0300 |        - |     192 B |
           KeyValuePairDiff |       490.73 ns |      9.9121 ns |      22.7746 ns |       484.58 ns |   0.0558 |        - |     352 B |
          TupleSameInstance |       346.95 ns |      6.9827 ns |      19.1149 ns |       346.40 ns |   0.0300 |        - |     192 B |
          TupleDiffInstance |       427.76 ns |      8.4745 ns |      19.3008 ns |       426.88 ns |   0.0558 |        - |     352 B |
     DictionarySameInstance |              NA |             NA |              NA |              NA |      N/A |      N/A |       N/A |
     DictionaryDiffInstance |              NA |             NA |              NA |              NA |      N/A |      N/A |       N/A |

Benchmarks with issues:
  DoubleSimpleClassDeepCopy.DictionarySameInstance: DefaultJob
  DoubleSimpleClassDeepCopy.DictionaryDiffInstance: DefaultJob
