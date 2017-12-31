
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |        StdDev |        Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|--------------:|--------------:|---------:|---------:|---------:|----------:|
             SingleInstance |     183.93 ns |      3.8503 ns |     11.353 ns |     183.67 ns |   0.0050 |        - |        - |      32 B |
             ObjectInstance |      67.17 ns |      1.3628 ns |      3.493 ns |      65.71 ns |        - |        - |        - |       0 B |
            DefaultInstance |      34.87 ns |      0.7355 ns |      1.748 ns |      34.26 ns |        - |        - |        - |       0 B |
     ArrayOfDefaultInstance | 190,178.48 ns |  6,325.7273 ns | 18,452.443 ns | 190,558.88 ns |  56.7212 |  56.7188 |  56.7188 |  240024 B |
        ArrayOfDiffInstance | 133,481.71 ns |  2,775.6489 ns |  8,140.498 ns | 132,778.93 ns |  54.5190 |  54.5190 |  54.5190 |  240024 B |
        ArrayOfSameInstance | 175,614.68 ns |  6,334.1225 ns | 18,676.303 ns | 175,123.34 ns |  54.4214 |  54.4214 |  54.4214 |  240024 B |
 ArrayOfObjectsDiffInstance | 841,464.75 ns | 16,745.9687 ns | 49,375.867 ns | 841,288.60 ns |  11.7188 |        - |        - |   80024 B |
 ArrayOfObjectsSameInstance | 825,364.04 ns | 16,410.9357 ns | 45,747.129 ns | 825,392.86 ns |  11.7188 |        - |        - |   80024 B |
      Array2dOfDiffInstance |  33,206.02 ns |    714.4612 ns |  2,106.605 ns |  32,516.00 ns |  38.6353 |  11.7188 |        - |  243224 B |
      Array2dOfSameInstance |   4,334.67 ns |     89.0095 ns |    262.447 ns |   4,364.20 ns |   0.5112 |        - |        - |    3248 B |
   ArrayRank2OfDiffInstance |     413.38 ns |      9.1030 ns |     26.841 ns |     409.39 ns |   0.3872 |        - |        - |    2440 B |
   ArrayRank2OfSameInstance |     414.25 ns |      8.8641 ns |     26.136 ns |     411.15 ns |   0.3872 |        - |        - |    2440 B |
   ArrayRank3OfDiffInstance | 411,063.15 ns |  8,189.4850 ns | 20,992.781 ns | 398,650.80 ns |  13.6719 |   1.4648 |        - |   88168 B |
   ArrayRank3OfSameInstance | 413,525.82 ns |  8,908.2385 ns | 25,985.750 ns | 397,234.60 ns |  13.6719 |   0.9766 |        - |   88168 B |
         ListOfDiffInstance | 198,883.56 ns |  7,377.0660 ns | 21,519.248 ns | 200,051.55 ns |  55.7666 |  55.7666 |  55.7666 |  240510 B |
         ListOfSameInstance |  95,364.01 ns |  1,871.2508 ns |  3,780.019 ns |  94,684.04 ns |  52.7039 |  52.7039 |  52.7039 |  240481 B |
  ListOfObjectsDiffInstance | 800,233.92 ns | 15,939.8122 ns | 36,303.018 ns | 782,502.11 ns |  11.7188 |   1.9531 |        - |   80064 B |
  ListOfObjectsSameInstance | 827,054.04 ns | 16,502.9227 ns | 45,453.842 ns | 826,147.31 ns |  11.7188 |   1.9531 |        - |   80064 B |
           KeyValuePairSame |      57.65 ns |      1.1752 ns |      2.770 ns |      57.33 ns |   0.0101 |        - |        - |      64 B |
           KeyValuePairDiff |      55.05 ns |      1.1308 ns |      3.263 ns |      54.34 ns |   0.0101 |        - |        - |      64 B |
          TupleSameInstance |     152.88 ns |      3.2168 ns |      8.418 ns |     148.61 ns |   0.0100 |        - |        - |      64 B |
          TupleDiffInstance |     146.67 ns |      3.0091 ns |      8.872 ns |     145.88 ns |   0.0100 |        - |        - |      64 B |
     DictionarySameInstance | 578,062.45 ns | 12,118.7351 ns | 35,732.364 ns | 578,919.07 ns | 175.6055 | 165.5859 | 164.8633 | 1052287 B |
     DictionaryDiffInstance | 724,862.08 ns | 22,670.8709 ns | 66,131.995 ns | 726,160.80 ns | 183.1508 | 172.9925 | 172.4086 | 1052287 B |
