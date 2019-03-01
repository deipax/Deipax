
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       127.89 ns |      0.2441 ns |      0.2283 ns |      0.0050 |           - |           - |                32 B |
             ObjectInstance |       135.95 ns |      0.1634 ns |      0.1529 ns |      0.0100 |           - |           - |                64 B |
            DefaultInstance |        42.35 ns |      0.0391 ns |      0.0346 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   142,458.86 ns |    406.6867 ns |    380.4149 ns |     34.4238 |     34.4238 |     34.4238 |            160024 B |
        ArrayOfDiffInstance | 1,117,437.28 ns | 16,373.8784 ns | 14,515.0167 ns |     89.8438 |     80.0781 |     41.0156 |            480101 B |
        ArrayOfSameInstance |   388,782.33 ns |  2,947.6178 ns |  2,757.2035 ns |     42.4805 |     42.4805 |     42.4805 |            160396 B |
 ArrayOfObjectsDiffInstance | 1,148,959.95 ns |  1,882.9898 ns |  1,669.2214 ns |    113.2813 |     54.6875 |           - |            720024 B |
 ArrayOfObjectsSameInstance |   616,039.88 ns |    679.6809 ns |    635.7739 ns |     63.4766 |     23.4375 |           - |            400056 B |
      Array2dOfDiffInstance |   856,215.38 ns |    391.5969 ns |    347.1404 ns |     76.1719 |     19.5313 |           - |            483224 B |
      Array2dOfSameInstance |    11,913.76 ns |     10.3418 ns |      9.6737 ns |      0.8850 |      0.0153 |           - |              5648 B |
   ArrayRank2OfDiffInstance |     8,480.06 ns |      7.7330 ns |      6.8551 ns |      0.7629 |           - |           - |              4840 B |
   ArrayRank2OfSameInstance |     4,288.90 ns |      5.7512 ns |      5.3796 ns |      0.2594 |           - |           - |              1672 B |
   ArrayRank3OfDiffInstance |   222,086.53 ns |    183.9260 ns |    172.0445 ns |     17.8223 |      2.1973 |           - |            112168 B |
   ArrayRank3OfSameInstance |   170,820.81 ns |    156.8205 ns |    130.9522 ns |     12.6953 |      0.4883 |           - |             80200 B |
         ListOfDiffInstance | 1,184,408.44 ns |  3,887.6825 ns |  3,446.3293 ns |     89.8438 |     66.4063 |     42.9688 |            480170 B |
         ListOfSameInstance |   393,624.33 ns |    925.3049 ns |    820.2587 ns |     42.4805 |     42.4805 |     42.4805 |            160431 B |
  ListOfObjectsDiffInstance | 1,167,915.64 ns |  1,125.5408 ns |  1,052.8316 ns |    113.2813 |     54.6875 |           - |            720064 B |
  ListOfObjectsSameInstance |   638,521.53 ns |    717.4243 ns |    635.9780 ns |     63.4766 |     23.4375 |           - |            400096 B |
           KeyValuePairSame |       186.89 ns |      0.1609 ns |      0.1505 ns |      0.0050 |           - |           - |                32 B |
           KeyValuePairDiff |       223.49 ns |      0.1351 ns |      0.1128 ns |      0.0100 |           - |           - |                64 B |
          TupleSameInstance |       199.46 ns |      0.1987 ns |      0.1762 ns |      0.0126 |           - |           - |                80 B |
          TupleDiffInstance |       237.19 ns |      0.5901 ns |      0.5520 ns |      0.0176 |           - |           - |               112 B |
     DictionarySameInstance | 2,899,734.48 ns | 15,364.5824 ns | 14,372.0399 ns |    207.0313 |    191.4063 |    101.5625 |           1084910 B |
     DictionaryDiffInstance | 3,808,480.47 ns | 10,314.1315 ns |  9,143.2090 ns |    253.9063 |    199.2188 |    101.5625 |           1404855 B |
