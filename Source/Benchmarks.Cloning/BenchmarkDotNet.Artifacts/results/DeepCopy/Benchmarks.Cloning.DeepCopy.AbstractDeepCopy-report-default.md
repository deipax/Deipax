
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                      Method |       Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
---------------------------- |-----------:|----------:|----------:|-------:|-------:|----------:|
        IRealOnlyList_String | 1,238.1 ns | 41.361 ns | 118.67 ns | 1.3103 | 0.0343 |    8256 B |
 GrandChildClass_AsInterface |   164.9 ns |  4.189 ns |  12.29 ns | 0.0520 |      - |     328 B |
     IRealOnlyList_Interface |   436.6 ns |  8.826 ns |  19.92 ns | 0.0277 |      - |     176 B |
