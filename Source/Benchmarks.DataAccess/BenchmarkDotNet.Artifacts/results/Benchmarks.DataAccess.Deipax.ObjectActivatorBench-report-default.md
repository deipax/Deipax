
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2117.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2117.0


                  Method |     Mean |     Error |   StdDev |  Gen 0 | Allocated |
------------------------ |---------:|----------:|---------:|-------:|----------:|
    IntializeClassByType | 62.78 ns | 2.3050 ns | 6.760 ns | 0.0312 |     164 B |
 IntializeClassByGeneric | 33.83 ns | 0.8345 ns | 2.381 ns | 0.0312 |     164 B |
