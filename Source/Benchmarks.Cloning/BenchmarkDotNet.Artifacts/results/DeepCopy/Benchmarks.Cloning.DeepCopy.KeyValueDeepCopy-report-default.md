
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


     Method |      Mean |    Error |    StdDev |  Gen 0 | Allocated |
----------- |----------:|---------:|----------:|-------:|----------:|
 Primitives |  57.72 ns | 1.180 ns |  3.347 ns | 0.0050 |      32 B |
    Classes | 222.15 ns | 4.506 ns | 10.078 ns | 0.0226 |     144 B |
    Structs |  80.30 ns | 1.639 ns |  4.051 ns | 0.0151 |      96 B |
      Nulls | 192.18 ns | 4.297 ns | 12.671 ns | 0.0050 |      32 B |
