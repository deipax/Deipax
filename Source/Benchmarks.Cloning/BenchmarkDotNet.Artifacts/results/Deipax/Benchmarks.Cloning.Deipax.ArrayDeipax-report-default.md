
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


              Method |       Mean |      Error |     StdDev |     Median |  Gen 0 |  Gen 1 | Allocated |
-------------------- |-----------:|-----------:|-----------:|-----------:|-------:|-------:|----------:|
            IntArray |   148.8 ns |   3.912 ns |  11.412 ns |   147.0 ns | 0.0100 |      - |      64 B |
           ByteArray |   252.5 ns |   6.916 ns |  20.175 ns |   252.7 ns | 0.1626 |      - |    1024 B |
         StringArray |   166.1 ns |   4.139 ns |  12.203 ns |   162.1 ns | 0.0165 |      - |     104 B |
       TimeSpanArray |   149.7 ns |   3.540 ns |  10.381 ns |   149.0 ns | 0.0165 |      - |     104 B |
       DateTimeArray |   156.2 ns |   4.475 ns |  13.195 ns |   156.8 ns | 0.0165 |      - |     104 B |
       DelegateArray |   155.6 ns |   3.148 ns |   7.295 ns |   152.3 ns | 0.0165 |      - |     104 B |
 ArrayOfStringArrays |   344.1 ns |   9.080 ns |  26.772 ns |   341.5 ns | 0.0186 |      - |     120 B |
      ArrayOfClasses | 6,402.1 ns | 151.151 ns | 445.673 ns | 6,373.3 ns | 1.0147 | 0.0153 |    6424 B |
       ArrayOfStruct |   495.7 ns |  15.171 ns |  44.732 ns |   489.5 ns | 0.6390 |      - |    4024 B |
