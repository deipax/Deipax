
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


              Method |       Mean |      Error |    StdDev |     Median |  Gen 0 |  Gen 1 | Allocated |
-------------------- |-----------:|-----------:|----------:|-----------:|-------:|-------:|----------:|
            IntArray |   156.9 ns |   6.426 ns |  18.64 ns |   152.0 ns | 0.0100 |      - |      64 B |
           ByteArray |   245.9 ns |   8.804 ns |  25.82 ns |   242.2 ns | 0.1626 |      - |    1024 B |
         StringArray |   171.8 ns |   4.074 ns |  11.62 ns |   171.6 ns | 0.0165 |      - |     104 B |
       TimeSpanArray |   166.9 ns |   5.191 ns |  15.14 ns |   165.6 ns | 0.0165 |      - |     104 B |
       DateTimeArray |   157.8 ns |   4.743 ns |  13.99 ns |   156.4 ns | 0.0165 |      - |     104 B |
       DelegateArray |   170.2 ns |   4.903 ns |  14.30 ns |   167.8 ns | 0.0165 |      - |     104 B |
 ArrayOfStringArrays |   349.3 ns |  10.368 ns |  30.41 ns |   346.8 ns | 0.0186 |      - |     120 B |
      ArrayOfClasses | 7,043.2 ns | 185.749 ns | 541.84 ns | 7,015.4 ns | 1.0071 | 0.0153 |    6424 B |
       ArrayOfStruct |   486.4 ns |  20.029 ns |  59.05 ns |   468.0 ns | 0.6390 |      - |    4024 B |
