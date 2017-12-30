
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                      Method |       Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Allocated |
---------------------------- |-----------:|----------:|----------:|-------:|-------:|----------:|
        IRealOnlyList_String | 1,068.3 ns | 25.713 ns | 74.597 ns | 1.2798 | 0.0324 |    8064 B |
 GrandChildClass_AsInterface |   182.8 ns |  3.672 ns |  6.896 ns | 0.0520 |      - |     328 B |
     IRealOnlyList_Interface |   532.8 ns | 17.021 ns | 50.187 ns | 0.0253 |      - |     160 B |
