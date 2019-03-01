
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3324.0


                     Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             SingleInstance | 177.8 ns | 1.0176 ns | 0.9519 ns |      0.0100 |           - |           - |                64 B |
             ObjectInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
            DefaultInstance | 113.2 ns | 0.6998 ns | 0.6546 ns |      0.0050 |           - |           - |                32 B |
     ArrayOfDefaultInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
        ArrayOfDiffInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
        ArrayOfSameInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
 ArrayOfObjectsDiffInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
 ArrayOfObjectsSameInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
      Array2dOfDiffInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
      Array2dOfSameInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
   ArrayRank2OfDiffInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
   ArrayRank2OfSameInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
   ArrayRank3OfDiffInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
   ArrayRank3OfSameInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
         ListOfDiffInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
         ListOfSameInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
  ListOfObjectsDiffInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
  ListOfObjectsSameInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
           KeyValuePairSame |       NA |        NA |        NA |           - |           - |           - |                   - |
           KeyValuePairDiff |       NA |        NA |        NA |           - |           - |           - |                   - |
          TupleSameInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
          TupleDiffInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
     DictionarySameInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
     DictionaryDiffInstance |       NA |        NA |        NA |           - |           - |           - |                   - |

Benchmarks with issues:
  ComplexStructDeepCopy.ObjectInstance: DefaultJob
  ComplexStructDeepCopy.ArrayOfDefaultInstance: DefaultJob
  ComplexStructDeepCopy.ArrayOfDiffInstance: DefaultJob
  ComplexStructDeepCopy.ArrayOfSameInstance: DefaultJob
  ComplexStructDeepCopy.ArrayOfObjectsDiffInstance: DefaultJob
  ComplexStructDeepCopy.ArrayOfObjectsSameInstance: DefaultJob
  ComplexStructDeepCopy.Array2dOfDiffInstance: DefaultJob
  ComplexStructDeepCopy.Array2dOfSameInstance: DefaultJob
  ComplexStructDeepCopy.ArrayRank2OfDiffInstance: DefaultJob
  ComplexStructDeepCopy.ArrayRank2OfSameInstance: DefaultJob
  ComplexStructDeepCopy.ArrayRank3OfDiffInstance: DefaultJob
  ComplexStructDeepCopy.ArrayRank3OfSameInstance: DefaultJob
  ComplexStructDeepCopy.ListOfDiffInstance: DefaultJob
  ComplexStructDeepCopy.ListOfSameInstance: DefaultJob
  ComplexStructDeepCopy.ListOfObjectsDiffInstance: DefaultJob
  ComplexStructDeepCopy.ListOfObjectsSameInstance: DefaultJob
  ComplexStructDeepCopy.KeyValuePairSame: DefaultJob
  ComplexStructDeepCopy.KeyValuePairDiff: DefaultJob
  ComplexStructDeepCopy.TupleSameInstance: DefaultJob
  ComplexStructDeepCopy.TupleDiffInstance: DefaultJob
  ComplexStructDeepCopy.DictionarySameInstance: DefaultJob
  ComplexStructDeepCopy.DictionaryDiffInstance: DefaultJob
