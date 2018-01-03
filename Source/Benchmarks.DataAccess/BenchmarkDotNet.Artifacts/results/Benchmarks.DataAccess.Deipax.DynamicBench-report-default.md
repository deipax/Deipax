
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2117.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2117.0


                        Method |     Mean |     Error |   StdDev |   Median |  Gen 0 | Allocated |
------------------------------ |---------:|----------:|---------:|---------:|-------:|----------:|
  ReadAsDictionary_DynamicDict | 408.5 ns |  8.240 ns | 23.78 ns | 408.5 ns |      - |       0 B |
 WriteAsDictionary_DynamicDict | 450.2 ns |  9.904 ns | 25.92 ns | 445.8 ns | 0.0224 |     120 B |
     ReadAsDynamic_DynamicDict | 460.9 ns |  9.690 ns | 28.27 ns | 458.6 ns | 0.0219 |     120 B |
    WriteAsDynamic_DynamicDict | 640.7 ns | 13.875 ns | 33.77 ns | 621.3 ns | 0.0448 |     240 B |
