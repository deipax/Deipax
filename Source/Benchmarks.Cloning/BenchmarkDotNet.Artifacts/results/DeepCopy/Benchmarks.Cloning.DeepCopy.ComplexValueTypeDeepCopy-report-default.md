
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


        Method |     Mean |    Error |   StdDev |   Median |  Gen 0 | Allocated |
-------------- |---------:|---------:|---------:|---------:|-------:|----------:|
 ComplexStruct | 48.83 ns | 1.042 ns | 3.023 ns | 46.80 ns | 0.0089 |      56 B |
  SimpleStruct | 50.40 ns | 1.031 ns | 2.606 ns | 50.13 ns | 0.0088 |      56 B |
    NullStruct | 49.85 ns | 1.025 ns | 2.117 ns | 49.09 ns | 0.0089 |      56 B |
