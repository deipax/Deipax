
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0


              Method |      Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |    Gen 2 |  Allocated |
-------------------- |----------:|----------:|----------:|----------:|----------:|---------:|-----------:|
    AllFieldsAsClass | 46.663 ms | 0.9236 ms | 0.8639 ms | 1250.0000 |  875.0000 |  62.5000 | 6931.85 KB |
   AllFieldsAsStruct | 51.410 ms | 0.5241 ms | 0.4903 ms | 1625.0000 | 1125.0000 | 437.5000 | 8598.74 KB |
  SingleFieldAsClass |  7.521 ms | 0.1142 ms | 0.1069 ms |   39.0625 |         - |        - |  182.69 KB |
 SingleFieldAsStruct |  7.203 ms | 0.0293 ms | 0.0260 ms |   39.0625 |    7.8125 |        - |  182.66 KB |
