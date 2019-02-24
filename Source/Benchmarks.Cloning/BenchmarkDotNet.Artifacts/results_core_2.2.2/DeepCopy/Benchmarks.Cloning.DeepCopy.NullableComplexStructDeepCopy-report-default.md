
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |         Mean |      Error |     StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |-------------:|-----------:|-----------:|------------:|------------:|------------:|--------------------:|
             SingleInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
             ObjectInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
            DefaultInstance |     41.38 ns |  0.0526 ns |  0.0492 ns |           - |           - |           - |                   - |
     ArrayOfDefaultInstance | 27,081.87 ns | 66.7971 ns | 55.7786 ns |     12.8174 |     12.8174 |     12.8174 |            240024 B |
        ArrayOfDiffInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
        ArrayOfSameInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
 ArrayOfObjectsDiffInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
 ArrayOfObjectsSameInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
      Array2dOfDiffInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
      Array2dOfSameInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
   ArrayRank2OfDiffInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
   ArrayRank2OfSameInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
   ArrayRank3OfDiffInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
   ArrayRank3OfSameInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
         ListOfDiffInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
         ListOfSameInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
  ListOfObjectsDiffInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
  ListOfObjectsSameInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
           KeyValuePairSame |           NA |         NA |         NA |           - |           - |           - |                   - |
           KeyValuePairDiff |           NA |         NA |         NA |           - |           - |           - |                   - |
          TupleSameInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
          TupleDiffInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
     DictionarySameInstance |           NA |         NA |         NA |           - |           - |           - |                   - |
     DictionaryDiffInstance |           NA |         NA |         NA |           - |           - |           - |                   - |

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
