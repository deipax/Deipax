
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                     Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
--------------------------- |---------:|---------:|---------:|-------:|----------:|
             SingleInstance | 283.4 ns | 6.662 ns | 18.90 ns | 0.0100 |      64 B |
            DefaultInstance | 162.2 ns | 4.219 ns | 12.31 ns | 0.0050 |      32 B |
     ArrayOfDefaultInstance |       NA |       NA |       NA |    N/A |       N/A |
        ArrayOfDiffInstance |       NA |       NA |       NA |    N/A |       N/A |
        ArrayOfSameInstance |       NA |       NA |       NA |    N/A |       N/A |
 ArrayOfObjectsDiffInstance |       NA |       NA |       NA |    N/A |       N/A |
 ArrayOfObjectsSameInstance |       NA |       NA |       NA |    N/A |       N/A |
      Array2dOfDiffInstance |       NA |       NA |       NA |    N/A |       N/A |
      Array2dOfSameInstance |       NA |       NA |       NA |    N/A |       N/A |
   ArrayRank2OfDiffInstance |       NA |       NA |       NA |    N/A |       N/A |
   ArrayRank2OfSameInstance |       NA |       NA |       NA |    N/A |       N/A |
   ArrayRank3OfDiffInstance |       NA |       NA |       NA |    N/A |       N/A |
   ArrayRank3OfSameInstance |       NA |       NA |       NA |    N/A |       N/A |
         ListOfDiffInstance |       NA |       NA |       NA |    N/A |       N/A |
         ListOfSameInstance |       NA |       NA |       NA |    N/A |       N/A |
  ListOfObjectsDiffInstance |       NA |       NA |       NA |    N/A |       N/A |
  ListOfObjectsSameInstance |       NA |       NA |       NA |    N/A |       N/A |
           KeyValuePairSame |       NA |       NA |       NA | 0.0219 |     144 B |
           KeyValuePairDiff |       NA |       NA |       NA |    N/A |       N/A |
          TupleSameInstance |       NA |       NA |       NA |    N/A |       N/A |
          TupleDiffInstance |       NA |       NA |       NA |    N/A |       N/A |
     DictionarySameInstance |       NA |       NA |       NA |    N/A |       N/A |
     DictionaryDiffInstance |       NA |       NA |       NA |    N/A |       N/A |

Benchmarks with issues:
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
