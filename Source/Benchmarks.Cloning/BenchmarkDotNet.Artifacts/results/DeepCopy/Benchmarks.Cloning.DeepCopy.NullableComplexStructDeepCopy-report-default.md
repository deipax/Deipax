
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |         Mean |        Error |       StdDev |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
--------------------------- |-------------:|-------------:|-------------:|--------:|--------:|--------:|----------:|
             SingleInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
            DefaultInstance |     63.22 ns |     1.831 ns |     5.370 ns |       - |       - |       - |       0 B |
     ArrayOfDefaultInstance | 41,891.48 ns | 2,566.006 ns | 7,565.928 ns | 10.3418 | 10.3418 | 10.3418 |  240024 B |
        ArrayOfDiffInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
        ArrayOfSameInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
 ArrayOfObjectsDiffInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
 ArrayOfObjectsSameInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
      Array2dOfDiffInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
      Array2dOfSameInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
   ArrayRank2OfDiffInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
   ArrayRank2OfSameInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
   ArrayRank3OfDiffInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
   ArrayRank3OfSameInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
         ListOfDiffInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
         ListOfSameInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
  ListOfObjectsDiffInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
  ListOfObjectsSameInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
           KeyValuePairSame |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
           KeyValuePairDiff |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
          TupleSameInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
          TupleDiffInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
     DictionarySameInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |
     DictionaryDiffInstance |           NA |           NA |           NA |     N/A |     N/A |     N/A |       N/A |

Benchmarks with issues:
  NullableComplexStructDeepCopy.SingleInstance: DefaultJob
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
