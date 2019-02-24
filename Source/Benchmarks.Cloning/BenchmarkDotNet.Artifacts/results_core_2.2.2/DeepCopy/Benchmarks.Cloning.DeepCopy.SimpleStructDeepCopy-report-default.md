
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      28.53 ns |     0.0539 ns |     0.0478 ns |           - |           - |           - |                   - |
             ObjectInstance |      50.48 ns |     0.0256 ns |     0.0239 ns |           - |           - |           - |                   - |
            DefaultInstance |      31.66 ns |     0.0216 ns |     0.0202 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |  20,170.07 ns |   376.6524 ns |   352.3209 ns |     36.0413 |     36.0413 |     36.0413 |            160024 B |
        ArrayOfDiffInstance |  19,275.92 ns |   189.4247 ns |   158.1782 ns |     36.0107 |     36.0107 |     36.0107 |            160024 B |
        ArrayOfSameInstance |  21,609.43 ns |   431.6972 ns |   684.7174 ns |     35.2783 |     35.2783 |     35.2783 |            160024 B |
 ArrayOfObjectsDiffInstance | 621,359.51 ns |   792.1391 ns |   740.9674 ns |     11.7188 |           - |           - |             80024 B |
 ArrayOfObjectsSameInstance | 626,158.59 ns |   438.8550 ns |   410.5052 ns |     11.7188 |           - |           - |             80024 B |
      Array2dOfDiffInstance |  20,359.44 ns |    15.4483 ns |    14.4504 ns |     25.9399 |      6.5002 |           - |            163224 B |
      Array2dOfSameInstance |   2,642.29 ns |     4.1410 ns |     3.8735 ns |      0.3853 |           - |           - |              2448 B |
   ArrayRank2OfDiffInstance |     255.40 ns |     0.2056 ns |     0.1823 ns |      0.2604 |           - |           - |              1640 B |
   ArrayRank2OfSameInstance |     261.53 ns |     0.1364 ns |     0.1276 ns |      0.2604 |           - |           - |              1640 B |
   ArrayRank3OfDiffInstance | 245,900.74 ns |   722.2000 ns |   675.5463 ns |     12.6953 |      1.4648 |           - |             80168 B |
   ArrayRank3OfSameInstance | 247,062.94 ns |   198.2225 ns |   175.7191 ns |     12.6953 |      1.4648 |           - |             80168 B |
         ListOfDiffInstance |  22,687.65 ns |   440.3310 ns |   411.8859 ns |     35.4004 |     35.3699 |     35.3699 |            160307 B |
         ListOfSameInstance |  20,841.77 ns |    92.9724 ns |    82.4176 ns |     35.6140 |     35.5835 |     35.5835 |            160295 B |
  ListOfObjectsDiffInstance | 622,882.21 ns |   448.1601 ns |   419.2092 ns |     11.7188 |      1.9531 |           - |             80064 B |
  ListOfObjectsSameInstance | 624,596.55 ns | 1,163.0699 ns |   971.2161 ns |     11.7188 |      1.9531 |           - |             80064 B |
           KeyValuePairSame |      37.12 ns |     0.0358 ns |     0.0335 ns |           - |           - |           - |                   - |
           KeyValuePairDiff |      37.61 ns |     0.0336 ns |     0.0298 ns |           - |           - |           - |                   - |
          TupleSameInstance |      82.06 ns |     0.0489 ns |     0.0434 ns |      0.0075 |           - |           - |                48 B |
          TupleDiffInstance |      80.50 ns |     0.0749 ns |     0.0626 ns |      0.0075 |           - |           - |                48 B |
     DictionarySameInstance |  94,817.43 ns | 1,887.0727 ns | 3,854.7894 ns |    143.1885 |    132.5684 |    131.8359 |            771497 B |
     DictionaryDiffInstance |  94,116.63 ns | 1,391.7027 ns | 1,301.7995 ns |    151.9775 |    141.3574 |    140.5029 |            771559 B |
