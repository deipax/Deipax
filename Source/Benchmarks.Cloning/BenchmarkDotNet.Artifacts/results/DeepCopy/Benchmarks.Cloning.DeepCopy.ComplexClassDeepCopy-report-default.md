
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev |          Median |   Gen 0 |   Gen 1 | Allocated |
--------------------------- |----------------:|---------------:|---------------:|----------------:|--------:|--------:|----------:|
             SingleInstance |       147.64 ns |      3.5119 ns |      10.244 ns |       145.31 ns |  0.0050 |       - |      32 B |
            DefaultInstance |        32.50 ns |      0.7052 ns |       1.833 ns |        32.16 ns |       - |       - |       0 B |
     ArrayOfDefaultInstance |     9,990.81 ns |    200.5212 ns |     376.627 ns |     9,812.46 ns | 12.6495 |       - |   80024 B |
        ArrayOfDiffInstance | 1,277,797.94 ns | 25,433.5633 ns |  63,338.398 ns | 1,275,419.14 ns | 62.5000 | 23.4375 |  400024 B |
        ArrayOfSameInstance |   222,660.31 ns |  4,080.3414 ns |   3,617.116 ns |   222,505.15 ns | 12.4512 |       - |   80056 B |
 ArrayOfObjectsDiffInstance | 1,587,706.95 ns | 31,595.7092 ns |  85,958.457 ns | 1,552,906.23 ns | 62.5000 | 23.4375 |  400024 B |
 ArrayOfObjectsSameInstance |   277,443.17 ns |  5,571.4205 ns |  12,229.403 ns |   271,874.19 ns | 12.2070 |       - |   80056 B |
      Array2dOfDiffInstance | 1,413,069.96 ns | 30,055.9388 ns |  88,620.614 ns | 1,395,324.53 ns | 62.5000 | 23.4375 |  403224 B |
      Array2dOfSameInstance |    17,350.26 ns |    358.2781 ns |   1,056.391 ns |    17,304.59 ns |  0.7324 |       - |    4848 B |
   ArrayRank2OfDiffInstance |    13,725.76 ns |    292.2192 ns |     852.417 ns |    13,589.73 ns |  0.6256 |       - |    4040 B |
   ArrayRank2OfSameInstance |     3,337.68 ns |     66.3396 ns |     186.023 ns |     3,328.13 ns |  0.1373 |       - |     872 B |
   ArrayRank3OfDiffInstance |   296,352.26 ns |  7,383.9032 ns |  21,655.710 ns |   289,641.03 ns |  5.8594 |  0.4883 |   40168 B |
   ArrayRank3OfSameInstance |   104,144.34 ns |  2,079.9546 ns |   5,658.670 ns |   103,514.41 ns |  1.2207 |       - |    8200 B |
         ListOfDiffInstance | 1,367,477.44 ns | 34,351.4084 ns | 101,285.903 ns | 1,341,763.74 ns | 62.5000 | 23.4375 |  400064 B |
         ListOfSameInstance |   231,052.12 ns |  4,638.8138 ns |   8,364.738 ns |   227,931.45 ns | 12.2070 |  1.9531 |   80096 B |
  ListOfObjectsDiffInstance | 1,667,793.20 ns | 35,291.0085 ns | 103,502.419 ns | 1,658,221.59 ns | 62.5000 | 23.4375 |  400064 B |
  ListOfObjectsSameInstance |   306,686.24 ns |  6,827.8529 ns |  19,917.167 ns |   302,248.64 ns | 12.2070 |  1.9531 |   80096 B |
           KeyValuePairSame |       326.23 ns |      8.1612 ns |      24.064 ns |       318.68 ns |  0.0100 |       - |      64 B |
           KeyValuePairDiff |       383.41 ns |      8.8363 ns |      25.636 ns |       380.85 ns |  0.0148 |       - |      96 B |
          TupleSameInstance |       346.01 ns |      7.8694 ns |      23.203 ns |       344.23 ns |  0.0100 |       - |      64 B |
          TupleDiffInstance |       389.78 ns |      8.0228 ns |      23.656 ns |       381.95 ns |  0.0148 |       - |      96 B |
     DictionarySameInstance |              NA |             NA |             NA |              NA |     N/A |     N/A |       N/A |
     DictionaryDiffInstance |              NA |             NA |             NA |              NA |     N/A |     N/A |       N/A |

Benchmarks with issues:
  ComplexClassDeepCopy.DictionarySameInstance: DefaultJob
  ComplexClassDeepCopy.DictionaryDiffInstance: DefaultJob
