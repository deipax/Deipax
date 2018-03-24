
BenchmarkDotNet=v0.10.13, OS=Windows 7 SP1 (6.1.7601.0)
Intel Xeon CPU E5-1650 v3 3.50GHz, 1 CPU, 12 logical cores and 6 physical cores
Frequency=3410087 Hz, Resolution=293.2477 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2563.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2563.0


              Method |      Mean |     Error |    StdDev |    Median |     Gen 0 |     Gen 1 |    Gen 2 |  Allocated |
-------------------- |----------:|----------:|----------:|----------:|----------:|----------:|---------:|-----------:|
    AllFieldsAsClass | 47.372 ms | 1.6685 ms | 4.9196 ms | 47.829 ms | 1250.0000 | 1125.0000 | 187.5000 | 6931.72 KB |
   AllFieldsAsStruct | 62.036 ms | 1.7851 ms | 5.2355 ms | 61.420 ms | 1437.5000 |  937.5000 | 437.5000 | 8596.21 KB |
  SingleFieldAsClass |  7.419 ms | 0.2523 ms | 0.7399 ms |  7.423 ms |   31.2500 |         - |        - |   182.6 KB |
 SingleFieldAsStruct |  7.646 ms | 0.2725 ms | 0.7775 ms |  7.430 ms |   31.2500 |         - |        - |   182.6 KB |
