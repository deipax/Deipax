
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |            Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       262.02 ns |      1.5255 ns |      1.3524 ns |      0.0100 |           - |           - |                64 B |
             ObjectInstance |       180.56 ns |      1.4464 ns |      1.3530 ns |      0.0100 |           - |           - |                64 B |
            DefaultInstance |        46.07 ns |      0.1727 ns |      0.1616 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |    22,204.17 ns |    520.4313 ns |  1,534.5034 ns |      7.9041 |      7.9041 |      7.9041 |            240024 B |
        ArrayOfDiffInstance | 2,789,767.71 ns | 29,594.3956 ns | 27,682.6160 ns |    148.4375 |    105.4688 |     50.7813 |            880364 B |
        ArrayOfSameInstance | 1,476,348.42 ns |  6,838.0499 ns |  6,396.3161 ns |    109.3750 |     58.5938 |     58.5938 |            560495 B |
 ArrayOfObjectsDiffInstance | 1,447,987.63 ns |  7,176.0206 ns |  6,712.4541 ns |    113.2813 |     54.6875 |           - |            720042 B |
 ArrayOfObjectsSameInstance |   715,634.00 ns |  2,898.4778 ns |  2,420.3603 ns |     63.4766 |     23.4375 |           - |            400058 B |
      Array2dOfDiffInstance | 2,169,350.00 ns | 12,557.0481 ns | 11,745.8706 ns |    136.7188 |     39.0625 |           - |            883248 B |
      Array2dOfSameInstance |    31,120.08 ns |    210.9648 ns |    197.3366 ns |      1.5259 |           - |           - |              9648 B |
   ArrayRank2OfDiffInstance |    20,949.66 ns |    135.6617 ns |    126.8980 ns |      1.4038 |           - |           - |              8840 B |
   ArrayRank2OfSameInstance |    14,590.01 ns |     87.5261 ns |     77.5896 ns |      0.9003 |           - |           - |              5672 B |
   ArrayRank3OfDiffInstance |   289,159.82 ns |  1,635.9414 ns |  1,450.2195 ns |     19.0430 |      2.4414 |           - |            120170 B |
   ArrayRank3OfSameInstance |   219,031.66 ns |  1,306.5974 ns |  1,222.1920 ns |     13.9160 |      0.9766 |           - |             88202 B |
         ListOfDiffInstance | 2,774,318.85 ns | 27,496.8826 ns | 25,720.6010 ns |    152.3438 |    105.4688 |     50.7813 |            880445 B |
         ListOfSameInstance | 1,513,468.07 ns |  9,539.9955 ns |  8,923.7177 ns |    109.3750 |     58.5938 |     58.5938 |            560478 B |
  ListOfObjectsDiffInstance | 1,461,851.28 ns |  7,371.9949 ns |  6,895.7686 ns |    113.2813 |     54.6875 |           - |            720067 B |
  ListOfObjectsSameInstance |   742,162.99 ns |  5,136.6839 ns |  4,804.8573 ns |     63.4766 |     23.4375 |           - |            400104 B |
           KeyValuePairSame |       458.69 ns |      2.1959 ns |      2.0541 ns |      0.0253 |           - |           - |               160 B |
           KeyValuePairDiff |       508.24 ns |      3.6400 ns |      3.2268 ns |      0.0296 |           - |           - |               192 B |
          TupleSameInstance |       457.69 ns |      1.7990 ns |      1.5022 ns |      0.0253 |           - |           - |               160 B |
          TupleDiffInstance |       523.77 ns |      4.3949 ns |      4.1110 ns |      0.0296 |           - |           - |               192 B |
     DictionarySameInstance | 6,050,019.69 ns | 53,583.9039 ns | 50,122.4170 ns |    320.3125 |    234.3750 |    117.1875 |           1892435 B |
     DictionaryDiffInstance | 7,014,696.46 ns | 95,630.2013 ns | 89,452.5497 ns |    359.3750 |    226.5625 |    109.3750 |           2208145 B |
