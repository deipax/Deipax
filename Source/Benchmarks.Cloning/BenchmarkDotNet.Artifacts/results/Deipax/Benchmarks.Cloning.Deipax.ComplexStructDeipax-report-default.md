
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |----------------:|---------------:|---------------:|---------:|---------:|---------:|----------:|
             SingleInstance |       192.01 ns |       3.839 ns |      10.180 ns |   0.0100 |        - |        - |      64 B |
            DefaultInstance |        66.06 ns |       1.399 ns |       3.186 ns |   0.0050 |        - |        - |      32 B |
     ArrayOfDefaultInstance |   636,403.83 ns |  19,270.413 ns |  56,516.785 ns |  88.9258 |  40.0977 |  40.0977 |  480038 B |
        ArrayOfDiffInstance | 2,919,576.12 ns |  64,141.928 ns | 187,105.015 ns | 132.7344 |  82.1094 |  39.1406 |  800040 B |
        ArrayOfSameInstance | 1,038,582.87 ns |  21,818.831 ns |  63,646.555 ns |  89.7461 |  40.9180 |  40.9180 |  480074 B |
 ArrayOfObjectsDiffInstance | 1,589,466.03 ns |  31,707.806 ns |  92,993.507 ns | 113.2813 |  42.9688 |        - |  720024 B |
 ArrayOfObjectsSameInstance |   803,790.44 ns |  16,072.206 ns |  41,199.209 ns |  62.5000 |  23.4375 |        - |  400056 B |
      Array2dOfDiffInstance | 1,346,533.98 ns |  28,256.212 ns |  83,314.077 ns | 126.9531 |  52.7344 |        - |  803224 B |
      Array2dOfSameInstance |    18,447.19 ns |     368.446 ns |     996.115 ns |   1.3733 |        - |        - |    8848 B |
   ArrayRank2OfDiffInstance |    12,857.80 ns |     253.570 ns |     607.538 ns |   1.2665 |   0.0153 |        - |    8040 B |
   ArrayRank2OfSameInstance |     7,088.75 ns |     140.602 ns |     253.535 ns |   0.7706 |        - |        - |    4872 B |
   ArrayRank3OfDiffInstance |   326,866.33 ns |   6,933.719 ns |  13,847.386 ns |  17.5781 |   1.9531 |        - |  112168 B |
   ArrayRank3OfSameInstance |   242,017.31 ns |   4,730.293 ns |   8,767.902 ns |  12.4512 |   0.4883 |        - |   80200 B |
         ListOfDiffInstance | 2,974,909.42 ns |  68,601.520 ns | 201,196.382 ns | 133.9453 |  83.2031 |  40.2344 |  800091 B |
         ListOfSameInstance | 1,269,175.51 ns |  45,560.775 ns | 134,336.973 ns |  89.5313 |  40.6836 |  40.6836 |  480113 B |
  ListOfObjectsDiffInstance | 1,502,221.12 ns |  29,812.813 ns |  61,568.628 ns | 113.2813 |  42.9688 |        - |  720064 B |
  ListOfObjectsSameInstance |   750,470.64 ns |   4,815.168 ns |   4,020.883 ns |  62.5000 |  23.4375 |        - |  400096 B |
           KeyValuePairSame |       309.43 ns |       6.142 ns |      13.352 ns |   0.0224 |        - |        - |     144 B |
           KeyValuePairDiff |       393.09 ns |       7.817 ns |      18.880 ns |   0.0277 |        - |        - |     176 B |
          TupleSameInstance |       319.49 ns |       6.289 ns |      16.120 ns |   0.0224 |        - |        - |     144 B |
          TupleDiffInstance |       354.63 ns |       7.098 ns |      13.157 ns |   0.0277 |        - |        - |     176 B |
     DictionarySameInstance | 6,705,342.22 ns | 189,974.472 ns | 560,144.016 ns | 304.6875 | 203.2813 | 101.5625 | 1724728 B |
     DictionaryDiffInstance | 8,279,237.15 ns | 194,949.172 ns | 574,812.031 ns | 312.5000 | 187.5000 |  78.1250 | 2044750 B |
