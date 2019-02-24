
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       146.73 ns |      0.2007 ns |      0.1877 ns |      0.0150 |           - |           - |                96 B |
             ObjectInstance |       166.99 ns |      0.1694 ns |      0.1584 ns |      0.0150 |           - |           - |                96 B |
            DefaultInstance |        21.18 ns |      0.0100 ns |      0.0089 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |     7,332.14 ns |     14.2749 ns |     13.3528 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfDiffInstance | 1,363,960.21 ns |  7,183.2806 ns |  6,719.2451 ns |    164.0625 |     64.4531 |           - |           1040024 B |
        ArrayOfSameInstance |   249,009.93 ns |    204.3052 ns |    191.1072 ns |     12.2070 |           - |           - |             80120 B |
 ArrayOfObjectsDiffInstance | 1,570,657.40 ns | 23,014.0549 ns | 21,527.3613 ns |    164.0625 |     64.4531 |           - |           1040024 B |
 ArrayOfObjectsSameInstance |   430,411.20 ns |    265.0463 ns |    234.9566 ns |     12.2070 |           - |           - |             80120 B |
      Array2dOfDiffInstance | 1,404,755.42 ns |  1,395.9736 ns |  1,305.7945 ns |    164.0625 |     64.4531 |           - |           1043224 B |
      Array2dOfSameInstance |    14,346.07 ns |     14.7413 ns |     13.7890 ns |      1.7853 |      0.0610 |           - |             11248 B |
   ArrayRank2OfDiffInstance |    11,645.55 ns |     12.6001 ns |     11.7861 ns |      1.6479 |      0.0458 |           - |             10440 B |
   ArrayRank2OfSameInstance |     3,128.23 ns |     28.3270 ns |     26.4970 ns |      0.1450 |           - |           - |               936 B |
   ArrayRank3OfDiffInstance |   197,285.08 ns |    138.4817 ns |    129.5359 ns |     16.3574 |      3.1738 |           - |            104168 B |
   ArrayRank3OfSameInstance |    98,688.54 ns |    113.5769 ns |     88.6734 ns |      1.2207 |           - |           - |              8264 B |
         ListOfDiffInstance | 1,383,649.97 ns |  3,156.3914 ns |  2,798.0587 ns |    164.0625 |     64.4531 |           - |           1040064 B |
         ListOfSameInstance |   249,308.40 ns |    174.6858 ns |    145.8705 ns |     12.2070 |      1.9531 |           - |             80160 B |
  ListOfObjectsDiffInstance | 1,563,453.46 ns |  1,398.3491 ns |  1,239.6000 ns |    164.0625 |     64.4531 |           - |           1040064 B |
  ListOfObjectsSameInstance |   432,633.83 ns |    297.3515 ns |    278.1428 ns |     12.2070 |      1.9531 |           - |             80160 B |
           KeyValuePairSame |       192.15 ns |      0.2197 ns |      0.1715 ns |      0.0150 |           - |           - |                96 B |
           KeyValuePairDiff |       270.94 ns |      0.1757 ns |      0.1558 ns |      0.0300 |           - |           - |               192 B |
          TupleSameInstance |       207.60 ns |      0.1983 ns |      0.1855 ns |      0.0203 |           - |           - |               128 B |
          TupleDiffInstance |       286.97 ns |      0.5052 ns |      0.4219 ns |      0.0353 |           - |           - |               224 B |
     DictionarySameInstance | 3,049,816.72 ns |  7,629.9768 ns |  7,137.0850 ns |    195.3125 |    101.5625 |     42.9688 |           1243075 B |
     DictionaryDiffInstance | 5,777,273.60 ns |  5,042.4595 ns |  4,470.0090 ns |    367.1875 |    195.3125 |     62.5000 |           2203041 B |
