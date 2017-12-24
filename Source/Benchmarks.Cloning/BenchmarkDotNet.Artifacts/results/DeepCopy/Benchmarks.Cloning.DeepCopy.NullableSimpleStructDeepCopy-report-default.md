
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |          Mean |          Error |        StdDev |        Median |    Gen 0 |    Gen 1 |    Gen 2 | Allocated |
--------------------------- |--------------:|---------------:|--------------:|--------------:|---------:|---------:|---------:|----------:|
             SingleInstance |     173.09 ns |      3.4923 ns |     10.020 ns |     172.07 ns |   0.0050 |        - |        - |      32 B |
            DefaultInstance |      35.37 ns |      0.7354 ns |      2.074 ns |      35.23 ns |        - |        - |        - |       0 B |
     ArrayOfDefaultInstance | 181,891.44 ns |  6,228.6337 ns | 18,267.504 ns | 181,058.04 ns |  58.3838 |  58.3813 |  58.3813 |  240024 B |
        ArrayOfDiffInstance | 136,504.00 ns |  2,845.6756 ns |  8,210.425 ns | 136,333.91 ns |  51.8262 |  51.8262 |  51.8262 |  240024 B |
        ArrayOfSameInstance | 176,159.18 ns |  5,978.6431 ns | 17,628.164 ns | 176,795.19 ns |  51.8047 |  51.7997 |  51.7997 |  240024 B |
 ArrayOfObjectsDiffInstance | 850,064.82 ns | 16,881.7474 ns | 49,244.849 ns | 857,210.47 ns |  11.7188 |        - |        - |   80024 B |
 ArrayOfObjectsSameInstance | 807,206.46 ns | 16,074.9797 ns | 39,128.722 ns | 806,513.94 ns |  11.7188 |        - |        - |   80024 B |
      Array2dOfDiffInstance |  41,048.08 ns |  1,058.1616 ns |  3,103.405 ns |  41,109.76 ns |  38.6353 |  11.7188 |        - |  243224 B |
      Array2dOfSameInstance |   4,193.41 ns |     98.3502 ns |    288.444 ns |   4,129.43 ns |   0.5112 |        - |        - |    3248 B |
   ArrayRank2OfDiffInstance |     448.65 ns |      8.9997 ns |     24.788 ns |     445.27 ns |   0.3872 |        - |        - |    2440 B |
   ArrayRank2OfSameInstance |     470.35 ns |      9.7842 ns |     28.541 ns |     467.82 ns |   0.3872 |        - |        - |    2440 B |
   ArrayRank3OfDiffInstance | 413,096.30 ns |  8,219.2307 ns | 23,975.882 ns | 411,383.21 ns |  13.6719 |   1.4648 |        - |   88168 B |
   ArrayRank3OfSameInstance | 406,145.48 ns |  8,059.3769 ns | 19,920.783 ns | 403,689.41 ns |  13.6719 |   1.4648 |        - |   88168 B |
         ListOfDiffInstance | 178,799.27 ns |  7,097.7139 ns | 20,816.366 ns | 180,004.30 ns |  57.7832 |  57.7808 |  57.7808 |  240521 B |
         ListOfSameInstance | 137,514.57 ns |  4,470.4523 ns | 13,111.063 ns | 139,086.85 ns |  51.9019 |  51.9019 |  51.9019 |  240471 B |
  ListOfObjectsDiffInstance | 810,037.83 ns | 16,873.5376 ns | 39,441.350 ns | 806,108.55 ns |  11.7188 |   1.9531 |        - |   80064 B |
  ListOfObjectsSameInstance | 805,717.47 ns | 16,056.8592 ns | 41,733.912 ns | 790,835.61 ns |  11.7188 |   1.9531 |        - |   80064 B |
           KeyValuePairSame |      57.68 ns |      1.1796 ns |      2.301 ns |      57.64 ns |   0.0101 |        - |        - |      64 B |
           KeyValuePairDiff |      54.53 ns |      1.1186 ns |      2.907 ns |      54.55 ns |   0.0101 |        - |        - |      64 B |
          TupleSameInstance |     152.89 ns |      3.0692 ns |      8.298 ns |     152.98 ns |   0.0100 |        - |        - |      64 B |
          TupleDiffInstance |     144.02 ns |      2.8892 ns |      7.860 ns |     142.73 ns |   0.0100 |        - |        - |      64 B |
     DictionarySameInstance | 462,769.90 ns | 17,529.2663 ns | 50,855.580 ns | 461,912.62 ns | 134.5410 | 128.3740 | 128.1934 |  607008 B |
     DictionaryDiffInstance | 351,537.68 ns | 10,598.5175 ns | 30,916.373 ns | 352,656.26 ns | 130.7520 | 124.5605 | 124.3994 |  607080 B |
