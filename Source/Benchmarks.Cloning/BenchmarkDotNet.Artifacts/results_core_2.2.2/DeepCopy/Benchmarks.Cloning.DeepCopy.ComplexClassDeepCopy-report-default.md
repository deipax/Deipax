
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |            Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       106.00 ns |     0.1187 ns |     0.1110 ns |      0.0050 |           - |           - |                32 B |
             ObjectInstance |       122.87 ns |     0.1444 ns |     0.1280 ns |      0.0050 |           - |           - |                32 B |
            DefaultInstance |        24.95 ns |     0.0120 ns |     0.0100 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |     9,557.31 ns |     9.4747 ns |     8.8627 ns |     12.6495 |           - |           - |             80024 B |
        ArrayOfDiffInstance |   951,678.69 ns |   741.3593 ns |   657.1957 ns |     63.4766 |     23.4375 |           - |            400024 B |
        ArrayOfSameInstance |   157,978.34 ns |   126.6711 ns |   118.4882 ns |     12.4512 |           - |           - |             80056 B |
 ArrayOfObjectsDiffInstance | 1,189,045.50 ns | 1,178.4628 ns | 1,102.3348 ns |     62.5000 |     23.4375 |           - |            400024 B |
 ArrayOfObjectsSameInstance |   189,252.73 ns |   214.4581 ns |   179.0822 ns |     12.4512 |           - |           - |             80056 B |
      Array2dOfDiffInstance |   969,694.41 ns | 2,949.2897 ns | 2,758.7674 ns |     63.4766 |     24.4141 |           - |            403224 B |
      Array2dOfSameInstance |    11,907.70 ns |     7.3970 ns |     6.9191 ns |      0.7629 |           - |           - |              4848 B |
   ArrayRank2OfDiffInstance |     9,432.25 ns |     8.8018 ns |     8.2332 ns |      0.6409 |           - |           - |              4040 B |
   ArrayRank2OfSameInstance |     2,271.61 ns |     3.7067 ns |     3.4673 ns |      0.1373 |           - |           - |               872 B |
   ArrayRank3OfDiffInstance |   199,062.78 ns |    89.7528 ns |    83.9548 ns |      6.3477 |      0.4883 |           - |             40168 B |
   ArrayRank3OfSameInstance |    69,528.17 ns |    44.9232 ns |    42.0212 ns |      1.2207 |           - |           - |              8200 B |
         ListOfDiffInstance |   976,034.76 ns | 1,834.5151 ns | 1,716.0065 ns |     63.4766 |     23.4375 |           - |            400064 B |
         ListOfSameInstance |   158,073.73 ns |   111.8697 ns |    99.1696 ns |     12.4512 |      1.9531 |           - |             80096 B |
  ListOfObjectsDiffInstance | 1,203,087.66 ns | 1,047.5219 ns |   979.8526 ns |     62.5000 |     23.4375 |           - |            400064 B |
  ListOfObjectsSameInstance |   193,748.64 ns |   174.3829 ns |   163.1179 ns |     12.4512 |      1.9531 |           - |             80096 B |
           KeyValuePairSame |       208.06 ns |     0.1442 ns |     0.1348 ns |      0.0050 |           - |           - |                32 B |
           KeyValuePairDiff |       249.96 ns |     0.3497 ns |     0.3100 ns |      0.0100 |           - |           - |                64 B |
          TupleSameInstance |       211.12 ns |     0.1842 ns |     0.1633 ns |      0.0100 |           - |           - |                64 B |
          TupleDiffInstance |       262.83 ns |     2.6797 ns |     2.5066 ns |      0.0148 |           - |           - |                96 B |
     DictionarySameInstance |              NA |            NA |            NA |           - |           - |           - |                   - |
     DictionaryDiffInstance |              NA |            NA |            NA |           - |           - |           - |                   - |

Benchmarks with issues:
  ComplexClassDeepCopy.DictionarySameInstance: DefaultJob
  ComplexClassDeepCopy.DictionaryDiffInstance: DefaultJob
