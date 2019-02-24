
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |            Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       102.41 ns |      0.0865 ns |      0.0767 ns |      0.0050 |           - |           - |                32 B |
             ObjectInstance |       122.09 ns |      0.1107 ns |      0.1036 ns |      0.0050 |           - |           - |                32 B |
            DefaultInstance |        21.04 ns |      0.0176 ns |      0.0164 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |     7,307.32 ns |     13.8354 ns |     12.9417 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfDiffInstance |   711,915.78 ns |    790.3649 ns |    739.3078 ns |     63.4766 |     23.4375 |           - |            400024 B |
        ArrayOfSameInstance |   248,257.88 ns |    216.2615 ns |    191.7101 ns |     12.2070 |           - |           - |             80056 B |
 ArrayOfObjectsDiffInstance |   903,943.95 ns |    946.3482 ns |    838.9130 ns |     63.4766 |     23.4375 |           - |            400024 B |
 ArrayOfObjectsSameInstance |   434,515.90 ns |  1,253.3106 ns |  1,172.3475 ns |     12.2070 |           - |           - |             80056 B |
      Array2dOfDiffInstance |   718,785.84 ns |  1,123.8718 ns |    996.2831 ns |     63.4766 |     24.4141 |           - |            403224 B |
      Array2dOfSameInstance |     9,775.84 ns |      9.6486 ns |      8.5532 ns |      0.7629 |           - |           - |              4848 B |
   ArrayRank2OfDiffInstance |     7,093.61 ns |      5.3293 ns |      4.9850 ns |      0.6409 |      0.0076 |           - |              4040 B |
   ArrayRank2OfSameInstance |     3,029.37 ns |      4.9701 ns |      4.6490 ns |      0.1373 |           - |           - |               872 B |
   ArrayRank3OfDiffInstance |   145,632.57 ns |    234.1592 ns |    219.0326 ns |      6.3477 |      0.4883 |           - |             40168 B |
   ArrayRank3OfSameInstance |    99,492.92 ns |     68.3184 ns |     63.9051 ns |      1.2207 |           - |           - |              8200 B |
         ListOfDiffInstance |   709,707.44 ns |    457.9718 ns |    405.9800 ns |     63.4766 |     23.4375 |           - |            400064 B |
         ListOfSameInstance |   254,096.07 ns |    776.9446 ns |    688.7412 ns |     12.2070 |      1.9531 |           - |             80096 B |
  ListOfObjectsDiffInstance |   901,470.92 ns |  2,414.4927 ns |  2,258.5180 ns |     63.4766 |     23.4375 |           - |            400064 B |
  ListOfObjectsSameInstance |   445,136.80 ns |  3,214.1020 ns |  2,849.2177 ns |     12.2070 |      1.9531 |           - |             80096 B |
           KeyValuePairSame |       155.95 ns |      0.1123 ns |      0.0995 ns |      0.0050 |           - |           - |                32 B |
           KeyValuePairDiff |       187.84 ns |      0.1776 ns |      0.1661 ns |      0.0100 |           - |           - |                64 B |
          TupleSameInstance |       161.71 ns |      0.1696 ns |      0.1586 ns |      0.0100 |           - |           - |                64 B |
          TupleDiffInstance |       196.61 ns |      0.0987 ns |      0.0924 ns |      0.0150 |           - |           - |                96 B |
     DictionarySameInstance | 1,665,727.77 ns | 23,229.6719 ns | 21,729.0495 ns |    126.9531 |    119.1406 |     70.3125 |            603166 B |
     DictionaryDiffInstance | 2,529,880.16 ns |  7,965.9974 ns |  7,451.3989 ns |    167.9688 |    128.9063 |     66.4063 |            923179 B |
