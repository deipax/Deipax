
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410087 Hz, Resolution=293.2477 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2563.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2563.0


              Method |      Mean |     Error |    StdDev |    Median |     Gen 0 |     Gen 1 |    Gen 2 |  Allocated |
-------------------- |----------:|----------:|----------:|----------:|----------:|----------:|---------:|-----------:|
    AllFieldsAsClass | 45.674 ms | 1.6260 ms | 4.7944 ms | 45.371 ms | 1312.5000 | 1187.5000 | 250.0000 | 7026.65 KB |
   AllFieldsAsStruct | 64.488 ms | 2.6127 ms | 7.6627 ms | 65.395 ms | 1437.5000 |  937.5000 | 437.5000 | 8692.27 KB |
  SingleFieldAsClass |  6.584 ms | 0.2275 ms | 0.6708 ms |  6.562 ms |   46.8750 |    7.8125 |        - |  271.67 KB |
 SingleFieldAsStruct |  6.660 ms | 0.1845 ms | 0.5411 ms |  6.950 ms |   46.8750 |    7.8125 |        - |  271.73 KB |
