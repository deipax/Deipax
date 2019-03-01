
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |            Mean |          Error |         StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |----------------:|---------------:|---------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |       197.42 ns |      1.7997 ns |      1.6835 ns |      0.0150 |           - |           - |                96 B |
             ObjectInstance |       215.98 ns |      1.1189 ns |      0.9918 ns |      0.0150 |           - |           - |                96 B |
            DefaultInstance |        23.77 ns |      0.1523 ns |      0.1425 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance |     7,050.07 ns |     38.6629 ns |     36.1653 ns |     12.6572 |           - |           - |             80048 B |
        ArrayOfDiffInstance | 1,741,688.35 ns | 11,438.8951 ns | 10,699.9496 ns |    164.0625 |     64.4531 |           - |           1040046 B |
        ArrayOfSameInstance |   295,491.07 ns |  1,656.2943 ns |  1,549.2987 ns |     12.2070 |           - |           - |             80152 B |
 ArrayOfObjectsDiffInstance | 2,059,389.09 ns | 11,270.8957 ns | 10,542.8028 ns |    164.0625 |     66.4063 |           - |           1040057 B |
 ArrayOfObjectsSameInstance |   563,987.79 ns |  5,577.6219 ns |  4,657.5669 ns |     11.7188 |           - |           - |             80152 B |
      Array2dOfDiffInstance | 1,796,238.92 ns |  9,392.3090 ns |  8,785.5717 ns |    164.0625 |     64.4531 |           - |           1043245 B |
      Array2dOfSameInstance |    23,189.18 ns |    180.1596 ns |    168.5214 ns |      1.7700 |      0.0610 |           - |             11248 B |
   ArrayRank2OfDiffInstance |    16,058.02 ns |    100.0159 ns |     93.5549 ns |      1.6479 |      0.0305 |           - |             10440 B |
   ArrayRank2OfSameInstance |     3,691.17 ns |     13.0997 ns |     11.6126 ns |      0.1450 |           - |           - |               936 B |
   ArrayRank3OfDiffInstance |   245,466.01 ns |  1,157.8337 ns |  1,026.3894 ns |     16.1133 |      2.9297 |           - |            104171 B |
   ArrayRank3OfSameInstance |   114,248.28 ns |    729.2948 ns |    682.1828 ns |      1.2207 |           - |           - |              8268 B |
         ListOfDiffInstance | 1,792,683.94 ns |  8,656.4393 ns |  7,673.7080 ns |    164.0625 |     64.4531 |           - |           1040084 B |
         ListOfSameInstance |   319,106.55 ns |  2,270.8194 ns |  2,124.1259 ns |     12.2070 |      1.9531 |           - |             80252 B |
  ListOfObjectsDiffInstance | 2,091,896.09 ns | 17,702.1396 ns | 16,558.5923 ns |    164.0625 |     66.4063 |           - |           1040080 B |
  ListOfObjectsSameInstance |   574,852.41 ns |  5,373.9035 ns |  5,026.7527 ns |     11.7188 |      1.9531 |           - |             80256 B |
           KeyValuePairSame |       273.23 ns |      2.6286 ns |      2.4588 ns |      0.0200 |           - |           - |               128 B |
           KeyValuePairDiff |       402.19 ns |      2.3292 ns |      2.1787 ns |      0.0353 |           - |           - |               224 B |
          TupleSameInstance |       283.52 ns |      1.3296 ns |      1.2437 ns |      0.0200 |           - |           - |               128 B |
          TupleDiffInstance |       390.30 ns |      1.4166 ns |      1.1829 ns |      0.0353 |           - |           - |               224 B |
     DictionarySameInstance | 3,889,425.10 ns | 59,676.2661 ns | 55,821.2163 ns |    195.3125 |    117.1875 |     46.8750 |           1243234 B |
     DictionaryDiffInstance | 6,905,607.86 ns | 82,854.3269 ns | 77,501.9888 ns |    367.1875 |    195.3125 |     62.5000 |           2203325 B |
