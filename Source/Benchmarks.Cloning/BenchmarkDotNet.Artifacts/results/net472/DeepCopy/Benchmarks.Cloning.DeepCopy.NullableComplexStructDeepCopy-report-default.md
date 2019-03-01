
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |         Mean |       Error |        StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |-------------:|------------:|--------------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
             ObjectInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
            DefaultInstance |     43.55 ns |   0.3767 ns |     0.3524 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance | 22,274.24 ns | 462.2853 ns | 1,363.0585 ns |      7.3853 |      7.3853 |      7.3853 |            240024 B |
        ArrayOfDiffInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
        ArrayOfSameInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
 ArrayOfObjectsDiffInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
 ArrayOfObjectsSameInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
      Array2dOfDiffInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
      Array2dOfSameInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
   ArrayRank2OfDiffInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
   ArrayRank2OfSameInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
   ArrayRank3OfDiffInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
   ArrayRank3OfSameInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
         ListOfDiffInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
         ListOfSameInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
  ListOfObjectsDiffInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
  ListOfObjectsSameInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
           KeyValuePairSame |           NA |          NA |            NA |           - |           - |           - |                   - |
           KeyValuePairDiff |           NA |          NA |            NA |           - |           - |           - |                   - |
          TupleSameInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
          TupleDiffInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
     DictionarySameInstance |           NA |          NA |            NA |           - |           - |           - |                   - |
     DictionaryDiffInstance |           NA |          NA |            NA |           - |           - |           - |                   - |

Benchmarks with issues:
  NullableComplexStructDeepCopy.SingleInstance: DefaultJob
  NullableComplexStructDeepCopy.ObjectInstance: DefaultJob
  NullableComplexStructDeepCopy.ArrayOfDiffInstance: DefaultJob
  NullableComplexStructDeepCopy.ArrayOfSameInstance: DefaultJob
  NullableComplexStructDeepCopy.ArrayOfObjectsDiffInstance: DefaultJob
  NullableComplexStructDeepCopy.ArrayOfObjectsSameInstance: DefaultJob
  NullableComplexStructDeepCopy.Array2dOfDiffInstance: DefaultJob
  NullableComplexStructDeepCopy.Array2dOfSameInstance: DefaultJob
  NullableComplexStructDeepCopy.ArrayRank2OfDiffInstance: DefaultJob
  NullableComplexStructDeepCopy.ArrayRank2OfSameInstance: DefaultJob
  NullableComplexStructDeepCopy.ArrayRank3OfDiffInstance: DefaultJob
  NullableComplexStructDeepCopy.ArrayRank3OfSameInstance: DefaultJob
  NullableComplexStructDeepCopy.ListOfDiffInstance: DefaultJob
  NullableComplexStructDeepCopy.ListOfSameInstance: DefaultJob
  NullableComplexStructDeepCopy.ListOfObjectsDiffInstance: DefaultJob
  NullableComplexStructDeepCopy.ListOfObjectsSameInstance: DefaultJob
  NullableComplexStructDeepCopy.KeyValuePairSame: DefaultJob
  NullableComplexStructDeepCopy.KeyValuePairDiff: DefaultJob
  NullableComplexStructDeepCopy.TupleSameInstance: DefaultJob
  NullableComplexStructDeepCopy.TupleDiffInstance: DefaultJob
  NullableComplexStructDeepCopy.DictionarySameInstance: DefaultJob
  NullableComplexStructDeepCopy.DictionaryDiffInstance: DefaultJob
