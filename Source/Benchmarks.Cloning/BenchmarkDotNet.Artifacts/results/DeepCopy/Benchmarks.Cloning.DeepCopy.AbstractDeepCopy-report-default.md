
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                      Method |       Mean |     Error |   StdDev |     Median |  Gen 0 |  Gen 1 | Allocated |
---------------------------- |-----------:|----------:|---------:|-----------:|-------:|-------:|----------:|
        IRealOnlyList_String | 1,114.6 ns | 26.638 ns | 77.70 ns | 1,107.0 ns | 1.3103 | 0.0343 |    8256 B |
 GrandChildClass_AsInterface |   153.7 ns |  3.563 ns | 10.45 ns |   153.7 ns | 0.0520 |      - |     328 B |
     IRealOnlyList_Interface |   431.1 ns |  8.972 ns | 23.79 ns |   422.5 ns | 0.0277 |      - |     176 B |
