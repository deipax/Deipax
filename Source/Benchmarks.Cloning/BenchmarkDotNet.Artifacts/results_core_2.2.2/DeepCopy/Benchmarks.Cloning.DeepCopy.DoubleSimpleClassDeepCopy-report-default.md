
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |            Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       113.17 ns |     0.0908 ns |     0.0805 ns |      0.0254 |           - |           - |               160 B |
             ObjectInstance |       138.82 ns |     0.0901 ns |     0.0842 ns |      0.0253 |           - |           - |               160 B |
            DefaultInstance |        27.16 ns |     0.0183 ns |     0.0171 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |     7,364.90 ns |     8.5395 ns |     7.9879 ns |     12.6572 |           - |           - |             80024 B |
        ArrayOfDiffInstance | 1,272,313.95 ns | 1,017.1632 ns |   849.3773 ns |    265.6250 |    132.8125 |           - |           1680024 B |
        ArrayOfSameInstance |   157,777.61 ns |    97.9532 ns |    91.6254 ns |     12.4512 |           - |           - |             80184 B |
 ArrayOfObjectsDiffInstance | 1,528,871.25 ns | 1,311.3308 ns | 1,226.6196 ns |    265.6250 |    132.8125 |           - |           1680024 B |
 ArrayOfObjectsSameInstance |   192,661.44 ns |   201.3283 ns |   188.3227 ns |     12.4512 |           - |           - |             80184 B |
      Array2dOfDiffInstance | 1,330,285.05 ns | 1,197.1397 ns |   934.6479 ns |    265.6250 |    132.8125 |           - |           1683224 B |
      Array2dOfSameInstance |    12,562.19 ns |     6.0032 ns |     5.6154 ns |      2.7924 |      0.1526 |           - |             17648 B |
   ArrayRank2OfDiffInstance |    10,145.67 ns |    10.2144 ns |     7.9747 ns |      2.6703 |      0.1221 |           - |             16840 B |
   ArrayRank2OfSameInstance |     2,237.03 ns |     4.3076 ns |     4.0293 ns |      0.1564 |           - |           - |              1000 B |
   ArrayRank3OfDiffInstance |   207,952.04 ns |   116.4221 ns |   108.9013 ns |     26.6113 |      7.0801 |           - |            168168 B |
   ArrayRank3OfSameInstance |    70,552.95 ns |    35.8486 ns |    29.9352 ns |      1.2207 |           - |           - |              8328 B |
         ListOfDiffInstance | 1,290,057.64 ns | 2,533.7236 ns | 2,370.0466 ns |    265.6250 |    132.8125 |           - |           1680064 B |
         ListOfSameInstance |   158,847.02 ns |    98.6240 ns |    92.2529 ns |     12.4512 |      1.9531 |           - |             80224 B |
  ListOfObjectsDiffInstance | 1,578,211.78 ns | 1,523.3791 ns | 1,350.4359 ns |    265.6250 |    132.8125 |           - |           1680064 B |
  ListOfObjectsSameInstance |   191,907.87 ns |   248.3151 ns |   232.2741 ns |     12.4512 |      1.9531 |           - |             80224 B |
           KeyValuePairSame |       220.74 ns |     0.1089 ns |     0.0965 ns |      0.0253 |           - |           - |               160 B |
           KeyValuePairDiff |       269.16 ns |     0.3212 ns |     0.3004 ns |      0.0505 |           - |           - |               320 B |
          TupleSameInstance |       220.88 ns |     0.1055 ns |     0.0987 ns |      0.0303 |           - |           - |               192 B |
          TupleDiffInstance |       266.05 ns |     2.7121 ns |     2.5369 ns |      0.0558 |           - |           - |               352 B |
     DictionarySameInstance |              NA |            NA |            NA |           - |           - |           - |                   - |
     DictionaryDiffInstance |              NA |            NA |            NA |           - |           - |           - |                   - |

Benchmarks with issues:
  DoubleSimpleClassDeepCopy.DictionarySameInstance: DefaultJob
  DoubleSimpleClassDeepCopy.DictionaryDiffInstance: DefaultJob
