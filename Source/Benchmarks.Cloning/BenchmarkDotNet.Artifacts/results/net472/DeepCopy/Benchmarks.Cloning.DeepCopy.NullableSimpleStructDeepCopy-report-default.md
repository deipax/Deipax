
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |     121.43 ns |     0.5661 ns |     0.5295 ns |      0.0050 |           - |           - |                32 B |
             ObjectInstance |      45.93 ns |     0.2802 ns |     0.2621 ns |           - |           - |           - |                   - |
            DefaultInstance |      27.81 ns |     0.0975 ns |     0.0912 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |  26,327.89 ns |   387.1107 ns |   362.1036 ns |     36.3159 |     36.3159 |     36.3159 |            240024 B |
        ArrayOfDiffInstance |  25,864.93 ns |   336.9852 ns |   315.2162 ns |     36.8652 |     36.8652 |     36.8652 |            240024 B |
        ArrayOfSameInstance |  26,039.55 ns |   262.7552 ns |   245.7814 ns |     36.4380 |     36.4380 |     36.4380 |            240024 B |
 ArrayOfObjectsDiffInstance | 562,658.10 ns | 5,202.8589 ns | 4,866.7574 ns |     11.7188 |           - |           - |             80048 B |
 ArrayOfObjectsSameInstance | 577,120.63 ns | 2,805.8638 ns | 2,624.6067 ns |     11.7188 |           - |           - |             80048 B |
      Array2dOfDiffInstance |  34,546.22 ns |   276.2414 ns |   258.3964 ns |     38.6353 |     11.7798 |           - |            243291 B |
      Array2dOfSameInstance |   3,519.39 ns |    13.4714 ns |    12.6011 ns |      0.5150 |           - |           - |              3248 B |
   ArrayRank2OfDiffInstance |     487.88 ns |     2.3724 ns |     2.2192 ns |      0.3872 |           - |           - |              2440 B |
   ArrayRank2OfSameInstance |     485.41 ns |     4.6761 ns |     4.3741 ns |      0.3872 |           - |           - |              2440 B |
   ArrayRank3OfDiffInstance | 290,584.53 ns | 1,790.2952 ns | 1,674.6432 ns |     13.6719 |      1.4648 |           - |             88171 B |
   ArrayRank3OfSameInstance | 290,871.20 ns | 1,368.0008 ns | 1,279.6288 ns |     13.6719 |      1.4648 |           - |             88171 B |
         ListOfDiffInstance |  26,427.77 ns |   309.3875 ns |   289.4013 ns |     35.6140 |     35.5835 |     35.5835 |            240355 B |
         ListOfSameInstance |  26,693.57 ns |   351.0247 ns |   328.3487 ns |     36.4990 |     36.4685 |     36.4685 |            240367 B |
  ListOfObjectsDiffInstance | 549,321.26 ns | 2,966.7864 ns | 2,629.9789 ns |     11.7188 |      1.9531 |           - |             80152 B |
  ListOfObjectsSameInstance | 552,659.35 ns | 2,313.7756 ns | 2,164.3072 ns |     11.7188 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |      38.82 ns |     0.1751 ns |     0.1638 ns |      0.0101 |           - |           - |                64 B |
           KeyValuePairDiff |      38.33 ns |     0.2461 ns |     0.2302 ns |      0.0101 |           - |           - |                64 B |
          TupleSameInstance |     126.48 ns |     0.6853 ns |     0.6410 ns |      0.0100 |           - |           - |                64 B |
          TupleDiffInstance |     126.08 ns |     0.6793 ns |     0.6355 ns |      0.0100 |           - |           - |                64 B |
     DictionarySameInstance | 120,919.67 ns | 1,426.5095 ns | 1,264.5635 ns |    119.6289 |    109.4971 |    108.1543 |           1054033 B |
     DictionaryDiffInstance | 120,730.50 ns | 2,403.2475 ns | 3,522.6491 ns |    119.6289 |    110.1074 |    108.1543 |           1053995 B |
