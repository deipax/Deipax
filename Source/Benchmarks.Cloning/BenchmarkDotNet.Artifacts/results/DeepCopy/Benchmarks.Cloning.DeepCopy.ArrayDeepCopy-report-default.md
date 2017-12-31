
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


              Method |       Mean |      Error |     StdDev |     Median |  Gen 0 |  Gen 1 | Allocated |
-------------------- |-----------:|-----------:|-----------:|-----------:|-------:|-------:|----------:|
            IntArray |   139.1 ns |   2.818 ns |   8.266 ns |   134.6 ns | 0.0100 |      - |      64 B |
           ByteArray |   203.1 ns |   4.169 ns |  10.148 ns |   197.4 ns | 0.1626 |      - |    1024 B |
         StringArray |   153.4 ns |   3.404 ns |   9.931 ns |   151.4 ns | 0.0165 |      - |     104 B |
       TimeSpanArray |   135.8 ns |   1.774 ns |   1.481 ns |   135.3 ns | 0.0165 |      - |     104 B |
       DateTimeArray |   147.9 ns |   3.611 ns |  10.591 ns |   148.7 ns | 0.0165 |      - |     104 B |
       DelegateArray |   538.0 ns |   2.571 ns |   2.007 ns |   538.0 ns | 0.0257 |      - |     168 B |
 ArrayOfStringArrays |   370.0 ns |   7.658 ns |  18.050 ns |   366.3 ns | 0.0186 |      - |     120 B |
      ArrayOfClasses | 6,218.3 ns | 122.750 ns | 214.986 ns | 6,186.8 ns | 1.0147 | 0.0153 |    6424 B |
       ArrayOfStruct |   463.5 ns |  11.840 ns |  34.725 ns |   462.0 ns | 0.6390 |      - |    4024 B |
