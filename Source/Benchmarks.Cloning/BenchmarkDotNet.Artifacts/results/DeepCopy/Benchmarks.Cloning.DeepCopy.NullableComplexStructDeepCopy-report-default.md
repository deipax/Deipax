
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |         Mean |        Error |       StdDev |       Median |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
--------------------------- |-------------:|-------------:|-------------:|-------------:|-------:|-------:|-------:|----------:|
             SingleInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
             ObjectInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
            DefaultInstance |     55.21 ns |     1.304 ns |     2.105 ns |     53.95 ns |      - |      - |      - |       0 B |
     ArrayOfDefaultInstance | 42,095.91 ns | 1,847.159 ns | 5,446.390 ns | 41,220.62 ns | 5.9290 | 5.9290 | 5.9290 |  240024 B |
        ArrayOfDiffInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
        ArrayOfSameInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
 ArrayOfObjectsDiffInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
 ArrayOfObjectsSameInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
      Array2dOfDiffInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
      Array2dOfSameInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
   ArrayRank2OfDiffInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
   ArrayRank2OfSameInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
   ArrayRank3OfDiffInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
   ArrayRank3OfSameInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
         ListOfDiffInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
         ListOfSameInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
  ListOfObjectsDiffInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
  ListOfObjectsSameInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
           KeyValuePairSame |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
           KeyValuePairDiff |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
          TupleSameInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
          TupleDiffInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
     DictionarySameInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |
     DictionaryDiffInstance |           NA |           NA |           NA |           NA |    N/A |    N/A |    N/A |       N/A |

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
