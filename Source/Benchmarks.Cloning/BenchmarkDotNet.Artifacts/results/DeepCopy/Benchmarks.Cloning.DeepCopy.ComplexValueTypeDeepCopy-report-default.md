
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


        Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
-------------- |---------:|---------:|---------:|-------:|----------:|
 ComplexStruct | 51.04 ns | 1.043 ns | 2.418 ns | 0.0089 |      56 B |
  SimpleStruct | 56.45 ns | 1.467 ns | 4.324 ns | 0.0089 |      56 B |
    NullStruct | 51.80 ns | 1.247 ns | 3.677 ns | 0.0089 |      56 B |
