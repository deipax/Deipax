
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |     104.70 ns |     0.8581 ns |     0.8027 ns |      0.0050 |           - |           - |                32 B |
             ObjectInstance |      40.73 ns |     0.2340 ns |     0.2188 ns |           - |           - |           - |                   - |
            DefaultInstance |      26.75 ns |     0.1197 ns |     0.1120 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |  26,259.54 ns |   359.7588 ns |   336.5186 ns |     36.1633 |     36.1633 |     36.1633 |            240024 B |
        ArrayOfDiffInstance |  25,864.69 ns |   301.9035 ns |   282.4007 ns |     35.9802 |     35.9802 |     35.9802 |            240024 B |
        ArrayOfSameInstance |  26,078.53 ns |   319.0422 ns |   298.4322 ns |     35.9802 |     35.9802 |     35.9802 |            240024 B |
 ArrayOfObjectsDiffInstance | 240,726.29 ns | 1,698.1181 ns | 1,505.3375 ns |     12.4512 |           - |           - |             80048 B |
 ArrayOfObjectsSameInstance | 237,121.29 ns |   968.9918 ns |   858.9860 ns |     12.4512 |           - |           - |             80048 B |
      Array2dOfDiffInstance |  33,186.85 ns |   277.4528 ns |   259.5295 ns |     38.6353 |     11.7798 |           - |            243290 B |
      Array2dOfSameInstance |  10,203.05 ns |    46.3622 ns |    43.3673 ns |      0.5035 |           - |           - |              3248 B |
   ArrayRank2OfDiffInstance |     487.35 ns |     3.3231 ns |     2.9458 ns |      0.3872 |           - |           - |              2440 B |
   ArrayRank2OfSameInstance |     494.06 ns |     3.8951 ns |     3.4529 ns |      0.3872 |           - |           - |              2440 B |
   ArrayRank3OfDiffInstance |   2,329.07 ns |    16.1623 ns |    15.1182 ns |      3.8147 |           - |           - |             24103 B |
   ArrayRank3OfSameInstance |   2,266.29 ns |    20.6949 ns |    19.3581 ns |      3.8147 |           - |           - |             24103 B |
         ListOfDiffInstance |  25,989.22 ns |   337.0741 ns |   315.2993 ns |     36.6211 |     36.5601 |     36.5601 |            240361 B |
         ListOfSameInstance |  25,937.24 ns |   201.3817 ns |   188.3726 ns |     35.7361 |     35.7056 |     35.7056 |            240358 B |
  ListOfObjectsDiffInstance | 266,452.80 ns | 2,386.5312 ns | 2,232.3628 ns |     12.2070 |      1.9531 |           - |             80152 B |
  ListOfObjectsSameInstance | 258,928.56 ns | 1,914.8634 ns | 1,791.1644 ns |     12.2070 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |      45.45 ns |     0.3561 ns |     0.3331 ns |      0.0101 |           - |           - |                64 B |
           KeyValuePairDiff |      46.74 ns |     0.3205 ns |     0.2998 ns |      0.0101 |           - |           - |                64 B |
          TupleSameInstance |      89.19 ns |     0.5748 ns |     0.5377 ns |      0.0101 |           - |           - |                64 B |
          TupleDiffInstance |      92.22 ns |     0.6623 ns |     0.6195 ns |      0.0101 |           - |           - |                64 B |
     DictionarySameInstance | 778,682.62 ns | 8,099.7537 ns | 7,576.5147 ns |    197.2656 |    158.2031 |    140.6250 |            927105 B |
     DictionaryDiffInstance | 777,416.18 ns | 5,581.6304 ns | 5,221.0606 ns |    197.2656 |    159.1797 |    140.6250 |            927046 B |
