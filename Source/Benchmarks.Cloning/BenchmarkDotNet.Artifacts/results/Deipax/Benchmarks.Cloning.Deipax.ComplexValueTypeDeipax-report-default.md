
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


        Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
-------------- |---------:|---------:|---------:|-------:|----------:|
 ComplexStruct | 69.34 ns | 3.251 ns | 9.586 ns | 0.0088 |      56 B |
  SimpleStruct | 65.16 ns | 2.294 ns | 6.619 ns | 0.0088 |      56 B |
    NullStruct | 61.40 ns | 2.064 ns | 5.922 ns | 0.0088 |      56 B |
