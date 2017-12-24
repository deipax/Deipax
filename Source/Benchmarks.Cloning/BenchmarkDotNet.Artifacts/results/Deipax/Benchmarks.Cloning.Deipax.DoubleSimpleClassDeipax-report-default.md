
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |             Mean |           Error |         StdDev |           Median |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |-----------------:|----------------:|---------------:|-----------------:|---------:|---------:|--------:|----------:|
             SingleInstance |        213.47 ns |       4.2753 ns |       9.737 ns |        214.71 ns |   0.0150 |        - |       - |      96 B |
            DefaultInstance |         35.92 ns |       0.7784 ns |       2.271 ns |         35.83 ns |        - |        - |       - |       0 B |
     ArrayOfDefaultInstance |     11,132.57 ns |     228.9463 ns |     671.460 ns |     11,043.87 ns |  12.6495 |        - |       - |   80024 B |
        ArrayOfDiffInstance |  2,456,704.10 ns | 187,414.6032 ns | 552,596.186 ns |  2,893,030.46 ns | 164.0625 |  62.5000 |       - | 1040024 B |
        ArrayOfSameInstance |    339,339.19 ns |   6,768.5284 ns |  18,528.737 ns |    335,054.92 ns |  12.2070 |        - |       - |   80120 B |
 ArrayOfObjectsDiffInstance |  2,563,158.76 ns |  59,615.8299 ns | 175,778.620 ns |  2,540,683.93 ns | 164.0625 |  62.5000 |       - | 1040024 B |
 ArrayOfObjectsSameInstance |    608,261.35 ns |  12,397.8039 ns |  36,360.613 ns |    606,526.36 ns |  11.7188 |        - |       - |   80120 B |
      Array2dOfDiffInstance |  1,886,119.45 ns |  44,374.3649 ns | 130,142.331 ns |  1,859,942.59 ns | 164.0625 |  74.2188 |       - | 1043224 B |
      Array2dOfSameInstance |     19,899.55 ns |     414.6816 ns |   1,216.189 ns |     19,878.22 ns |   1.7700 |   0.0610 |       - |   11248 B |
   ArrayRank2OfDiffInstance |     15,598.22 ns |     348.7602 ns |     822.069 ns |     15,163.94 ns |   1.6479 |   0.0305 |       - |   10440 B |
   ArrayRank2OfSameInstance |      4,019.15 ns |     101.0733 ns |     127.825 ns |      3,953.69 ns |   0.1450 |        - |       - |     936 B |
   ArrayRank3OfDiffInstance |    323,334.54 ns |   7,320.7963 ns |  21,585.533 ns |    323,633.53 ns |  16.1133 |   2.9297 |       - |  104168 B |
   ArrayRank3OfSameInstance |    144,268.70 ns |   2,860.0865 ns |   7,829.441 ns |    143,367.87 ns |   1.2207 |        - |       - |    8264 B |
         ListOfDiffInstance |  1,832,247.21 ns |  38,059.6388 ns | 111,622.332 ns |  1,823,190.07 ns | 164.0625 |  58.5938 |       - | 1040064 B |
         ListOfSameInstance |    349,606.11 ns |   6,945.9326 ns |  18,896.922 ns |    348,483.40 ns |  12.2070 |   1.9531 |       - |   80160 B |
  ListOfObjectsDiffInstance |  2,336,773.14 ns |  62,518.5789 ns | 183,356.169 ns |  2,293,734.10 ns | 164.0625 |  62.5000 |       - | 1040064 B |
  ListOfObjectsSameInstance |    598,351.49 ns |  12,035.7333 ns |  35,108.799 ns |    592,192.70 ns |  11.7188 |   1.9531 |       - |   80160 B |
           KeyValuePairSame |        318.96 ns |       7.2031 ns |      21.126 ns |        312.70 ns |   0.0200 |        - |       - |     128 B |
           KeyValuePairDiff |        391.10 ns |       7.7615 ns |      16.540 ns |        383.04 ns |   0.0353 |        - |       - |     224 B |
          TupleSameInstance |        304.83 ns |       6.2036 ns |      18.096 ns |        303.32 ns |   0.0200 |        - |       - |     128 B |
          TupleDiffInstance |        459.52 ns |      12.1017 ns |      35.301 ns |        449.41 ns |   0.0353 |        - |       - |     224 B |
     DictionarySameInstance |  5,517,969.96 ns | 138,967.3672 ns | 409,748.418 ns |  5,495,436.22 ns | 195.3125 | 117.1875 | 54.6875 | 1243075 B |
     DictionaryDiffInstance | 10,340,298.30 ns | 220,435.0220 ns | 649,957.636 ns | 10,284,060.92 ns | 343.7500 | 171.8750 | 46.8750 | 2203092 B |
