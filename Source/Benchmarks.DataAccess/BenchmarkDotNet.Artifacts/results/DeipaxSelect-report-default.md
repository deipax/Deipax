
BenchmarkDotNet=v0.10.14, OS=Windows 10.0.16299.431 (1709/FallCreatorsUpdate/Redstone3)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical and 4 physical cores
Frequency=3435892 Hz, Resolution=291.0452 ns, Timer=TSC
  [Host]     : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0
  DefaultJob : .NET Framework 4.6.1 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2650.0


                   Method |     Mean |     Error |    StdDev |     Gen 0 |     Gen 1 |    Gen 2 | Allocated |
------------------------- |---------:|----------:|----------:|----------:|----------:|---------:|----------:|
  AllFieldsAsClass_Deipax | 59.75 ms | 0.2144 ms | 0.2006 ms | 2062.5000 | 1375.0000 | 500.0000 |   9.45 MB |
 AllFieldsAsStruct_Deipax | 68.99 ms | 0.9993 ms | 0.9347 ms | 2125.0000 | 1562.5000 | 687.5000 |  11.38 MB |
  AllFieldsAsClass_Dapper | 66.01 ms | 0.4301 ms | 0.3110 ms | 2187.5000 | 1437.5000 | 500.0000 |   9.61 MB |
 AllFieldsAsStruct_Dapper | 73.47 ms | 0.8065 ms | 0.7149 ms | 2500.0000 | 1562.5000 | 812.5000 |  12.27 MB |
