
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2117.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2117.0


                  Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
------------------------ |---------:|---------:|---------:|-------:|----------:|
    IntializeClassByType | 55.39 ns | 1.974 ns | 5.820 ns | 0.0312 |     164 B |
 IntializeClassByGeneric | 34.59 ns | 1.133 ns | 3.304 ns | 0.0312 |     164 B |
