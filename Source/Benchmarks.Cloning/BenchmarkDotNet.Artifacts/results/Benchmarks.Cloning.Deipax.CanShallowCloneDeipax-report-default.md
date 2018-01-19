
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410136 Hz, Resolution=293.2434 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                        Method |        Mean |      Error |     StdDev |  Gen 0 | Allocated |
------------------------------ |------------:|-----------:|-----------:|-------:|----------:|
       CanShallowClone_Decimal |    23.84 ns |  0.5068 ns |   1.205 ns |      - |       0 B |
 CanShallowClone_ComplexStruct | 1,482.15 ns | 42.2464 ns | 123.901 ns | 0.0725 |     464 B |
