
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |        84.18 ns |      0.0647 ns |      0.0540 ns |      0.0101 |           - |           - |                64 B |
             ObjectInstance |       105.82 ns |      0.1526 ns |      0.1353 ns |      0.0101 |           - |           - |                64 B |
            DefaultInstance |        24.28 ns |      0.0338 ns |      0.0316 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |    11,932.48 ns |     17.3923 ns |     15.4178 ns |     12.6495 |           - |           - |             80024 B |
        ArrayOfDiffInstance |   529,154.39 ns |    623.1563 ns |    552.4118 ns |    114.2578 |     56.6406 |           - |            720024 B |
        ArrayOfSameInstance |   249,693.57 ns |    405.2078 ns |    379.0317 ns |     12.2070 |           - |           - |             80088 B |
 ArrayOfObjectsDiffInstance |   735,553.53 ns |    678.1567 ns |    601.1682 ns |    114.2578 |     56.6406 |           - |            720024 B |
 ArrayOfObjectsSameInstance |   447,897.46 ns |  2,133.2929 ns |  1,995.4835 ns |     12.2070 |           - |           - |             80088 B |
      Array2dOfDiffInstance |   545,947.71 ns |    751.6757 ns |    703.1179 ns |    114.2578 |     44.9219 |           - |            723224 B |
      Array2dOfSameInstance |     7,798.13 ns |     14.0214 ns |     11.7085 ns |      1.2665 |      0.0305 |           - |              8048 B |
   ArrayRank2OfDiffInstance |     4,873.61 ns |      5.9198 ns |      5.2478 ns |      1.1444 |      0.0229 |           - |              7240 B |
   ArrayRank2OfSameInstance |     3,003.83 ns |      4.8190 ns |      4.5077 ns |      0.1411 |           - |           - |               904 B |
   ArrayRank3OfDiffInstance |   126,130.72 ns |    121.2060 ns |    113.3762 ns |     11.2305 |      1.7090 |           - |             72168 B |
   ArrayRank3OfSameInstance |   101,167.05 ns |     78.7087 ns |     69.7732 ns |      1.2207 |           - |           - |              8232 B |
         ListOfDiffInstance |   526,992.38 ns |    669.1756 ns |    625.9472 ns |    114.2578 |     56.6406 |           - |            720064 B |
         ListOfSameInstance |   250,653.05 ns |    396.3867 ns |    351.3865 ns |     12.2070 |      1.9531 |           - |             80128 B |
  ListOfObjectsDiffInstance |   727,197.75 ns |    689.0785 ns |    644.5645 ns |    114.2578 |     56.6406 |           - |            720064 B |
  ListOfObjectsSameInstance |   431,503.62 ns |    407.0842 ns |    360.8695 ns |     12.2070 |      1.9531 |           - |             80128 B |
           KeyValuePairSame |       127.25 ns |      0.1473 ns |      0.1378 ns |      0.0100 |           - |           - |                64 B |
           KeyValuePairDiff |       138.69 ns |      0.2754 ns |      0.2576 ns |      0.0203 |           - |           - |               128 B |
          TupleSameInstance |       147.46 ns |      0.1274 ns |      0.1192 ns |      0.0150 |           - |           - |                96 B |
          TupleDiffInstance |       160.22 ns |      0.1181 ns |      0.1105 ns |      0.0253 |           - |           - |               160 B |
     DictionarySameInstance | 1,773,668.37 ns | 30,721.4785 ns | 28,736.8901 ns |    175.7813 |    138.6719 |     68.3594 |            923114 B |
     DictionaryDiffInstance | 2,894,479.14 ns | 14,504.8496 ns | 13,567.8453 ns |    265.6250 |    179.6875 |     62.5000 |           1563074 B |
