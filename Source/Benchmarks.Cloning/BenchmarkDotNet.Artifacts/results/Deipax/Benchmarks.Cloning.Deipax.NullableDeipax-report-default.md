
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


  Method |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
-------- |----------:|----------:|----------:|-------:|----------:|
     Int | 143.84 ns | 4.7998 ns | 14.152 ns | 0.0037 |      24 B |
 NullInt |  30.02 ns | 0.7977 ns |  2.327 ns |      - |       0 B |
  Struct | 172.96 ns | 5.3198 ns | 15.263 ns | 0.0088 |      56 B |
