
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |            Mean |           Error |          StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|----------------:|----------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       163.16 ns |       1.5291 ns |       1.4304 ns |      0.0100 |           - |           - |                64 B |
             ObjectInstance |       176.69 ns |       2.3630 ns |       2.2104 ns |      0.0100 |           - |           - |                64 B |
            DefaultInstance |        57.23 ns |       0.4607 ns |       0.4309 ns |      0.0051 |           - |           - |                32 B |
     ArrayOfDefaultInstance |   637,960.45 ns |   8,609.4228 ns |   7,632.0290 ns |     90.8203 |     40.0391 |     40.0391 |            480195 B |
        ArrayOfDiffInstance | 2,183,636.59 ns |  43,238.4641 ns |  40,445.2861 ns |    132.8125 |     85.9375 |     39.0625 |            800178 B |
        ArrayOfSameInstance |   983,116.00 ns |  29,161.8751 ns |  85,984.4467 ns |     89.8438 |     39.0625 |     39.0625 |            480235 B |
 ArrayOfObjectsDiffInstance | 1,427,150.92 ns |  11,570.3795 ns |  10,256.8400 ns |    113.2813 |     54.6875 |           - |            720039 B |
 ArrayOfObjectsSameInstance |   714,425.88 ns |   3,437.9853 ns |   3,047.6845 ns |     63.4766 |     23.4375 |           - |            400065 B |
      Array2dOfDiffInstance | 1,241,905.85 ns |   9,193.1185 ns |   8,599.2488 ns |    126.9531 |     50.7813 |           - |            803231 B |
      Array2dOfSameInstance |    19,469.72 ns |     147.6392 ns |     138.1018 ns |      1.4038 |           - |           - |              8848 B |
   ArrayRank2OfDiffInstance |    11,676.35 ns |      67.7725 ns |      63.3944 ns |      1.2665 |      0.0153 |           - |              8040 B |
   ArrayRank2OfSameInstance |     5,506.71 ns |      27.5768 ns |      25.7953 ns |      0.7706 |           - |           - |              4872 B |
   ArrayRank3OfDiffInstance |   265,164.85 ns |   1,188.6620 ns |   1,111.8752 ns |     17.5781 |      1.9531 |           - |            112169 B |
   ArrayRank3OfSameInstance |   199,351.05 ns |   1,740.6565 ns |   1,628.2112 ns |     12.6953 |      0.4883 |           - |             80201 B |
         ListOfDiffInstance | 2,219,311.95 ns |  19,100.6824 ns |  17,866.7902 ns |    132.8125 |     82.0313 |     39.0625 |            800252 B |
         ListOfSameInstance | 1,060,264.76 ns |  26,260.2454 ns |  77,428.9260 ns |     89.8438 |     39.0625 |     39.0625 |            480219 B |
  ListOfObjectsDiffInstance | 1,585,302.11 ns |   8,186.4496 ns |   7,657.6100 ns |    113.2813 |     54.6875 |           - |            720069 B |
  ListOfObjectsSameInstance |   754,537.48 ns |   6,361.9189 ns |   5,950.9429 ns |     63.4766 |     23.4375 |           - |            400105 B |
           KeyValuePairSame |       253.24 ns |       2.2924 ns |       2.1444 ns |      0.0224 |           - |           - |               144 B |
           KeyValuePairDiff |       305.83 ns |       1.3302 ns |       1.1108 ns |      0.0277 |           - |           - |               176 B |
          TupleSameInstance |       260.65 ns |       2.1169 ns |       1.8765 ns |      0.0224 |           - |           - |               144 B |
          TupleDiffInstance |       318.12 ns |       2.6287 ns |       2.3302 ns |      0.0277 |           - |           - |               176 B |
     DictionarySameInstance | 4,015,447.14 ns |  85,393.3656 ns | 135,442.9270 ns |    312.5000 |    210.9375 |    105.4688 |           1730392 B |
     DictionaryDiffInstance | 5,894,274.65 ns | 115,904.8911 ns | 162,482.4698 ns |    328.1250 |    195.3125 |     85.9375 |           2049823 B |
