
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |          Mean |       Error |      StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|------------:|------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      34.78 ns |   0.0257 ns |   0.0227 ns |      0.0101 |           - |           - |                64 B |
             ObjectInstance |      56.12 ns |   0.0451 ns |   0.0422 ns |      0.0101 |           - |           - |                64 B |
            DefaultInstance |      22.74 ns |   0.0123 ns |   0.0109 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   9,622.78 ns |  11.3697 ns |  10.6353 ns |     12.6495 |           - |           - |             80024 B |
        ArrayOfDiffInstance | 529,598.36 ns | 441.6478 ns | 391.5093 ns |    114.2578 |     56.6406 |           - |            720024 B |
        ArrayOfSameInstance | 163,757.46 ns | 154.0522 ns | 144.1005 ns |     12.4512 |           - |           - |             80088 B |
 ArrayOfObjectsDiffInstance | 741,876.09 ns | 903.0299 ns | 800.5125 ns |    114.2578 |     56.6406 |           - |            720024 B |
 ArrayOfObjectsSameInstance | 195,743.13 ns |  91.7447 ns |  76.6110 ns |     12.4512 |           - |           - |             80088 B |
      Array2dOfDiffInstance | 539,611.48 ns | 579.0927 ns | 541.6837 ns |    114.2578 |     44.9219 |           - |            723224 B |
      Array2dOfSameInstance |   7,370.44 ns |   5.7238 ns |   4.7796 ns |      1.2741 |      0.0305 |           - |              8048 B |
   ArrayRank2OfDiffInstance |   4,807.35 ns |   4.9900 ns |   4.6676 ns |      1.1444 |      0.0229 |           - |              7240 B |
   ArrayRank2OfSameInstance |   2,258.98 ns |   2.4344 ns |   2.2772 ns |      0.1411 |           - |           - |               904 B |
   ArrayRank3OfDiffInstance | 148,153.37 ns | 118.6863 ns | 111.0192 ns |     11.2305 |      1.7090 |           - |             72168 B |
   ArrayRank3OfSameInstance |  69,341.04 ns |  56.7869 ns |  53.1185 ns |      1.2207 |           - |           - |              8232 B |
         ListOfDiffInstance | 517,639.41 ns | 395.9041 ns | 370.3289 ns |    114.2578 |     56.6406 |           - |            720064 B |
         ListOfSameInstance | 157,977.67 ns | 156.5938 ns | 138.8163 ns |     12.4512 |      1.9531 |           - |             80128 B |
  ListOfObjectsDiffInstance | 758,124.39 ns | 734.0874 ns | 612.9962 ns |    114.2578 |     56.6406 |           - |            720064 B |
  ListOfObjectsSameInstance | 203,658.90 ns | 163.9332 ns | 153.3432 ns |     12.4512 |      1.9531 |           - |             80128 B |
           KeyValuePairSame |     153.95 ns |   0.2679 ns |   0.2506 ns |      0.0203 |           - |           - |               128 B |
           KeyValuePairDiff |     159.86 ns |   0.1589 ns |   0.1487 ns |      0.0203 |           - |           - |               128 B |
          TupleSameInstance |     162.83 ns |   0.1168 ns |   0.1092 ns |      0.0253 |           - |           - |               160 B |
          TupleDiffInstance |     161.35 ns |   0.1387 ns |   0.1229 ns |      0.0253 |           - |           - |               160 B |
     DictionarySameInstance |            NA |          NA |          NA |           - |           - |           - |                   - |
     DictionaryDiffInstance |            NA |          NA |          NA |           - |           - |           - |                   - |

Benchmarks with issues:
  SimpleClassDeepCopy.DictionarySameInstance: DefaultJob
  SimpleClassDeepCopy.DictionaryDiffInstance: DefaultJob
