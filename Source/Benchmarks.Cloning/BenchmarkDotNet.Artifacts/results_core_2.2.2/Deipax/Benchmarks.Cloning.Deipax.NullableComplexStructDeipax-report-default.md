
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       204.08 ns |      0.2637 ns |      0.2467 ns |      0.0100 |           - |           - |                64 B |
             ObjectInstance |       132.27 ns |      0.0612 ns |      0.0543 ns |      0.0100 |           - |           - |                64 B |
            DefaultInstance |        41.52 ns |      0.0545 ns |      0.0483 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |    27,212.48 ns |    526.9755 ns |    666.4552 ns |     12.7258 |     12.7258 |     12.7258 |            240024 B |
        ArrayOfDiffInstance | 2,316,718.89 ns |  3,174.9764 ns |  2,814.5338 ns |    152.3438 |    113.2813 |     54.6875 |            880095 B |
        ArrayOfSameInstance | 1,209,892.58 ns |  3,228.5986 ns |  3,020.0331 ns |    109.3750 |     58.5938 |     58.5938 |            560225 B |
 ArrayOfObjectsDiffInstance | 1,140,125.39 ns |  1,253.0119 ns |    978.2693 ns |    113.2813 |     54.6875 |           - |            720024 B |
 ArrayOfObjectsSameInstance |   632,047.18 ns |    624.2900 ns |    553.4168 ns |     63.4766 |     23.4375 |           - |            400056 B |
      Array2dOfDiffInstance | 1,665,988.95 ns |  1,309.4931 ns |  1,224.9006 ns |    138.6719 |     42.9688 |           - |            883224 B |
      Array2dOfSameInstance |    19,158.08 ns |     15.1290 ns |     13.4114 ns |      1.5259 |      0.0305 |           - |              9648 B |
   ArrayRank2OfDiffInstance |    15,918.74 ns |     18.0647 ns |     16.8977 ns |      1.4038 |           - |           - |              8840 B |
   ArrayRank2OfSameInstance |    11,477.61 ns |      7.9253 ns |      7.4133 ns |      0.9003 |           - |           - |              5672 B |
   ArrayRank3OfDiffInstance |   245,813.27 ns |    614.0849 ns |    574.4154 ns |     19.0430 |      2.6855 |           - |            120168 B |
   ArrayRank3OfSameInstance |   195,083.38 ns |    145.0385 ns |    128.5729 ns |     13.9160 |      0.9766 |           - |             88200 B |
         ListOfDiffInstance | 2,305,337.83 ns |  3,178.4748 ns |  2,654.1704 ns |    152.3438 |    109.3750 |     54.6875 |            880198 B |
         ListOfSameInstance | 1,228,322.10 ns |  4,628.5257 ns |  4,329.5258 ns |    109.3750 |     58.5938 |     58.5938 |            560313 B |
  ListOfObjectsDiffInstance | 1,128,754.91 ns |  2,325.6976 ns |  2,061.6704 ns |    113.2813 |     54.6875 |           - |            720064 B |
  ListOfObjectsSameInstance |   672,919.99 ns |    809.5154 ns |    757.2212 ns |     63.4766 |     23.4375 |           - |            400096 B |
           KeyValuePairSame |       344.50 ns |      0.3001 ns |      0.2807 ns |      0.0148 |           - |           - |                96 B |
           KeyValuePairDiff |       398.26 ns |      6.8725 ns |      6.4286 ns |      0.0200 |           - |           - |               128 B |
          TupleSameInstance |       352.99 ns |      0.2247 ns |      0.2102 ns |      0.0253 |           - |           - |               160 B |
          TupleDiffInstance |       381.82 ns |      0.3764 ns |      0.3521 ns |      0.0300 |           - |           - |               192 B |
     DictionarySameInstance | 4,776,965.02 ns | 12,797.5081 ns | 10,686.4988 ns |    328.1250 |    250.0000 |    125.0000 |           1886642 B |
     DictionaryDiffInstance | 6,095,571.56 ns | 13,643.8963 ns | 12,762.5091 ns |    359.3750 |    226.5625 |    109.3750 |           2206633 B |
