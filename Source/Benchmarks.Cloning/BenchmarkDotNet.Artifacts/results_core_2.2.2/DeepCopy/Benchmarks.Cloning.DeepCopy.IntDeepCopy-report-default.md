
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      28.14 ns |     0.1840 ns |     0.1537 ns |           - |           - |           - |                   - |
             ObjectInstance |      43.58 ns |     0.0288 ns |     0.0255 ns |           - |           - |           - |                   - |
            DefaultInstance |      24.61 ns |     0.0115 ns |     0.0107 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   2,533.04 ns |     9.3992 ns |     8.7920 ns |      6.3286 |           - |           - |             40024 B |
        ArrayOfDiffInstance |   2,459.40 ns |     4.4297 ns |     4.1436 ns |      6.3286 |           - |           - |             40024 B |
        ArrayOfSameInstance |   2,466.73 ns |     9.7647 ns |     9.1339 ns |      6.3286 |           - |           - |             40024 B |
 ArrayOfObjectsDiffInstance | 616,369.64 ns |   746.6023 ns |   698.3722 ns |     11.7188 |           - |           - |             80024 B |
 ArrayOfObjectsSameInstance | 615,555.89 ns |   377.4693 ns |   334.6167 ns |     11.7188 |           - |           - |             80024 B |
      Array2dOfDiffInstance |  11,846.50 ns |     9.1040 ns |     8.5159 ns |      6.8665 |      0.7629 |           - |             43224 B |
      Array2dOfSameInstance |   2,608.42 ns |    14.3321 ns |    13.4063 ns |      0.1945 |           - |           - |              1248 B |
   ArrayRank2OfDiffInstance |     202.48 ns |     0.0900 ns |     0.0842 ns |      0.0699 |           - |           - |               440 B |
   ArrayRank2OfSameInstance |     199.93 ns |     0.1785 ns |     0.1491 ns |      0.0699 |           - |           - |               440 B |
   ArrayRank3OfDiffInstance | 229,358.02 ns |   162.7166 ns |   152.2052 ns |      8.0566 |      0.4883 |           - |             52168 B |
   ArrayRank3OfSameInstance | 228,567.56 ns |   184.8638 ns |   172.9217 ns |      8.0566 |      0.4883 |           - |             52168 B |
         ListOfDiffInstance |   2,685.97 ns |     3.8100 ns |     3.3775 ns |      6.3667 |      0.6332 |           - |             40064 B |
         ListOfSameInstance |   2,755.57 ns |     2.9520 ns |     2.4650 ns |      6.3667 |      0.6332 |           - |             40064 B |
  ListOfObjectsDiffInstance | 618,387.82 ns | 1,157.4478 ns | 1,082.6774 ns |     11.7188 |      1.9531 |           - |             80064 B |
  ListOfObjectsSameInstance | 619,299.26 ns |   426.0275 ns |   398.5064 ns |     11.7188 |      1.9531 |           - |             80064 B |
           KeyValuePairSame |      27.79 ns |     0.0189 ns |     0.0177 ns |           - |           - |           - |                   - |
           KeyValuePairDiff |      33.72 ns |     0.0797 ns |     0.0707 ns |           - |           - |           - |                   - |
          TupleSameInstance |      71.19 ns |     0.0740 ns |     0.0692 ns |      0.0037 |           - |           - |                24 B |
          TupleDiffInstance |      77.40 ns |     0.0959 ns |     0.0897 ns |      0.0037 |           - |           - |                24 B |
     DictionarySameInstance | 144,409.61 ns |   131.2618 ns |   116.3602 ns |     83.2520 |     83.2520 |     83.2520 |            350536 B |
     DictionaryDiffInstance | 144,999.47 ns |   121.3378 ns |   113.4995 ns |     83.2520 |     83.2520 |     83.2520 |            350536 B |
