
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0


                   Method |     Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |    Gen 2 | Allocated |
------------------------- |---------:|----------:|----------:|----------:|----------:|---------:|----------:|
  AllFieldsAsClass_Deipax | 56.20 ms | 0.1302 ms | 0.1016 ms | 1875.0000 | 1312.5000 | 312.5000 |   9.45 MB |
 AllFieldsAsStruct_Deipax | 67.61 ms | 1.3424 ms | 1.4920 ms | 2125.0000 | 1500.0000 | 687.5000 |  11.38 MB |
  AllFieldsAsClass_Dapper | 73.01 ms | 1.4518 ms | 2.3444 ms | 2187.5000 | 1500.0000 | 625.0000 |   9.61 MB |
 AllFieldsAsStruct_Dapper | 73.38 ms | 0.9666 ms | 0.8569 ms | 2062.5000 | 1437.5000 | 750.0000 |  12.27 MB |
