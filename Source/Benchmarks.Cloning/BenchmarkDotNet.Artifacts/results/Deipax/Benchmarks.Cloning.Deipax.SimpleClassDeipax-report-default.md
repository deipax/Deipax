
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |            Mean |           Error |         StdDev |          Median |    Gen 0 |    Gen 1 |   Gen 2 | Allocated |
--------------------------- |----------------:|----------------:|---------------:|----------------:|---------:|---------:|--------:|----------:|
             SingleInstance |       110.71 ns |       2.2527 ns |       5.974 ns |       109.46 ns |   0.0101 |        - |       - |      64 B |
             ObjectInstance |       138.40 ns |       2.9642 ns |       6.444 ns |       134.97 ns |   0.0100 |        - |       - |      64 B |
            DefaultInstance |        32.27 ns |       0.7002 ns |       2.054 ns |        32.13 ns |        - |        - |       - |       0 B |
     ArrayOfDefaultInstance |     9,293.10 ns |     251.7771 ns |     738.419 ns |     9,120.65 ns |  12.6495 |        - |       - |   80024 B |
        ArrayOfDiffInstance |   781,279.49 ns |  16,478.5707 ns |  48,068.764 ns |   779,946.19 ns | 113.2813 |  41.9922 |       - |  720024 B |
        ArrayOfSameInstance |   327,012.68 ns |   7,232.9293 ns |  21,098.794 ns |   317,629.93 ns |  12.2070 |        - |       - |   80088 B |
 ArrayOfObjectsDiffInstance | 1,075,400.74 ns |  16,585.3846 ns |  13,849.546 ns | 1,082,887.59 ns | 113.2813 |  41.9922 |       - |  720024 B |
 ArrayOfObjectsSameInstance |   625,176.46 ns |  13,556.2378 ns |  39,970.873 ns |   622,971.68 ns |  11.7188 |        - |       - |   80088 B |
      Array2dOfDiffInstance |   986,680.95 ns |  29,590.1996 ns |  86,782.933 ns |   983,615.16 ns | 114.2578 |  44.9219 |       - |  723224 B |
      Array2dOfSameInstance |    11,166.36 ns |     221.1752 ns |     641.669 ns |    11,111.82 ns |   1.2665 |   0.0305 |       - |    8048 B |
   ArrayRank2OfDiffInstance |     9,336.04 ns |     251.6079 ns |     741.871 ns |     9,283.36 ns |   1.1444 |   0.0229 |       - |    7240 B |
   ArrayRank2OfSameInstance |     4,077.89 ns |     111.5320 ns |     328.855 ns |     4,012.42 ns |   0.1373 |        - |       - |     904 B |
   ArrayRank3OfDiffInstance |   186,822.49 ns |   5,034.8966 ns |  14,845.506 ns |   184,351.58 ns |  11.2305 |   1.7090 |       - |   72168 B |
   ArrayRank3OfSameInstance |   140,749.15 ns |   3,251.9777 ns |   4,766.707 ns |   138,453.26 ns |   1.2207 |        - |       - |    8232 B |
         ListOfDiffInstance |   939,127.70 ns |  18,682.5750 ns |  45,475.970 ns |   937,146.29 ns | 113.2813 |  41.9922 |       - |  720064 B |
         ListOfSameInstance |   329,293.40 ns |   7,613.2330 ns |  22,447.789 ns |   326,953.56 ns |  12.2070 |   1.9531 |       - |   80128 B |
  ListOfObjectsDiffInstance | 1,074,955.22 ns |  24,811.6398 ns |  72,768.245 ns | 1,085,170.04 ns | 113.2813 |  42.9688 |       - |  720064 B |
  ListOfObjectsSameInstance |   637,082.48 ns |  13,073.0218 ns |  37,927.207 ns |   637,951.50 ns |  11.7188 |   1.9531 |       - |   80128 B |
           KeyValuePairSame |       195.21 ns |       3.8760 ns |      10.869 ns |       194.20 ns |   0.0150 |        - |       - |      96 B |
           KeyValuePairDiff |       217.68 ns |       4.4348 ns |      13.006 ns |       215.71 ns |   0.0253 |        - |       - |     160 B |
          TupleSameInstance |       198.90 ns |       3.9864 ns |      10.502 ns |       197.72 ns |   0.0150 |        - |       - |      96 B |
          TupleDiffInstance |       239.69 ns |       5.0179 ns |      14.637 ns |       237.63 ns |   0.0253 |        - |       - |     160 B |
     DictionarySameInstance | 3,618,239.03 ns |  84,423.8131 ns | 248,925.518 ns | 3,642,219.25 ns | 162.2656 | 123.2031 | 60.7031 |  923115 B |
     DictionaryDiffInstance | 6,054,373.66 ns | 159,259.2875 ns | 469,579.602 ns | 6,042,419.88 ns | 265.7031 | 171.7188 | 62.5000 | 1563088 B |
