
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |        StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|--------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |     133.13 ns |      2.9322 ns |      8.600 ns |     132.68 ns |  0.0036 |       - |       - |      24 B |
             ObjectInstance |      57.97 ns |      1.4453 ns |      4.261 ns |      57.79 ns |       - |       - |       - |       0 B |
            DefaultInstance |      27.31 ns |      0.5853 ns |      1.689 ns |      27.00 ns |       - |       - |       - |       0 B |
     ArrayOfDefaultInstance |   6,962.94 ns |    145.6757 ns |    213.530 ns |   6,856.13 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfDiffInstance |   7,347.15 ns |    173.8058 ns |    512.470 ns |   7,268.88 ns | 12.6495 |       - |       - |   80024 B |
        ArrayOfSameInstance |   7,963.98 ns |    269.3168 ns |    794.087 ns |   8,062.98 ns | 12.6495 |       - |       - |   80024 B |
 ArrayOfObjectsDiffInstance | 305,149.17 ns |  7,076.2935 ns | 20,864.611 ns | 296,927.44 ns | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 317,308.20 ns |  8,980.9085 ns | 26,480.411 ns | 316,746.80 ns | 12.2070 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  16,475.07 ns |    419.0714 ns |  1,235.642 ns |  16,275.42 ns | 13.2141 |  2.6398 |       - |   83224 B |
      Array2dOfSameInstance |   4,131.34 ns |    147.6975 ns |    151.674 ns |   4,056.75 ns |  0.2594 |       - |       - |    1648 B |
   ArrayRank2OfDiffInstance |     311.20 ns |      7.3172 ns |     21.345 ns |     309.02 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank2OfSameInstance |     317.36 ns |      8.7146 ns |     25.695 ns |     314.86 ns |  0.1330 |       - |       - |     840 B |
   ArrayRank3OfDiffInstance |   1,075.19 ns |     27.7654 ns |     80.110 ns |   1,021.13 ns |  1.2836 |       - |       - |    8088 B |
   ArrayRank3OfSameInstance |   1,092.34 ns |     24.6261 ns |     72.611 ns |   1,079.46 ns |  1.2836 |       - |       - |    8088 B |
         ListOfDiffInstance |   8,088.80 ns |    210.0970 ns |    619.476 ns |   8,043.38 ns | 12.6495 |  2.1057 |       - |   80064 B |
         ListOfSameInstance |   7,905.61 ns |    222.2719 ns |    655.374 ns |   7,798.23 ns | 12.6495 |  2.1057 |       - |   80064 B |
  ListOfObjectsDiffInstance | 322,216.28 ns |  7,600.1245 ns | 22,409.139 ns | 319,607.72 ns | 12.2070 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 316,825.24 ns |  6,980.2976 ns | 20,472.005 ns | 315,315.41 ns | 12.2070 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      50.89 ns |      1.1235 ns |      3.313 ns |      50.89 ns |  0.0050 |       - |       - |      32 B |
           KeyValuePairDiff |      49.75 ns |      1.0279 ns |      2.672 ns |      48.34 ns |  0.0051 |       - |       - |      32 B |
          TupleSameInstance |     115.09 ns |      2.3889 ns |      7.006 ns |     114.97 ns |  0.0050 |       - |       - |      32 B |
          TupleDiffInstance |     100.23 ns |      2.2490 ns |      2.590 ns |      98.90 ns |  0.0050 |       - |       - |      32 B |
     DictionarySameInstance | 687,178.35 ns | 15,936.4431 ns | 46,738.829 ns | 685,571.95 ns | 76.1719 | 76.1719 | 76.1719 |  283040 B |
     DictionaryDiffInstance | 699,992.64 ns | 15,772.5429 ns | 46,009.248 ns | 701,004.35 ns | 76.1719 | 76.1719 | 76.1719 |  283040 B |
