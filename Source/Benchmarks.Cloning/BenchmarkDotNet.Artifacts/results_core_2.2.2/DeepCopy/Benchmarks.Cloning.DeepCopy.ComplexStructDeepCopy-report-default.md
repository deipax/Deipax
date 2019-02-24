
BenchmarkDotNet=v0.11.4, OS=Windows 10.0.17763.316 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), 64bit RyuJIT


                     Method |     Mean |     Error |    StdDev | Gen 0/1k Op | Gen 1/1k Op | Gen 2/1k Op | Allocated Memory/Op |
--------------------------- |---------:|----------:|----------:|------------:|------------:|------------:|--------------------:|
             SingleInstance | 167.8 ns | 0.3214 ns | 0.2509 ns |      0.0050 |           - |           - |                32 B |
             ObjectInstance |       NA |        NA |        NA |           - |           - |           - |                   - |
            DefaultInstance | 112.1 ns | 0.0490 ns | 0.0435 ns |           - |           - |           - |                   - |
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
