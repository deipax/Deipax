
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


     Method |      Mean |    Error |    StdDev |    Median |  Gen 0 | Allocated |
----------- |----------:|---------:|----------:|----------:|-------:|----------:|
 Primitives |  55.76 ns | 1.206 ns |  3.198 ns |  54.05 ns | 0.0050 |      32 B |
    Classes | 215.10 ns | 4.450 ns | 11.246 ns | 213.69 ns | 0.0226 |     144 B |
    Structs |  69.16 ns | 1.418 ns |  1.793 ns |  68.11 ns | 0.0151 |      96 B |
      Nulls | 183.79 ns | 3.696 ns |  9.992 ns | 183.58 ns | 0.0050 |      32 B |
