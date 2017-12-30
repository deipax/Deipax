
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev |          Median |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |----------------:|---------------:|---------------:|----------------:|---------:|---------:|--------:|----------:|
             SingleInstance |       178.32 ns |       3.612 ns |      10.592 ns |       176.72 ns |   0.0100 |        - |       - |      64 B |
             ObjectInstance |       189.79 ns |       3.815 ns |      10.249 ns |       189.22 ns |   0.0100 |        - |       - |      64 B |
            DefaultInstance |        70.49 ns |       1.440 ns |       4.200 ns |        69.80 ns |   0.0050 |        - |       - |      32 B |
     ArrayOfDefaultInstance |   545,985.36 ns |  12,419.482 ns |  36,228.213 ns |   542,532.06 ns |  89.2188 |  39.4043 | 39.4043 |  480035 B |
        ArrayOfDiffInstance | 2,699,052.49 ns |  63,844.495 ns | 187,244.852 ns | 2,662,008.57 ns | 129.8828 |  82.0313 | 38.7109 |  800062 B |
        ArrayOfSameInstance | 1,008,799.05 ns |  39,807.442 ns | 117,373.140 ns | 1,006,547.30 ns |  89.4824 |  39.6777 | 39.6777 |  480083 B |
 ArrayOfObjectsDiffInstance | 1,413,414.26 ns |  38,952.716 ns |  46,370.437 ns | 1,391,637.92 ns | 113.2813 |  42.9688 |       - |  720024 B |
 ArrayOfObjectsSameInstance |   775,945.59 ns |  15,468.376 ns |  41,288.226 ns |   774,486.18 ns |  62.5000 |  23.4375 |       - |  400056 B |
      Array2dOfDiffInstance | 1,370,329.78 ns |  44,334.697 ns | 130,721.854 ns | 1,345,780.31 ns | 126.9531 |  52.7344 |       - |  803224 B |
      Array2dOfSameInstance |    16,416.22 ns |     326.872 ns |     724.325 ns |    15,992.11 ns |   1.3733 |        - |       - |    8848 B |
   ArrayRank2OfDiffInstance |    12,099.01 ns |     238.640 ns |     454.038 ns |    12,080.93 ns |   1.2665 |   0.0153 |       - |    8040 B |
   ArrayRank2OfSameInstance |     6,178.47 ns |     123.112 ns |     326.474 ns |     6,092.54 ns |   0.7706 |        - |       - |    4872 B |
   ArrayRank3OfDiffInstance |   316,411.72 ns |   6,270.356 ns |  13,631.238 ns |   311,231.40 ns |  17.5781 |   1.9531 |       - |  112168 B |
   ArrayRank3OfSameInstance |   251,598.54 ns |   5,025.053 ns |  10,816.956 ns |   249,873.71 ns |  12.4512 |   0.4883 |       - |   80200 B |
         ListOfDiffInstance | 3,109,206.22 ns |  84,640.961 ns | 249,565.782 ns | 3,065,554.92 ns | 128.0859 |  77.1484 | 36.9922 |  800097 B |
         ListOfSameInstance | 1,039,814.87 ns |  23,329.632 ns |  68,787.946 ns | 1,030,596.45 ns |  86.8555 |  38.0273 | 38.0273 |  480123 B |
  ListOfObjectsDiffInstance | 1,474,027.28 ns |  32,988.596 ns |  97,267.618 ns | 1,466,887.97 ns | 113.2813 |  42.9688 |       - |  720064 B |
  ListOfObjectsSameInstance |   797,691.74 ns |  15,939.292 ns |  39,694.368 ns |   799,786.16 ns |  62.5000 |  23.4375 |       - |  400096 B |
           KeyValuePairSame |       284.28 ns |       6.466 ns |       9.064 ns |       279.51 ns |   0.0224 |        - |       - |     144 B |
           KeyValuePairDiff |       341.92 ns |       6.838 ns |      19.509 ns |       335.28 ns |   0.0277 |        - |       - |     176 B |
          TupleSameInstance |       280.37 ns |       5.614 ns |      15.082 ns |       274.37 ns |   0.0224 |        - |       - |     144 B |
          TupleDiffInstance |       338.22 ns |       6.764 ns |      14.559 ns |       339.65 ns |   0.0277 |        - |       - |     176 B |
     DictionarySameInstance | 5,613,094.33 ns | 143,961.829 ns | 422,215.125 ns | 5,648,006.09 ns | 296.8750 | 193.5156 | 93.7500 | 1724905 B |
     DictionaryDiffInstance | 7,722,515.74 ns | 206,792.310 ns | 609,731.791 ns | 7,693,023.19 ns | 335.3125 | 202.1094 | 92.4219 | 2044773 B |
