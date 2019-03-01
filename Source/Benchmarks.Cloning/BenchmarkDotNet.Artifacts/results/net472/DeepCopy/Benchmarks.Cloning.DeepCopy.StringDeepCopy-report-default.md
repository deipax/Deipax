
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      33.49 ns |     0.2972 ns |     0.2780 ns |           - |           - |           - |                   - |
             ObjectInstance |      54.05 ns |     0.4769 ns |     0.4461 ns |           - |           - |           - |                   - |
            DefaultInstance |      24.33 ns |     0.2244 ns |     0.1989 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   6,204.73 ns |    72.3525 ns |    67.6785 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfDiffInstance |   5,945.77 ns |    57.6326 ns |    51.0898 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfSameInstance |   6,055.63 ns |   114.4975 ns |   101.4991 ns |     12.6572 |           - |           - |             80048 B |
 ArrayOfObjectsDiffInstance | 580,376.98 ns | 7,042.0283 ns | 6,242.5747 ns |     11.7188 |           - |           - |             80048 B |
 ArrayOfObjectsSameInstance | 173,349.40 ns |   652.1709 ns |   610.0411 ns |     12.4512 |           - |           - |             80048 B |
      Array2dOfDiffInstance |  18,530.03 ns |   111.3415 ns |   104.1489 ns |     13.2141 |      2.6245 |           - |             83229 B |
      Array2dOfSameInstance |   3,370.28 ns |    18.2718 ns |    17.0914 ns |      0.2594 |           - |           - |              1648 B |
   ArrayRank2OfDiffInstance |     356.59 ns |     4.0345 ns |     3.7739 ns |      0.1330 |           - |           - |               840 B |
   ArrayRank2OfSameInstance |     357.43 ns |     6.0103 ns |     5.6220 ns |      0.1330 |           - |           - |               840 B |
   ArrayRank3OfDiffInstance | 135,894.79 ns |   822.6173 ns |   769.4767 ns |      1.2207 |           - |           - |              8172 B |
   ArrayRank3OfSameInstance |  70,996.88 ns |   317.0817 ns |   296.5984 ns |      1.2207 |           - |           - |              8171 B |
         ListOfDiffInstance |   6,467.43 ns |    25.4541 ns |    23.8098 ns |     12.6572 |      2.1057 |           - |             80152 B |
         ListOfSameInstance |   6,384.35 ns |    20.6023 ns |    18.2634 ns |     12.6572 |      2.1057 |           - |             80152 B |
  ListOfObjectsDiffInstance | 572,280.74 ns | 2,598.6358 ns | 2,430.7655 ns |     11.7188 |      1.9531 |           - |             80152 B |
  ListOfObjectsSameInstance | 172,189.65 ns |   937.4310 ns |   876.8735 ns |     12.4512 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |      57.17 ns |     0.1976 ns |     0.1848 ns |      0.0050 |           - |           - |                32 B |
           KeyValuePairDiff |      55.70 ns |     0.3838 ns |     0.3402 ns |      0.0051 |           - |           - |                32 B |
          TupleSameInstance |     102.44 ns |     0.5798 ns |     0.5423 ns |      0.0050 |           - |           - |                32 B |
          TupleDiffInstance |      97.86 ns |     0.6025 ns |     0.5636 ns |      0.0050 |           - |           - |                32 B |
     DictionarySameInstance | 163,786.82 ns | 3,170.0406 ns | 3,113.4038 ns |     26.8555 |     16.6016 |     15.8691 |            491095 B |
     DictionaryDiffInstance | 162,298.14 ns | 1,389.9770 ns | 1,300.1853 ns |     30.7617 |     20.2637 |     19.7754 |            491203 B |
