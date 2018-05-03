
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.371 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435896 Hz, Resolution=291.0449 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0


              Method |      Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |    Gen 2 |  Allocated |
-------------------- |----------:|----------:|----------:|----------:|----------:|---------:|-----------:|
    AllFieldsAsClass | 40.970 ms | 0.8579 ms | 0.8426 ms | 1312.5000 | 1000.0000 | 125.0000 | 6928.33 KB |
   AllFieldsAsStruct | 51.747 ms | 1.2574 ms | 1.5902 ms | 1625.0000 | 1500.0000 | 687.5000 |  8592.8 KB |
  SingleFieldAsClass |  6.181 ms | 0.1233 ms | 0.1807 ms |   39.0625 |         - |        - |  174.65 KB |
 SingleFieldAsStruct |  5.541 ms | 0.0819 ms | 0.0684 ms |   39.0625 |    7.8125 |        - |  174.62 KB |
