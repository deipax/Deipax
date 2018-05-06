
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0


              Method |      Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |    Gen 2 |  Allocated |
-------------------- |----------:|----------:|----------:|----------:|----------:|---------:|-----------:|
    AllFieldsAsClass | 38.873 ms | 0.2566 ms | 0.2400 ms | 1500.0000 | 1187.5000 | 250.0000 | 6931.72 KB |
   AllFieldsAsStruct | 50.050 ms | 0.8953 ms | 0.6990 ms | 1562.5000 | 1062.5000 | 437.5000 | 8597.79 KB |
  SingleFieldAsClass |  7.035 ms | 0.0395 ms | 0.0369 ms |   39.0625 |         - |        - |  182.69 KB |
 SingleFieldAsStruct |  6.911 ms | 0.0284 ms | 0.0266 ms |   39.0625 |    7.8125 |        - |  182.63 KB |
