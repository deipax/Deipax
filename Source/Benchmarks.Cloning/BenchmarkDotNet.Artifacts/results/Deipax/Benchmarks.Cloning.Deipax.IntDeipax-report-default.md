
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |         Error |         StdDev |        Median |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |--------------:|--------------:|---------------:|--------------:|--------:|--------:|--------:|----------:|
             SingleInstance |      39.77 ns |     0.8341 ns |      2.3797 ns |      39.72 ns |  0.0038 |       - |       - |      24 B |
             ObjectInstance |      64.09 ns |     1.3756 ns |      4.0561 ns |      64.07 ns |       - |       - |       - |       0 B |
            DefaultInstance |      39.55 ns |     0.9446 ns |      2.7553 ns |      39.20 ns |  0.0038 |       - |       - |      24 B |
     ArrayOfDefaultInstance |   4,013.75 ns |   117.4770 ns |    346.3835 ns |   3,969.49 ns |  6.3248 |       - |       - |   40024 B |
        ArrayOfDiffInstance |   3,879.23 ns |    97.7884 ns |    283.7020 ns |   3,790.10 ns |  6.3248 |       - |       - |   40024 B |
        ArrayOfSameInstance |   3,693.02 ns |    83.6444 ns |    105.7834 ns |   3,645.11 ns |  6.3248 |       - |       - |   40024 B |
 ArrayOfObjectsDiffInstance | 325,950.65 ns | 7,442.6679 ns | 21,944.8741 ns | 316,610.79 ns | 12.2070 |       - |       - |   80024 B |
 ArrayOfObjectsSameInstance | 324,003.41 ns | 6,477.5193 ns | 17,622.5688 ns | 318,457.46 ns | 12.2070 |       - |       - |   80024 B |
      Array2dOfDiffInstance |  13,600.50 ns |   270.8973 ns |    684.5921 ns |  13,548.80 ns |  6.8512 |  0.7477 |       - |   43224 B |
      Array2dOfSameInstance |   4,444.25 ns |   101.1593 ns |    295.0864 ns |   4,412.27 ns |  0.1907 |       - |       - |    1248 B |
   ArrayRank2OfDiffInstance |     277.47 ns |     6.0035 ns |     10.0305 ns |     276.95 ns |  0.0696 |       - |       - |     440 B |
   ArrayRank2OfSameInstance |     300.52 ns |     7.8636 ns |     23.0625 ns |     297.55 ns |  0.0696 |       - |       - |     440 B |
   ArrayRank3OfDiffInstance |     696.33 ns |     1.2586 ns |      0.9826 ns |     696.02 ns |  0.6485 |       - |       - |    4088 B |
   ArrayRank3OfSameInstance |     723.03 ns |    14.4304 ns |     30.1217 ns |     713.33 ns |  0.6485 |       - |       - |    4088 B |
         ListOfDiffInstance |   3,915.12 ns |    77.7846 ns |    142.2335 ns |   3,829.51 ns |  6.3629 |  0.6332 |       - |   40064 B |
         ListOfSameInstance |   4,204.05 ns |   122.0518 ns |    359.8725 ns |   4,165.65 ns |  6.3667 |  0.6332 |       - |   40064 B |
  ListOfObjectsDiffInstance | 346,072.85 ns | 6,856.9670 ns | 16,428.8550 ns | 344,160.06 ns | 12.2070 |  1.9531 |       - |   80064 B |
  ListOfObjectsSameInstance | 351,025.96 ns | 7,565.8985 ns | 22,308.2225 ns | 351,510.83 ns | 12.2070 |  1.9531 |       - |   80064 B |
           KeyValuePairSame |      40.64 ns |     0.8734 ns |      2.5617 ns |      39.86 ns |  0.0038 |       - |       - |      24 B |
           KeyValuePairDiff |      39.76 ns |     0.8814 ns |      2.5989 ns |      39.52 ns |  0.0038 |       - |       - |      24 B |
          TupleSameInstance |     104.15 ns |     2.8897 ns |      8.3835 ns |     100.38 ns |  0.0037 |       - |       - |      24 B |
          TupleDiffInstance |     103.63 ns |     2.0841 ns |      5.0333 ns |     100.57 ns |  0.0037 |       - |       - |      24 B |
     DictionarySameInstance | 374,005.21 ns | 8,231.6139 ns | 13,977.9050 ns | 365,493.17 ns | 49.8047 | 49.8047 | 49.8047 |  202216 B |
     DictionaryDiffInstance | 387,490.80 ns | 7,849.7128 ns | 20,952.4726 ns | 386,012.76 ns | 49.8047 | 49.8047 | 49.8047 |  202216 B |
