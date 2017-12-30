
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


     Method |      Mean |     Error |     StdDev |    Median |  Gen 0 | Allocated |
----------- |----------:|----------:|-----------:|----------:|-------:|----------:|
 Primitives | 101.19 ns | 0.2668 ns |  0.2228 ns | 101.19 ns | 0.0050 |      32 B |
    Classes | 211.92 ns | 4.2937 ns | 11.8977 ns | 211.44 ns | 0.0226 |     144 B |
    Structs |  89.00 ns | 1.8150 ns |  5.0294 ns |  89.12 ns | 0.0151 |      96 B |
      Nulls |  75.57 ns | 2.4867 ns |  7.2539 ns |  73.57 ns | 0.0050 |      32 B |
