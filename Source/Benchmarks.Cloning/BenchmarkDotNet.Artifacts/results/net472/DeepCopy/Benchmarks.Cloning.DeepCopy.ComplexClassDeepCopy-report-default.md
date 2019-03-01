
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |            Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       101.28 ns |     0.7947 ns |     0.7433 ns |      0.0050 |           - |           - |                32 B |
             ObjectInstance |       125.68 ns |     1.1900 ns |     1.1132 ns |      0.0050 |           - |           - |                32 B |
            DefaultInstance |        22.93 ns |     0.1269 ns |     0.1125 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |     9,387.15 ns |    61.0739 ns |    54.1405 ns |     12.6495 |           - |           - |             80048 B |
        ArrayOfDiffInstance |   894,118.44 ns | 7,996.7563 ns | 7,480.1708 ns |     63.4766 |     23.4375 |           - |            400030 B |
        ArrayOfSameInstance |   151,918.37 ns | 1,156.6809 ns | 1,081.9600 ns |     12.4512 |           - |           - |             80152 B |
 ArrayOfObjectsDiffInstance | 1,076,604.59 ns | 8,340.3865 ns | 7,801.6027 ns |     62.5000 |     23.4375 |           - |            400030 B |
 ArrayOfObjectsSameInstance |   172,868.53 ns |   664.9863 ns |   622.0286 ns |     12.4512 |           - |           - |             80152 B |
      Array2dOfDiffInstance |   912,450.74 ns | 3,788.0007 ns | 3,543.2982 ns |     63.4766 |     24.4141 |           - |            403228 B |
      Array2dOfSameInstance |    11,880.52 ns |    71.2831 ns |    66.6782 ns |      0.7629 |           - |           - |              4848 B |
   ArrayRank2OfDiffInstance |     9,115.33 ns |    44.9545 ns |    39.8510 ns |      0.6409 |           - |           - |              4040 B |
   ArrayRank2OfSameInstance |     2,227.55 ns |    18.6143 ns |    17.4118 ns |      0.1373 |           - |           - |               872 B |
   ArrayRank3OfDiffInstance |   190,481.22 ns |   963.8592 ns |   901.5945 ns |      6.3477 |      0.4883 |           - |             40169 B |
   ArrayRank3OfSameInstance |    71,985.50 ns |   480.6484 ns |   449.5988 ns |      1.2207 |           - |           - |              8203 B |
         ListOfDiffInstance |   868,248.84 ns | 3,927.3002 ns | 3,673.5990 ns |     63.4766 |     23.4375 |           - |            400067 B |
         ListOfSameInstance |   151,265.29 ns |   716.6066 ns |   635.2531 ns |     12.4512 |      1.9531 |           - |             80152 B |
  ListOfObjectsDiffInstance | 1,070,556.43 ns | 6,130.1402 ns | 5,734.1370 ns |     62.5000 |     23.4375 |           - |            400080 B |
  ListOfObjectsSameInstance |   173,410.09 ns |   901.8285 ns |   799.4474 ns |     12.4512 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |       223.69 ns |     1.1547 ns |     1.0236 ns |      0.0100 |           - |           - |                64 B |
           KeyValuePairDiff |       257.15 ns |     1.2825 ns |     1.1996 ns |      0.0148 |           - |           - |                96 B |
          TupleSameInstance |       243.12 ns |     1.7251 ns |     1.6137 ns |      0.0100 |           - |           - |                64 B |
          TupleDiffInstance |       279.96 ns |     1.5477 ns |     1.4477 ns |      0.0148 |           - |           - |                96 B |
     DictionarySameInstance |              NA |            NA |            NA |           - |           - |           - |                   - |
     DictionaryDiffInstance |              NA |            NA |            NA |           - |           - |           - |                   - |

Benchmarks with issues:
  ComplexClassDeepCopy.DictionarySameInstance: DefaultJob
  ComplexClassDeepCopy.DictionaryDiffInstance: DefaultJob
