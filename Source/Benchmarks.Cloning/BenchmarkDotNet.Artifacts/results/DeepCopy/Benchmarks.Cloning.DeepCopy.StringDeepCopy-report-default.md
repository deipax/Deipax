
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |         StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|---------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |      38.67 ns |      0.8068 ns |      1.8046 ns |      38.49 ns |       - |       - |       - |       0 B |
             ObjectInstance |      72.21 ns |      1.4957 ns |      3.9923 ns |      71.94 ns |       - |       - |       - |       0 B |
            DefaultInstance |      28.40 ns |      0.4171 ns |      0.3256 ns |      28.29 ns |       - |       - |       - |       0 B |
     ArrayOfDefaultInstance |   8,383.04 ns |    195.4415 ns |    576.2638 ns |   8,224.41 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfDiffInstance |   8,946.69 ns |    208.0060 ns |    610.0455 ns |   8,990.83 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfSameInstance |   8,968.53 ns |    256.7151 ns |    756.9303 ns |   9,086.38 ns | 12.6495 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance | 794,542.73 ns | 15,648.6239 ns | 27,407.3025 ns | 784,092.69 ns | 11.7188 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 272,924.37 ns |  5,901.8957 ns |  9,530.4614 ns | 267,967.96 ns | 12.2070 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  19,780.34 ns |     32.2179 ns |     28.5603 ns |  19,778.28 ns | 13.2141 |  2.5940 |       - |   83224 B |
      Array2dOfSameInstance |   3,950.27 ns |     78.4333 ns |    190.9175 ns |   3,906.71 ns |  0.2594 |       - |       - |    1648 B |
   ArrayRank2OfDiffInstance |     310.39 ns |      0.9909 ns |      0.7736 ns |     310.64 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank2OfSameInstance |     313.31 ns |      6.1098 ns |      5.4162 ns |     311.05 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank3OfDiffInstance | 187,597.83 ns |  3,728.1637 ns |  4,293.3584 ns | 185,283.17 ns |  1.2207 |       - |       - |    8168 B |
   ArrayRank3OfSameInstance | 103,528.22 ns |  2,070.0801 ns |  4,714.6200 ns | 104,003.31 ns |  1.2207 |       - |       - |    8168 B |
         ListOfDiffInstance |   9,029.35 ns |    198.2326 ns |    581.3819 ns |   8,999.60 ns | 12.6495 |  2.1057 |       - |   80064 B |
         ListOfSameInstance |   9,730.65 ns |    245.6260 ns |    724.2339 ns |   9,843.03 ns | 12.6495 |  2.1057 |       - |   80064 B |
  ListOfObjectsDiffInstance | 813,991.82 ns | 16,103.3650 ns | 41,567.9274 ns | 811,459.91 ns | 11.7188 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 277,850.21 ns |  5,516.0857 ns | 13,939.8525 ns | 278,195.59 ns | 12.2070 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      64.15 ns |      1.3111 ns |      3.0905 ns |      62.64 ns |  0.0050 |       - |       - |      32 B |
           KeyValuePairDiff |      69.51 ns |      1.4061 ns |      2.4994 ns |      70.16 ns |  0.0050 |       - |       - |      32 B |
          TupleSameInstance |     127.11 ns |      2.6623 ns |      7.8499 ns |     126.57 ns |  0.0050 |       - |       - |      32 B |
          TupleDiffInstance |     111.15 ns |      2.2423 ns |      3.0692 ns |     109.68 ns |  0.0050 |       - |       - |      32 B |
     DictionarySameInstance | 356,846.64 ns |  9,972.8444 ns | 29,091.2552 ns | 356,077.71 ns | 35.3564 | 25.6055 | 24.5947 |  490852 B |
     DictionaryDiffInstance | 359,107.63 ns |  9,298.8201 ns | 27,417.7810 ns | 360,327.21 ns | 47.3145 | 37.6074 | 36.5088 |  490957 B |
