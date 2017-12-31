
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
.NET Core SDK=2.0.2
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


  Method |      Mean |     Error |   StdDev |  Gen 0 | Allocated |
-------- |----------:|----------:|---------:|-------:|----------:|
     Int | 161.54 ns | 3.2768 ns | 8.221 ns | 0.0036 |      24 B |
 NullInt |  29.49 ns | 0.6199 ns | 1.473 ns |      - |       0 B |
  Struct | 173.78 ns | 3.4829 ns | 8.544 ns | 0.0088 |      56 B |
