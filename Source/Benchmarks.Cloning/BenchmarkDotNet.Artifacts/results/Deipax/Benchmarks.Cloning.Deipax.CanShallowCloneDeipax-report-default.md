
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410136 Hz, Resolution=293.2434 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


                        Method |     Mean |    Error |   StdDev | Allocated |
------------------------------ |---------:|---------:|---------:|----------:|
       CanShallowClone_Decimal | 24.37 ns | 1.219 ns | 3.595 ns |       0 B |
 CanShallowClone_ComplexStruct | 23.36 ns | 1.132 ns | 3.338 ns |       0 B |
