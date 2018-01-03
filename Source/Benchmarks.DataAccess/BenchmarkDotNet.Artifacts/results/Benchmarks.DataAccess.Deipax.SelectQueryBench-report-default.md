
BenchmarkDotNet=v0.10.11, OS=Windows 7 SP1 (6.1.7601.0)
Processor=Intel Xeon CPU E5-1650 v3 3.50GHz, ProcessorCount=12
Frequency=3410146 Hz, Resolution=293.2426 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2117.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2117.0


              Method |      Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |    Gen 2 |  Allocated |
-------------------- |----------:|----------:|----------:|----------:|----------:|---------:|-----------:|
    AllFieldsAsClass | 36.012 ms | 1.0482 ms | 3.0742 ms | 1187.5000 | 1000.0000 |  62.5000 | 7028.87 KB |
   AllFieldsAsStruct | 49.429 ms | 1.1234 ms | 3.2947 ms | 1437.5000 |  937.5000 | 437.5000 | 8692.78 KB |
  SingleFieldAsClass |  5.516 ms | 0.1196 ms | 0.3488 ms |   46.8750 |    7.8125 |        - |  271.73 KB |
 SingleFieldAsStruct |  5.074 ms | 0.1256 ms | 0.3664 ms |   46.8750 |    7.8125 |        - |  271.71 KB |
