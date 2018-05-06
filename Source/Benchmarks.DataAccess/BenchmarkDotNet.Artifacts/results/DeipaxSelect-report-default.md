
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0


              Method |      Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |    Gen 2 |  Allocated |
-------------------- |----------:|----------:|----------:|----------:|----------:|---------:|-----------:|
    AllFieldsAsClass | 36.640 ms | 0.0307 ms | 0.0287 ms | 1500.0000 | 1000.0000 | 125.0000 | 6929.21 KB |
   AllFieldsAsStruct | 45.723 ms | 0.3496 ms | 0.3271 ms | 1562.5000 | 1062.5000 | 437.5000 | 8595.05 KB |
  SingleFieldAsClass |  5.900 ms | 0.0084 ms | 0.0061 ms |   39.0625 |         - |        - |  174.52 KB |
 SingleFieldAsStruct |  5.554 ms | 0.0044 ms | 0.0039 ms |   39.0625 |         - |        - |   174.4 KB |
