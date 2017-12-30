
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


  Method |      Mean |    Error |    StdDev |    Median |  Gen 0 | Allocated |
-------- |----------:|---------:|----------:|----------:|-------:|----------:|
     Int | 136.34 ns | 5.157 ns | 15.205 ns | 131.34 ns | 0.0036 |      24 B |
 NullInt |  37.10 ns | 1.427 ns |  4.207 ns |  37.56 ns |      - |       0 B |
  Struct | 190.67 ns | 7.830 ns | 23.086 ns | 191.51 ns | 0.0088 |      56 B |
