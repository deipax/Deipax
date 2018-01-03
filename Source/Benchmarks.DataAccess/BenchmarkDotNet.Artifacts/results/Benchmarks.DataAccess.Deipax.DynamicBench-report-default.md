
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2117.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2117.0


                        Method |     Mean |     Error |   StdDev |  Gen 0 | Allocated |
------------------------------ |---------:|----------:|---------:|-------:|----------:|
  ReadAsDictionary_DynamicDict | 376.3 ns | 10.125 ns | 29.69 ns |      - |       0 B |
 WriteAsDictionary_DynamicDict | 443.7 ns |  8.902 ns | 22.17 ns | 0.0219 |     120 B |
     ReadAsDynamic_DynamicDict | 451.9 ns | 11.262 ns | 32.85 ns | 0.0224 |     120 B |
    WriteAsDynamic_DynamicDict | 589.3 ns | 15.606 ns | 45.52 ns | 0.0448 |     240 B |
