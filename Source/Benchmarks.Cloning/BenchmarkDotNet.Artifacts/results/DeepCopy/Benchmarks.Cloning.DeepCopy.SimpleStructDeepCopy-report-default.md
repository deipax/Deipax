
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |         Error |        StdDev |        Median |    Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|--------------:|--------------:|--------------:|---------:|--------:|--------:|----------:|
             SingleInstance |      59.83 ns |      3.259 ns |      9.609 ns |      60.40 ns |   0.0051 |       - |       - |      32 B |
            DefaultInstance |      44.59 ns |      1.473 ns |      4.321 ns |      43.73 ns |   0.0051 |       - |       - |      32 B |
     ArrayOfDefaultInstance | 111,895.98 ns |  4,681.802 ns | 13,804.398 ns | 115,152.46 ns |  35.5969 | 35.5957 | 35.5957 |  160024 B |
        ArrayOfDiffInstance | 119,396.18 ns |  4,557.722 ns | 13,438.546 ns | 118,699.85 ns |  41.0364 | 41.0364 | 41.0364 |  160024 B |
        ArrayOfSameInstance |  88,334.43 ns |  1,859.698 ns |  5,483.363 ns |  88,686.73 ns |  40.1196 | 40.1196 | 40.1196 |  160024 B |
 ArrayOfObjectsDiffInstance | 835,430.99 ns | 16,655.923 ns | 40,542.818 ns | 838,808.32 ns |  11.7188 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 873,993.05 ns | 17,406.510 ns | 47,650.041 ns | 872,842.16 ns |  11.7188 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  27,498.32 ns |    546.248 ns |  1,567.289 ns |  26,850.69 ns |  25.9094 |  7.1106 |       - |  163224 B |
      Array2dOfSameInstance |   4,160.48 ns |     83.008 ns |    238.165 ns |   4,162.89 ns |   0.3815 |       - |       - |    2448 B |
   ArrayRank2OfDiffInstance |     396.93 ns |      7.966 ns |     17.485 ns |     398.75 ns |   0.2604 |       - |       - |    1640 B |
   ArrayRank2OfSameInstance |     396.82 ns |      7.947 ns |     21.888 ns |     390.13 ns |   0.2604 |       - |       - |    1640 B |
   ArrayRank3OfDiffInstance | 380,933.86 ns |  7,524.435 ns | 18,457.567 ns | 381,983.97 ns |  12.2070 |  1.4648 |       - |   80168 B |
   ArrayRank3OfSameInstance | 358,673.81 ns |  7,113.530 ns | 18,614.868 ns | 347,182.33 ns |  12.2070 |  1.4648 |       - |   80168 B |
         ListOfDiffInstance |  87,510.26 ns |  2,067.679 ns |  6,031.516 ns |  87,311.27 ns |  40.5505 | 40.5505 | 40.5505 |  160384 B |
         ListOfSameInstance | 114,982.04 ns |  4,542.773 ns | 13,323.166 ns | 117,129.97 ns |  35.6628 | 35.6616 | 35.6616 |  160328 B |
  ListOfObjectsDiffInstance | 783,521.49 ns | 15,181.687 ns | 20,780.865 ns | 773,731.59 ns |  11.7188 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 814,546.51 ns | 16,268.063 ns | 46,413.700 ns | 804,265.28 ns |  11.7188 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      57.33 ns |      1.460 ns |      4.259 ns |      57.61 ns |   0.0075 |       - |       - |      48 B |
           KeyValuePairDiff |      57.40 ns |      1.174 ns |      2.967 ns |      57.13 ns |   0.0076 |       - |       - |      48 B |
          TupleSameInstance |     133.21 ns |      2.692 ns |      7.636 ns |     132.48 ns |   0.0074 |       - |       - |      48 B |
          TupleDiffInstance |     130.34 ns |      2.642 ns |      6.072 ns |     127.18 ns |   0.0074 |       - |       - |      48 B |
     DictionarySameInstance | 176,117.46 ns |  3,330.188 ns |  3,701.495 ns | 176,388.46 ns | 103.7402 | 97.5439 | 97.3926 |  445332 B |
     DictionaryDiffInstance | 253,518.55 ns |  5,345.149 ns | 15,676.397 ns | 252,577.07 ns | 101.4160 | 95.2393 | 95.0684 |  445364 B |
