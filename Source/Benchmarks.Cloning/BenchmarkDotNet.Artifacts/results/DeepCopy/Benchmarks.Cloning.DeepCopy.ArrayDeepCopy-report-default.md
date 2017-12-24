
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


              Method |       Mean |      Error |    StdDev |     Median |  Gen 0 |  Gen 1 | Allocated |
-------------------- |-----------:|-----------:|----------:|-----------:|-------:|-------:|----------:|
            IntArray |   149.0 ns |   3.645 ns |  10.75 ns |   148.6 ns | 0.0100 |      - |      64 B |
           ByteArray |   226.6 ns |   4.798 ns |  14.15 ns |   225.4 ns | 0.1626 |      - |    1024 B |
         StringArray |   159.9 ns |   3.789 ns |  11.11 ns |   156.3 ns | 0.0165 |      - |     104 B |
       TimeSpanArray |   159.6 ns |   3.784 ns |  11.10 ns |   159.7 ns | 0.0165 |      - |     104 B |
       DateTimeArray |   156.9 ns |   3.837 ns |  11.31 ns |   156.1 ns | 0.0165 |      - |     104 B |
       DelegateArray |   620.0 ns |  16.829 ns |  49.62 ns |   616.7 ns | 0.0257 |      - |     168 B |
 ArrayOfStringArrays |   387.4 ns |   9.401 ns |  27.42 ns |   381.3 ns | 0.0186 |      - |     120 B |
      ArrayOfClasses | 6,657.7 ns | 150.792 ns | 444.61 ns | 6,648.2 ns | 1.0147 | 0.0153 |    6424 B |
       ArrayOfStruct |   484.9 ns |  12.631 ns |  37.24 ns |   479.5 ns | 0.6390 |      - |    4024 B |
