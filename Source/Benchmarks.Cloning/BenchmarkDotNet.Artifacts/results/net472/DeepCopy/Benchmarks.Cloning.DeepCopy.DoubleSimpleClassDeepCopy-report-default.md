
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |            Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       112.58 ns |     1.0742 ns |     1.0048 ns |      0.0253 |           - |           - |               160 B |
             ObjectInstance |       134.42 ns |     0.7492 ns |     0.7008 ns |      0.0253 |           - |           - |               160 B |
            DefaultInstance |        23.51 ns |     0.0960 ns |     0.0898 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |     7,103.80 ns |    27.2873 ns |    24.1895 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfDiffInstance | 1,209,959.36 ns | 6,878.6257 ns | 6,434.2708 ns |    265.6250 |    132.8125 |           - |           1680046 B |
        ArrayOfSameInstance |   153,642.50 ns |   796.1854 ns |   744.7523 ns |     12.4512 |           - |           - |             80256 B |
 ArrayOfObjectsDiffInstance | 1,421,602.30 ns | 9,186.2322 ns | 8,143.3556 ns |    265.6250 |    132.8125 |           - |           1680046 B |
 ArrayOfObjectsSameInstance |   172,301.38 ns | 1,279.4006 ns | 1,134.1553 ns |     12.4512 |           - |           - |             80256 B |
      Array2dOfDiffInstance | 1,259,735.56 ns | 5,189.6811 ns | 4,854.4310 ns |    265.6250 |    132.8125 |           - |           1683253 B |
      Array2dOfSameInstance |    12,624.41 ns |    68.7071 ns |    64.2687 ns |      2.7924 |      0.1526 |           - |             17648 B |
   ArrayRank2OfDiffInstance |     9,975.05 ns |    42.1932 ns |    37.4031 ns |      2.6703 |      0.1221 |           - |             16840 B |
   ArrayRank2OfSameInstance |     2,218.65 ns |    11.5864 ns |    10.8380 ns |      0.1564 |           - |           - |              1000 B |
   ArrayRank3OfDiffInstance |   201,860.36 ns | 1,166.3224 ns | 1,090.9787 ns |     26.6113 |      7.0801 |           - |            168169 B |
   ArrayRank3OfSameInstance |    71,729.65 ns |   313.3108 ns |   293.0711 ns |      1.2207 |           - |           - |              8333 B |
         ListOfDiffInstance | 1,203,264.75 ns | 5,703.9029 ns | 5,335.4343 ns |    265.6250 |    132.8125 |           - |           1680091 B |
         ListOfSameInstance |   151,172.87 ns |   869.4044 ns |   813.2414 ns |     12.4512 |      1.9531 |           - |             80256 B |
  ListOfObjectsDiffInstance | 1,406,410.08 ns | 9,632.0721 ns | 9,009.8462 ns |    265.6250 |    132.8125 |           - |           1680091 B |
  ListOfObjectsSameInstance |   173,022.98 ns |   703.8756 ns |   658.4057 ns |     12.4512 |      1.9531 |           - |             80256 B |
           KeyValuePairSame |       232.21 ns |     1.0304 ns |     0.9638 ns |      0.0303 |           - |           - |               192 B |
           KeyValuePairDiff |       286.53 ns |     2.2260 ns |     2.0822 ns |      0.0558 |           - |           - |               352 B |
          TupleSameInstance |       249.39 ns |     1.6014 ns |     1.4979 ns |      0.0300 |           - |           - |               192 B |
          TupleDiffInstance |       296.78 ns |     2.4287 ns |     2.2718 ns |      0.0558 |           - |           - |               352 B |
     DictionarySameInstance |              NA |            NA |            NA |           - |           - |           - |                   - |
     DictionaryDiffInstance |              NA |            NA |            NA |           - |           - |           - |                   - |

Benchmarks with issues:
  DoubleSimpleClassDeepCopy.DictionarySameInstance: DefaultJob
  DoubleSimpleClassDeepCopy.DictionaryDiffInstance: DefaultJob
