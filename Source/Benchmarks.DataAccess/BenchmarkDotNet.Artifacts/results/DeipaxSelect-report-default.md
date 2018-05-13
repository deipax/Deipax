
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0


                   Method |     Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |    Gen 2 | Allocated |
------------------------- |---------:|----------:|----------:|----------:|----------:|---------:|----------:|
  AllFieldsAsClass_Deipax | 32.00 ms | 0.0845 ms | 0.0791 ms | 1312.5000 | 1062.5000 | 250.0000 |   6.76 MB |
 AllFieldsAsStruct_Deipax | 35.05 ms | 0.2375 ms | 0.2222 ms | 1437.5000 |  937.5000 | 437.5000 |   7.95 MB |
  AllFieldsAsClass_Dapper | 35.89 ms | 0.0594 ms | 0.0496 ms | 1437.5000 | 1125.0000 | 187.5000 |   6.76 MB |
 AllFieldsAsStruct_Dapper | 49.72 ms | 1.0106 ms | 1.0378 ms | 1437.5000 | 1000.0000 | 437.5000 |   8.39 MB |
