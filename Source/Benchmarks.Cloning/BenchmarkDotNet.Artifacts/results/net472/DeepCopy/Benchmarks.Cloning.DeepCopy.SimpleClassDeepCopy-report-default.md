
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |          Mean |         Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |--------------:|--------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |      38.48 ns |     0.1806 ns |     0.1508 ns |      0.0101 |           - |           - |                64 B |
             ObjectInstance |      57.05 ns |     0.1561 ns |     0.1384 ns |      0.0101 |           - |           - |                64 B |
            DefaultInstance |      30.53 ns |     0.1306 ns |     0.1222 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |   7,102.50 ns |    31.7095 ns |    29.6611 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfDiffInstance | 507,978.10 ns | 3,721.0753 ns | 3,480.6961 ns |    114.2578 |     56.6406 |           - |            720032 B |
        ArrayOfSameInstance | 148,545.40 ns |   718.8124 ns |   637.2084 ns |     12.4512 |           - |           - |             80152 B |
 ArrayOfObjectsDiffInstance | 712,344.30 ns | 2,821.1269 ns | 2,638.8839 ns |    114.2578 |     56.6406 |           - |            720033 B |
 ArrayOfObjectsSameInstance | 181,217.33 ns |   733.3725 ns |   650.1157 ns |     12.4512 |           - |           - |             80152 B |
      Array2dOfDiffInstance | 581,174.93 ns | 4,282.4445 ns | 4,005.8013 ns |    114.2578 |     44.9219 |           - |            723240 B |
      Array2dOfSameInstance |   7,684.16 ns |    44.7105 ns |    41.8222 ns |      1.2665 |      0.0305 |           - |              8048 B |
   ArrayRank2OfDiffInstance |   4,933.28 ns |    18.9529 ns |    17.7285 ns |      1.1444 |      0.0229 |           - |              7240 B |
   ArrayRank2OfSameInstance |   2,136.05 ns |    10.3301 ns |     9.6627 ns |      0.1411 |           - |           - |               904 B |
   ArrayRank3OfDiffInstance | 149,128.05 ns | 1,455.0970 ns | 1,361.0986 ns |     11.2305 |      1.7090 |           - |             72170 B |
   ArrayRank3OfSameInstance |  69,077.66 ns |   273.9124 ns |   228.7293 ns |      1.2207 |           - |           - |              8235 B |
         ListOfDiffInstance | 507,765.21 ns | 2,169.5301 ns | 1,811.6559 ns |    114.2578 |     56.6406 |           - |            720073 B |
         ListOfSameInstance | 149,607.28 ns |   840.5503 ns |   786.2513 ns |     12.4512 |      1.9531 |           - |             80152 B |
  ListOfObjectsDiffInstance | 684,942.88 ns | 3,117.3561 ns | 2,915.9769 ns |    114.2578 |     56.6406 |           - |            720075 B |
  ListOfObjectsSameInstance | 180,503.45 ns | 3,419.9026 ns | 2,855.7735 ns |     12.4512 |      1.9531 |           - |             80152 B |
           KeyValuePairSame |     169.69 ns |     1.0170 ns |     0.9016 ns |      0.0253 |           - |           - |               160 B |
           KeyValuePairDiff |     174.24 ns |     0.6292 ns |     0.5885 ns |      0.0253 |           - |           - |               160 B |
          TupleSameInstance |     196.01 ns |     0.9380 ns |     0.8774 ns |      0.0253 |           - |           - |               160 B |
          TupleDiffInstance |     190.96 ns |     1.1793 ns |     1.1031 ns |      0.0253 |           - |           - |               160 B |
     DictionarySameInstance |            NA |            NA |            NA |           - |           - |           - |                   - |
     DictionaryDiffInstance |            NA |            NA |            NA |           - |           - |           - |                   - |

Benchmarks with issues:
  SimpleClassDeepCopy.DictionarySameInstance: DefaultJob
  SimpleClassDeepCopy.DictionaryDiffInstance: DefaultJob
