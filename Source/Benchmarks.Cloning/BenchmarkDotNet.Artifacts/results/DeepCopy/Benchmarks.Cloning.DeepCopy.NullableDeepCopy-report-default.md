
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


  Method |      Mean |     Error |   StdDev |  Gen 0 | Allocated |
-------- |----------:|----------:|---------:|-------:|----------:|
     Int | 160.28 ns | 3.3871 ns | 9.773 ns | 0.0036 |      24 B |
 NullInt |  33.84 ns | 0.7150 ns | 2.028 ns |      - |       0 B |
  Struct | 180.66 ns | 3.6389 ns | 8.788 ns | 0.0088 |      56 B |
