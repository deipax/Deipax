
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      27.01 ns |     0.0277 ns |     0.0246 ns |           - |           - |           - |                   - |
             ObjectInstance |      46.80 ns |     0.4337 ns |     0.3845 ns |           - |           - |           - |                   - |
            DefaultInstance |      21.24 ns |     0.1157 ns |     0.0966 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   5,150.24 ns |    70.7081 ns |    66.1404 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfDiffInstance |   5,437.99 ns |    74.3777 ns |    69.5730 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfSameInstance |   5,214.69 ns |    65.2409 ns |    61.0264 ns |     12.6572 |           - |           - |             80024 B |
 ArrayOfObjectsDiffInstance | 638,278.94 ns | 6,887.6727 ns | 6,442.7333 ns |     11.7188 |           - |           - |             80024 B |
 ArrayOfObjectsSameInstance | 201,376.60 ns | 1,570.9311 ns | 1,469.4499 ns |     12.4512 |           - |           - |             80024 B |
      Array2dOfDiffInstance |  16,226.87 ns |   190.4281 ns |   178.1265 ns |     13.2141 |      2.5024 |           - |             83224 B |
      Array2dOfSameInstance |   2,676.84 ns |    27.4321 ns |    24.3179 ns |      0.2594 |           - |           - |              1648 B |
   ArrayRank2OfDiffInstance |     237.48 ns |     2.6248 ns |     2.4552 ns |      0.1330 |           - |           - |               840 B |
   ArrayRank2OfSameInstance |     245.40 ns |     4.6083 ns |     4.3106 ns |      0.1330 |           - |           - |               840 B |
   ArrayRank3OfDiffInstance | 140,446.63 ns |   253.7744 ns |   211.9131 ns |      1.2207 |           - |           - |              8168 B |
   ArrayRank3OfSameInstance |  70,887.14 ns |    92.3831 ns |    81.8952 ns |      1.2207 |           - |           - |              8168 B |
         ListOfDiffInstance |   6,156.27 ns |    86.7379 ns |    81.1347 ns |     12.6572 |      2.1057 |           - |             80064 B |
         ListOfSameInstance |   5,760.10 ns |     4.7478 ns |     3.9646 ns |     12.6572 |      2.1057 |           - |             80064 B |
  ListOfObjectsDiffInstance | 643,304.79 ns |   609.0208 ns |   569.6785 ns |     11.7188 |      1.9531 |           - |             80064 B |
  ListOfObjectsSameInstance | 195,490.32 ns |   149.9542 ns |   132.9305 ns |     12.4512 |      1.9531 |           - |             80064 B |
           KeyValuePairSame |      41.11 ns |     0.0324 ns |     0.0303 ns |           - |           - |           - |                   - |
           KeyValuePairDiff |      40.97 ns |     0.0283 ns |     0.0265 ns |           - |           - |           - |                   - |
          TupleSameInstance |      77.94 ns |     0.0688 ns |     0.0644 ns |      0.0050 |           - |           - |                32 B |
          TupleDiffInstance |      77.37 ns |     0.0714 ns |     0.0633 ns |      0.0050 |           - |           - |                32 B |
     DictionarySameInstance | 184,299.30 ns | 2,661.7843 ns | 2,489.8347 ns |     19.5313 |      9.7656 |      8.5449 |            490736 B |
     DictionaryDiffInstance | 184,754.08 ns | 3,354.9851 ns | 3,138.2552 ns |     21.4844 |     11.7188 |     10.4980 |            490746 B |
