
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                      Method |       Mean |     Error |   StdDev |  Gen 0 |  Gen 1 | Allocated |
---------------------------- |-----------:|----------:|---------:|-------:|-------:|----------:|
        IRealOnlyList_String | 1,152.6 ns | 31.267 ns | 91.70 ns | 1.2798 | 0.0324 |    8064 B |
 GrandChildClass_AsInterface |   210.8 ns |  6.445 ns | 19.00 ns | 0.0520 |      - |     328 B |
     IRealOnlyList_Interface |   503.4 ns | 14.807 ns | 43.66 ns | 0.0248 |      - |     160 B |
