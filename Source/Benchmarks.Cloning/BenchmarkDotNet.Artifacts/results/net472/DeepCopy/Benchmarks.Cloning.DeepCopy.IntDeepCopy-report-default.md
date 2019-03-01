
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      29.51 ns |      0.4438 ns |      0.3706 ns |      0.0038 |           - |           - |                24 B |
             ObjectInstance |      72.26 ns |      1.4324 ns |      1.4710 ns |           - |           - |           - |                   - |
            DefaultInstance |      34.83 ns |      0.1042 ns |      0.0870 ns |      0.0038 |           - |           - |                24 B |
     ArrayOfDefaultInstance |   2,583.61 ns |     42.7807 ns |     37.9240 ns |      6.3286 |           - |           - |             40048 B |
        ArrayOfDiffInstance |   2,568.66 ns |     19.9930 ns |     16.6951 ns |      6.3286 |           - |           - |             40048 B |
        ArrayOfSameInstance |   2,575.19 ns |     48.4601 ns |     45.3296 ns |      6.3286 |           - |           - |             40048 B |
 ArrayOfObjectsDiffInstance | 841,758.56 ns |  4,056.0746 ns |  3,595.6045 ns |     11.7188 |           - |           - |             80048 B |
 ArrayOfObjectsSameInstance | 581,660.62 ns |  3,019.5605 ns |  2,676.7617 ns |     11.7188 |           - |           - |             80048 B |
      Array2dOfDiffInstance |  15,005.49 ns |    283.0444 ns |    314.6031 ns |      6.8665 |      0.7629 |           - |             43226 B |
      Array2dOfSameInstance |   3,537.75 ns |     28.9606 ns |     27.0898 ns |      0.1945 |           - |           - |              1248 B |
   ArrayRank2OfDiffInstance |     408.26 ns |      6.2535 ns |      5.8495 ns |      0.0696 |           - |           - |               440 B |
   ArrayRank2OfSameInstance |     413.76 ns |      3.5999 ns |      3.1912 ns |      0.0696 |           - |           - |               440 B |
   ArrayRank3OfDiffInstance | 293,126.34 ns |  4,152.5493 ns |  3,884.2972 ns |      7.8125 |      0.4883 |           - |             52170 B |
   ArrayRank3OfSameInstance | 259,709.41 ns |  1,400.1216 ns |  1,309.6746 ns |      7.8125 |      0.4883 |           - |             52170 B |
         ListOfDiffInstance |   2,769.24 ns |     34.2981 ns |     32.0825 ns |      6.3667 |      0.6332 |           - |             40100 B |
         ListOfSameInstance |   2,671.80 ns |     27.4526 ns |     25.6791 ns |      6.3667 |      0.6332 |           - |             40100 B |
  ListOfObjectsDiffInstance | 570,191.27 ns | 11,093.2036 ns | 11,869.6036 ns |     11.7188 |      1.9531 |           - |             80152 B |
  ListOfObjectsSameInstance | 564,954.86 ns |  5,938.5649 ns |  4,636.4408 ns |     11.7188 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |      29.59 ns |      0.6103 ns |      0.6530 ns |      0.0038 |           - |           - |                24 B |
           KeyValuePairDiff |      30.52 ns |      0.6310 ns |      0.5903 ns |      0.0038 |           - |           - |                24 B |
          TupleSameInstance |      95.53 ns |      0.5416 ns |      0.5066 ns |      0.0037 |           - |           - |                24 B |
          TupleDiffInstance |      97.73 ns |      0.0747 ns |      0.0699 ns |      0.0037 |           - |           - |                24 B |
     DictionarySameInstance | 143,306.23 ns |  2,802.4626 ns |  2,484.3101 ns |     83.2520 |     83.2520 |     83.2520 |            351140 B |
     DictionaryDiffInstance | 142,383.65 ns |  2,643.6425 ns |  2,596.4104 ns |     83.2520 |     83.2520 |     83.2520 |            351140 B |
