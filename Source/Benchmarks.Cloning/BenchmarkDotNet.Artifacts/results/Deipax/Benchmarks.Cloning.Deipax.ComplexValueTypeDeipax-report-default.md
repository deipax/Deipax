
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


        Method |     Mean |    Error |   StdDev |   Median |  Gen 0 | Allocated |
-------------- |---------:|---------:|---------:|---------:|-------:|----------:|
 ComplexStruct | 63.79 ns | 1.725 ns | 5.085 ns | 64.19 ns | 0.0089 |      56 B |
  SimpleStruct | 59.14 ns | 1.405 ns | 4.142 ns | 58.37 ns | 0.0089 |      56 B |
    NullStruct | 59.48 ns | 1.370 ns | 4.041 ns | 58.23 ns | 0.0088 |      56 B |
