
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


     Method |      Mean |    Error |    StdDev |  Gen 0 | Allocated |
----------- |----------:|---------:|----------:|-------:|----------:|
 Primitives |  69.95 ns | 1.427 ns |  4.186 ns | 0.0050 |      32 B |
    Classes | 226.50 ns | 4.507 ns | 11.141 ns | 0.0226 |     144 B |
    Structs |  82.91 ns | 1.692 ns |  4.772 ns | 0.0151 |      96 B |
      Nulls |  89.12 ns | 2.988 ns |  8.811 ns | 0.0050 |      32 B |
